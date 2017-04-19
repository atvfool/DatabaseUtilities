' -------------------------------------------------------------------------
'   Module: modUtilities
'   Author: Andrew Hayden
'   Abstract: Some general purpose utilities.
'
'   Revision        Owner   Changes:
'1  2014/07/17      A.H.    Created.
'2  2014/10/24      A.H.    Revised, report code moved to new module
'3  2015/02/16      A.H.    Revised, Added Support for AD login
' -------------------------------------------------------------------------

' -------------------------------------------------------------------------
'  Options
' -------------------------------------------------------------------------
Option Explicit On

' -------------------------------------------------------------------------
'  Imports
' -------------------------------------------------------------------------
Imports System.Data
'Imports System.DirectoryServices ' System.DirectoryServices.dll

Module modUtilities



	Private m_osk As Process ' For displaying On Screen Keyboards
	
	
	''' <summary>
	''' Shows the default Microsoft On Screen keyboard
	''' </summary>
	''' <remarks></remarks>
	Public Sub ShowOnScreenKeyboard()

		Try

			If m_osk Is Nothing OrElse m_osk.HasExited Then
				If m_osk IsNot Nothing AndAlso m_osk.HasExited Then
					m_osk.Close()
				End If
				m_osk = Process.Start("C:\Program Files\Common Files\Microsoft Shared\ink\TabTip.exe")
			End If

		Catch excError As Exception
			WriteLog(excError.ToString, False)
		End Try

	End Sub

	''' <summary>
	''' Attempts to hide the onscreen keyboard from ShowOnScreenKeyboard but doesn't always work
	''' </summary>
	''' <remarks></remarks>
	Public Sub HideOnScreenKeyboard()

		Try

			If m_osk IsNot Nothing Then
				If Not m_osk.HasExited Then
					m_osk.Kill()
				End If

				m_osk.Close()
				m_osk = Nothing
			End If

		Catch excError As Exception
			'WriteLog(excError.ToString) ' Will usually Fail
		End Try

	End Sub

	
    ''' <summary>
    ''' Reverse input string.
    ''' </summary>
    Public Function Reverse(ByVal value As String) As String
        ' Convert to char array.
        Dim arr() As Char = value.ToCharArray()
        ' Use Array.Reverse function.
        Array.Reverse(arr)
        ' Construct new string.
        Return New String(arr)
    End Function

    Public Function AddCommas(ByVal strNumber As String, Optional ByVal strDelimiter As String = ",") As String

        Dim strReturn As String = String.Empty

        Try
            Dim astrStringParts As String() = Split(strNumber, ".")
            Dim strReversed As String = Reverse(astrStringParts(0))
            Dim achrReverse As Char() = strReversed.ToCharArray

            Dim intCount As Integer = 0

            strReturn = "." & astrStringParts(1)

            For Each value In achrReverse

                intCount += 1

                strReturn = value & strReturn

                If intCount = 3 Then

                    strReturn = "," & strReturn

                    intCount = 0

                End If

            Next

            If Left(strReturn, 1) = "," Then

                strReturn = Right(strReturn, strReturn.Length - 1)

            End If

        Catch excError As Exception
            WriteLog(excError.ToString)
        End Try

        Return strReturn

    End Function

	
	Public Function MakeProperCase(ByVal strUPPERCASE As String) As String

		Dim strReturn As String = String.Empty

		Try

			Dim chrCurrent As Char = Nothing
			Dim blnPreviousIsCapitalOrSpace As Boolean = True

			Dim a_chrString As Char() = strUPPERCASE.ToCharArray

			For intIndex = 0 To a_chrString.Count - 1

				chrCurrent = a_chrString(intIndex)

				If Char.IsLetter(chrCurrent) And Not blnPreviousIsCapitalOrSpace Then

					strReturn &= Char.ToLower(chrCurrent)

				Else

					' Should be caps already or space or special char
					strReturn &= chrCurrent
					If Char.IsWhiteSpace(chrCurrent) Then
						blnPreviousIsCapitalOrSpace = True
					Else
						blnPreviousIsCapitalOrSpace = False
					End If

				End If

			Next

		Catch excError As Exception
			MessageBox.Show(excError.ToString)
		End Try

		Return strReturn

	End Function
	

   ' -------------------------------------------------------------------------
	' Name: WriteLog
	' Abstract: Write a message to the error log.
	' -------------------------------------------------------------------------
	Public Sub WriteLog(ByVal strMessage As String, Optional ByVal blnDisplay As Boolean = True)

		Try
			Dim folderpath As String = "\Generic\Logs\"

			' We use the txt extension so we have the ability to open the log on the device itself
			Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & folderpath & _
			DatePart(DateInterval.Year, Date.Now) & DatePart(DateInterval.Month, Date.Now) & _
			DatePart(DateInterval.Day, Date.Now) & "__" & DatePart(DateInterval.Hour, Date.Now) & _
			DatePart(DateInterval.Minute, Date.Now) & DatePart(DateInterval.Second, Date.Now) & ".txt"

			System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & folderpath)


			Dim fs As IO.FileStream

			' Open the stream and write to it.
			fs = IO.File.OpenWrite(path)
			Dim info As Byte() = _
			 New System.Text.UTF8Encoding(True).GetBytes(strMessage)

			' Add some information to the file.
			fs.Write(info, 0, info.Length)
			fs.Close()

			If blnDisplay = True Then
				MessageBox.Show(strMessage)
			End If

		Catch excError As Exception
			MessageBox.Show("Error saving log of error: " & excError.ToString)
		End Try

	End Sub

    ''' <summary>
    ''' Initializes Null string values to an Empty string
    ''' </summary>
    ''' <param name="strValue"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InitNull(ByVal strValue As String) As String

        Dim strReturn As String = String.Empty

        Try

            If IsNothing(strValue) Then

                strReturn = String.Empty

            Else

                strReturn = strValue

            End If

        Catch excError As Exception
            WriteLog(excError.ToString)
        End Try

        Return strReturn

    End Function

    ''' <summary>
    ''' Checks if a number from the db is not null and not an empty string, if it is then return false
    ''' </summary>
    ''' <param name="strValue"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsDBNumberValid(ByVal strValue As String) As Boolean

        Dim blnResult As Boolean = False

        Try

            If Not IsNothing(strValue) AndAlso strValue <> String.Empty Then
                blnResult = True
            End If

        Catch excError As Exception

        End Try

        Return blnResult

    End Function


	'   Public Function ValidateActiveDirectoryLogin(ByVal Domain As String, ByVal Username As String, ByVal Password As String, Optional ByVal Group As String = "") As Boolean
	'	Dim Success As Boolean = False
	'	Dim Entry As New System.DirectoryServices.DirectoryEntry("LDAP://" & Domain, Username, Password)
	'	Dim Searcher As New System.DirectoryServices.DirectorySearcher(Entry)
	'	Searcher.Filter = "sAMAccountName=" & Username
	'	Searcher.PropertiesToLoad.Add("MemberOf")
	'	'Searcher.SearchScope = DirectoryServices.SearchScope.OneLevel
	'	Try

	'		Dim Results As System.DirectoryServices.SearchResult = Searcher.FindOne

	'		If Not IsNothing(Results) Then
	'			Dim intGroupCount As Integer = 0
	'			intGroupCount = Results.Properties("MemberOf").Count - 1

	'			Group = Group.ToLower

	'			Dim tempString As String
	'			'A temp string that we will use to get only what we
	'			'need from the MemberOf string property

	'			While (intGroupCount >= 0)
	'				tempString = Results.Properties("MemberOf").Item(intGroupCount)
	'				tempString = tempString.Substring(0, tempString.IndexOf(",", 0))
	'				'Above we set tempString to the first index of "," starting
	'				'from the zeroth element of itself.
	'				tempString = tempString.Replace("CN=", "")
	'				'Above, we remove the "CN=" from the beginning of the string
	'				tempString = tempString.ToLower() 'Lets make all letters lowercase
	'				tempString = tempString.Trim()
	'				'Finnally, we trim any blank characters from the edges

	'				If (Group = tempString) Then
	'					Success = True
	'					Exit Try
	'				End If
	'				'If we have a match, the return is true
	'				'username is a member of grouptoCheck

	'				intGroupCount = intGroupCount - 1
	'			End While

	'			MessageBox.Show("You have insufficient privileges")

	'		End If

	'	Catch
	'		Success = ValidateUserHasAccount(Username)
	'	End Try
	'	Return Success
	'End Function

	'Public Function ValidateUserHasAccount(ByVal Username As String) As Boolean

	'	Dim blnResult As Boolean = False

	'	Try
	'		sqlConnection.ConnectionString = "Persist Security Info=False;Integrated Security=False;database=master;server=mbvfairsql1;" & _
	'		"Connect Timeout=5;User ID=" & Username & ";Password=vse"
	'		sqlConnection.Open()
	'		sqlConnection.Close()

	'		blnResult = True
	'	Catch excError As Exception
	'		WriteLog(excError.ToString, False)
	'	End Try

	'	Return blnResult

	'End Function


	'''' <summary>
	'''' Initializes Null Integer values to 0
	'''' </summary>
	'''' <param name="intValue"></param>
	'''' <returns></returns>
	'''' <remarks></remarks>
	'Public Function InitNull(ByVal intValue As Integer) As Integer

	'    Dim intReturn As Integer = 0

	'    Try

	'        If IsNothing(intValue) Then

	'            intReturn = 0

	'        Else

	'            intReturn = intValue

	'        End If

	'    Catch excError As Exception
	'        WriteLog(excError.ToString)
	'    End Try

	'    Return intReturn

	'End Function

	'''' <summary>
	'''' Initializes Null Decimal values to 0.0
	'''' </summary>
	'''' <param name="decValue"></param>
	'''' <returns></returns>
	'''' <remarks></remarks>
	'Public Function InitNull(ByVal decValue As Decimal) As Decimal

	'    Dim decReturn As Decimal = 0.0

	'    Try

	'        If IsNothing(decValue) Then

	'            decReturn = 0.0

	'        Else

	'            decReturn = decValue

	'        End If

	'    Catch excError As Exception
	'        WriteLog(excError.ToString)
	'    End Try

	'    Return decReturn

	'End Function

	''' <summary>
	''' This goes through a specified form and locks/unlocks the form, add "_NoEnable" to control names to prevent their status from being toggled
	''' </summary>
	''' <param name="blnIsLocked"></param>
	''' <param name="frmCurrent"></param>
	''' <remarks></remarks>
	Public Sub LockForm(ByVal blnIsLocked As Boolean, ByRef frmCurrent As Windows.Forms.Form)

        Try

            ' Sets if the cursor should be the loading cursor 
            If blnIsLocked Then
                Cursor.Current = Cursors.WaitCursor
            Else
                Cursor.Current = Cursors.Default
            End If

            ' loops through every control on the form
            For Each ctrlCurrent As Windows.Forms.Control In frmCurrent.Controls

                If InStr(ctrlCurrent.Name, "_NoEnable") = 0 Then ' Fields with "_NoEnable" have differnt locked/unlocked states independent of the form
                    ctrlCurrent.Enabled = Not blnIsLocked
                End If

            Next

        Catch excError As Exception
            WriteLog(excError.ToString)
        End Try

    End Sub

	
	Public Sub SetFormToProperMonitor(ByRef frm As Windows.Forms.Form, ByVal intWhichMonitor As Integer)

		Try

			If intWhichMonitor > SystemInformation.MonitorCount Then intWhichMonitor = SystemInformation.MonitorCount

			frm.StartPosition = FormStartPosition.Manual

			frm.Bounds = Screen.AllScreens(intWhichMonitor).Bounds



		Catch excError As Exception
			WriteLog(excError.ToString)
		End Try

	End Sub

	Public Enum VerticalHorizontalBoth
		Vertical
		Horizontal
		Both
	End Enum

	Public Sub CenterElementInForm(ByRef frm As Windows.Forms.Form, ByRef obj As Windows.Forms.Control, Optional ByRef position As VerticalHorizontalBoth = VerticalHorizontalBoth.Both)

		Try

			Dim pnt As New Point

			pnt.X = obj.Location.X
			pnt.Y = obj.Location.Y

			If position = VerticalHorizontalBoth.Horizontal Or position = VerticalHorizontalBoth.Both Then _
 pnt.X = GetCenterValue(frm.Size.Width, obj.Size.Width)


			If position = VerticalHorizontalBoth.Vertical Or position = VerticalHorizontalBoth.Both Then _
			 pnt.Y = GetCenterValue(frm.Size.Height, obj.Size.Height)

			obj.Location = pnt

		Catch excError As Exception
			WriteLog(excError.ToString)
		End Try

	End Sub

	Public Function GetCenterValue(ByVal intContainerLocation As Integer, ByVal intControlSize As Integer) As Integer

		Dim intReturn As Integer = 0

		Try

			intReturn = (intContainerLocation / 2) - (intControlSize / 2)

		Catch excError As Exception
			WriteLog(excError.ToString)
		End Try

		Return intReturn

	End Function
	
End Module
