Imports System.Data.SqlClient
Imports System.Data
Imports System.Collections.Specialized

''' <summary>
''' Class for interacting with Databases
''' </summary>
Public Class CDatabaseUtilties
	
	Private m_strSQLServerConnectionString As String = String.Empty
	Private m_conSQLDatabaseConnection As SqlClient.SqlConnection
	Private m_strServerAddress As String = String.Empty
	Private m_strUsername As String = String.Empty
	Private m_strPassword As String = String.Empty
	Private m_strDB As String = String.Empty

	Public Property ConnectionString As String
		Get
			Return m_strSQLServerConnectionString
		End Get
		Private Set(value As String)
			m_strSQLServerConnectionString = value
		End Set
	End Property

	Public Property ServerAddress As String
		Get
			Return m_strServerAddress
		End Get
		Set(value As String)
			m_strServerAddress = value
		End Set
	End Property

	Public Property Username As String
		Get
			Return m_strUsername
		End Get
		Set(value As String)
			m_strUsername = value
		End Set
	End Property

	Public Property Password As String
		Get
			Return m_strPassword
		End Get
		Set(value As String)
			m_strPassword = value
		End Set
	End Property

	Public Property DB As String
		Get
			Return m_strDB
		End Get
		Set(value As String)
			m_strDB = value
		End Set
	End Property


	Public Sub New()

	End Sub

	Public Sub New(ByVal strServerAddress As String, ByVal strUsername As String, ByVal strPassword As String, Optional ByVal strDB As String = "")

		Try

			ServerAddress = strServerAddress
			Username = strUsername
			Password = strPassword
			DB = strDB
			BuildConnectionString()

		Catch excError As Exception
			WriteLog(excError.ToString)
		End Try

	End Sub


	''' <summary>
	''' Opens a SQL Server Connection
	''' </summary>
	''' <returns>True if Success or already open</returns>
	Public Function OpenSQLServerConnection() As Boolean

        Dim blnResult As Boolean = False

        Try

			If IsNothing(m_conSQLDatabaseConnection) OrElse m_conSQLDatabaseConnection.State <> ConnectionState.Open Then
				m_conSQLDatabaseConnection = New SqlClient.SqlConnection(m_strSQLServerConnectionString)
				m_conSQLDatabaseConnection.Open()
			End If

            blnResult = True

        Catch excError As Exception
            WriteLog(excError.ToString, False)
        End Try

        Return blnResult

    End Function

	''' <summary>
	''' Closes as SQL Server Connection
	''' </summary>
	''' <returns>True if success or already closed</returns>
	Public Function CloseSQLServerConnection() As Boolean

        Dim blnResult As Boolean = False

        Try

            If m_conSQLDatabaseConnection.State = ConnectionState.Open Then

                m_conSQLDatabaseConnection.Close()
                m_conSQLDatabaseConnection.Dispose()

            End If

            blnResult = True

        Catch excError As Exception
            WriteLog(excError.ToString)
        End Try

        Return blnResult

    End Function

	''' <summary>
	''' Builds the connection string
	''' </summary>
	''' <returns>True if Success Else return an false and writes and exception</returns>
	Public Function BuildConnectionString() As Boolean

		Dim blnResult As Boolean = False

		Try

			Dim strErrorMessage As String = "The following error(s) occurred: " & vbCrLf
			Dim blnIsValid As Boolean = True

			If ServerAddress.Trim.Equals(String.Empty) Then

				blnIsValid = False
				strErrorMessage &= "-Server Address is not set" & vbCrLf
			Else
				ConnectionString &= "Data Source=" & ServerAddress & ";"

			End If

			If Not DB.Trim.Equals(String.Empty) Then
				ConnectionString &= "Initial Catalog=" & DB & ";"
			End If

			ConnectionString &= "Persist Security Info=False;"

			If Username.Trim.Equals(String.Empty) Then

				blnIsValid = False
				strErrorMessage &= "-Username is not set" & vbCrLf
			Else
				ConnectionString &= "User ID=" & Username & ";"
			End If

			If Password.Trim.Equals(String.Empty) Then

				blnIsValid = False
				strErrorMessage &= "-Password is not set" & vbCrLf
			Else
				ConnectionString &= "Password=" & Password & ";"
			End If

			If blnIsValid Then
				blnResult = True
			Else
				Throw New Exception(strErrorMessage)
			End If

		Catch excError As Exception
			WriteLog(excError.ToString, True)
		End Try

		Return blnResult

	End Function


	''' <summary>
	''' Runs a sql query using a String Dictionary for the parameters
	''' </summary>
	''' <param name="strQuery">Query to be executed</param>
	''' <param name="sdParam">Parameters</param>
	''' <param name="cmtType">Command Type: Text, Table, Stored Procedure</param>
	''' <returns></returns>
	Public Function RunSQLQuery(ByVal strQuery As String, Optional ByVal sdParam As StringDictionary = Nothing, Optional ByVal cmtType As CommandType = CommandType.Text) As DataSet

        Dim dsReturn As New DataSet

        Try
            If OpenSQLServerConnection() Then
                Dim cmdQuery As New SqlCommand(strQuery, m_conSQLDatabaseConnection)
                cmdQuery.CommandType = cmtType
                If Not IsNothing(sdParam) Then
                    For Each ParameterKey As String In sdParam.Keys
                        If IsNothing(sdParam.Item(ParameterKey)) Then
                            cmdQuery.Parameters.Add(New SqlParameter(ParameterKey, Nothing))
                        Else
                            cmdQuery.Parameters.Add(New SqlParameter(ParameterKey, sdParam.Item(ParameterKey)))
                        End If

                    Next
                End If

                Dim daAdapter As New SqlClient.SqlDataAdapter(cmdQuery)
                daAdapter.Fill(dsReturn)

                CloseSQLServerConnection()
            End If
        Catch excError As Exception
            WriteLog(excError.ToString)
        End Try

        Return dsReturn

    End Function

	''' <summary>
	''' DOES NOT RETURN DATA: executes a query with sql parameter. for when datatypes need to be customized.
	''' </summary>
	''' <param name="strQuery">Query to execute</param>
	''' <param name="params"></param>
	''' <returns>true if success</returns>
	Public Function RunSQLQueryWithSQLParameters(ByVal strQuery As String, ByRef params As List(Of SqlParameter)) As Boolean

		Dim blnResult As Boolean = False

		Try

			If OpenSQLServerConnection() Then

				Dim cmdQuery As New SqlCommand(strQuery, m_conSQLDatabaseConnection)
				cmdQuery.CommandType = CommandType.Text
				cmdQuery.Parameters.Clear()

				For Each param As SqlClient.SqlParameter In params

					cmdQuery.Parameters.Add(param)

				Next

				cmdQuery.ExecuteNonQuery()

				CloseSQLServerConnection()
				blnResult = True
			End If

		Catch excError As Exception
			WriteLog(excError.ToString)
		End Try

		Return blnResult

	End Function


	''' <summary>
	''' 
	''' </summary>
	''' <param name="strTableName"></param>
	''' <param name="strColumnName"></param>
	''' <param name="strValueToSearch"></param>
	''' <param name="blnAnywhereInString"></param>
	''' <returns>Returns true if value is found</returns>
	''' <remarks></remarks>
	Public Function CheckColumnForEntry(ByVal strTableName As String, _
                                        ByVal strColumnName As String, _
                                        ByVal strValueToSearch As String, _
                                        Optional ByVal blnAnywhereInString As Boolean = False) As Boolean
        Dim blnResult As Boolean = False

        Try

            Dim strQuery As String = "SELECT " & strColumnName & " FROM " & strColumnName & " WHERE " & strColumnName
            If blnAnywhereInString Then
                strQuery &= " = '%' + @strValue + '%'"
            Else
                strQuery &= " = @strValue"
            End If

            Dim sdParam As New StringDictionary
            sdParam.Add("@strValue", strValueToSearch)

            Dim dtTemp As DataTable = Nothing
            dtTemp = RunSQLQuery(strQuery, sdParam).Tables(0)

            If dtTemp.Rows.Count > 0 Then
                blnResult = True
            End If


        Catch excError As Exception
            WriteLog(excError.ToString)
        End Try

        Return True

    End Function
	
End Class
