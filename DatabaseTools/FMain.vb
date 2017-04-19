Imports System.Collections.Specialized
Imports System.Data
Imports System.IO


Public Class FMain

	Private Const m_DB1_FILE_LOCATION As String = "C:\TEMP\db1.txt"
	Private Const m_DB2_FILE_LOCATION As String = "C:\TEMP\db2.txt"
	Private m_clsDB1 As CDatabaseUtilties
	Private m_clsDB2 As CDatabaseUtilties


	Private Sub FMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Try

			Dim FileContents As String()
			If File.Exists(m_DB1_FILE_LOCATION) Then

				FileContents = File.ReadAllLines(m_DB1_FILE_LOCATION)
				For Each strline As String In FileContents

					If strline.Contains("Server") Then
						txtServerName1.Text = strline.Split("=")(1)
					ElseIf strline.Contains("UserID") Then
						txtUsername1.Text = strline.Split("=")(1)
					ElseIf strline.Contains("Password") Then
						txtPassword1.Text = strline.Split("=")(1)
					ElseIf strline.Contains("DB") Then
						cmbDB1.Text = strline.Split("=")(1)
					End If

				Next

				m_clsDB1 = New CDatabaseUtilties(txtServerName1.Text, txtUsername1.Text, txtPassword1.Text, cmbDB1.Text)

				txtConnectionString1.Text = m_clsDB1.ConnectionString

			End If

			If File.Exists(m_DB2_FILE_LOCATION) Then

				FileContents = File.ReadAllLines(m_DB2_FILE_LOCATION)
				For Each strline As String In FileContents

					If strline.Contains("Server") Then
						txtServerName2.Text = strline.Split("=")(1)
					ElseIf strline.Contains("UserID") Then
						txtUsername2.Text = strline.Split("=")(1)
					ElseIf strline.Contains("Password") Then
						txtPassword2.Text = strline.Split("=")(1)
					ElseIf strline.Contains("DB") Then
						cmbDB2.Text = strline.Split("=")(1)
					End If

				Next

				m_clsDB2 = New CDatabaseUtilties(txtServerName2.Text, txtUsername2.Text, txtPassword2.Text, cmbDB2.Text)

				txtConnectionString2.Text = m_clsDB2.ConnectionString

			End If

		Catch excError As Exception
			WriteLog(excError.ToString)
		End Try

	End Sub

	Private Sub btnTest1_Click(sender As Object, e As EventArgs) Handles btnTest1.Click

		Try

			If m_clsDB1 Is Nothing Then
				m_clsDB1 = New CDatabaseUtilties(txtServerName1.Text, txtUsername1.Text, txtPassword1.Text, cmbDB1.Text)
			Else
				m_clsDB1.ServerAddress = txtServerName1.Text
				m_clsDB1.Username = txtUsername1.Text
				m_clsDB1.Password = txtPassword1.Text
				If cmbDB1.Text <> String.Empty Then m_clsDB1.DB = cmbDB1.Text
				m_clsDB1.BuildConnectionString()
			End If

			If m_clsDB1.OpenSQLServerConnection Then

				Set1DBStatusGood()
				m_clsDB1.CloseSQLServerConnection()

				Dim dt As DataTable = m_clsDB1.RunSQLQuery("sp_databases", Nothing, CommandType.StoredProcedure).Tables(0)

				If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then

					cmbDB1.Items.Clear()

					For Each drRow As DataRow In dt.Rows

						cmbDB1.Items.Add(drRow("DATABASE_NAME"))

					Next

				End If

			Else

				Set1DBStatusBad()

			End If

		Catch excError As Exception
			WriteLog(excError.ToString)
		End Try

	End Sub

	Private Sub Set1DBStatusGood()

		Try

			lblConnectionSuccessful1.Text = "Good"
			lblConnectionSuccessful1.BackColor = Color.FromArgb(0, 255, 0)

		Catch excError As Exception
			WriteLog(excError.ToString)
		End Try

	End Sub

	Private Sub Set1DBStatusBad()

		Try

			lblConnectionSuccessful1.Text = "Bad"
			lblConnectionSuccessful1.BackColor = Color.FromArgb(255, 0, 0)

		Catch excError As Exception
			WriteLog(excError.ToString)
		End Try

	End Sub

	Private Sub Set1DBStatusUnknown()

		Try


			lblConnectionSuccessful1.Text = "Unknown"
			lblConnectionSuccessful1.BackColor = Color.FromArgb(255, 128, 0)

		Catch excError As Exception
			WriteLog(excError.ToString)
		End Try

	End Sub

	Private Sub txtServerName1_TextChanged(sender As Object, e As EventArgs) Handles txtServerName1.TextChanged
		Set1DBStatusUnknown()
	End Sub

	Private Sub txtUsername1_TextChanged(sender As Object, e As EventArgs) Handles txtUsername1.TextChanged
		Set1DBStatusUnknown()
	End Sub

	Private Sub txtPassword1_TextChanged(sender As Object, e As EventArgs) Handles txtPassword1.TextChanged
		Set1DBStatusUnknown()
	End Sub

	Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
		Try

			If TabControl1.SelectedTab.Text = "Actions" Then
				m_clsDB1.DB = cmbDB1.Text
				m_clsDB1.BuildConnectionString()
				chklstSelectedFields1.Items.Clear()
				cmbSelectedTable1.Items.Clear()
				dgv1.DataSource = Nothing
				Dim dt As DataTable = m_clsDB1.RunSQLQuery("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'", Nothing).Tables(0)

				If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
					cmbSelectedTable1.Items.Clear()

					For Each dr As DataRow In dt.Rows
						cmbSelectedTable1.Items.Add(dr("TABLE_NAME"))
					Next

				End If


			End If

		Catch excError As Exception
			WriteLog(excError.ToString)
		End Try
	End Sub

	Private Sub cmbSelectedTable1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelectedTable1.SelectedIndexChanged

		Try

			Dim sdParams As New StringDictionary
			sdParams.Add("@tableName", cmbSelectedTable1.SelectedItem)
			sdParams.Add("@DBName", m_clsDB1.DB)


			Dim dt As DataTable = m_clsDB1.RunSQLQuery("SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @tableName AND TABLE_CATALOG = @DBName", sdParams).Tables(0)

			If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then

				For Each dr As DataRow In dt.Rows

					chklstSelectedFields1.Items.Add(dr("COLUMN_NAME"), True)

				Next





			End If

		Catch excError As Exception
			WriteLog(excError.ToString)
		End Try

	End Sub

	Private Sub btnRun1_Click(sender As Object, e As EventArgs) Handles btnRun1.Click

		Try
			Dim strSelectedFields As String = String.Empty

			For Each lstItem As String In chklstSelectedFields1.CheckedItems
				If strSelectedFields <> String.Empty Then strSelectedFields &= ","
				strSelectedFields &= lstItem.ToString
			Next

			Dim dt As DataTable = m_clsDB1.RunSQLQuery("SELECT " & strSelectedFields & " FROM " & cmbSelectedTable1.Text).Tables(0)

			If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then

				dgv1.DataSource = dt
				dgv1.AutoGenerateColumns = True

			End If

		Catch excError As Exception
			WriteLog(excError.ToString)
		End Try

	End Sub

	Private Sub btnTest2_Click(sender As Object, e As EventArgs) Handles btnTest2.Click

		Try

			If m_clsDB2 Is Nothing Then
				m_clsDB2 = New CDatabaseUtilties(txtServerName2.Text, txtUsername2.Text, txtPassword2.Text, cmbDB2.Text)
			Else
				m_clsDB2.ServerAddress = txtServerName2.Text
				m_clsDB2.Username = txtUsername2.Text
				m_clsDB2.Password = txtPassword2.Text
				If cmbDB2.Text <> String.Empty Then m_clsDB2.DB = cmbDB2.Text
				m_clsDB2.BuildConnectionString()
			End If

			If m_clsDB2.OpenSQLServerConnection Then

				Set2DBStatusGood()
				m_clsDB2.CloseSQLServerConnection()

				Dim dt As DataTable = m_clsDB2.RunSQLQuery("sp_databases", Nothing, CommandType.StoredProcedure).Tables(0)

				If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then

					cmbDB2.Items.Clear()

					For Each drRow As DataRow In dt.Rows

						cmbDB2.Items.Add(drRow("DATABASE_NAME"))

					Next

				End If

			Else

				Set2DBStatusBad()

			End If

		Catch excError As Exception
			WriteLog(excError.ToString)
		End Try

	End Sub

	Private Sub Set2DBStatusGood()

		Try

			lblConnectionSuccessful2.Text = "Good"
			lblConnectionSuccessful2.BackColor = Color.FromArgb(0, 255, 0)

		Catch excError As Exception
			WriteLog(excError.ToString)
		End Try

	End Sub

	Private Sub Set2DBStatusBad()

		Try

			lblConnectionSuccessful2.Text = "Bad"
			lblConnectionSuccessful2.BackColor = Color.FromArgb(255, 0, 0)

		Catch excError As Exception
			WriteLog(excError.ToString)
		End Try

	End Sub

	Private Sub Set2DBStatusUnknown()

		Try


			lblConnectionSuccessful2.Text = "Unknown"
			lblConnectionSuccessful2.BackColor = Color.FromArgb(255, 128, 0)

		Catch excError As Exception
			WriteLog(excError.ToString)
		End Try

	End Sub

	Private Sub txtServerName2_TextChanged(sender As Object, e As EventArgs) Handles txtServerName2.TextChanged
		Set2DBStatusUnknown()
	End Sub

	Private Sub txtUsername2_TextChanged(sender As Object, e As EventArgs) Handles txtUsername2.TextChanged
		Set2DBStatusUnknown()
	End Sub

	Private Sub txtPassword2_TextChanged(sender As Object, e As EventArgs) Handles txtPassword2.TextChanged
		Set2DBStatusUnknown()
	End Sub

	Private Sub TabControl2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl2.SelectedIndexChanged
		Try

			If TabControl2.SelectedTab.Text = "Actions" Then
				m_clsDB2.DB = cmbDB2.Text
				m_clsDB2.BuildConnectionString()
				chklstSelectedFields2.Items.Clear()
				cmbSelectedTable2.Items.Clear()
				dgv2.DataSource = Nothing
				Dim dt As DataTable = m_clsDB2.RunSQLQuery("SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'", Nothing).Tables(0)

				If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
					cmbSelectedTable2.Items.Clear()

					For Each dr As DataRow In dt.Rows
						cmbSelectedTable2.Items.Add(dr("TABLE_NAME"))
					Next

				End If


			End If

		Catch excError As Exception
			WriteLog(excError.ToString)
		End Try
	End Sub

	Private Sub cmbSelectedTable2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelectedTable2.SelectedIndexChanged

		Try

			Dim sdParams As New StringDictionary
			sdParams.Add("@tableName", cmbSelectedTable2.SelectedItem)
			sdParams.Add("@DBName", m_clsDB2.DB)


			Dim dt As DataTable = m_clsDB2.RunSQLQuery("SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @tableName AND TABLE_CATALOG = @DBName", sdParams).Tables(0)

			If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then

				For Each dr As DataRow In dt.Rows

					chklstSelectedFields2.Items.Add(dr("COLUMN_NAME"), True)

				Next





			End If

		Catch excError As Exception
			WriteLog(excError.ToString)
		End Try

	End Sub

	Private Sub btnRun2_Click(sender As Object, e As EventArgs) Handles btnRun2.Click

		Try
			Dim strSelectedFields As String = String.Empty

			For Each lstItem As String In chklstSelectedFields2.CheckedItems
				If strSelectedFields <> String.Empty Then strSelectedFields &= ","
				strSelectedFields &= lstItem.ToString
			Next

			Dim dt As DataTable = m_clsDB2.RunSQLQuery("SELECT " & strSelectedFields & " FROM " & cmbSelectedTable2.Text).Tables(0)

			If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then

				dgv2.DataSource = dt
				dgv2.AutoGenerateColumns = True

			End If

		Catch excError As Exception
			WriteLog(excError.ToString)
		End Try

	End Sub

	Private Sub CopyTable1ToTable2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyTable1ToTable2ToolStripMenuItem.Click

		Try

			Dim dt1 As DataTable = dgv1.DataSource

			Dim strFields As String = String.Empty
			Dim strParams As String = String.Empty
			Dim params As List(Of SqlClient.SqlParameter)

			Dim strCommand As String = "INSERT INTO " & cmbSelectedTable2.Text & " ("

			For Each dc As DataColumn In dt1.Columns
				If strFields <> String.Empty Then strFields &= ","
				strFields &= dc.ColumnName

				If strParams <> String.Empty Then strParams &= ","
				strParams &= "@" & dc.ColumnName

			Next

			strCommand &= strFields & ") VALUES(" & strParams & ")"

			Dim tmpParam As SqlClient.SqlParameter
			For Each drRow As DataRow In dt1.Rows
				params = New List(Of SqlClient.SqlParameter)
				For Each dc As DataColumn In dt1.Columns
					If dc.DataType.ToString = GetType(Byte()).ToString Then
						tmpParam = New SqlClient.SqlParameter("@" & dc.ColumnName, SqlDbType.Image)
						With tmpParam

							.Value = drRow(dc)
							If Not IsDBNull(drRow(dc)) Then
								.Size = DirectCast(drRow(dc), Byte()).Length
							Else
								'.Size = 0
							End If

						End With
					Else
						tmpParam = New SqlClient.SqlParameter("@" & dc.ColumnName, drRow(dc))
					End If
					params.Add(tmpParam)

				Next

				m_clsDB2.RunSQLQueryWithSQLParameters(strCommand, params)

			Next

			MessageBox.Show("Copy Completed Successfully")

		Catch excError As Exception
			MessageBox.Show("Some Errors Occurred See following error message")
			WriteLog(excError.ToString, True)
		End Try

	End Sub
End Class
