<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMain
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.tbpConnectionSettings = New System.Windows.Forms.TabPage()
		Me.lblConnectionSuccessful1 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.cmbDB1 = New System.Windows.Forms.ComboBox()
		Me.btnTest1 = New System.Windows.Forms.Button()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtPassword1 = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtUsername1 = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtServerName1 = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtConnectionString1 = New System.Windows.Forms.TextBox()
		Me.tbpActions = New System.Windows.Forms.TabPage()
		Me.btnRun1 = New System.Windows.Forms.Button()
		Me.pnlWhere1 = New System.Windows.Forms.Panel()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.chklstSelectedFields1 = New System.Windows.Forms.CheckedListBox()
		Me.dgv1 = New System.Windows.Forms.DataGridView()
		Me.cmbSelectedTable1 = New System.Windows.Forms.ComboBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CrossServerActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CopyTable1ToTable2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.TabControl2 = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.lblConnectionSuccessful2 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.cmbDB2 = New System.Windows.Forms.ComboBox()
		Me.btnTest2 = New System.Windows.Forms.Button()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.txtPassword2 = New System.Windows.Forms.TextBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.txtUsername2 = New System.Windows.Forms.TextBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.txtServerName2 = New System.Windows.Forms.TextBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.txtConnectionString2 = New System.Windows.Forms.TextBox()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.btnRun2 = New System.Windows.Forms.Button()
		Me.pnlWhere2 = New System.Windows.Forms.Panel()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.chklstSelectedFields2 = New System.Windows.Forms.CheckedListBox()
		Me.dgv2 = New System.Windows.Forms.DataGridView()
		Me.cmbSelectedTable2 = New System.Windows.Forms.ComboBox()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
		Me.tspbLoading = New System.Windows.Forms.ToolStripProgressBar()
		Me.GroupBox1.SuspendLayout()
		Me.TabControl1.SuspendLayout()
		Me.tbpConnectionSettings.SuspendLayout()
		Me.tbpActions.SuspendLayout()
		CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.MenuStrip1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.TabControl2.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.TabPage2.SuspendLayout()
		CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ToolStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox1.Controls.Add(Me.TabControl1)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(337, 552)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Database 1"
		'
		'TabControl1
		'
		Me.TabControl1.Controls.Add(Me.tbpConnectionSettings)
		Me.TabControl1.Controls.Add(Me.tbpActions)
		Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TabControl1.Location = New System.Drawing.Point(3, 16)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(331, 533)
		Me.TabControl1.TabIndex = 0
		'
		'tbpConnectionSettings
		'
		Me.tbpConnectionSettings.BackColor = System.Drawing.SystemColors.Control
		Me.tbpConnectionSettings.Controls.Add(Me.lblConnectionSuccessful1)
		Me.tbpConnectionSettings.Controls.Add(Me.Label5)
		Me.tbpConnectionSettings.Controls.Add(Me.cmbDB1)
		Me.tbpConnectionSettings.Controls.Add(Me.btnTest1)
		Me.tbpConnectionSettings.Controls.Add(Me.Label4)
		Me.tbpConnectionSettings.Controls.Add(Me.txtPassword1)
		Me.tbpConnectionSettings.Controls.Add(Me.Label3)
		Me.tbpConnectionSettings.Controls.Add(Me.txtUsername1)
		Me.tbpConnectionSettings.Controls.Add(Me.Label2)
		Me.tbpConnectionSettings.Controls.Add(Me.txtServerName1)
		Me.tbpConnectionSettings.Controls.Add(Me.Label1)
		Me.tbpConnectionSettings.Controls.Add(Me.txtConnectionString1)
		Me.tbpConnectionSettings.Location = New System.Drawing.Point(4, 22)
		Me.tbpConnectionSettings.Name = "tbpConnectionSettings"
		Me.tbpConnectionSettings.Padding = New System.Windows.Forms.Padding(3)
		Me.tbpConnectionSettings.Size = New System.Drawing.Size(323, 507)
		Me.tbpConnectionSettings.TabIndex = 0
		Me.tbpConnectionSettings.Text = "Connection Settings"
		'
		'lblConnectionSuccessful1
		'
		Me.lblConnectionSuccessful1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.lblConnectionSuccessful1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblConnectionSuccessful1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblConnectionSuccessful1.ForeColor = System.Drawing.Color.Black
		Me.lblConnectionSuccessful1.Location = New System.Drawing.Point(6, 390)
		Me.lblConnectionSuccessful1.Name = "lblConnectionSuccessful1"
		Me.lblConnectionSuccessful1.Size = New System.Drawing.Size(311, 114)
		Me.lblConnectionSuccessful1.TabIndex = 11
		Me.lblConnectionSuccessful1.Text = "Unknown"
		Me.lblConnectionSuccessful1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(44, 154)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(56, 13)
		Me.Label5.TabIndex = 10
		Me.Label5.Text = "Database:"
		'
		'cmbDB1
		'
		Me.cmbDB1.FormattingEnabled = True
		Me.cmbDB1.Location = New System.Drawing.Point(106, 151)
		Me.cmbDB1.Name = "cmbDB1"
		Me.cmbDB1.Size = New System.Drawing.Size(210, 21)
		Me.cmbDB1.TabIndex = 9
		'
		'btnTest1
		'
		Me.btnTest1.Location = New System.Drawing.Point(9, 121)
		Me.btnTest1.Name = "btnTest1"
		Me.btnTest1.Size = New System.Drawing.Size(308, 23)
		Me.btnTest1.TabIndex = 8
		Me.btnTest1.Text = "Test Connection"
		Me.btnTest1.UseVisualStyleBackColor = True
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(44, 66)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(56, 13)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "Password:"
		'
		'txtPassword1
		'
		Me.txtPassword1.Location = New System.Drawing.Point(106, 63)
		Me.txtPassword1.Name = "txtPassword1"
		Me.txtPassword1.Size = New System.Drawing.Size(210, 20)
		Me.txtPassword1.TabIndex = 6
		Me.txtPassword1.UseSystemPasswordChar = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(42, 37)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(58, 13)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "Username:"
		'
		'txtUsername1
		'
		Me.txtUsername1.Location = New System.Drawing.Point(106, 34)
		Me.txtUsername1.Name = "txtUsername1"
		Me.txtUsername1.Size = New System.Drawing.Size(210, 20)
		Me.txtUsername1.TabIndex = 4
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(28, 13)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(72, 13)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Server Name:"
		'
		'txtServerName1
		'
		Me.txtServerName1.Location = New System.Drawing.Point(106, 10)
		Me.txtServerName1.Name = "txtServerName1"
		Me.txtServerName1.Size = New System.Drawing.Size(210, 20)
		Me.txtServerName1.TabIndex = 2
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(6, 92)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(94, 13)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Connection String:"
		'
		'txtConnectionString1
		'
		Me.txtConnectionString1.Location = New System.Drawing.Point(106, 89)
		Me.txtConnectionString1.Name = "txtConnectionString1"
		Me.txtConnectionString1.ReadOnly = True
		Me.txtConnectionString1.Size = New System.Drawing.Size(210, 20)
		Me.txtConnectionString1.TabIndex = 0
		'
		'tbpActions
		'
		Me.tbpActions.BackColor = System.Drawing.SystemColors.Control
		Me.tbpActions.Controls.Add(Me.btnRun1)
		Me.tbpActions.Controls.Add(Me.pnlWhere1)
		Me.tbpActions.Controls.Add(Me.Label7)
		Me.tbpActions.Controls.Add(Me.chklstSelectedFields1)
		Me.tbpActions.Controls.Add(Me.dgv1)
		Me.tbpActions.Controls.Add(Me.cmbSelectedTable1)
		Me.tbpActions.Controls.Add(Me.Label6)
		Me.tbpActions.Location = New System.Drawing.Point(4, 22)
		Me.tbpActions.Name = "tbpActions"
		Me.tbpActions.Padding = New System.Windows.Forms.Padding(3)
		Me.tbpActions.Size = New System.Drawing.Size(323, 507)
		Me.tbpActions.TabIndex = 1
		Me.tbpActions.Text = "Actions"
		'
		'btnRun1
		'
		Me.btnRun1.Location = New System.Drawing.Point(7, 287)
		Me.btnRun1.Name = "btnRun1"
		Me.btnRun1.Size = New System.Drawing.Size(75, 23)
		Me.btnRun1.TabIndex = 15
		Me.btnRun1.Text = "Run"
		Me.btnRun1.UseVisualStyleBackColor = True
		'
		'pnlWhere1
		'
		Me.pnlWhere1.Location = New System.Drawing.Point(6, 164)
		Me.pnlWhere1.Name = "pnlWhere1"
		Me.pnlWhere1.Size = New System.Drawing.Size(311, 116)
		Me.pnlWhere1.TabIndex = 14
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(19, 34)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(82, 13)
		Me.Label7.TabIndex = 13
		Me.Label7.Text = "Selected Fields:"
		'
		'chklstSelectedFields1
		'
		Me.chklstSelectedFields1.FormattingEnabled = True
		Me.chklstSelectedFields1.Location = New System.Drawing.Point(107, 34)
		Me.chklstSelectedFields1.Name = "chklstSelectedFields1"
		Me.chklstSelectedFields1.Size = New System.Drawing.Size(210, 124)
		Me.chklstSelectedFields1.TabIndex = 12
		'
		'dgv1
		'
		Me.dgv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv1.Location = New System.Drawing.Point(6, 316)
		Me.dgv1.Name = "dgv1"
		Me.dgv1.Size = New System.Drawing.Size(311, 185)
		Me.dgv1.TabIndex = 11
		'
		'cmbSelectedTable1
		'
		Me.cmbSelectedTable1.FormattingEnabled = True
		Me.cmbSelectedTable1.Location = New System.Drawing.Point(107, 6)
		Me.cmbSelectedTable1.Name = "cmbSelectedTable1"
		Me.cmbSelectedTable1.Size = New System.Drawing.Size(210, 21)
		Me.cmbSelectedTable1.TabIndex = 10
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(64, 9)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(37, 13)
		Me.Label6.TabIndex = 0
		Me.Label6.Text = "Table:"
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CrossServerActionsToolStripMenuItem, Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(705, 24)
		Me.MenuStrip1.TabIndex = 1
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
		Me.FileToolStripMenuItem.Text = "&File"
		'
		'ExitToolStripMenuItem
		'
		Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
		Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
		Me.ExitToolStripMenuItem.Text = "E&xit"
		'
		'CrossServerActionsToolStripMenuItem
		'
		Me.CrossServerActionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyTable1ToTable2ToolStripMenuItem})
		Me.CrossServerActionsToolStripMenuItem.Name = "CrossServerActionsToolStripMenuItem"
		Me.CrossServerActionsToolStripMenuItem.Size = New System.Drawing.Size(126, 20)
		Me.CrossServerActionsToolStripMenuItem.Text = "Cross Server Actions"
		'
		'CopyTable1ToTable2ToolStripMenuItem
		'
		Me.CopyTable1ToTable2ToolStripMenuItem.Name = "CopyTable1ToTable2ToolStripMenuItem"
		Me.CopyTable1ToTable2ToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
		Me.CopyTable1ToTable2ToolStripMenuItem.Text = "Copy Table 1 to Table 2"
		'
		'AboutToolStripMenuItem
		'
		Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
		Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
		Me.AboutToolStripMenuItem.Text = "&About"
		'
		'HelpToolStripMenuItem
		'
		Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
		Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
		Me.HelpToolStripMenuItem.Text = "&Help"
		'
		'GroupBox2
		'
		Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox2.Controls.Add(Me.TabControl2)
		Me.GroupBox2.Location = New System.Drawing.Point(356, 27)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(337, 552)
		Me.GroupBox2.TabIndex = 1
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Database 2"
		'
		'TabControl2
		'
		Me.TabControl2.Controls.Add(Me.TabPage1)
		Me.TabControl2.Controls.Add(Me.TabPage2)
		Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TabControl2.Location = New System.Drawing.Point(3, 16)
		Me.TabControl2.Name = "TabControl2"
		Me.TabControl2.SelectedIndex = 0
		Me.TabControl2.Size = New System.Drawing.Size(331, 533)
		Me.TabControl2.TabIndex = 1
		'
		'TabPage1
		'
		Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
		Me.TabPage1.Controls.Add(Me.lblConnectionSuccessful2)
		Me.TabPage1.Controls.Add(Me.Label9)
		Me.TabPage1.Controls.Add(Me.cmbDB2)
		Me.TabPage1.Controls.Add(Me.btnTest2)
		Me.TabPage1.Controls.Add(Me.Label10)
		Me.TabPage1.Controls.Add(Me.txtPassword2)
		Me.TabPage1.Controls.Add(Me.Label11)
		Me.TabPage1.Controls.Add(Me.txtUsername2)
		Me.TabPage1.Controls.Add(Me.Label12)
		Me.TabPage1.Controls.Add(Me.txtServerName2)
		Me.TabPage1.Controls.Add(Me.Label13)
		Me.TabPage1.Controls.Add(Me.txtConnectionString2)
		Me.TabPage1.Location = New System.Drawing.Point(4, 22)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(323, 507)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Connection Settings"
		'
		'lblConnectionSuccessful2
		'
		Me.lblConnectionSuccessful2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.lblConnectionSuccessful2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblConnectionSuccessful2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblConnectionSuccessful2.ForeColor = System.Drawing.Color.Black
		Me.lblConnectionSuccessful2.Location = New System.Drawing.Point(6, 390)
		Me.lblConnectionSuccessful2.Name = "lblConnectionSuccessful2"
		Me.lblConnectionSuccessful2.Size = New System.Drawing.Size(311, 114)
		Me.lblConnectionSuccessful2.TabIndex = 11
		Me.lblConnectionSuccessful2.Text = "Unknown"
		Me.lblConnectionSuccessful2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(44, 154)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(56, 13)
		Me.Label9.TabIndex = 10
		Me.Label9.Text = "Database:"
		'
		'cmbDB2
		'
		Me.cmbDB2.FormattingEnabled = True
		Me.cmbDB2.Location = New System.Drawing.Point(106, 151)
		Me.cmbDB2.Name = "cmbDB2"
		Me.cmbDB2.Size = New System.Drawing.Size(210, 21)
		Me.cmbDB2.TabIndex = 9
		'
		'btnTest2
		'
		Me.btnTest2.Location = New System.Drawing.Point(9, 121)
		Me.btnTest2.Name = "btnTest2"
		Me.btnTest2.Size = New System.Drawing.Size(308, 23)
		Me.btnTest2.TabIndex = 8
		Me.btnTest2.Text = "Test Connection"
		Me.btnTest2.UseVisualStyleBackColor = True
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(44, 66)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(56, 13)
		Me.Label10.TabIndex = 7
		Me.Label10.Text = "Password:"
		'
		'txtPassword2
		'
		Me.txtPassword2.Location = New System.Drawing.Point(106, 63)
		Me.txtPassword2.Name = "txtPassword2"
		Me.txtPassword2.Size = New System.Drawing.Size(210, 20)
		Me.txtPassword2.TabIndex = 6
		Me.txtPassword2.UseSystemPasswordChar = True
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(42, 37)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(58, 13)
		Me.Label11.TabIndex = 5
		Me.Label11.Text = "Username:"
		'
		'txtUsername2
		'
		Me.txtUsername2.Location = New System.Drawing.Point(106, 34)
		Me.txtUsername2.Name = "txtUsername2"
		Me.txtUsername2.Size = New System.Drawing.Size(210, 20)
		Me.txtUsername2.TabIndex = 4
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(28, 13)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(72, 13)
		Me.Label12.TabIndex = 3
		Me.Label12.Text = "Server Name:"
		'
		'txtServerName2
		'
		Me.txtServerName2.Location = New System.Drawing.Point(106, 10)
		Me.txtServerName2.Name = "txtServerName2"
		Me.txtServerName2.Size = New System.Drawing.Size(210, 20)
		Me.txtServerName2.TabIndex = 2
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(6, 92)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(94, 13)
		Me.Label13.TabIndex = 1
		Me.Label13.Text = "Connection String:"
		'
		'txtConnectionString2
		'
		Me.txtConnectionString2.Location = New System.Drawing.Point(106, 89)
		Me.txtConnectionString2.Name = "txtConnectionString2"
		Me.txtConnectionString2.ReadOnly = True
		Me.txtConnectionString2.Size = New System.Drawing.Size(210, 20)
		Me.txtConnectionString2.TabIndex = 0
		'
		'TabPage2
		'
		Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
		Me.TabPage2.Controls.Add(Me.btnRun2)
		Me.TabPage2.Controls.Add(Me.pnlWhere2)
		Me.TabPage2.Controls.Add(Me.Label14)
		Me.TabPage2.Controls.Add(Me.chklstSelectedFields2)
		Me.TabPage2.Controls.Add(Me.dgv2)
		Me.TabPage2.Controls.Add(Me.cmbSelectedTable2)
		Me.TabPage2.Controls.Add(Me.Label15)
		Me.TabPage2.Location = New System.Drawing.Point(4, 22)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(323, 507)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "Actions"
		'
		'btnRun2
		'
		Me.btnRun2.Location = New System.Drawing.Point(7, 287)
		Me.btnRun2.Name = "btnRun2"
		Me.btnRun2.Size = New System.Drawing.Size(75, 23)
		Me.btnRun2.TabIndex = 15
		Me.btnRun2.Text = "Run"
		Me.btnRun2.UseVisualStyleBackColor = True
		'
		'pnlWhere2
		'
		Me.pnlWhere2.Location = New System.Drawing.Point(6, 164)
		Me.pnlWhere2.Name = "pnlWhere2"
		Me.pnlWhere2.Size = New System.Drawing.Size(311, 116)
		Me.pnlWhere2.TabIndex = 14
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Location = New System.Drawing.Point(19, 34)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(82, 13)
		Me.Label14.TabIndex = 13
		Me.Label14.Text = "Selected Fields:"
		'
		'chklstSelectedFields2
		'
		Me.chklstSelectedFields2.FormattingEnabled = True
		Me.chklstSelectedFields2.Location = New System.Drawing.Point(107, 34)
		Me.chklstSelectedFields2.Name = "chklstSelectedFields2"
		Me.chklstSelectedFields2.Size = New System.Drawing.Size(210, 124)
		Me.chklstSelectedFields2.TabIndex = 12
		'
		'dgv2
		'
		Me.dgv2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv2.Location = New System.Drawing.Point(6, 316)
		Me.dgv2.Name = "dgv2"
		Me.dgv2.Size = New System.Drawing.Size(311, 185)
		Me.dgv2.TabIndex = 11
		'
		'cmbSelectedTable2
		'
		Me.cmbSelectedTable2.FormattingEnabled = True
		Me.cmbSelectedTable2.Location = New System.Drawing.Point(107, 6)
		Me.cmbSelectedTable2.Name = "cmbSelectedTable2"
		Me.cmbSelectedTable2.Size = New System.Drawing.Size(210, 21)
		Me.cmbSelectedTable2.TabIndex = 10
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Location = New System.Drawing.Point(64, 9)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(37, 13)
		Me.Label15.TabIndex = 0
		Me.Label15.Text = "Table:"
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tspbLoading})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 602)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(705, 25)
		Me.ToolStrip1.TabIndex = 2
		Me.ToolStrip1.Text = "ToolStrip1"
		'
		'tspbLoading
		'
		Me.tspbLoading.Name = "tspbLoading"
		Me.tspbLoading.Size = New System.Drawing.Size(674, 22)
		'
		'FMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(705, 627)
		Me.Controls.Add(Me.ToolStrip1)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.MinimumSize = New System.Drawing.Size(721, 665)
		Me.Name = "FMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Database Tools"
		Me.GroupBox1.ResumeLayout(False)
		Me.TabControl1.ResumeLayout(False)
		Me.tbpConnectionSettings.ResumeLayout(False)
		Me.tbpConnectionSettings.PerformLayout()
		Me.tbpActions.ResumeLayout(False)
		Me.tbpActions.PerformLayout()
		CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.TabControl2.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.TabPage1.PerformLayout()
		Me.TabPage2.ResumeLayout(False)
		Me.TabPage2.PerformLayout()
		CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents tbpConnectionSettings As TabPage
	Friend WithEvents lblConnectionSuccessful1 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents cmbDB1 As ComboBox
	Friend WithEvents btnTest1 As Button
	Friend WithEvents Label4 As Label
	Friend WithEvents txtPassword1 As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents txtUsername1 As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents txtServerName1 As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents txtConnectionString1 As TextBox
	Friend WithEvents tbpActions As TabPage
	Friend WithEvents ToolStrip1 As ToolStrip
	Friend WithEvents tspbLoading As ToolStripProgressBar
	Friend WithEvents btnRun1 As Button
	Friend WithEvents pnlWhere1 As Panel
	Friend WithEvents Label7 As Label
	Friend WithEvents chklstSelectedFields1 As CheckedListBox
	Friend WithEvents dgv1 As DataGridView
	Friend WithEvents cmbSelectedTable1 As ComboBox
	Friend WithEvents Label6 As Label
	Friend WithEvents CrossServerActionsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CopyTable1ToTable2ToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents TabControl2 As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents lblConnectionSuccessful2 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents cmbDB2 As ComboBox
	Friend WithEvents btnTest2 As Button
	Friend WithEvents Label10 As Label
	Friend WithEvents txtPassword2 As TextBox
	Friend WithEvents Label11 As Label
	Friend WithEvents txtUsername2 As TextBox
	Friend WithEvents Label12 As Label
	Friend WithEvents txtServerName2 As TextBox
	Friend WithEvents Label13 As Label
	Friend WithEvents txtConnectionString2 As TextBox
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents btnRun2 As Button
	Friend WithEvents pnlWhere2 As Panel
	Friend WithEvents Label14 As Label
	Friend WithEvents chklstSelectedFields2 As CheckedListBox
	Friend WithEvents dgv2 As DataGridView
	Friend WithEvents cmbSelectedTable2 As ComboBox
	Friend WithEvents Label15 As Label
End Class
