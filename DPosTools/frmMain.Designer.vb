﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.thisOpenFileDia = New System.Windows.Forms.OpenFileDialog()
        Me.thisFileBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.DotNetBarTabcontrol1 = New DPosTools.DotNetBarTabcontrol()
        Me.tblMain = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblPWCrust = New System.Windows.Forms.Label()
        Me.lblPWDsoft = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtCloudUrl = New System.Windows.Forms.Label()
        Me.txtClient = New System.Windows.Forms.Label()
        Me.txtEnabledCloud = New System.Windows.Forms.Label()
        Me.txtDocket = New System.Windows.Forms.Label()
        Me.txtDBVersion = New System.Windows.Forms.Label()
        Me.txtDposVersion = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbpBackup = New System.Windows.Forms.TabPage()
        Me.chkBackupProgram = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBkpOK = New System.Windows.Forms.Button()
        Me.chkCopyBackup = New System.Windows.Forms.CheckBox()
        Me.btnChooseBackupFolder = New System.Windows.Forms.Button()
        Me.chkBackupData = New System.Windows.Forms.CheckBox()
        Me.txtBackupFolder = New System.Windows.Forms.TextBox()
        Me.chkBkpDeliverit = New System.Windows.Forms.CheckBox()
        Me.chkBkpDposSys = New System.Windows.Forms.CheckBox()
        Me.chkBkpStreets = New System.Windows.Forms.CheckBox()
        Me.chkBkpStock = New System.Windows.Forms.CheckBox()
        Me.chkBkpTimeClock = New System.Windows.Forms.CheckBox()
        Me.tbpRestore = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnRstOK = New System.Windows.Forms.Button()
        Me.chkRestoreData = New System.Windows.Forms.CheckBox()
        Me.chkRstIsZip = New System.Windows.Forms.CheckBox()
        Me.chkRstDPosSys = New System.Windows.Forms.CheckBox()
        Me.chkRstStock = New System.Windows.Forms.CheckBox()
        Me.chkRstTimeClock = New System.Windows.Forms.CheckBox()
        Me.chkRstStreets = New System.Windows.Forms.CheckBox()
        Me.chkRstDeliverit = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnChooseRstFolder = New System.Windows.Forms.Button()
        Me.txtRstFolder = New System.Windows.Forms.TextBox()
        Me.tbpLogs = New System.Windows.Forms.TabPage()
        Me.btnLogsBack = New System.Windows.Forms.Button()
        Me.dgLogs = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbpDPosSettings = New System.Windows.Forms.TabPage()
        Me.tbSettings = New System.Windows.Forms.TabControl()
        Me.tbSetGlobal = New System.Windows.Forms.TabPage()
        Me.btnSettingsCancel = New System.Windows.Forms.Button()
        Me.cbSettingMatchOpt = New System.Windows.Forms.CheckBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblSettingSetting = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.pbCopy = New System.Windows.Forms.PictureBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.btnSettingsSave = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btnSettingsEdit = New System.Windows.Forms.Button()
        Me.txtSettingSettingValue = New System.Windows.Forms.TextBox()
        Me.cmbSettingSetting = New System.Windows.Forms.ComboBox()
        Me.txtSettingDefaultValue = New System.Windows.Forms.TextBox()
        Me.txtSettingComment = New System.Windows.Forms.TextBox()
        Me.txtSettingCategory = New System.Windows.Forms.TextBox()
        Me.tbSetCloud = New System.Windows.Forms.TabPage()
        Me.btnCloudCancel = New System.Windows.Forms.Button()
        Me.tgCloudEnable = New MetroFramework.Controls.MetroToggle()
        Me.btnCloudSave = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCloudPresetUSE = New System.Windows.Forms.Button()
        Me.cmbCloudPreset = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtCloudResyncReturn = New System.Windows.Forms.TextBox()
        Me.txtCloudSSHCreds = New System.Windows.Forms.TextBox()
        Me.txtCloudAutoActivation = New System.Windows.Forms.TextBox()
        Me.txtCloudCloudURL = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtCloudClientID = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbHash = New System.Windows.Forms.TabPage()
        Me.txtHashAdapterName = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtHashMac = New System.Windows.Forms.TextBox()
        Me.txtHashID = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.dgIPs = New System.Windows.Forms.DataGridView()
        Me.AdapName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MacAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.tbpConfigurations = New System.Windows.Forms.TabPage()
        Me.btnConfigTestMS = New System.Windows.Forms.Button()
        Me.btnConfigSave = New System.Windows.Forms.Button()
        Me.tbDatabase = New System.Windows.Forms.TabControl()
        Me.tbcDB = New System.Windows.Forms.TabPage()
        Me.txtOptDPosIni = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtOptServerName = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblOptMS = New System.Windows.Forms.Label()
        Me.tgOptDBType = New MetroFramework.Controls.MetroToggle()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbcCreds = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtOptMSPass = New System.Windows.Forms.TextBox()
        Me.txtOptMSUser = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtOptMYPort = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtOptMYCSVPass = New System.Windows.Forms.TextBox()
        Me.txtOptMYPass = New System.Windows.Forms.TextBox()
        Me.txtOptMYUser = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DotNetBarTabcontrol1.SuspendLayout()
        Me.tblMain.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tbpBackup.SuspendLayout()
        Me.tbpRestore.SuspendLayout()
        Me.tbpLogs.SuspendLayout()
        CType(Me.dgLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpDPosSettings.SuspendLayout()
        Me.tbSettings.SuspendLayout()
        Me.tbSetGlobal.SuspendLayout()
        CType(Me.pbCopy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbSetCloud.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tbHash.SuspendLayout()
        CType(Me.dgIPs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpConfigurations.SuspendLayout()
        Me.tbDatabase.SuspendLayout()
        Me.tbcDB.SuspendLayout()
        Me.tbcCreds.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'thisOpenFileDia
        '
        Me.thisOpenFileDia.FileName = "OpenFileDialog1"
        '
        'thisFileBrowser
        '
        Me.thisFileBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'DotNetBarTabcontrol1
        '
        Me.DotNetBarTabcontrol1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.DotNetBarTabcontrol1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DotNetBarTabcontrol1.Controls.Add(Me.tblMain)
        Me.DotNetBarTabcontrol1.Controls.Add(Me.tbpBackup)
        Me.DotNetBarTabcontrol1.Controls.Add(Me.tbpRestore)
        Me.DotNetBarTabcontrol1.Controls.Add(Me.tbpLogs)
        Me.DotNetBarTabcontrol1.Controls.Add(Me.tbpDPosSettings)
        Me.DotNetBarTabcontrol1.Controls.Add(Me.tbpConfigurations)
        Me.DotNetBarTabcontrol1.ItemSize = New System.Drawing.Size(44, 136)
        Me.DotNetBarTabcontrol1.Location = New System.Drawing.Point(2, 0)
        Me.DotNetBarTabcontrol1.Multiline = True
        Me.DotNetBarTabcontrol1.Name = "DotNetBarTabcontrol1"
        Me.DotNetBarTabcontrol1.SelectedIndex = 0
        Me.DotNetBarTabcontrol1.Size = New System.Drawing.Size(665, 373)
        Me.DotNetBarTabcontrol1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.DotNetBarTabcontrol1.TabIndex = 0
        '
        'tblMain
        '
        Me.tblMain.BackColor = System.Drawing.Color.White
        Me.tblMain.Controls.Add(Me.GroupBox4)
        Me.tblMain.Controls.Add(Me.txtCloudUrl)
        Me.tblMain.Controls.Add(Me.txtClient)
        Me.tblMain.Controls.Add(Me.txtEnabledCloud)
        Me.tblMain.Controls.Add(Me.txtDocket)
        Me.tblMain.Controls.Add(Me.txtDBVersion)
        Me.tblMain.Controls.Add(Me.txtDposVersion)
        Me.tblMain.Controls.Add(Me.Label4)
        Me.tblMain.Controls.Add(Me.Label7)
        Me.tblMain.Controls.Add(Me.Label6)
        Me.tblMain.Controls.Add(Me.Label5)
        Me.tblMain.Controls.Add(Me.Label3)
        Me.tblMain.Controls.Add(Me.Label2)
        Me.tblMain.Controls.Add(Me.Label1)
        Me.tblMain.Location = New System.Drawing.Point(140, 4)
        Me.tblMain.Name = "tblMain"
        Me.tblMain.Padding = New System.Windows.Forms.Padding(3)
        Me.tblMain.Size = New System.Drawing.Size(521, 365)
        Me.tblMain.TabIndex = 0
        Me.tblMain.Text = "Main"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblPWCrust)
        Me.GroupBox4.Controls.Add(Me.lblPWDsoft)
        Me.GroupBox4.Controls.Add(Me.Label37)
        Me.GroupBox4.Controls.Add(Me.Label36)
        Me.GroupBox4.Location = New System.Drawing.Point(22, 256)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 86)
        Me.GroupBox4.TabIndex = 127
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Passwords"
        Me.GroupBox4.Visible = False
        '
        'lblPWCrust
        '
        Me.lblPWCrust.AutoSize = True
        Me.lblPWCrust.BackColor = System.Drawing.Color.Transparent
        Me.lblPWCrust.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPWCrust.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblPWCrust.Location = New System.Drawing.Point(79, 52)
        Me.lblPWCrust.Name = "lblPWCrust"
        Me.lblPWCrust.Size = New System.Drawing.Size(28, 15)
        Me.lblPWCrust.TabIndex = 127
        Me.lblPWCrust.Text = "101"
        '
        'lblPWDsoft
        '
        Me.lblPWDsoft.AutoSize = True
        Me.lblPWDsoft.BackColor = System.Drawing.Color.Transparent
        Me.lblPWDsoft.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPWDsoft.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblPWDsoft.Location = New System.Drawing.Point(78, 26)
        Me.lblPWDsoft.Name = "lblPWDsoft"
        Me.lblPWDsoft.Size = New System.Drawing.Size(28, 15)
        Me.lblPWDsoft.TabIndex = 126
        Me.lblPWDsoft.Text = "101"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(21, 52)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(53, 15)
        Me.Label37.TabIndex = 121
        Me.Label37.Text = "CRUST:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(21, 26)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(51, 15)
        Me.Label36.TabIndex = 120
        Me.Label36.Text = "DSOFT:"
        '
        'txtCloudUrl
        '
        Me.txtCloudUrl.AutoSize = True
        Me.txtCloudUrl.BackColor = System.Drawing.Color.Transparent
        Me.txtCloudUrl.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCloudUrl.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtCloudUrl.Location = New System.Drawing.Point(100, 215)
        Me.txtCloudUrl.Name = "txtCloudUrl"
        Me.txtCloudUrl.Size = New System.Drawing.Size(303, 15)
        Me.txtCloudUrl.TabIndex = 126
        Me.txtCloudUrl.Text = "http://cloudstaging.deliverit.com.au/sync/service/v2"
        '
        'txtClient
        '
        Me.txtClient.AutoSize = True
        Me.txtClient.BackColor = System.Drawing.Color.Transparent
        Me.txtClient.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClient.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtClient.Location = New System.Drawing.Point(91, 185)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(28, 15)
        Me.txtClient.TabIndex = 125
        Me.txtClient.Text = "101"
        '
        'txtEnabledCloud
        '
        Me.txtEnabledCloud.AutoSize = True
        Me.txtEnabledCloud.BackColor = System.Drawing.Color.Transparent
        Me.txtEnabledCloud.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnabledCloud.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtEnabledCloud.Location = New System.Drawing.Point(165, 155)
        Me.txtEnabledCloud.Name = "txtEnabledCloud"
        Me.txtEnabledCloud.Size = New System.Drawing.Size(15, 15)
        Me.txtEnabledCloud.TabIndex = 124
        Me.txtEnabledCloud.Text = "Y"
        '
        'txtDocket
        '
        Me.txtDocket.AutoSize = True
        Me.txtDocket.BackColor = System.Drawing.Color.Transparent
        Me.txtDocket.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocket.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtDocket.Location = New System.Drawing.Point(142, 125)
        Me.txtDocket.Name = "txtDocket"
        Me.txtDocket.Size = New System.Drawing.Size(69, 15)
        Me.txtDocket.TabIndex = 123
        Me.txtDocket.Text = "Pizza Bites"
        '
        'txtDBVersion
        '
        Me.txtDBVersion.AutoSize = True
        Me.txtDBVersion.BackColor = System.Drawing.Color.Transparent
        Me.txtDBVersion.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDBVersion.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtDBVersion.Location = New System.Drawing.Point(142, 95)
        Me.txtDBVersion.Name = "txtDBVersion"
        Me.txtDBVersion.Size = New System.Drawing.Size(48, 15)
        Me.txtDBVersion.TabIndex = 122
        Me.txtDBVersion.Text = "2.17.24"
        '
        'txtDposVersion
        '
        Me.txtDposVersion.AutoSize = True
        Me.txtDposVersion.BackColor = System.Drawing.Color.Transparent
        Me.txtDposVersion.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDposVersion.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtDposVersion.Location = New System.Drawing.Point(118, 67)
        Me.txtDposVersion.Name = "txtDposVersion"
        Me.txtDposVersion.Size = New System.Drawing.Size(54, 15)
        Me.txtDposVersion.TabIndex = 121
        Me.txtDposVersion.Text = "v2.18.04"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "ClientID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 15)
        Me.Label7.TabIndex = 119
        Me.Label7.Text = "CloudURL:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 15)
        Me.Label6.TabIndex = 118
        Me.Label6.Text = "EnabledCloud Setting:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 15)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "DocketHeading1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 15)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "Database Version"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 15)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "DPos Version"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 29)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Information"
        '
        'tbpBackup
        '
        Me.tbpBackup.BackColor = System.Drawing.Color.White
        Me.tbpBackup.Controls.Add(Me.chkBackupProgram)
        Me.tbpBackup.Controls.Add(Me.Label8)
        Me.tbpBackup.Controls.Add(Me.btnBkpOK)
        Me.tbpBackup.Controls.Add(Me.chkCopyBackup)
        Me.tbpBackup.Controls.Add(Me.btnChooseBackupFolder)
        Me.tbpBackup.Controls.Add(Me.chkBackupData)
        Me.tbpBackup.Controls.Add(Me.txtBackupFolder)
        Me.tbpBackup.Controls.Add(Me.chkBkpDeliverit)
        Me.tbpBackup.Controls.Add(Me.chkBkpDposSys)
        Me.tbpBackup.Controls.Add(Me.chkBkpStreets)
        Me.tbpBackup.Controls.Add(Me.chkBkpStock)
        Me.tbpBackup.Controls.Add(Me.chkBkpTimeClock)
        Me.tbpBackup.Location = New System.Drawing.Point(140, 4)
        Me.tbpBackup.Name = "tbpBackup"
        Me.tbpBackup.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpBackup.Size = New System.Drawing.Size(521, 365)
        Me.tbpBackup.TabIndex = 1
        Me.tbpBackup.Text = "Backup"
        '
        'chkBackupProgram
        '
        Me.chkBackupProgram.AutoSize = True
        Me.chkBackupProgram.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chkBackupProgram.Location = New System.Drawing.Point(30, 170)
        Me.chkBackupProgram.Name = "chkBackupProgram"
        Me.chkBackupProgram.Size = New System.Drawing.Size(150, 19)
        Me.chkBackupProgram.TabIndex = 87
        Me.chkBackupProgram.Text = "Backup Program files"
        Me.chkBackupProgram.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(197, 29)
        Me.Label8.TabIndex = 86
        Me.Label8.Text = "Backup Database"
        '
        'btnBkpOK
        '
        Me.btnBkpOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnBkpOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnBkpOK.FlatAppearance.BorderSize = 0
        Me.btnBkpOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBkpOK.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBkpOK.ForeColor = System.Drawing.Color.White
        Me.btnBkpOK.Location = New System.Drawing.Point(171, 263)
        Me.btnBkpOK.Name = "btnBkpOK"
        Me.btnBkpOK.Size = New System.Drawing.Size(110, 32)
        Me.btnBkpOK.TabIndex = 85
        Me.btnBkpOK.Text = "Start"
        Me.btnBkpOK.UseVisualStyleBackColor = False
        '
        'chkCopyBackup
        '
        Me.chkCopyBackup.AutoSize = True
        Me.chkCopyBackup.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCopyBackup.Location = New System.Drawing.Point(30, 198)
        Me.chkCopyBackup.Name = "chkCopyBackup"
        Me.chkCopyBackup.Size = New System.Drawing.Size(119, 19)
        Me.chkCopyBackup.TabIndex = 84
        Me.chkCopyBackup.Text = "Copy backup to:"
        Me.chkCopyBackup.UseVisualStyleBackColor = True
        '
        'btnChooseBackupFolder
        '
        Me.btnChooseBackupFolder.Location = New System.Drawing.Point(347, 196)
        Me.btnChooseBackupFolder.Name = "btnChooseBackupFolder"
        Me.btnChooseBackupFolder.Size = New System.Drawing.Size(28, 21)
        Me.btnChooseBackupFolder.TabIndex = 83
        Me.btnChooseBackupFolder.Text = "..."
        Me.btnChooseBackupFolder.UseVisualStyleBackColor = True
        '
        'chkBackupData
        '
        Me.chkBackupData.AutoSize = True
        Me.chkBackupData.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBackupData.Location = New System.Drawing.Point(30, 63)
        Me.chkBackupData.Name = "chkBackupData"
        Me.chkBackupData.Size = New System.Drawing.Size(126, 19)
        Me.chkBackupData.TabIndex = 75
        Me.chkBackupData.Text = "Backup Data files"
        Me.chkBackupData.UseVisualStyleBackColor = True
        '
        'txtBackupFolder
        '
        Me.txtBackupFolder.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBackupFolder.Location = New System.Drawing.Point(171, 196)
        Me.txtBackupFolder.Name = "txtBackupFolder"
        Me.txtBackupFolder.Size = New System.Drawing.Size(170, 23)
        Me.txtBackupFolder.TabIndex = 82
        '
        'chkBkpDeliverit
        '
        Me.chkBkpDeliverit.AutoSize = True
        Me.chkBkpDeliverit.Checked = True
        Me.chkBkpDeliverit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBkpDeliverit.Enabled = False
        Me.chkBkpDeliverit.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBkpDeliverit.Location = New System.Drawing.Point(51, 89)
        Me.chkBkpDeliverit.Name = "chkBkpDeliverit"
        Me.chkBkpDeliverit.Size = New System.Drawing.Size(76, 19)
        Me.chkBkpDeliverit.TabIndex = 77
        Me.chkBkpDeliverit.Text = "DeliverIT"
        Me.chkBkpDeliverit.UseVisualStyleBackColor = True
        '
        'chkBkpDposSys
        '
        Me.chkBkpDposSys.AutoSize = True
        Me.chkBkpDposSys.Checked = True
        Me.chkBkpDposSys.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBkpDposSys.Enabled = False
        Me.chkBkpDposSys.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBkpDposSys.Location = New System.Drawing.Point(161, 114)
        Me.chkBkpDposSys.Name = "chkBkpDposSys"
        Me.chkBkpDposSys.Size = New System.Drawing.Size(78, 19)
        Me.chkBkpDposSys.TabIndex = 81
        Me.chkBkpDposSys.Text = "DPosSys"
        Me.chkBkpDposSys.UseVisualStyleBackColor = True
        '
        'chkBkpStreets
        '
        Me.chkBkpStreets.AutoSize = True
        Me.chkBkpStreets.Checked = True
        Me.chkBkpStreets.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBkpStreets.Enabled = False
        Me.chkBkpStreets.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBkpStreets.Location = New System.Drawing.Point(51, 114)
        Me.chkBkpStreets.Name = "chkBkpStreets"
        Me.chkBkpStreets.Size = New System.Drawing.Size(67, 19)
        Me.chkBkpStreets.TabIndex = 78
        Me.chkBkpStreets.Text = "Streets"
        Me.chkBkpStreets.UseVisualStyleBackColor = True
        '
        'chkBkpStock
        '
        Me.chkBkpStock.AutoSize = True
        Me.chkBkpStock.Checked = True
        Me.chkBkpStock.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBkpStock.Enabled = False
        Me.chkBkpStock.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBkpStock.Location = New System.Drawing.Point(161, 89)
        Me.chkBkpStock.Name = "chkBkpStock"
        Me.chkBkpStock.Size = New System.Drawing.Size(58, 19)
        Me.chkBkpStock.TabIndex = 80
        Me.chkBkpStock.Text = "Stock"
        Me.chkBkpStock.UseVisualStyleBackColor = True
        '
        'chkBkpTimeClock
        '
        Me.chkBkpTimeClock.AutoSize = True
        Me.chkBkpTimeClock.Checked = True
        Me.chkBkpTimeClock.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBkpTimeClock.Enabled = False
        Me.chkBkpTimeClock.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBkpTimeClock.Location = New System.Drawing.Point(51, 139)
        Me.chkBkpTimeClock.Name = "chkBkpTimeClock"
        Me.chkBkpTimeClock.Size = New System.Drawing.Size(87, 19)
        Me.chkBkpTimeClock.TabIndex = 79
        Me.chkBkpTimeClock.Text = "TimeClock"
        Me.chkBkpTimeClock.UseVisualStyleBackColor = True
        '
        'tbpRestore
        '
        Me.tbpRestore.BackColor = System.Drawing.Color.White
        Me.tbpRestore.Controls.Add(Me.Label11)
        Me.tbpRestore.Controls.Add(Me.btnRstOK)
        Me.tbpRestore.Controls.Add(Me.chkRestoreData)
        Me.tbpRestore.Controls.Add(Me.chkRstIsZip)
        Me.tbpRestore.Controls.Add(Me.chkRstDPosSys)
        Me.tbpRestore.Controls.Add(Me.chkRstStock)
        Me.tbpRestore.Controls.Add(Me.chkRstTimeClock)
        Me.tbpRestore.Controls.Add(Me.chkRstStreets)
        Me.tbpRestore.Controls.Add(Me.chkRstDeliverit)
        Me.tbpRestore.Controls.Add(Me.Label10)
        Me.tbpRestore.Controls.Add(Me.btnChooseRstFolder)
        Me.tbpRestore.Controls.Add(Me.txtRstFolder)
        Me.tbpRestore.Location = New System.Drawing.Point(140, 4)
        Me.tbpRestore.Name = "tbpRestore"
        Me.tbpRestore.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpRestore.Size = New System.Drawing.Size(521, 365)
        Me.tbpRestore.TabIndex = 2
        Me.tbpRestore.Text = "Restore"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Roboto Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(17, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(199, 29)
        Me.Label11.TabIndex = 87
        Me.Label11.Text = "Restore Database"
        '
        'btnRstOK
        '
        Me.btnRstOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnRstOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnRstOK.FlatAppearance.BorderSize = 0
        Me.btnRstOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRstOK.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRstOK.ForeColor = System.Drawing.Color.White
        Me.btnRstOK.Location = New System.Drawing.Point(168, 264)
        Me.btnRstOK.Name = "btnRstOK"
        Me.btnRstOK.Size = New System.Drawing.Size(110, 32)
        Me.btnRstOK.TabIndex = 86
        Me.btnRstOK.Text = "Start"
        Me.btnRstOK.UseVisualStyleBackColor = False
        '
        'chkRestoreData
        '
        Me.chkRestoreData.AutoSize = True
        Me.chkRestoreData.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRestoreData.Location = New System.Drawing.Point(27, 64)
        Me.chkRestoreData.Name = "chkRestoreData"
        Me.chkRestoreData.Size = New System.Drawing.Size(128, 19)
        Me.chkRestoreData.TabIndex = 85
        Me.chkRestoreData.Text = "Restore Data files"
        Me.chkRestoreData.UseVisualStyleBackColor = True
        '
        'chkRstIsZip
        '
        Me.chkRstIsZip.AutoSize = True
        Me.chkRstIsZip.Checked = True
        Me.chkRstIsZip.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRstIsZip.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRstIsZip.Location = New System.Drawing.Point(163, 202)
        Me.chkRstIsZip.Name = "chkRstIsZip"
        Me.chkRstIsZip.Size = New System.Drawing.Size(57, 19)
        Me.chkRstIsZip.TabIndex = 84
        Me.chkRstIsZip.Text = "Is Zip"
        Me.chkRstIsZip.UseVisualStyleBackColor = True
        '
        'chkRstDPosSys
        '
        Me.chkRstDPosSys.AutoSize = True
        Me.chkRstDPosSys.Checked = True
        Me.chkRstDPosSys.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRstDPosSys.Enabled = False
        Me.chkRstDPosSys.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRstDPosSys.Location = New System.Drawing.Point(158, 114)
        Me.chkRstDPosSys.Name = "chkRstDPosSys"
        Me.chkRstDPosSys.Size = New System.Drawing.Size(78, 19)
        Me.chkRstDPosSys.TabIndex = 83
        Me.chkRstDPosSys.Text = "DPosSys"
        Me.chkRstDPosSys.UseVisualStyleBackColor = True
        '
        'chkRstStock
        '
        Me.chkRstStock.AutoSize = True
        Me.chkRstStock.Checked = True
        Me.chkRstStock.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRstStock.Enabled = False
        Me.chkRstStock.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRstStock.Location = New System.Drawing.Point(158, 89)
        Me.chkRstStock.Name = "chkRstStock"
        Me.chkRstStock.Size = New System.Drawing.Size(58, 19)
        Me.chkRstStock.TabIndex = 82
        Me.chkRstStock.Text = "Stock"
        Me.chkRstStock.UseVisualStyleBackColor = True
        '
        'chkRstTimeClock
        '
        Me.chkRstTimeClock.AutoSize = True
        Me.chkRstTimeClock.Checked = True
        Me.chkRstTimeClock.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRstTimeClock.Enabled = False
        Me.chkRstTimeClock.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRstTimeClock.Location = New System.Drawing.Point(47, 139)
        Me.chkRstTimeClock.Name = "chkRstTimeClock"
        Me.chkRstTimeClock.Size = New System.Drawing.Size(87, 19)
        Me.chkRstTimeClock.TabIndex = 81
        Me.chkRstTimeClock.Text = "TimeClock"
        Me.chkRstTimeClock.UseVisualStyleBackColor = True
        '
        'chkRstStreets
        '
        Me.chkRstStreets.AutoSize = True
        Me.chkRstStreets.Checked = True
        Me.chkRstStreets.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRstStreets.Enabled = False
        Me.chkRstStreets.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRstStreets.Location = New System.Drawing.Point(47, 114)
        Me.chkRstStreets.Name = "chkRstStreets"
        Me.chkRstStreets.Size = New System.Drawing.Size(67, 19)
        Me.chkRstStreets.TabIndex = 80
        Me.chkRstStreets.Text = "Streets"
        Me.chkRstStreets.UseVisualStyleBackColor = True
        '
        'chkRstDeliverit
        '
        Me.chkRstDeliverit.AutoSize = True
        Me.chkRstDeliverit.Checked = True
        Me.chkRstDeliverit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRstDeliverit.Enabled = False
        Me.chkRstDeliverit.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRstDeliverit.Location = New System.Drawing.Point(47, 89)
        Me.chkRstDeliverit.Name = "chkRstDeliverit"
        Me.chkRstDeliverit.Size = New System.Drawing.Size(76, 19)
        Me.chkRstDeliverit.TabIndex = 79
        Me.chkRstDeliverit.Text = "DeliverIT"
        Me.chkRstDeliverit.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 15)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "Backup file to restore:"
        '
        'btnChooseRstFolder
        '
        Me.btnChooseRstFolder.Location = New System.Drawing.Point(338, 175)
        Me.btnChooseRstFolder.Name = "btnChooseRstFolder"
        Me.btnChooseRstFolder.Size = New System.Drawing.Size(28, 21)
        Me.btnChooseRstFolder.TabIndex = 78
        Me.btnChooseRstFolder.Text = "..."
        Me.btnChooseRstFolder.UseVisualStyleBackColor = True
        '
        'txtRstFolder
        '
        Me.txtRstFolder.Location = New System.Drawing.Point(162, 176)
        Me.txtRstFolder.Name = "txtRstFolder"
        Me.txtRstFolder.Size = New System.Drawing.Size(170, 20)
        Me.txtRstFolder.TabIndex = 77
        '
        'tbpLogs
        '
        Me.tbpLogs.BackColor = System.Drawing.Color.White
        Me.tbpLogs.Controls.Add(Me.btnLogsBack)
        Me.tbpLogs.Controls.Add(Me.dgLogs)
        Me.tbpLogs.Location = New System.Drawing.Point(140, 4)
        Me.tbpLogs.Name = "tbpLogs"
        Me.tbpLogs.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpLogs.Size = New System.Drawing.Size(521, 365)
        Me.tbpLogs.TabIndex = 3
        Me.tbpLogs.Text = "Logs"
        '
        'btnLogsBack
        '
        Me.btnLogsBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogsBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnLogsBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnLogsBack.FlatAppearance.BorderSize = 0
        Me.btnLogsBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogsBack.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogsBack.ForeColor = System.Drawing.Color.White
        Me.btnLogsBack.Location = New System.Drawing.Point(405, 324)
        Me.btnLogsBack.Name = "btnLogsBack"
        Me.btnLogsBack.Size = New System.Drawing.Size(111, 32)
        Me.btnLogsBack.TabIndex = 87
        Me.btnLogsBack.Text = "Back"
        Me.btnLogsBack.UseVisualStyleBackColor = False
        Me.btnLogsBack.Visible = False
        '
        'dgLogs
        '
        Me.dgLogs.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton
        Me.dgLogs.AllowUserToDeleteRows = False
        Me.dgLogs.AllowUserToResizeColumns = False
        Me.dgLogs.AllowUserToResizeRows = False
        Me.dgLogs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgLogs.BackgroundColor = System.Drawing.Color.White
        Me.dgLogs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgLogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgLogs.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLogs.ColumnHeadersVisible = False
        Me.dgLogs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgLogs.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgLogs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgLogs.Location = New System.Drawing.Point(4, 5)
        Me.dgLogs.Margin = New System.Windows.Forms.Padding(0)
        Me.dgLogs.Name = "dgLogs"
        Me.dgLogs.ReadOnly = True
        Me.dgLogs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgLogs.RowHeadersVisible = False
        Me.dgLogs.RowHeadersWidth = 14
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLogs.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgLogs.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.dgLogs.RowTemplate.Height = 14
        Me.dgLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgLogs.Size = New System.Drawing.Size(513, 310)
        Me.dgLogs.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'tbpDPosSettings
        '
        Me.tbpDPosSettings.BackColor = System.Drawing.Color.White
        Me.tbpDPosSettings.Controls.Add(Me.tbSettings)
        Me.tbpDPosSettings.Controls.Add(Me.Label25)
        Me.tbpDPosSettings.Location = New System.Drawing.Point(140, 4)
        Me.tbpDPosSettings.Name = "tbpDPosSettings"
        Me.tbpDPosSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDPosSettings.Size = New System.Drawing.Size(521, 365)
        Me.tbpDPosSettings.TabIndex = 4
        Me.tbpDPosSettings.Text = "DPos Settings"
        '
        'tbSettings
        '
        Me.tbSettings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSettings.Controls.Add(Me.tbSetGlobal)
        Me.tbSettings.Controls.Add(Me.tbSetCloud)
        Me.tbSettings.Controls.Add(Me.tbHash)
        Me.tbSettings.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tbSettings.Location = New System.Drawing.Point(6, 47)
        Me.tbSettings.Name = "tbSettings"
        Me.tbSettings.SelectedIndex = 0
        Me.tbSettings.Size = New System.Drawing.Size(512, 312)
        Me.tbSettings.TabIndex = 109
        '
        'tbSetGlobal
        '
        Me.tbSetGlobal.Controls.Add(Me.btnSettingsCancel)
        Me.tbSetGlobal.Controls.Add(Me.cbSettingMatchOpt)
        Me.tbSetGlobal.Controls.Add(Me.Label26)
        Me.tbSetGlobal.Controls.Add(Me.lblSettingSetting)
        Me.tbSetGlobal.Controls.Add(Me.Label27)
        Me.tbSetGlobal.Controls.Add(Me.pbCopy)
        Me.tbSetGlobal.Controls.Add(Me.Label28)
        Me.tbSetGlobal.Controls.Add(Me.Label29)
        Me.tbSetGlobal.Controls.Add(Me.btnSettingsSave)
        Me.tbSetGlobal.Controls.Add(Me.Label30)
        Me.tbSetGlobal.Controls.Add(Me.btnSettingsEdit)
        Me.tbSetGlobal.Controls.Add(Me.txtSettingSettingValue)
        Me.tbSetGlobal.Controls.Add(Me.cmbSettingSetting)
        Me.tbSetGlobal.Controls.Add(Me.txtSettingDefaultValue)
        Me.tbSetGlobal.Controls.Add(Me.txtSettingComment)
        Me.tbSetGlobal.Controls.Add(Me.txtSettingCategory)
        Me.tbSetGlobal.Location = New System.Drawing.Point(4, 24)
        Me.tbSetGlobal.Name = "tbSetGlobal"
        Me.tbSetGlobal.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSetGlobal.Size = New System.Drawing.Size(504, 284)
        Me.tbSetGlobal.TabIndex = 0
        Me.tbSetGlobal.Text = "Global"
        Me.tbSetGlobal.UseVisualStyleBackColor = True
        '
        'btnSettingsCancel
        '
        Me.btnSettingsCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSettingsCancel.Enabled = False
        Me.btnSettingsCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSettingsCancel.FlatAppearance.BorderSize = 0
        Me.btnSettingsCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettingsCancel.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettingsCancel.ForeColor = System.Drawing.Color.White
        Me.btnSettingsCancel.Location = New System.Drawing.Point(341, 244)
        Me.btnSettingsCancel.Name = "btnSettingsCancel"
        Me.btnSettingsCancel.Size = New System.Drawing.Size(110, 32)
        Me.btnSettingsCancel.TabIndex = 105
        Me.btnSettingsCancel.Text = "Back"
        Me.btnSettingsCancel.UseVisualStyleBackColor = False
        '
        'cbSettingMatchOpt
        '
        Me.cbSettingMatchOpt.AutoSize = True
        Me.cbSettingMatchOpt.Checked = True
        Me.cbSettingMatchOpt.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSettingMatchOpt.Location = New System.Drawing.Point(342, 15)
        Me.cbSettingMatchOpt.Name = "cbSettingMatchOpt"
        Me.cbSettingMatchOpt.Size = New System.Drawing.Size(102, 19)
        Me.cbSettingMatchOpt.TabIndex = 108
        Me.cbSettingMatchOpt.Text = "Any Matches"
        Me.cbSettingMatchOpt.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(15, 17)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(54, 15)
        Me.Label26.TabIndex = 93
        Me.Label26.Text = "Setting: "
        '
        'lblSettingSetting
        '
        Me.lblSettingSetting.AutoSize = True
        Me.lblSettingSetting.BackColor = System.Drawing.Color.Transparent
        Me.lblSettingSetting.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettingSetting.Location = New System.Drawing.Point(129, 41)
        Me.lblSettingSetting.Name = "lblSettingSetting"
        Me.lblSettingSetting.Size = New System.Drawing.Size(47, 15)
        Me.lblSettingSetting.TabIndex = 107
        Me.lblSettingSetting.Text = "Setting"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(15, 68)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(87, 15)
        Me.Label27.TabIndex = 94
        Me.Label27.Text = "Setting Value:"
        '
        'pbCopy
        '
        Me.pbCopy.BackgroundImage = Global.DPosTools.My.Resources.Resources.ToolCopy
        Me.pbCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbCopy.Location = New System.Drawing.Point(434, 98)
        Me.pbCopy.Name = "pbCopy"
        Me.pbCopy.Size = New System.Drawing.Size(20, 20)
        Me.pbCopy.TabIndex = 106
        Me.pbCopy.TabStop = False
        Me.pbCopy.Visible = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(15, 100)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(88, 15)
        Me.Label28.TabIndex = 95
        Me.Label28.Text = "Default Value:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(15, 132)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(64, 15)
        Me.Label29.TabIndex = 96
        Me.Label29.Text = "Category:"
        '
        'btnSettingsSave
        '
        Me.btnSettingsSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSettingsSave.Enabled = False
        Me.btnSettingsSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSettingsSave.FlatAppearance.BorderSize = 0
        Me.btnSettingsSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettingsSave.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettingsSave.ForeColor = System.Drawing.Color.White
        Me.btnSettingsSave.Location = New System.Drawing.Point(225, 244)
        Me.btnSettingsSave.Name = "btnSettingsSave"
        Me.btnSettingsSave.Size = New System.Drawing.Size(110, 32)
        Me.btnSettingsSave.TabIndex = 104
        Me.btnSettingsSave.Text = "Save"
        Me.btnSettingsSave.UseVisualStyleBackColor = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(15, 162)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(67, 15)
        Me.Label30.TabIndex = 97
        Me.Label30.Text = "Comment:"
        '
        'btnSettingsEdit
        '
        Me.btnSettingsEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSettingsEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSettingsEdit.FlatAppearance.BorderSize = 0
        Me.btnSettingsEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettingsEdit.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettingsEdit.ForeColor = System.Drawing.Color.White
        Me.btnSettingsEdit.Location = New System.Drawing.Point(109, 244)
        Me.btnSettingsEdit.Name = "btnSettingsEdit"
        Me.btnSettingsEdit.Size = New System.Drawing.Size(110, 32)
        Me.btnSettingsEdit.TabIndex = 103
        Me.btnSettingsEdit.Text = "Edit"
        Me.btnSettingsEdit.UseVisualStyleBackColor = False
        '
        'txtSettingSettingValue
        '
        Me.txtSettingSettingValue.Enabled = False
        Me.txtSettingSettingValue.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSettingSettingValue.Location = New System.Drawing.Point(129, 63)
        Me.txtSettingSettingValue.Name = "txtSettingSettingValue"
        Me.txtSettingSettingValue.Size = New System.Drawing.Size(299, 23)
        Me.txtSettingSettingValue.TabIndex = 98
        '
        'cmbSettingSetting
        '
        Me.cmbSettingSetting.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbSettingSetting.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSettingSetting.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.cmbSettingSetting.FormattingEnabled = True
        Me.cmbSettingSetting.Location = New System.Drawing.Point(129, 12)
        Me.cmbSettingSetting.Name = "cmbSettingSetting"
        Me.cmbSettingSetting.Size = New System.Drawing.Size(207, 23)
        Me.cmbSettingSetting.TabIndex = 102
        '
        'txtSettingDefaultValue
        '
        Me.txtSettingDefaultValue.BackColor = System.Drawing.Color.White
        Me.txtSettingDefaultValue.Enabled = False
        Me.txtSettingDefaultValue.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSettingDefaultValue.Location = New System.Drawing.Point(129, 95)
        Me.txtSettingDefaultValue.Name = "txtSettingDefaultValue"
        Me.txtSettingDefaultValue.ReadOnly = True
        Me.txtSettingDefaultValue.Size = New System.Drawing.Size(299, 23)
        Me.txtSettingDefaultValue.TabIndex = 99
        '
        'txtSettingComment
        '
        Me.txtSettingComment.BackColor = System.Drawing.Color.White
        Me.txtSettingComment.Enabled = False
        Me.txtSettingComment.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSettingComment.Location = New System.Drawing.Point(129, 159)
        Me.txtSettingComment.Multiline = True
        Me.txtSettingComment.Name = "txtSettingComment"
        Me.txtSettingComment.ReadOnly = True
        Me.txtSettingComment.Size = New System.Drawing.Size(299, 77)
        Me.txtSettingComment.TabIndex = 101
        '
        'txtSettingCategory
        '
        Me.txtSettingCategory.BackColor = System.Drawing.Color.White
        Me.txtSettingCategory.Enabled = False
        Me.txtSettingCategory.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSettingCategory.Location = New System.Drawing.Point(129, 127)
        Me.txtSettingCategory.Name = "txtSettingCategory"
        Me.txtSettingCategory.ReadOnly = True
        Me.txtSettingCategory.Size = New System.Drawing.Size(299, 23)
        Me.txtSettingCategory.TabIndex = 100
        '
        'tbSetCloud
        '
        Me.tbSetCloud.Controls.Add(Me.btnCloudCancel)
        Me.tbSetCloud.Controls.Add(Me.tgCloudEnable)
        Me.tbSetCloud.Controls.Add(Me.btnCloudSave)
        Me.tbSetCloud.Controls.Add(Me.GroupBox3)
        Me.tbSetCloud.Controls.Add(Me.txtCloudClientID)
        Me.tbSetCloud.Controls.Add(Me.Label21)
        Me.tbSetCloud.Controls.Add(Me.Label18)
        Me.tbSetCloud.Location = New System.Drawing.Point(4, 24)
        Me.tbSetCloud.Name = "tbSetCloud"
        Me.tbSetCloud.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSetCloud.Size = New System.Drawing.Size(504, 284)
        Me.tbSetCloud.TabIndex = 1
        Me.tbSetCloud.Text = "Cloud Setup"
        Me.tbSetCloud.UseVisualStyleBackColor = True
        '
        'btnCloudCancel
        '
        Me.btnCloudCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnCloudCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnCloudCancel.FlatAppearance.BorderSize = 0
        Me.btnCloudCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloudCancel.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloudCancel.ForeColor = System.Drawing.Color.White
        Me.btnCloudCancel.Location = New System.Drawing.Point(242, 245)
        Me.btnCloudCancel.Name = "btnCloudCancel"
        Me.btnCloudCancel.Size = New System.Drawing.Size(110, 32)
        Me.btnCloudCancel.TabIndex = 111
        Me.btnCloudCancel.Text = "Cancel"
        Me.btnCloudCancel.UseVisualStyleBackColor = False
        '
        'tgCloudEnable
        '
        Me.tgCloudEnable.AutoSize = True
        Me.tgCloudEnable.BackColor = System.Drawing.Color.DodgerBlue
        Me.tgCloudEnable.Checked = True
        Me.tgCloudEnable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tgCloudEnable.DisplayStatus = False
        Me.tgCloudEnable.Location = New System.Drawing.Point(116, 14)
        Me.tgCloudEnable.Name = "tgCloudEnable"
        Me.tgCloudEnable.Size = New System.Drawing.Size(50, 19)
        Me.tgCloudEnable.TabIndex = 110
        Me.tgCloudEnable.Text = "On"
        Me.tgCloudEnable.UseVisualStyleBackColor = False
        '
        'btnCloudSave
        '
        Me.btnCloudSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnCloudSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnCloudSave.FlatAppearance.BorderSize = 0
        Me.btnCloudSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloudSave.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloudSave.ForeColor = System.Drawing.Color.White
        Me.btnCloudSave.Location = New System.Drawing.Point(126, 245)
        Me.btnCloudSave.Name = "btnCloudSave"
        Me.btnCloudSave.Size = New System.Drawing.Size(110, 32)
        Me.btnCloudSave.TabIndex = 109
        Me.btnCloudSave.Text = "Save"
        Me.btnCloudSave.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCloudPresetUSE)
        Me.GroupBox3.Controls.Add(Me.cmbCloudPreset)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.txtCloudResyncReturn)
        Me.GroupBox3.Controls.Add(Me.txtCloudSSHCreds)
        Me.GroupBox3.Controls.Add(Me.txtCloudAutoActivation)
        Me.GroupBox3.Controls.Add(Me.txtCloudCloudURL)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 74)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(454, 163)
        Me.GroupBox3.TabIndex = 108
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "URL"
        '
        'btnCloudPresetUSE
        '
        Me.btnCloudPresetUSE.BackColor = System.Drawing.Color.Teal
        Me.btnCloudPresetUSE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnCloudPresetUSE.FlatAppearance.BorderSize = 0
        Me.btnCloudPresetUSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloudPresetUSE.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloudPresetUSE.ForeColor = System.Drawing.Color.White
        Me.btnCloudPresetUSE.Location = New System.Drawing.Point(397, 16)
        Me.btnCloudPresetUSE.Name = "btnCloudPresetUSE"
        Me.btnCloudPresetUSE.Size = New System.Drawing.Size(44, 24)
        Me.btnCloudPresetUSE.TabIndex = 112
        Me.btnCloudPresetUSE.Text = "USE"
        Me.btnCloudPresetUSE.UseVisualStyleBackColor = False
        '
        'cmbCloudPreset
        '
        Me.cmbCloudPreset.FormattingEnabled = True
        Me.cmbCloudPreset.Items.AddRange(New Object() {"staging", "live"})
        Me.cmbCloudPreset.Location = New System.Drawing.Point(306, 16)
        Me.cmbCloudPreset.Name = "cmbCloudPreset"
        Me.cmbCloudPreset.Size = New System.Drawing.Size(86, 23)
        Me.cmbCloudPreset.TabIndex = 112
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(223, 19)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(77, 15)
        Me.Label34.TabIndex = 114
        Me.Label34.Text = "Use Preset?"
        '
        'txtCloudResyncReturn
        '
        Me.txtCloudResyncReturn.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCloudResyncReturn.Location = New System.Drawing.Point(134, 131)
        Me.txtCloudResyncReturn.Name = "txtCloudResyncReturn"
        Me.txtCloudResyncReturn.Size = New System.Drawing.Size(307, 23)
        Me.txtCloudResyncReturn.TabIndex = 113
        '
        'txtCloudSSHCreds
        '
        Me.txtCloudSSHCreds.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCloudSSHCreds.Location = New System.Drawing.Point(134, 102)
        Me.txtCloudSSHCreds.Name = "txtCloudSSHCreds"
        Me.txtCloudSSHCreds.Size = New System.Drawing.Size(307, 23)
        Me.txtCloudSSHCreds.TabIndex = 112
        '
        'txtCloudAutoActivation
        '
        Me.txtCloudAutoActivation.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCloudAutoActivation.Location = New System.Drawing.Point(134, 74)
        Me.txtCloudAutoActivation.Name = "txtCloudAutoActivation"
        Me.txtCloudAutoActivation.Size = New System.Drawing.Size(307, 23)
        Me.txtCloudAutoActivation.TabIndex = 111
        '
        'txtCloudCloudURL
        '
        Me.txtCloudCloudURL.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCloudCloudURL.Location = New System.Drawing.Point(134, 45)
        Me.txtCloudCloudURL.Name = "txtCloudCloudURL"
        Me.txtCloudCloudURL.Size = New System.Drawing.Size(307, 23)
        Me.txtCloudCloudURL.TabIndex = 110
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(14, 134)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(95, 15)
        Me.Label33.TabIndex = 109
        Me.Label33.Text = "Resync Return:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(14, 105)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(105, 15)
        Me.Label32.TabIndex = 108
        Me.Label32.Text = "SSH Credentials:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(14, 48)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(44, 15)
        Me.Label24.TabIndex = 106
        Me.Label24.Text = "Cloud:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(14, 77)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(99, 15)
        Me.Label31.TabIndex = 107
        Me.Label31.Text = "Auto Activation:"
        '
        'txtCloudClientID
        '
        Me.txtCloudClientID.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCloudClientID.Location = New System.Drawing.Point(116, 42)
        Me.txtCloudClientID.Name = "txtCloudClientID"
        Me.txtCloudClientID.Size = New System.Drawing.Size(98, 23)
        Me.txtCloudClientID.TabIndex = 105
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(15, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 15)
        Me.Label21.TabIndex = 104
        Me.Label21.Text = "Client ID:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(15, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 15)
        Me.Label18.TabIndex = 94
        Me.Label18.Text = "Enable Cloud:"
        '
        'tbHash
        '
        Me.tbHash.Controls.Add(Me.txtHashAdapterName)
        Me.tbHash.Controls.Add(Me.Label40)
        Me.tbHash.Controls.Add(Me.txtHashMac)
        Me.tbHash.Controls.Add(Me.txtHashID)
        Me.tbHash.Controls.Add(Me.Label39)
        Me.tbHash.Controls.Add(Me.Label38)
        Me.tbHash.Controls.Add(Me.dgIPs)
        Me.tbHash.Location = New System.Drawing.Point(4, 24)
        Me.tbHash.Name = "tbHash"
        Me.tbHash.Padding = New System.Windows.Forms.Padding(3)
        Me.tbHash.Size = New System.Drawing.Size(504, 284)
        Me.tbHash.TabIndex = 2
        Me.tbHash.Text = "Network Adapters"
        Me.tbHash.UseVisualStyleBackColor = True
        '
        'txtHashAdapterName
        '
        Me.txtHashAdapterName.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHashAdapterName.Location = New System.Drawing.Point(99, 223)
        Me.txtHashAdapterName.Name = "txtHashAdapterName"
        Me.txtHashAdapterName.ReadOnly = True
        Me.txtHashAdapterName.Size = New System.Drawing.Size(158, 23)
        Me.txtHashAdapterName.TabIndex = 123
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(9, 226)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(90, 15)
        Me.Label40.TabIndex = 122
        Me.Label40.Text = "Adapter Name"
        '
        'txtHashMac
        '
        Me.txtHashMac.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHashMac.Location = New System.Drawing.Point(353, 223)
        Me.txtHashMac.Name = "txtHashMac"
        Me.txtHashMac.ReadOnly = True
        Me.txtHashMac.Size = New System.Drawing.Size(139, 23)
        Me.txtHashMac.TabIndex = 120
        '
        'txtHashID
        '
        Me.txtHashID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHashID.BackColor = System.Drawing.Color.White
        Me.txtHashID.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHashID.Location = New System.Drawing.Point(99, 252)
        Me.txtHashID.Name = "txtHashID"
        Me.txtHashID.ReadOnly = True
        Me.txtHashID.Size = New System.Drawing.Size(394, 23)
        Me.txtHashID.TabIndex = 121
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(9, 256)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(52, 15)
        Me.Label39.TabIndex = 119
        Me.Label39.Text = "Hash ID"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(263, 226)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(84, 15)
        Me.Label38.TabIndex = 118
        Me.Label38.Text = "Mac Address"
        '
        'dgIPs
        '
        Me.dgIPs.AllowUserToAddRows = False
        Me.dgIPs.AllowUserToDeleteRows = False
        Me.dgIPs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgIPs.BackgroundColor = System.Drawing.Color.White
        Me.dgIPs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgIPs.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgIPs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgIPs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AdapName, Me.MacAddress, Me.NIC, Me.OpStatus})
        Me.dgIPs.Location = New System.Drawing.Point(9, 10)
        Me.dgIPs.MultiSelect = False
        Me.dgIPs.Name = "dgIPs"
        Me.dgIPs.ReadOnly = True
        Me.dgIPs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgIPs.RowHeadersVisible = False
        Me.dgIPs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgIPs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgIPs.ShowEditingIcon = False
        Me.dgIPs.Size = New System.Drawing.Size(484, 203)
        Me.dgIPs.TabIndex = 117
        '
        'AdapName
        '
        Me.AdapName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AdapName.HeaderText = "Name"
        Me.AdapName.Name = "AdapName"
        Me.AdapName.ReadOnly = True
        '
        'MacAddress
        '
        Me.MacAddress.HeaderText = "MacAddress"
        Me.MacAddress.Name = "MacAddress"
        Me.MacAddress.ReadOnly = True
        Me.MacAddress.Width = 125
        '
        'NIC
        '
        Me.NIC.HeaderText = "Network Interface Type"
        Me.NIC.Name = "NIC"
        Me.NIC.ReadOnly = True
        '
        'OpStatus
        '
        Me.OpStatus.HeaderText = "Status"
        Me.OpStatus.Name = "OpStatus"
        Me.OpStatus.ReadOnly = True
        Me.OpStatus.Width = 75
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Roboto Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(17, 14)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(98, 29)
        Me.Label25.TabIndex = 87
        Me.Label25.Text = "Settings"
        '
        'tbpConfigurations
        '
        Me.tbpConfigurations.BackColor = System.Drawing.Color.White
        Me.tbpConfigurations.Controls.Add(Me.btnConfigTestMS)
        Me.tbpConfigurations.Controls.Add(Me.btnConfigSave)
        Me.tbpConfigurations.Controls.Add(Me.tbDatabase)
        Me.tbpConfigurations.Controls.Add(Me.Label12)
        Me.tbpConfigurations.Location = New System.Drawing.Point(140, 4)
        Me.tbpConfigurations.Name = "tbpConfigurations"
        Me.tbpConfigurations.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpConfigurations.Size = New System.Drawing.Size(521, 365)
        Me.tbpConfigurations.TabIndex = 5
        Me.tbpConfigurations.Text = "Configurations"
        '
        'btnConfigTestMS
        '
        Me.btnConfigTestMS.BackColor = System.Drawing.Color.Teal
        Me.btnConfigTestMS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnConfigTestMS.FlatAppearance.BorderSize = 0
        Me.btnConfigTestMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigTestMS.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfigTestMS.ForeColor = System.Drawing.Color.White
        Me.btnConfigTestMS.Location = New System.Drawing.Point(250, 333)
        Me.btnConfigTestMS.Name = "btnConfigTestMS"
        Me.btnConfigTestMS.Size = New System.Drawing.Size(110, 32)
        Me.btnConfigTestMS.TabIndex = 105
        Me.btnConfigTestMS.Text = "Test Connection"
        Me.btnConfigTestMS.UseVisualStyleBackColor = False
        '
        'btnConfigSave
        '
        Me.btnConfigSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnConfigSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnConfigSave.FlatAppearance.BorderSize = 0
        Me.btnConfigSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigSave.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfigSave.ForeColor = System.Drawing.Color.White
        Me.btnConfigSave.Location = New System.Drawing.Point(366, 333)
        Me.btnConfigSave.Name = "btnConfigSave"
        Me.btnConfigSave.Size = New System.Drawing.Size(110, 32)
        Me.btnConfigSave.TabIndex = 106
        Me.btnConfigSave.Text = "Save"
        Me.btnConfigSave.UseVisualStyleBackColor = False
        '
        'tbDatabase
        '
        Me.tbDatabase.Controls.Add(Me.tbcDB)
        Me.tbDatabase.Controls.Add(Me.tbcCreds)
        Me.tbDatabase.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDatabase.Location = New System.Drawing.Point(8, 58)
        Me.tbDatabase.Name = "tbDatabase"
        Me.tbDatabase.SelectedIndex = 0
        Me.tbDatabase.Size = New System.Drawing.Size(473, 273)
        Me.tbDatabase.TabIndex = 104
        '
        'tbcDB
        '
        Me.tbcDB.Controls.Add(Me.txtOptDPosIni)
        Me.tbcDB.Controls.Add(Me.Label17)
        Me.tbcDB.Controls.Add(Me.txtOptServerName)
        Me.tbcDB.Controls.Add(Me.Label22)
        Me.tbcDB.Controls.Add(Me.Label14)
        Me.tbcDB.Controls.Add(Me.lblOptMS)
        Me.tbcDB.Controls.Add(Me.tgOptDBType)
        Me.tbcDB.Controls.Add(Me.Label13)
        Me.tbcDB.Location = New System.Drawing.Point(4, 24)
        Me.tbcDB.Name = "tbcDB"
        Me.tbcDB.Size = New System.Drawing.Size(465, 245)
        Me.tbcDB.TabIndex = 2
        Me.tbcDB.Text = "Database Settings"
        Me.tbcDB.UseVisualStyleBackColor = True
        '
        'txtOptDPosIni
        '
        Me.txtOptDPosIni.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOptDPosIni.Location = New System.Drawing.Point(25, 154)
        Me.txtOptDPosIni.Name = "txtOptDPosIni"
        Me.txtOptDPosIni.Size = New System.Drawing.Size(369, 23)
        Me.txtOptDPosIni.TabIndex = 94
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(22, 136)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 15)
        Me.Label17.TabIndex = 94
        Me.Label17.Text = "DPos.ini"
        '
        'txtOptServerName
        '
        Me.txtOptServerName.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOptServerName.Location = New System.Drawing.Point(129, 74)
        Me.txtOptServerName.Name = "txtOptServerName"
        Me.txtOptServerName.Size = New System.Drawing.Size(125, 23)
        Me.txtOptServerName.TabIndex = 93
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(22, 79)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(83, 15)
        Me.Label22.TabIndex = 92
        Me.Label22.Text = "Server Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(260, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 15)
        Me.Label14.TabIndex = 91
        Me.Label14.Text = "MYSQL"
        '
        'lblOptMS
        '
        Me.lblOptMS.AutoSize = True
        Me.lblOptMS.BackColor = System.Drawing.Color.Transparent
        Me.lblOptMS.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptMS.Location = New System.Drawing.Point(126, 44)
        Me.lblOptMS.Name = "lblOptMS"
        Me.lblOptMS.Size = New System.Drawing.Size(72, 15)
        Me.lblOptMS.TabIndex = 90
        Me.lblOptMS.Text = "MSSERVER"
        '
        'tgOptDBType
        '
        Me.tgOptDBType.AutoSize = True
        Me.tgOptDBType.BackColor = System.Drawing.Color.DodgerBlue
        Me.tgOptDBType.Checked = True
        Me.tgOptDBType.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tgOptDBType.DisplayStatus = False
        Me.tgOptDBType.Location = New System.Drawing.Point(204, 44)
        Me.tgOptDBType.Name = "tgOptDBType"
        Me.tgOptDBType.Size = New System.Drawing.Size(50, 19)
        Me.tgOptDBType.TabIndex = 89
        Me.tgOptDBType.Text = "On"
        Me.tgOptDBType.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(22, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 15)
        Me.Label13.TabIndex = 88
        Me.Label13.Text = "Database-Type"
        '
        'tbcCreds
        '
        Me.tbcCreds.Controls.Add(Me.GroupBox2)
        Me.tbcCreds.Controls.Add(Me.GroupBox1)
        Me.tbcCreds.Location = New System.Drawing.Point(4, 24)
        Me.tbcCreds.Name = "tbcCreds"
        Me.tbcCreds.Padding = New System.Windows.Forms.Padding(3)
        Me.tbcCreds.Size = New System.Drawing.Size(465, 245)
        Me.tbcCreds.TabIndex = 1
        Me.tbcCreds.Text = "Database Credentials"
        Me.tbcCreds.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtOptMSPass)
        Me.GroupBox2.Controls.Add(Me.txtOptMSUser)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(413, 83)
        Me.GroupBox2.TabIndex = 102
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SQL Server"
        '
        'txtOptMSPass
        '
        Me.txtOptMSPass.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOptMSPass.Location = New System.Drawing.Point(157, 48)
        Me.txtOptMSPass.Name = "txtOptMSPass"
        Me.txtOptMSPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOptMSPass.Size = New System.Drawing.Size(165, 23)
        Me.txtOptMSPass.TabIndex = 96
        '
        'txtOptMSUser
        '
        Me.txtOptMSUser.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOptMSUser.Location = New System.Drawing.Point(157, 19)
        Me.txtOptMSUser.Name = "txtOptMSUser"
        Me.txtOptMSUser.Size = New System.Drawing.Size(165, 23)
        Me.txtOptMSUser.TabIndex = 95
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(17, 53)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 15)
        Me.Label16.TabIndex = 89
        Me.Label16.Text = "Root Password"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(17, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 15)
        Me.Label15.TabIndex = 88
        Me.Label15.Text = "Root Username"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.txtOptMYPort)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtOptMYCSVPass)
        Me.GroupBox1.Controls.Add(Me.txtOptMYPass)
        Me.GroupBox1.Controls.Add(Me.txtOptMYUser)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 141)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MySQL Server"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(18, 22)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 15)
        Me.Label23.TabIndex = 108
        Me.Label23.Text = "Port"
        '
        'txtOptMYPort
        '
        Me.txtOptMYPort.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOptMYPort.Location = New System.Drawing.Point(158, 17)
        Me.txtOptMYPort.Name = "txtOptMYPort"
        Me.txtOptMYPort.Size = New System.Drawing.Size(72, 23)
        Me.txtOptMYPort.TabIndex = 97
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 15)
        Me.Label9.TabIndex = 106
        Me.Label9.Text = "Restore Password"
        '
        'txtOptMYCSVPass
        '
        Me.txtOptMYCSVPass.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOptMYCSVPass.Location = New System.Drawing.Point(157, 108)
        Me.txtOptMYCSVPass.Name = "txtOptMYCSVPass"
        Me.txtOptMYCSVPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOptMYCSVPass.Size = New System.Drawing.Size(165, 23)
        Me.txtOptMYCSVPass.TabIndex = 100
        '
        'txtOptMYPass
        '
        Me.txtOptMYPass.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOptMYPass.Location = New System.Drawing.Point(157, 79)
        Me.txtOptMYPass.Name = "txtOptMYPass"
        Me.txtOptMYPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOptMYPass.Size = New System.Drawing.Size(165, 23)
        Me.txtOptMYPass.TabIndex = 99
        '
        'txtOptMYUser
        '
        Me.txtOptMYUser.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOptMYUser.Location = New System.Drawing.Point(157, 50)
        Me.txtOptMYUser.Name = "txtOptMYUser"
        Me.txtOptMYUser.Size = New System.Drawing.Size(165, 23)
        Me.txtOptMYUser.TabIndex = 98
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(17, 84)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 15)
        Me.Label19.TabIndex = 102
        Me.Label19.Text = "Root Password"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Roboto Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(17, 55)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 15)
        Me.Label20.TabIndex = 101
        Me.Label20.Text = "Root Username"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Roboto Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(166, 29)
        Me.Label12.TabIndex = 103
        Me.Label12.Text = "Configurations"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 372)
        Me.Controls.Add(Me.DotNetBarTabcontrol1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "DPos Tools"
        Me.DotNetBarTabcontrol1.ResumeLayout(False)
        Me.tblMain.ResumeLayout(False)
        Me.tblMain.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.tbpBackup.ResumeLayout(False)
        Me.tbpBackup.PerformLayout()
        Me.tbpRestore.ResumeLayout(False)
        Me.tbpRestore.PerformLayout()
        Me.tbpLogs.ResumeLayout(False)
        CType(Me.dgLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpDPosSettings.ResumeLayout(False)
        Me.tbpDPosSettings.PerformLayout()
        Me.tbSettings.ResumeLayout(False)
        Me.tbSetGlobal.ResumeLayout(False)
        Me.tbSetGlobal.PerformLayout()
        CType(Me.pbCopy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbSetCloud.ResumeLayout(False)
        Me.tbSetCloud.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tbHash.ResumeLayout(False)
        Me.tbHash.PerformLayout()
        CType(Me.dgIPs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpConfigurations.ResumeLayout(False)
        Me.tbpConfigurations.PerformLayout()
        Me.tbDatabase.ResumeLayout(False)
        Me.tbcDB.ResumeLayout(False)
        Me.tbcDB.PerformLayout()
        Me.tbcCreds.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DotNetBarTabcontrol1 As DotNetBarTabcontrol
    Friend WithEvents tblMain As TabPage
    Friend WithEvents tbpBackup As TabPage
    Friend WithEvents tbpRestore As TabPage
    Friend WithEvents tbpLogs As TabPage
    Friend WithEvents tbpDPosSettings As TabPage
    Friend WithEvents tbpConfigurations As TabPage
    Friend WithEvents txtCloudUrl As Label
    Friend WithEvents txtClient As Label
    Friend WithEvents txtEnabledCloud As Label
    Friend WithEvents txtDocket As Label
    Friend WithEvents txtDBVersion As Label
    Friend WithEvents txtDposVersion As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnBkpOK As Button
    Friend WithEvents chkCopyBackup As CheckBox
    Friend WithEvents btnChooseBackupFolder As Button
    Friend WithEvents chkBackupData As CheckBox
    Friend WithEvents txtBackupFolder As TextBox
    Friend WithEvents chkBkpDeliverit As CheckBox
    Friend WithEvents chkBkpDposSys As CheckBox
    Friend WithEvents chkBkpStreets As CheckBox
    Friend WithEvents chkBkpStock As CheckBox
    Friend WithEvents chkBkpTimeClock As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnRstOK As Button
    Friend WithEvents chkRestoreData As CheckBox
    Friend WithEvents chkRstIsZip As CheckBox
    Friend WithEvents chkRstDPosSys As CheckBox
    Friend WithEvents chkRstStock As CheckBox
    Friend WithEvents chkRstTimeClock As CheckBox
    Friend WithEvents chkRstStreets As CheckBox
    Friend WithEvents chkRstDeliverit As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnChooseRstFolder As Button
    Friend WithEvents txtRstFolder As TextBox
    Friend WithEvents btnConfigTestMS As Button
    Friend WithEvents btnConfigSave As Button
    Friend WithEvents tbDatabase As TabControl
    Friend WithEvents tbcDB As TabPage
    Friend WithEvents txtOptDPosIni As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtOptServerName As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblOptMS As Label
    Friend WithEvents tgOptDBType As MetroFramework.Controls.MetroToggle
    Friend WithEvents Label13 As Label
    Friend WithEvents tbcCreds As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtOptMSPass As TextBox
    Friend WithEvents txtOptMSUser As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtOptMYPort As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtOptMYCSVPass As TextBox
    Friend WithEvents txtOptMYPass As TextBox
    Friend WithEvents txtOptMYUser As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnLogsBack As Button
    Friend WithEvents dgLogs As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents thisOpenFileDia As OpenFileDialog
    Friend WithEvents thisFileBrowser As FolderBrowserDialog
    Friend WithEvents chkBackupProgram As CheckBox
    Friend WithEvents Label25 As Label
    Friend WithEvents cmbSettingSetting As ComboBox
    Friend WithEvents txtSettingComment As TextBox
    Friend WithEvents txtSettingCategory As TextBox
    Friend WithEvents txtSettingDefaultValue As TextBox
    Friend WithEvents txtSettingSettingValue As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents btnSettingsCancel As Button
    Friend WithEvents btnSettingsSave As Button
    Friend WithEvents btnSettingsEdit As Button
    Friend WithEvents pbCopy As PictureBox
    Friend WithEvents lblSettingSetting As Label
    Friend WithEvents cbSettingMatchOpt As CheckBox
    Friend WithEvents tbSettings As TabControl
    Friend WithEvents tbSetGlobal As TabPage
    Friend WithEvents tbSetCloud As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtCloudResyncReturn As TextBox
    Friend WithEvents txtCloudSSHCreds As TextBox
    Friend WithEvents txtCloudAutoActivation As TextBox
    Friend WithEvents txtCloudCloudURL As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents txtCloudClientID As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents btnCloudSave As Button
    Friend WithEvents tgCloudEnable As MetroFramework.Controls.MetroToggle
    Friend WithEvents btnCloudCancel As Button
    Friend WithEvents Label34 As Label
    Friend WithEvents btnCloudPresetUSE As Button
    Friend WithEvents cmbCloudPreset As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents lblPWCrust As Label
    Friend WithEvents lblPWDsoft As Label
    Friend WithEvents tbHash As TabPage
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents dgIPs As DataGridView
    Friend WithEvents txtHashMac As TextBox
    Friend WithEvents txtHashID As TextBox
    Friend WithEvents AdapName As DataGridViewTextBoxColumn
    Friend WithEvents MacAddress As DataGridViewTextBoxColumn
    Friend WithEvents NIC As DataGridViewTextBoxColumn
    Friend WithEvents OpStatus As DataGridViewTextBoxColumn
    Friend WithEvents txtHashAdapterName As TextBox
    Friend WithEvents Label40 As Label
End Class
