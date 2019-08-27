Imports DPosSecurity.modSecurity
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Microsoft.Win32
Imports System.IO

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName).Length > 1 Then
            Try
                MessageBox.Show(Me, "Another instance of DPos Tool is already Running", "Multiple Instance Forbidden")
                ExitProgram()
                Exit Sub
            Catch ex As Exception
            End Try
        End If


        Dim sError As String = ""
        If myAppIni(sError, True) = False Then
            MessageBox.Show(Me, sError, "Failed to Initialize App Tool")
            ExitProgram()
        End If

    End Sub

#Region "Initialization"
    Private Function myAppIni(ByRef sErrorMsg As String, ByVal bReturnIfErr As Boolean) As Boolean
        Dim bReturn As Boolean = True
        Try
            If Debugger.IsAttached Then
                bDemo = True
            End If

            'check if MyAppConfig exist
            sConfigFile = ExtraFilesAppPath("ToolConfig.ini")
            bReturn = CreateTextFiles(sConfigFile, "Failed to initialize ToolConfig.ini")
            If bReturn = False Then
                If bReturnIfErr Then
                    Return bReturn
                End If
            End If

            'initialize CSVRestore exist
            sCSVRestoreLogsFile = ExtraFilesAppPath("CSVRestoreLogs.txt")
            bReturn = CreateTextFiles(sCSVRestoreLogsFile, "Failed to initialize CSVRestoreLogs.ini")
            If bReturn = False Then
                If bReturnIfErr Then
                    Return bReturn
                End If
            End If

            'Create Folders
            If Directory.Exists(dirMSSERVER & "\Backups") = False Then Directory.CreateDirectory(dirMSSERVER & "\Backups")
            If Directory.Exists(dirMSSERVER & "\Restore") = False Then Directory.CreateDirectory(dirMSSERVER & "\Restore")
            If Directory.Exists(dirMYSQL & "\Backups") = False Then Directory.CreateDirectory(dirMYSQL & "\Backups")
            If Directory.Exists(dirMYSQL & "\Restore") = False Then Directory.CreateDirectory(dirMYSQL & "\Restore")

            'Load App Configuration
            sErrorMsg = ""
            bReturn = LoadConfigFile(sErrorMsg)
            If bReturn = False Then
                If bReturnIfErr Then
                    Return bReturn
                End If
            End If

            '...and put em to config fields
            bReturn = FillConfigFields()
            If bReturn = False Then
                If bReturnIfErr Then
                    sErrorMsg = "Failed to populate Config Fields"
                    bReturn = False
                    Return bReturn
                End If
            End If

            Try
                Me.Text = "DPos Tools - " & myBooltoDBType(thisConfig.DatabaseType) & " - Server Name: " & thisConfig.ServerName
            Catch ex As Exception
                If bReturnIfErr Then
                    sErrorMsg = "Title Bar: " & ex.Message.ToString
                    bReturn = False
                End If
            End Try

            'Load Settings
            sErrorMsg = ""
            bReturn = GetAllSettings(sErrorMsg)
            If bReturn = False Then
                If bReturnIfErr Then
                    If MsgBox("Do you still want to continue?", vbYesNo, "Failed to Load DPos Settings") = MsgBoxResult.Yes Then
                        sErrorMsg = ""
                        bReturn = True
                    Else
                        sErrorMsg &= " User aborted to load the app..."
                        Return bReturn
                    End If
                End If
            End If

            'Load General Information
            sErrorMsg = ""
            bReturn = LoadInformation(sErrorMsg)
            If bReturn = False Then
                If bReturnIfErr Then
                    If MsgBox("Error: " & sErrorMsg & vbCrLf & "Do you still want to continue?", vbYesNo, "Failed to Load DPos Information") = MsgBoxResult.Yes Then
                        sErrorMsg = ""
                        bReturn = True
                    Else
                        sErrorMsg &= " User aborted to load the app..."
                        Return bReturn
                    End If
                End If
            End If

            '... and put them to fields
            sErrorMsg = ""
            bReturn = FillInfoFields(sErrorMsg)
            If bReturn = False Then
                If bReturnIfErr Then
                    sErrorMsg = "Failed to populate Information Fields"
                    bReturn = False
                    Return bReturn
                End If
            End If

            Me.dgLogs.Rows.Clear()
            Me.dgLogs.Columns("Column1").Width = 370
            Me.dgLogs.Columns("Column2").Width = 100

            bChangeTab = True
        Catch ex As Exception
            bReturn = False
            sErrorMsg = ex.Message.ToString
        End Try

        Return bReturn
    End Function

    Private Function CreateTextFiles(ByVal sTextFile As String, ByVal sErrMsg As String) As Boolean
        Dim bReturn As Boolean = True

        Try
            If myFileExist(sTextFile) = False Then
                If CreateIni(sTextFile) = False Then
                    bReturn = False
                Else
                    If sTextFile = sConfigFile Then
                        bReturn = InitializeOptionFile(sErrMsg)
                    End If
                End If
            End If
        Catch ex As Exception
            bReturn = False
        End Try

        Return bReturn
    End Function

    Private Function InitializeOptionFile(ByRef sErrMsg As String) As Boolean
        Dim bReturn As Boolean = True
        Dim sPW As String = ""

        Try
            sErrMsg = "Error on Writing to ToolConfig.ini"
            If WriteToIni("[GLOBAL]", "[GLOBAL]", sConfigFile) = False Then
                bReturn = False
                Return bReturn
            End If

            If WriteToIni("DATABASE-TYPE=0", "DATABASE-TYPE", sConfigFile) = False Then
                bReturn = False
                Return bReturn
            End If

            If WriteToIni("SERVERNAME=" & My.Computer.Name, "SERVERNAME", sConfigFile) = False Then
                bReturn = False
                Return bReturn
            End If

            If WriteToIni("DPOSINILOC=C:\DPos\DPos.ini", "DPOSINILOC", sConfigFile) = False Then
                bReturn = False
                Return bReturn
            End If

            If WriteToIni(vbCrLf & "[SQL SERVER]", "[SQL SERVER]", sConfigFile) = False Then
                bReturn = False
                Return bReturn
            End If

            If WriteToIni("SQLUSERNAME=dpos", "SQLUSERNAME", sConfigFile) = False Then
                bReturn = False
                Return bReturn
            End If

            sPW = DecryptString("nzy}CC")
            sPW = EncryptString(sPW)
            If WriteToIni("SQLPASSWORD=" & sPW, "SQLPASSWORD", sConfigFile) = False Then
                bReturn = False
                Return bReturn
            End If

            If WriteToIni(vbCrLf & "[MYSQL SERVER]", "[MYSQL SERVER]", sConfigFile) = False Then
                bReturn = False
                Return bReturn
            End If

            If WriteToIni("MYSQLPORT=3306", "MYSQLPORT", sConfigFile) = False Then
                bReturn = False
                Return bReturn
            End If

            If WriteToIni("MYSQLUSERNAME=root", "MYSQLUSERNAME", sConfigFile) = False Then
                bReturn = False
                Return bReturn
            End If

            sPW = DecryptString(";<=>Jrywo")
            sPW = EncryptString(sPW)
            If WriteToIni("MYSQLPASSWORD=" & sPW, "MYSQLPASSWORD", sConfigFile) = False Then
                bReturn = False
                Return bReturn
            End If

            sPW = DecryptString("nzy}JCC")
            sPW = EncryptString(sPW)
            If WriteToIni("CSVPASSWORD=" & sPW, "CSVPASSWORD", sConfigFile) = False Then
                bReturn = False
                Return bReturn
            End If

            sErrMsg = ""
        Catch ex As Exception
            sErrMsg = "Error on Writing to ToolConfig.ini: " & ex.Message.ToString
            bReturn = False
        End Try

        Return bReturn
    End Function

    Private Function LoadConfigFile(ByRef sErrMsg As String) As Boolean
        Dim bReturn As Boolean = True

        Try
            thisConfig.DatabaseType = GetInfoFromIni("DATABASE-TYPE", sConfigFile, False)
            thisConfig.ServerName = GetInfoFromIni("SERVERNAME", sConfigFile, False)
            thisConfig.DPosIniLoc = GetInfoFromIni("DPOSINILOC", sConfigFile, False)
            thisConfig.MSUser = GetInfoFromIni("SQLUSERNAME", sConfigFile, False)
            thisConfig.MSPass = DecryptString(GetInfoFromIni("SQLPASSWORD", sConfigFile, False))
            thisConfig.MYPort = GetInfoFromIni("MYSQLPORT", sConfigFile, False)
            thisConfig.MYUser = GetInfoFromIni("MYSQLUSERNAME", sConfigFile, False)
            thisConfig.MYPass = DecryptString(GetInfoFromIni("MYSQLPASSWORD", sConfigFile, False))
            thisConfig.MYCSVPass = DecryptString(GetInfoFromIni("CSVPASSWORD", sConfigFile, False))
        Catch ex As Exception
            sErrMsg = ex.Message.ToString
            Return bReturn
        End Try

        Return bReturn
    End Function

    Private Function FillConfigFields() As Boolean
        Dim bReturn As Boolean = True
        Try
            Me.tgOptDBType.Checked = myCBool(thisConfig.DatabaseType)
            Me.txtOptServerName.Text = thisConfig.ServerName
            Me.txtOptDPosIni.Text = thisConfig.DPosIniLoc
            Me.txtOptMSUser.Text = thisConfig.MSUser
            Me.txtOptMSPass.Text = thisConfig.MSPass
            Me.txtOptMYPort.Text = thisConfig.MYPort
            Me.txtOptMYUser.Text = thisConfig.MYUser
            Me.txtOptMYPass.Text = thisConfig.MYPass
            Me.txtOptMYCSVPass.Text = thisConfig.MYCSVPass
        Catch ex As Exception
            bReturn = False
        End Try

        Return bReturn
    End Function

    Private Function LoadInformation(ByRef sErrMsg As String) As Boolean
        Dim bReturn As Boolean = True

        Try
            thisInfo.DPosVersion = GetDPosVersion()

            'check if Dpos.ini Exist
            If myFileExist(thisConfig.DPosIniLoc) Then
                Dim sThisDBType As String = GetInfoFromIni("DATABASE-TYPE", thisConfig.DPosIniLoc, False)
                If sThisDBType = "" Then
                    thisInfo.DPosIniDBType = "0"
                    bReturn = False
                    sErrMsg = "DATABASE-TYPE property was not found on Dpos.ini. Please check file or Dpos.ini location from Configurations"
                Else
                    thisInfo.DPosIniDBType = sThisDBType
                End If
            Else
                thisInfo.DPosIniDBType = "0"
                bReturn = False
                sErrMsg = "DPos.ini does not exist check Dpos.ini location from Configurations"
            End If

            thisInfo.DBVersion = GetSetting("Version")
            thisInfo.DocketHeading1 = GetSetting("DocketHeading1")
            thisInfo.EnableCloud = GetSetting("EnableCloud")
            thisInfo.ClientID = GetSetting("ClientID")
            thisInfo.CloudURL = GetSetting("CloudURL")
        Catch ex As Exception
            sErrMsg = ex.Message.ToString
            bReturn = False
        End Try

        Return bReturn
    End Function

    Private Function FillInfoFields(ByRef sErrMsg As String) As Boolean
        Dim bReturn As Boolean = True
        Try
            Me.txtDposVersion.Text = thisInfo.DPosVersion
            Me.txtDBVersion.Text = thisInfo.DBVersion
            Me.txtDocket.Text = thisInfo.DocketHeading1
            Me.txtEnabledCloud.Text = thisInfo.EnableCloud
            Me.txtClient.Text = thisInfo.ClientID
            Me.txtCloudUrl.Text = thisInfo.CloudURL
            Me.tgInfoDPosDBType.Checked = myCBool(thisInfo.DPosIniDBType)
        Catch ex As Exception
            sErrMsg = ex.Message.ToString
            bReturn = False
        End Try

        Return bReturn
    End Function

    Private Function GetDPosVersion() As String
        Dim sReturn As String = "Not Installed"

        Try
            If isThisSoftwareInstalled("DPos", True) Then
                sReturn = GetSoftwareInfoByDisplayName("DPos", "DisplayVersion", "SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall", RegistryView.Default, True)
                If sReturn <> "" Then
                    Return sReturn
                Else
                    sReturn = GetSoftwareInfoByDisplayName("DPos", "DisplayVersion", "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", RegistryView.Registry64, True)
                End If
            End If
        Catch ex As Exception

        End Try

        Return sReturn
    End Function
#End Region

#Region "Information"
    Private Sub btnInfoEdit_Click(sender As Object, e As EventArgs) Handles btnInfoEdit.Click
        If Me.btnInfoEdit.Text = "Edit" Then
            SwitchInfoUI(True, "Save", True, myCInt(thisInfo.DPosIniDBType), Me.DotNetBarTabcontrol1.SelectedIndex, False)
        Else
            Try
                If myFileExist(thisConfig.DPosIniLoc) Then
                    If thisInfo.DPosIniDBType <> myCInt(Me.tgInfoDPosDBType.Checked) Then WriteToIni("DATABASE-TYPE=" & myBooltoInt(myCStr(Me.tgInfoDPosDBType.Checked)), "DATABASE-TYPE", thisConfig.DPosIniLoc)
                Else
                    MessageBox.Show(Me, "DPos.ini not found or your installed DPos does not have DPos.ini", "Please check Configurations")
                End If

                Dim sError As String = ""
                myAppIni(sError, False)

                SwitchInfoUI(False, "Edit", False, myCInt(thisInfo.DPosIniDBType), Me.DotNetBarTabcontrol1.SelectedIndex, True)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnInfoCancel_Click(sender As Object, e As EventArgs) Handles btnInfoCancel.Click
        SwitchInfoUI(False, "Edit", False, myCInt(thisInfo.DPosIniDBType), Me.DotNetBarTabcontrol1.SelectedIndex, True)
    End Sub

    Private Sub SwitchInfoUI(ByVal bBtnIOCancelV As Boolean, ByVal sBtnIOEditText As String, ByVal bBtnIODPosDB As Boolean, ByVal iDPosIniDBType As Integer, ByVal iTabIndex As Integer, ByVal bbChangeTab As Boolean)
        Me.btnInfoCancel.Visible = bBtnIOCancelV
        Me.btnInfoEdit.Text = sBtnIOEditText
        Me.tgInfoDPosDBType.Enabled = bBtnIODPosDB
        Me.tgInfoDPosDBType.CheckState = iDPosIniDBType
        sThisTabIndex = iTabIndex
        bChangeTab = bbChangeTab
    End Sub
#End Region

#Region "Configurations"
    Private Sub btnConfigTestMS_Click(sender As Object, e As EventArgs) Handles btnConfigTestMS.Click
        TestConnection(True)
    End Sub

    Private Sub btnConfigSave_Click(sender As Object, e As EventArgs) Handles btnConfigSave.Click
        Dim sErrorMsg As String = ""

        If ConfigValidation(sErrorMsg) = False Then
            MessageBox.Show(sErrorMsg)
            sErrorMsg = ""
            myAppIni(sErrorMsg, False)
            sErrorMsg = ""
            Exit Sub
        End If

        Try
            If thisConfig.DatabaseType <> myCInt(Me.tgOptDBType.Checked) Then WriteToIni("DATABASE-TYPE=" & myBooltoInt(myCStr(Me.tgOptDBType.Checked)), "DATABASE-TYPE", sConfigFile)
            If thisConfig.ServerName <> Me.txtOptServerName.Text Then WriteToIni("SERVERNAME=" & Me.txtOptServerName.Text, "SERVERNAME", sConfigFile)
            If thisConfig.DPosIniLoc <> Me.txtOptDPosIni.Text Then WriteToIni("DPOSINILOC=" & Me.txtOptDPosIni.Text, "DPOSINILOC", sConfigFile)
            If thisConfig.MSUser <> Me.txtOptMSUser.Text Then WriteToIni("SQLUSERNAME=" & Me.txtOptMSUser.Text, "SQLUSERNAME", sConfigFile)
            If thisConfig.MSPass <> Me.txtOptMSPass.Text Then WriteToIni("SQLPASSWORD=" & EncryptString(Me.txtOptMSPass.Text), "SQLPASSWORD", sConfigFile)
            If thisConfig.MYPort <> Me.txtOptMYPort.Text Then WriteToIni("MYSQLPORT=" & Me.txtOptMYPort.Text, "MYSQLPORT", sConfigFile)
            If thisConfig.MYUser <> Me.txtOptMYUser.Text Then WriteToIni("MYSQLUSERNAME=" & Me.txtOptMYUser.Text, "MYSQLUSERNAME", sConfigFile)
            If thisConfig.MYPass <> Me.txtOptMYPass.Text Then WriteToIni("MYSQLPASSWORD=" & EncryptString(Me.txtOptMYPass.Text), "MYSQLPASSWORD", sConfigFile)
            If thisConfig.MYCSVPass <> Me.txtOptMYCSVPass.Text Then WriteToIni("CSVPASSWORD=" & EncryptString(Me.txtOptMYCSVPass.Text), "CSVPASSWORD", sConfigFile)
        Catch ex As Exception

        End Try

        myAppIni(sErrorMsg, False)
    End Sub

    Private Function ConfigValidation(ByRef sErrMsg As String) As Boolean
        Dim bReturn As Boolean = True

        Try
            If myFileExist(Me.txtOptDPosIni.Text) = False Then
                sErrMsg = "DPos.ini file does not exist. Please check"
                bReturn = False
                Return bReturn
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            bReturn = False
        End Try

        Return bReturn
    End Function

    Private Function StoreThisConfig(ByVal clsThisConfig As clsConfig) As clsConfig
        Dim thisCLS As New clsConfig

        Try
            thisCLS.DatabaseType = clsThisConfig.DatabaseType
            thisCLS.ServerName = clsThisConfig.ServerName
            thisCLS.DPosIniLoc = clsThisConfig.DPosIniLoc
            thisCLS.MSUser = clsThisConfig.MSUser
            thisCLS.MSPass = clsThisConfig.MSPass
            thisCLS.MYPort = clsThisConfig.MYPort
            thisCLS.MYUser = clsThisConfig.MYUser
            thisCLS.MYPass = clsThisConfig.MYPass
            thisCLS.MYCSVPass = clsThisConfig.MYCSVPass
        Catch ex As Exception

        End Try

        Return thisCLS
    End Function

    Private Function TestConnection(ByVal bPrompt As Boolean) As Boolean
        Dim bReturn As Boolean = True
        Dim thisOGClsSetting As New clsConfig
        Dim MSCON As New SqlConnection
        Dim MYCON As New MySqlConnection
        Dim sConStatus As String = ""

        Try
            thisOGClsSetting = StoreThisConfig(thisConfig)

            thisConfig.DatabaseType = myBooltoInt(Me.tgOptDBType.Checked)
            thisConfig.ServerName = Me.txtOptServerName.Text
            thisConfig.MSUser = Me.txtOptMSUser.Text
            thisConfig.MSPass = Me.txtOptMSPass.Text
            thisConfig.MYUser = Me.txtOptMYUser.Text
            thisConfig.MYPass = Me.txtOptMYPass.Text

            If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
                MSCON.ConnectionString = GetConnectionString("")
                MyDBOpen(MSCON)

                If MSCON.State = ConnectionState.Open Then
                    sConStatus = "PASSED"
                    MSCON.Close()
                Else
                    sConStatus = "FAILED"
                End If
            Else
                MYCON.ConnectionString = GetConnectionString("")
                MyDBOpen(MYCON)

                If MYCON.State = ConnectionState.Open Then
                    sConStatus = "PASSED"
                    MYCON.Close()
                Else
                    sConStatus = "FAILED"
                End If
            End If

            If bPrompt Then
                MessageBox.Show(Me, "Database-Type: " & myBooltoDBType(thisConfig.DatabaseType) & vbCrLf & "Status: " & sConStatus, "Test Connection")
            End If
        Catch ex As Exception
            If bPrompt Then
                MessageBox.Show(ex.Message.ToString)
            End If
            bReturn = False
        Finally
            thisConfig = thisOGClsSetting
        End Try

        Return bReturn
    End Function
#End Region

#Region "Backup"

    Private Sub btnBkpOK_Click(sender As Object, e As EventArgs) Handles btnBkpOK.Click
        Dim arrDB As New ArrayList
        Dim arrFilesToZip As New Chilkat.StringArray
        Dim zipDataFile As String = ""
        Dim zipProgFile As String = ""

        Me.dgLogs.Rows.Clear()

        If Me.chkCopyBackup.Checked Then
            If myDirExist(Me.txtBackupFolder.Text) = False Then
                MessageBox.Show(Me, "Copy Backup File not found", "Backup")
                Exit Sub
            End If
        End If

        If Me.chkBackupData.Checked Then
            arrDB.Clear()
            If Me.chkBkpDeliverit.Checked Then arrDB.Add("DeliveritSQL")
            If Me.chkBkpStreets.Checked Then arrDB.Add("StreetsSQL")
            If Me.chkBkpTimeClock.Checked Then arrDB.Add("TimeClockSQL")
            If Me.chkBkpStock.Checked Then arrDB.Add("StockSQL")
            If Me.chkBkpDposSys.Checked Then arrDB.Add("DPosSysSQL")
        End If

        If arrDB.Count = 0 Then
            MessageBox.Show(Me, "No Database selected", "Backup")
            Exit Sub
        End If

        Dim sErr As String = ""
        If TestConnection(False) = False Then
            MessageBox.Show(Me, "Database connection failed. Please check configuration", "Backup")
            Exit Sub
        End If

        Dim myLogs As New FileInfo(sCSVRestoreLogsFile)
        Dim mybkLog As String = myLogs.DirectoryName & "\CSVLogsBak_" & Date.Today.Year.ToString & Date.Today.Month.ToString.PadLeft(2, "0") & Date.Today.Day.ToString.PadLeft(2, "0")
        Dim myLogsSize As Long = myLogs.Length

        If File.Exists(sCSVRestoreLogsFile) Then
            If myLogsSize > (1024 * 1024) Then
                Dim int As Integer = 0
                While File.Exists(mybkLog)
                    If int = 0 Then
                        mybkLog = myLogs.DirectoryName & "\CSVLogsBak_" & Date.Today.Year.ToString & Date.Today.Month.ToString.PadLeft(2, "0") & Date.Today.Day.ToString.PadLeft(2, "0")
                    Else
                        mybkLog = myLogs.DirectoryName & "\CSVLogsBak_" & Date.Today.Year.ToString & Date.Today.Month.ToString.PadLeft(2, "0") & Date.Today.Day.ToString.PadLeft(2, "0") & "-" & myCStr(int)
                    End If
                    int += 1
                End While
                mybkLog &= ".txt"

                System.IO.File.Copy(sCSVRestoreLogsFile, mybkLog)
                System.IO.File.Delete(sCSVRestoreLogsFile)

                CreateIni(sCSVRestoreLogsFile)
            End If
        End If

        Application.DoEvents()
        sPrevTabIndex = sThisTabIndex
        sThisTabIndex = 3
        Me.DotNetBarTabcontrol1.SelectTab(sThisTabIndex)
        bChangeTab = False

        WritetoLog("Backup has been started", "", Me.dgLogs)
        LogDataImport("=== Backup/Restore Session ===" & vbCrLf & "Action: BACKUP" & vbCrLf & "Database-Type: " & myBooltoDBType(thisConfig.DatabaseType) & vbCrLf & "Computer Name: " & thisConfig.ServerName & vbCrLf & "Date/Time " & DateTime.Now.ToString & vbCrLf & vbCrLf & "Logs:" & vbCrLf & "Backup has been started")

        WritetoLog("Disabling triggers...", "", Me.dgLogs)
        If Triggers(False) Then
            'failed
            MessageBox.Show(Me, "Failed to disable Triggers", "Backup")
            LogDataImport("Disabling triggers...FAILED")
            ReWritetoLog("Disabling triggers", "FAILED", Me.dgLogs)
        Else
            LogDataImport("Disabling triggers...SUCCESS")
            ReWritetoLog("Disabling triggers", "SUCCESS", Me.dgLogs)
        End If

        WritetoLog("Deleting backup file residues", "", Me.dgLogs)
        LogDataImport("Deleting backup file residues")
        DeleteDefaultBackups()

        WritetoLog("", "", Me.dgLogs)
        LogDataImport(vbCrLf & "Backup Databases")
        WritetoLog("Backup Databases", "", Me.dgLogs)
        For Each thisDB As String In arrDB
            Dim sError As String = ""
            If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
                Dim sAppend As String
                sAppend = BackupDatabase(thisDB, sError)
                If sError = "" Then
                    arrFilesToZip.Append(sAppend)
                End If
            Else
                BackupDatabaseMySQL(thisDB, arrFilesToZip, sError)
            End If
        Next

        WritetoLog("", "", Me.dgLogs)
        WritetoLog("Enabling triggers...", "", Me.dgLogs)
        If Triggers(True) Then
            'failed
            MessageBox.Show(Me, "Failed to disable Triggers", "Backup")
            LogDataImport(vbCrLf & "Enabling triggers...FAILED")
            ReWritetoLog("Enabling triggers", "FAILED", Me.dgLogs)
        Else
            LogDataImport(vbCrLf & "Enabling triggers...SUCCESS")
            ReWritetoLog("Enabling triggers", "SUCCESS", Me.dgLogs)
        End If

        If arrFilesToZip.Count <> 0 Then
            WritetoLog("Compressing Restore File...", "", Me.dgLogs)
            zipDataFile = CompressFiles("Data", arrFilesToZip)
            If zipDataFile = "" Then
                LogDataImport("Compressing Restore File...FAILED")
                LogDataImport(vbCrLf & vbCrLf & "=== Backup/Restore done ===" & vbCrLf & vbCrLf & vbCrLf)
                ReWritetoLog("Failed to Compress Restore File", "FAILED", Me.dgLogs)
                MessageBox.Show(Me, "Failed to Compress Restore File", "Backup")
                Me.btnLogsBack.Visible = True
                Exit Sub
            Else
                LogDataImport("Compressing Restore File...SUCCESS")
                ReWritetoLog("Compressing Restore File", "SUCCESS", Me.dgLogs)
                MessageBox.Show(Me, "Database backup finished OK", "Backup")
            End If

            If Me.chkBackupProgram.Checked Then
                arrFilesToZip.Clear()
                For Each s As String In My.Computer.FileSystem.GetFiles(Environment.CurrentDirectory)
                    arrFilesToZip.Append(s)
                Next

                WritetoLog("Compressing Program File...", "", Me.dgLogs)
                zipProgFile = CompressFiles("Program", arrFilesToZip)
                If zipProgFile = "" Then
                    LogDataImport("Compressing Program File...FAILED")
                    ReWritetoLog("Compressing Program File", "FAILED", Me.dgLogs)
                    MessageBox.Show(Me, "Compressing Backup Program failed", "Backup")
                Else
                    LogDataImport("Compressing Program File...SUCCESS")
                    ReWritetoLog("Compressing Program File", "SUCCESS", Me.dgLogs)
                End If
            End If

            If Me.chkCopyBackup.Checked And txtBackupFolder.Text <> "" Then
                Try
                    If zipDataFile <> "" Then
                        File.Copy(zipDataFile, txtBackupFolder.Text & zipDataFile.Substring(zipDataFile.LastIndexOf("\")), True)
                    End If

                    If zipProgFile <> "" Then
                        File.Copy(zipProgFile, txtBackupFolder.Text & zipProgFile.Substring(zipProgFile.LastIndexOf("\")), True)
                    End If

                    MessageBox.Show(Me, "Copied to " & txtBackupFolder.Text, "Backup")
                Catch ex As Exception
                End Try
            End If

            WritetoLog("", "", Me.dgLogs)
            WritetoLog("", "", Me.dgLogs)
            LogDataImport(vbCrLf & vbCrLf & "=== Backup/Restore done ===" & vbCrLf & vbCrLf & vbCrLf)
            WritetoLog("Backup complete. Click [Back] to return", "", Me.dgLogs)
        End If

        Me.btnLogsBack.Visible = True
    End Sub

    Public Function BackupDatabase(ByVal sType As String, ByRef sErrMsg As String) As String
        Dim sName As String = ""
        Dim bError As Boolean = False
        Application.DoEvents()

        Try
            If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
                sName = dirMSSERVER & "\Backups\"
            Else
                sName = dirMYSQL & "\Backups\"
            End If

            sName &= sType & ".BAK"
            If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
                WritetoLog("Backup Database: " & sType & "...", "", Me.dgLogs)
                bError = ProcessSQL("BACKUP DATABASE " & sType & " TO DISK = '" & sName & "'", sType, 10000, sErrMsg)
                If bError Then
                    ReWritetoLog("Backup Database: " & sType, "FAILED", Me.dgLogs)
                    LogDataImport("Backup Database: " & sType & "... FAILED" & vbCrLf & "Error: " & sErrMsg)
                    WritetoLog(sErrMsg, "", Me.dgLogs)
                    sName = ""
                Else
                    LogDataImport("Backup Database: " & sType & "... SUCCESS")
                    ReWritetoLog("Backup Database: " & sType, "SUCCESS", Me.dgLogs)
                End If
            Else
                Dim constring As String = GetConnectionString(sType)
                constring += ";convertzerodatetime=true;"

                Dim MYCON As New MySqlConnection
                Dim MYCMD As New MySqlCommand
                Dim mb As New MySqlBackup
                Dim bBackupMySQL As Boolean = True

                WritetoLog("Backup " & sType & "...", "", Me.dgLogs)
                Try
                    MYCON.ConnectionString = constring
                    MyDBOpen(MYCON)
                    MYCMD.Connection = MYCON
                    mb.ExportInfo.ExportRows = False
                    mb.Command = MYCMD

                    mb.ExportToFile(sName)

                    MYCMD.Dispose()
                    MYCON.Close()
                Catch ex As Exception
                    sErrMsg = ex.Message.ToString
                    bBackupMySQL = False
                End Try

                If bBackupMySQL Then
                    LogDataImport("Backup DB Structure: " & sType & "... SUCCESS")
                    ReWritetoLog("Backup DB Structure: " & sType, "SUCCESS", Me.dgLogs)

                    Dim arrTableList As ArrayList
                    arrTableList = FillDatabaseStructureMySQL(sType)

                    DeleteDefaultCSVBackups(arrTableList)

                    For Each thisTableInfo As String In arrTableList
                        Dim splitInfo As String()
                        Dim sExportfile As String = ""
                        splitInfo = thisTableInfo.Split(CHAR_DELIM)
                        WritetoLog("Backup Table: " & splitInfo(1).ToString & "...", "", Me.dgLogs)

                        sExportfile = ExportBackupCSVMySQL(splitInfo(0).ToString, splitInfo(1).ToString, sErrMsg)
                        If sExportfile = "" Then
                            LogDataImport("Backup Table:  " & splitInfo(1).ToString & "... FAILED" & vbCrLf & "Error: " & sErrMsg)
                            ReWritetoLog("Backup Table: " & splitInfo(1).ToString & "", "FAILED", Me.dgLogs)
                            WritetoLog(sErrMsg, "", Me.dgLogs)
                        Else
                            LogDataImport("Backup Table:  " & splitInfo(1).ToString & "... SUCCESS")
                            ReWritetoLog("Backup Table: " & splitInfo(1).ToString, "SUCCESS", Me.dgLogs)
                        End If
                    Next
                Else
                    LogDataImport("Backup DB Structure: " & sType & "... FAILED" & vbCrLf & "Error: " & sErrMsg)
                    ReWritetoLog("Backup DB Structure: " & sType, "FAILED", Me.dgLogs)
                End If
            End If
        Catch ex As Exception

        End Try
        Return sName
    End Function

    Public Sub BackupDatabaseMySQL(ByVal sType As String, ByRef sFilesToAdd As Chilkat.StringArray, ByRef sErrMsg As String)
        Dim bReturn As Boolean = True
        Dim sName As String = ""

        Try
            If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
                sName = dirMSSERVER & "\Backups\"
            Else
                sName = dirMYSQL & "\Backups\"
            End If

            sName &= sType & ".BAK"
            Dim constring As String = GetConnectionString(sType)
            constring += ";convertzerodatetime=true;"

            Dim MYCON As New MySqlConnection
            Dim MYCMD As New MySqlCommand
            Dim mb As New MySqlBackup
            Dim bBackupMySQL As Boolean = True

            WritetoLog("Backup DB Structure: " & sType & "...", "", Me.dgLogs)
            Try
                MYCON.ConnectionString = constring
                MyDBOpen(MYCON)
                MYCMD.Connection = MYCON
                mb.ExportInfo.ExportRows = False
                mb.Command = MYCMD

                mb.ExportToFile(sName)

                MYCMD.Dispose()
                MYCON.Close()
            Catch ex As Exception
                sErrMsg = ex.Message.ToString
                bBackupMySQL = False
            End Try

            If bBackupMySQL Then
                sFilesToAdd.Append(sName)
                LogDataImport("Backup DB Structure: " & sType & "... SUCCESS")
                ReWritetoLog("Backup DB Structure: " & sType, "SUCCESS", Me.dgLogs)

                Dim arrTableList As ArrayList
                arrTableList = FillDatabaseStructureMySQL(sType)

                DeleteDefaultCSVBackups(arrTableList)

                For Each thisTableInfo As String In arrTableList
                    Dim splitInfo As String()
                    Dim sExportfile As String = ""

                    splitInfo = thisTableInfo.Split(CHAR_DELIM)
                    WritetoLog("Backup Table: " & splitInfo(1).ToString & "...", "", Me.dgLogs)
                    sExportfile = ExportBackupCSVMySQL(splitInfo(0).ToString, splitInfo(1).ToString, sErrMsg)
                    If sExportfile = "" Then
                        LogDataImport("Backup Table:  " & splitInfo(1).ToString & "... FAILED" & vbCrLf & "Error: " & sErrMsg & vbCrLf)
                        ReWritetoLog("Backup Table: " & splitInfo(1).ToString & "", "FAILED", Me.dgLogs)
                        WritetoLog(sErrMsg, "", Me.dgLogs)
                    Else
                        LogDataImport("Backup Table:  " & splitInfo(1).ToString & "... SUCCESS")
                        ReWritetoLog("Backup Table: " & splitInfo(1).ToString, "SUCCESS", Me.dgLogs)
                        sFilesToAdd.Append(sExportfile.ToString)
                    End If
                Next
            Else
                LogDataImport("Backup DB Structure: " & sType & "... FAILED" & vbCrLf & "Error: " & sErrMsg)
                ReWritetoLog("Backup DB Structure: " & sType, "FAILED", Me.dgLogs)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function FillDatabaseStructureMySQL(ByVal sDatabase As String) As ArrayList

        Dim arrReturn As New ArrayList
        Dim MYCN As New MySqlConnection
        Dim MYCM As New MySqlCommand
        Dim MYDR As MySqlDataReader
        Dim sSQL As String

        Try
            sSQL = "USE sys; " &
                   "SELECT TABLE_SCHEMA, TABLE_NAME " &
                   "FROM INFORMATION_SCHEMA.TABLES " &
                   "WHERE TABLE_SCHEMA='" & sDatabase & "';"

            MYCN.ConnectionString = GetConnectionString("")
            MyDBOpen(MYCN)
            MYCM.Connection = MYCN
            MYCM.CommandText = sSQL
            MYDR = MYCM.ExecuteReader

            Do While MYDR.Read
                arrReturn.Add(MYDR.Item("TABLE_SCHEMA") & CHAR_DELIM & MYDR.Item("TABLE_NAME"))
            Loop

            MYDR.Close()
            MYCN.Close()
        Catch ex As Exception
            arrReturn.Clear()
        End Try

        Return arrReturn
    End Function

    Public Function ExportBackupCSVMySQL(ByVal sDatabase As String, ByVal sTable As String, ByRef sErrMsg As String) As String
        Dim sReturn As String = ""
        Dim sSQL As String
        Dim sPath As String = dirMYSQL & "\Backups\" & sDatabase.ToLower & "_" & sTable.ToLower & ".BAK"
        Dim sString1 As String = Date.Today.Year.ToString & Date.Today.Month.ToString.PadLeft(2, "0") & Date.Today.Day.ToString.PadLeft(2, "0")
        Dim sString2 As String = Date.Today.AddDays(1).ToString
        Dim sDataPath As String
        Dim bError As Boolean = False
        Dim sError As String = ""

        Try
            Dim sString22 As Date = CDate(sString2)
            Dim sMonth As String = sString22.Month.ToString.PadLeft(2, "0")
            Dim sDay As String = sString22.Day.ToString.PadLeft(2, "0")
            Dim sYear As String = sString22.Year.ToString

            sString2 = sYear & sMonth & sDay
            File.WriteAllText(sPath, EncryptString(sString1 & thisConfig.MYCSVPass & sString2) & vbCrLf)

            sDataPath = dirMYSQL & "\Backups\temp_" & sDatabase.ToLower & "_" & sTable.ToLower & ".BAK"
            sDataPath = sDataPath.Replace("\", "\\")

            sSQL = "USE " & sDatabase & ";"
            sSQL &= "SELECT * FROM " & sTable & " "
            sSQL &= "INTO OUTFILE '" & sDataPath & "' "
            sSQL &= "FIELDS TERMINATED BY ',' OPTIONALLY ENCLOSED BY '""' LINES TERMINATED BY '\n'"

            bError = ProcessSQL(sSQL, "", 10000, sError)
            If bError = False Then
                sDataPath = sDataPath.Replace("\\", "\")

                If MergeTextFiles(sPath, sDataPath) = False Then
                    sPath = ""
                    sErrMsg = "Failed to merge table files"
                End If
            Else
                sPath = ""
                sErrMsg = sError
            End If

            sReturn = sPath
        Catch ex As Exception

        End Try

        Return sReturn
    End Function

    Public Sub DeleteDefaultBackups()
        Dim x As Integer
        Dim sDeleteFiles As New ArrayList
        Dim sBAKFile As String

        If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
            sBAKFile = dirMSSERVER & "\Backups\"
        Else
            sBAKFile = dirMYSQL & "\Backups\"
        End If

        sDeleteFiles.Add(sBAKFile & "DeliverITSQL.BAK")
        sDeleteFiles.Add(sBAKFile & "StreetsSQL.BAK")
        sDeleteFiles.Add(sBAKFile & "DPosSysSQL.BAK")
        sDeleteFiles.Add(sBAKFile & "TimeClockSQL.BAK")
        sDeleteFiles.Add(sBAKFile & "StockSQL.BAK")

        For x = 0 To (sDeleteFiles.Count - 1)
            If IO.File.Exists(sDeleteFiles.Item(x)) Then
                IO.File.Delete(sDeleteFiles.Item(x))
            End If
        Next

    End Sub

    Public Sub DeleteDefaultCSVBackups(ByVal arrCSVlist As ArrayList)
        Dim x As Integer
        Dim sDeleteFiles As New ArrayList
        Dim sBAKFile As String

        If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
            sBAKFile = dirMSSERVER & "\Backups\"
        Else
            sBAKFile = dirMYSQL & "\Backups\"
        End If

        For Each thisCSVfile As String In arrCSVlist
            Dim splitInfo As String()
            splitInfo = thisCSVfile.Split(CHAR_DELIM)
            sDeleteFiles.Add(sBAKFile & splitInfo(0).ToString & "_" & splitInfo(1).ToString & ".BAK")
        Next

        For x = 0 To (sDeleteFiles.Count - 1)
            If IO.File.Exists(sDeleteFiles.Item(x)) Then
                IO.File.Delete(sDeleteFiles.Item(x))
            End If
        Next

    End Sub

    Private Sub btnChooseBackupFolder_Click(sender As Object, e As EventArgs) Handles btnChooseBackupFolder.Click
        Dim sFileFolder As String
        sFileFolder = myCStr(thisOpenDir("Choose Backup File Path", thisFileBrowser))
        Me.txtBackupFolder.Text = sFileFolder
    End Sub

    Private Sub chkBackupData_CheckedChanged(sender As Object, e As EventArgs) Handles chkBackupData.CheckedChanged
        BackupSelectionEnabled(Me.chkBackupData.Checked)
    End Sub

    Private Sub chkCopyBackup_CheckedChanged(sender As Object, e As EventArgs) Handles chkCopyBackup.CheckedChanged
        BackupCopyEnabled(Me.chkCopyBackup.Checked)
    End Sub

    Private Function BackupCopyEnabled(ByVal bsSwitch As Boolean) As Boolean
        Dim bReturn As Boolean = True

        Try
            Me.txtBackupFolder.Enabled = bsSwitch
            Me.btnChooseBackupFolder.Enabled = bsSwitch
        Catch ex As Exception
            bReturn = False
        End Try

        Return bReturn
    End Function

    Private Function BackupSelectionEnabled(ByVal bSwitch As Boolean) As Boolean
        Dim bReturn As Boolean = True
        Dim cFontColor As Color

        Try
            If bSwitch Then
                cFontColor = Color.Black
            Else
                cFontColor = Color.Gray
            End If

            Me.chkBkpDeliverit.Enabled = bSwitch
            Me.chkBkpDposSys.Enabled = bSwitch
            Me.chkBkpStock.Enabled = bSwitch
            Me.chkBkpStreets.Enabled = bSwitch
            Me.chkBkpTimeClock.Enabled = bSwitch
        Catch ex As Exception
            bReturn = False
        End Try

        Return bReturn
    End Function


#End Region

#Region "Restore"
    Private Sub btnRstOK_Click(sender As Object, e As EventArgs) Handles btnRstOK.Click
        Dim arrDB As New ArrayList
        Dim arrFDB As New ArrayList
        Dim sExtractFolder As String = ""
        Dim sFileName As String = ""
        Dim bSuccess As Boolean = True
        Dim sError As String = ""

        If MsgBox("WARNING" & vbCrLf & "Please exit DPOS on " & thisConfig.ServerName & " and its workstation before continuing.", vbOKCancel, "IMPORTANT!!!") = MsgBoxResult.Cancel Then
            Exit Sub
        End If

        If TestConnection(False) = False Then
            MessageBox.Show(Me, "Database connection failed. Please check configuration", "Restore")
            Exit Sub
        End If

        Me.dgLogs.Rows.Clear()

        If Me.chkRestoreData.Checked Then
            arrDB.Clear()
            arrFDB.Clear()
            If Me.chkRstDeliverit.Checked Then arrDB.Add("DeliveritSQL")
            If Me.chkRstStreets.Checked Then arrDB.Add("StreetsSQL")
            If Me.chkRstTimeClock.Checked Then arrDB.Add("TimeClockSQL")
            If Me.chkRstStock.Checked Then arrDB.Add("StockSQL")
            If Me.chkRstDPosSys.Checked Then arrDB.Add("DPosSysSQL")
        End If

        If arrDB.Count = 0 Then
            MessageBox.Show(Me, "No Database selected", "Backup")
            Exit Sub
        End If

        If Me.chkRstIsZip.Checked Then
            sExtractFolder = ExtractZipFile(Me.thisOpenFileDia.FileName, "Restore", arrDB)
            If sExtractFolder = "" Then
                Exit Sub
            End If
        Else
            sExtractFolder = Me.thisOpenFileDia.FileName
            Dim i, j As Integer
            i = sExtractFolder.IndexOf(Me.thisOpenFileDia.SafeFileName)
            j = Me.thisOpenFileDia.SafeFileName.Length
            sExtractFolder = sExtractFolder.Remove(i, j)

            If arrDB.Count = 1 Then
                sFileName = Me.thisOpenFileDia.SafeFileName
                Dim iStart, iEnd As Integer
                iStart = sFileName.IndexOf(".")
                iEnd = sFileName.Length - iStart
                sFileName = sFileName.Remove(iStart, iEnd)
                If File.Exists(sExtractFolder & sFileName & ".BAK") = False Then
                    MessageBox.Show("DPos cannot find the file specified: " & sExtractFolder & sFileName & ".BAK")
                    Exit Sub
                End If
            Else
                For k As Integer = 0 To arrDB.Count - 1
                    If File.Exists(sExtractFolder & arrDB.Item(k) & ".BAK") = False Then
                        MessageBox.Show("DPos cannot find the file specified: " & sExtractFolder & arrDB.Item(k) & ".BAK")
                        Exit Sub
                    End If
                Next
            End If
        End If

        Dim myLogs As New FileInfo(sCSVRestoreLogsFile)
        Dim mybkLog As String = myLogs.DirectoryName & "\CSVLogsBak_" & Date.Today.Year.ToString & Date.Today.Month.ToString.PadLeft(2, "0") & Date.Today.Day.ToString.PadLeft(2, "0")
        Dim myLogsSize As Long = myLogs.Length

        If File.Exists(sCSVRestoreLogsFile) Then
            If myLogsSize > (1024 * 1024) Then
                Dim int As Integer = 0
                While File.Exists(mybkLog)
                    If int = 0 Then
                        mybkLog = myLogs.DirectoryName & "\CSVLogsBak_" & Date.Today.Year.ToString & Date.Today.Month.ToString.PadLeft(2, "0") & Date.Today.Day.ToString.PadLeft(2, "0")
                    Else
                        mybkLog = myLogs.DirectoryName & "\CSVLogsBak_" & Date.Today.Year.ToString & Date.Today.Month.ToString.PadLeft(2, "0") & Date.Today.Day.ToString.PadLeft(2, "0") & "-" & myCStr(int)
                    End If
                    int += 1
                End While
                mybkLog &= ".txt"

                System.IO.File.Copy(sCSVRestoreLogsFile, mybkLog)
                System.IO.File.Delete(sCSVRestoreLogsFile)

                CreateIni(sCSVRestoreLogsFile)
            End If
        End If

        Application.DoEvents()
        sPrevTabIndex = sThisTabIndex
        sThisTabIndex = 3
        Me.DotNetBarTabcontrol1.SelectTab(sThisTabIndex)
        bChangeTab = False

        WritetoLog("Restore has been started", "", Me.dgLogs)
        LogDataImport("=== Backup/Restore Session ===" & vbCrLf & "Action: RESTORE" & vbCrLf & "Database-Type: " & myBooltoDBType(thisConfig.DatabaseType) & vbCrLf & "Computer Name: " & thisConfig.ServerName & vbCrLf & "Date/Time " & DateTime.Now.ToString & vbCrLf & vbCrLf & "Logs:" & vbCrLf & "Backup has been started")

        KillKybRunning("DPOSCloudSync")


        For Each thisFile As String In arrDB
            Dim sRestoreMsg As String = ""
            If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
                sRestoreMsg = "Restoring Database: "
            Else
                sRestoreMsg = "Restoring Database Structure: "
            End If

            WritetoLog(sRestoreMsg & thisFile & "...", "", Me.dgLogs)

            bSuccess = RestoreDatabase(thisFile, sExtractFolder, thisFile, sError)
            If bSuccess = False Then
                MessageBox.Show("Error with restore - contact Support" & vbCrLf & thisFile)

                ReWritetoLog(sRestoreMsg & thisFile, "FAILED", Me.dgLogs)
                LogDataImport("Restoring Database Structure: " & thisFile & " - FAILED" & vbCrLf & "Error: " & sError & vbCrLf)

                Exit For
            Else
                ReWritetoLog(sRestoreMsg & thisFile, "SUCCESS", Me.dgLogs)
                LogDataImport("Restoring Database Structure: " & thisFile & " - SUCCESS")
            End If

            If bSuccess AndAlso thisConfig.DatabaseType = eDatabaseType.MYSQL Then
                Dim arrTableList As New ArrayList
                arrTableList = FillDatabaseStructureMySQL(thisFile)
                WritetoLog("Disabling all indexes under " & thisFile & "...", "", Me.dgLogs)
                LogDataImport("Disabling all indexes under " & thisFile & "...")
                ChangeIndexSettingByDatabase(thisFile, False, arrTableList)

                For Each thisTable As String In arrTableList
                    Dim thisCSVFileInfo As String() = thisTable.Split(CHAR_DELIM)

                    Dim sCSVfile As String
                    sCSVfile = thisCSVFileInfo(0).ToString & "_" & thisCSVFileInfo(1).ToString & ".BAK"
                    WritetoLog("Restoring Data: " & sCSVfile & "...", "", Me.dgLogs)

                    If CheckFileIfExistInZip(sCSVfile, thisOpenFileDia.FileName) Then
                        Dim sProcessImportCSV As Boolean
                        Dim bValidate As Boolean = True

                        sProcessImportCSV = ImportCSVMySQL(thisCSVFileInfo(0).ToString, thisCSVFileInfo(1).ToString, sExtractFolder & sCSVfile, bValidate)
                        If sProcessImportCSV = False Then
                            If bValidate Then
                                MessageBox.Show("Error with CSV restore - contact Support" & vbCrLf & sFileName.ToLower & "(" & sCSVfile & ")")

                                If MsgBox("Table " & thisCSVFileInfo(1).ToString & " has encountered an error during restore. " & vbCrLf & "Do you still want to proceed or stop restoring?", vbYesNo, "") = DialogResult.Yes Then
                                    ReWritetoLog("Restoring Data: " & sCSVfile, "SKIPPED", Me.dgLogs)
                                    arrFDB.Add(thisCSVFileInfo(1).ToString)
                                Else
                                    ReWritetoLog("Restoring Data: " & sCSVfile, "FAILED", Me.dgLogs)
                                    WritetoLog("DPos Restore has been aborted", "", Me.dgLogs)
                                    arrFDB.Add(thisCSVFileInfo(1).ToString)
                                    bError = True

                                    Exit For
                                End If
                            Else
                                MessageBox.Show("Error with CSV restore - contact Support" & vbCrLf & sFileName.ToLower & "(" & sCSVfile & ")")

                                ReWritetoLog("Restoring Data: " & sCSVfile, "SKIPPED", Me.dgLogs)
                                WritetoLog("The data file did not passed the validation", "", Me.dgLogs)

                                LogDataImport("Restoring Data: " & sCSVfile & "...SKIPPED")
                                LogDataImportDetails(thisCSVFileInfo(1).ToString.ToLower, thisCSVFileInfo(0).ToLower.ToLower, "The data file did not passed the validation", "Not Provided")
                            End If
                        Else
                            ReWritetoLog("Restoring Data: " & sCSVfile, "SUCCESS", Me.dgLogs)
                            LogDataImport("Restoring Data: " & sCSVfile & " - SUCCESS")
                        End If
                    Else
                        MessageBox.Show("DPos cannot find the file specified: " & sCSVfile)
                        ReWritetoLog("Restoring Data: " & sCSVfile, "SKIPPED", Me.dgLogs)

                        arrFDB.Add(thisCSVFileInfo(1).ToString)
                        LogDataImport("Restoring Data: " & sCSVfile & " - SKIPPED")
                        LogDataImportDetails(thisCSVFileInfo(1).ToString, thisCSVFileInfo(0).ToString, "DPos cannot find the file specified: " & sCSVfile, "Not Provided")
                    End If
                Next

                ChangeIndexSettingByDatabase(thisFile, True)
            End If
        Next

        If thisConfig.DatabaseType = eDatabaseType.MYSQL Then
            If arrFDB.Count <> 0 Then
                WritetoLog("", "", Me.dgLogs)
                WritetoLog("Skipped Table(s):", "", Me.dgLogs)
                LogDataImport(vbCrLf & "Skipped Table(s):")
                For Each thisF In arrFDB
                    WritetoLog(thisF, "", Me.dgLogs)
                    LogDataImport(thisF.ToString)
                Next
            End If
        End If

        If bSuccess Then
            If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
                SqlConnection.ClearAllPools()
            Else
                MySqlConnection.ClearAllPools()
            End If

            Triggers(True)
        End If

        WritetoLog("", "", Me.dgLogs)
        WritetoLog("", "", Me.dgLogs)
        If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
            LogDataImport(vbCrLf & vbCrLf & "=== Backup/Restore done ===" & vbCrLf & vbCrLf & vbCrLf)
        Else
            If arrFDB.Count <> 0 Then
                LogDataImport(vbCrLf & vbCrLf & "=== Backup/Restore done with restore error(s) ===" & vbCrLf & vbCrLf & vbCrLf)
            Else
                LogDataImport(vbCrLf & vbCrLf & "=== Backup/Restore done w/out restore errors ===" & vbCrLf & vbCrLf & vbCrLf)

            End If
        End If

        WritetoLog("Restore complete. Click [Back] to return", "", Me.dgLogs)

        Me.btnLogsBack.Visible = True
    End Sub

    Public Function ImportCSVMySQL(ByVal sDatabase As String, ByVal sTable As String, ByVal sCSVPath As String, ByRef bValidation As Boolean) As Boolean
        Dim bReturn As Boolean = False
        Dim sSQL As String
        Dim sPath As String = sCSVPath

        Try
            Dim myFileInfo As New FileInfo(sCSVPath)
            Dim myFileSize As Long = myFileInfo.Length
            Dim iTimeout As Integer = 0

            If VerifyEncryptedTextonCSV(sPath, thisConfig.MYCSVPass) Then
                bValidation = True

                'calculate timeout based on filesize
                If myCInt(myFileSize) > 10000000 Then
                    iTimeout = myCInt(myFileSize) / 10000000
                    iTimeout *= 100

                    If iTimeout > 900 Then
                        iTimeout = 900
                    End If
                Else
                    iTimeout = 100
                End If

                sPath = sPath.Replace("\", "\\")
                'sSQL = "SET autocommit=0;"
                sSQL = "SET unique_checks=0;"
                sSQL &= "SET foreign_key_checks=0;"
                sSQL &= "LOAD DATA LOCAL INFILE '" & sPath & "' "
                sSQL &= "INTO TABLE " & sDatabase.ToLower & "." & sTable.ToLower & " "
                sSQL &= "FIELDS TERMINATED BY ',' OPTIONALLY ENCLOSED BY '""' LINES TERMINATED BY '\r\n' "
                sSQL &= "IGNORE 1 LINES;"
                sSQL &= "SET foreign_key_checks=1;"
                sSQL &= "SET unique_checks=1;"
                'sSQL &= "SET autocommit=1;"
                'sSQL &= "commit;"

                'ProcessSQL using the root credentials
                Dim bErr As Boolean = False
                Dim sErr As String = ""
                bErr = ProcessSQL2(sSQL, "", iTimeout, sErr)
                If bErr = False Then
                    bReturn = True
                Else
                    'log
                    LogDataImport("Restoring Data: " & sTable.ToLower & "...FAILED")
                    LogDataImportDetails(sTable.ToLower, sDatabase.ToLower, sErr, sSQL)
                End If
            Else
                bValidation = False
            End If
        Catch ex As Exception

        End Try

        Return bReturn
    End Function

    Public Function VerifyEncryptedTextonCSV(ByVal sFile As String, ByVal sPassword As String) As Boolean
        Dim bReturn As Boolean = False
        Dim sDecryptedText As String = ""

        Try
            Dim thisline As String = File.ReadLines(sFile).First()

            sDecryptedText = DPosSecurity.modSecurity.DecryptString(thisline)

            Dim sTrimmed As String
            sTrimmed = sDecryptedText.Substring(8, Len(sDecryptedText) - 16)

            'password validation
            If sPassword = sTrimmed Then
                bReturn = True
            End If

        Catch ex As Exception

        End Try

        Return bReturn
    End Function

    Public Function ChangeIndexSettingByDatabase(ByVal sDB As String, ByVal bSetting As Boolean) As Boolean
        Dim bReturn As Boolean = False

        If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
            bReturn = True
        Else
            arrTables = FillDatabaseStructureMySQL(sDB)

            For Each thisTable As String In arrTables
                Dim thisTableInfo As String()
                thisTableInfo = thisTable.Split(CHAR_DELIM)
                If thisTableInfo(1) <> "audit" Then
                    If ChangeIndexSetting(sDB, thisTableInfo(1), bSetting) = True Then
                        bReturn = True
                    Else
                        Exit For
                    End If
                Else
                    bReturn = True
                    Exit For
                End If
            Next
        End If

        Return bReturn
    End Function

    Public Function ChangeIndexSettingByDatabase(ByVal sDB As String, ByVal bSetting As Boolean, ByVal arrTables As ArrayList) As Boolean
        Dim bReturn As Boolean = False

        If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
            bReturn = True
        Else
            For Each thisTable As String In arrTables
                Dim thisTableInfo As String()
                thisTableInfo = thisTable.Split(CHAR_DELIM)
                If thisTableInfo(1) <> "audit" Then
                    If ChangeIndexSetting(sDB, thisTableInfo(1), bSetting) = True Then
                        bReturn = True
                    Else
                        Exit For
                    End If
                Else
                    bReturn = True
                    Exit For
                End If
            Next
        End If

        Return bReturn
    End Function

    Public Function ChangeIndexSetting(ByVal sDB As String, ByVal sTable As String, ByVal bSetting As Boolean) As Boolean
        Dim bReturn As Boolean = True
        Dim sSQL As String
        Dim bErr As Boolean = False
        Dim sErr As String = ""

        If bSetting = True Then
            sSQL = "ALTER TABLE `" & sDB & "`.`" & sTable & "` ENABLE KEYS"
        Else
            sSQL = "ALTER TABLE `" & sDB & "`.`" & sTable & "` DISABLE KEYS"
        End If

        bErr = ProcessSQL(sSQL, sDB, 10000, sErr)

        If bErr Then
            bReturn = False
        End If

        Return bReturn
    End Function

    Public Function RestoreDatabase(ByVal sType As String, ByVal sPath As String, ByVal sFileName As String, ByRef sError As String) As Boolean
        Dim bError As Boolean = False

        Try
            If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
                'close any open connections for this database
                bError = ProcessSQL("ALTER DATABASE " & sType & " SET SINGLE_USER WITH ROLLBACK IMMEDIATE", "master", 10000, sError)
                If bError = False Then
                    'full restore and replace
                    'i = ProcessSQL("RESTORE DATABASE " & sType & " FROM DISK = '" & sfile & "' WITH REPLACE, KEEP_REPLICATION, RECOVERY", "master")
                    bError = ProcessSQL("RESTORE DATABASE [" & sType & "] FROM  DISK = N'" & sPath & sFileName & ".BAK' WITH  FILE = 1,  KEEP_REPLICATION,  NOUNLOAD,  REPLACE", "master", 10000, sError)

                    If bError Then
                        ProcessSQL("ALTER DATABASE " & sType & " SET MULTI_USER", "master", 10000, sError)
                    End If
                End If

                If bError = False Then
                    'put it back to multi-user
                    bError = ProcessSQL("ALTER DATABASE " & sType & " SET MULTI_USER", "master", 10000, sError)
                End If
            Else
                Dim constring As String = GetConnectionString(sType)
                ' Important Additional Connection Options
                'constring += ";charset=utf8;convertzerodatetime=true;"
                constring += ";convertzerodatetime=true;"

                Dim MYCON As New MySqlConnection
                Dim MYCMD As New MySqlCommand
                Dim MYBAK As New MySqlBackup

                'for crm3269 - bug015
                'Packets larger than max_allowed_packet are not allowed.
                'adjustments on max_allowed_packet
                MYCON.ConnectionString = constring
                MyDBOpen(MYCON)
                MYCMD.Connection = MYCON
                MYCMD.CommandText = "SET GLOBAL max_allowed_packet=1024*1024*1024;"
                MYCMD.ExecuteNonQuery()
                MYCMD.Dispose()
                MYCON.Close()

                MYCON.ConnectionString = constring
                MyDBOpen(MYCON)
                MYCMD.Connection = MYCON
                MYCMD.CommandTimeout = 180
                MYBAK.Command = MYCMD
                MYBAK.ImportFromFile(sPath & sFileName & ".BAK")

                MYCMD.Dispose()
                MYCON.Close()
            End If

            If bError Then
                'there was an error with the restore
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub chkRestoreData_CheckedChanged(sender As Object, e As EventArgs) Handles chkRestoreData.CheckedChanged
        RestoreSelectionEnabled(Me.chkRestoreData.Checked)
    End Sub

    Private Sub btnChooseRstFolder_Click(sender As Object, e As EventArgs) Handles btnChooseRstFolder.Click
        Dim sFileFolder As String

        If Me.chkRstIsZip.Checked Then
            sFileFolder = myCStr(thisOpenFile("Choose Restore File Path", txtRstFolder.Text, "*.ZIP", thisOpenFileDia))
        Else
            sFileFolder = myCStr(thisOpenFile("Choose Restore File Path", txtRstFolder.Text, "*.BAK", thisOpenFileDia))
        End If
        Me.txtRstFolder.Text = sFileFolder
    End Sub

    Private Function RestoreSelectionEnabled(ByVal bSwitch As Boolean) As Boolean
        Dim bReturn As Boolean = True
        Dim cFontColor As Color

        Try
            If bSwitch Then
                cFontColor = Color.Black
            Else
                cFontColor = Color.Gray
            End If

            Me.chkRstDeliverit.Enabled = bSwitch
            Me.chkRstDPosSys.Enabled = bSwitch
            Me.chkRstStock.Enabled = bSwitch
            Me.chkRstStreets.Enabled = bSwitch
            Me.chkRstTimeClock.Enabled = bSwitch
        Catch ex As Exception
            bReturn = False
        End Try

        Return bReturn
    End Function
#End Region

#Region "DPos Settings"
    Private Sub btnSettingsEdit_Click(sender As Object, e As EventArgs) Handles btnSettingsEdit.Click
        SwitchSettingFields(True)
    End Sub



    Private Sub btnSettingsCancel_Click(sender As Object, e As EventArgs) Handles btnSettingsCancel.Click
        SwitchSettingFields(False)
    End Sub

    Private Sub cmbSettingSetting_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSettingSetting.SelectedIndexChanged
        PopulateSettingFields()
    End Sub

    Private Sub cmbSettingSetting_TextChanged(sender As Object, e As EventArgs) Handles cmbSettingSetting.TextChanged
        PopulateSettingFields()
    End Sub

    Private Sub pbCopy_Click(sender As Object, e As EventArgs) Handles pbCopy.Click
        If Me.txtSettingDefaultValue.Text <> "" Then
            Me.txtSettingSettingValue.Text = Me.txtSettingDefaultValue.Text
        End If
    End Sub

    Private Sub pbCopy_MouseHover(sender As Object, e As EventArgs) Handles pbCopy.MouseHover
        Me.pbCopy.BackgroundImage = My.Resources.ToolCopy_h
    End Sub

    Private Sub pbCopy_MouseLeave(sender As Object, e As EventArgs) Handles pbCopy.MouseLeave
        Me.pbCopy.BackgroundImage = My.Resources.ToolCopy
    End Sub

    Private Function SwitchSettingFields(ByVal bSwitch As Boolean) As Boolean
        Dim bReturn As Boolean = True

        Try
            If bSwitch Then
                Me.txtSettingSettingValue.Focus()
            Else
                Me.cmbSettingSetting.Focus()
            End If
            Me.txtSettingSettingValue.Enabled = bSwitch
            Me.pbCopy.Visible = bSwitch
            Me.btnSettingsSave.Enabled = bSwitch
            Me.btnSettingsCancel.Enabled = bSwitch
            If bSwitch Then
                Me.btnSettingsEdit.Enabled = False
                sThisTabIndex = sThisTabIndex
                bChangeTab = False
            Else
                Me.btnSettingsEdit.Enabled = True
                sThisTabIndex = sThisTabIndex
                bChangeTab = True
            End If
        Catch ex As Exception
            bReturn = False
        End Try

        Return bReturn
    End Function

    Private Function FillMeSettingCombobox() As Boolean
        Dim bReturn As Boolean = True

        Try
            Me.cmbSettingSetting.Items.Clear()

            Dim thisSetting As String
            For Each thisSetting In arSettings
                Me.cmbSettingSetting.Items.Add(GetField(thisSetting, CHAR_DELIM, 1))
            Next

            Me.cmbSettingSetting.SelectedIndex = 0
        Catch ex As Exception

        End Try

        Return bReturn
    End Function

    Private Sub btnSettingsSave_Click(sender As Object, e As EventArgs) Handles btnSettingsSave.Click
        Dim sSQL As String

        If Me.lblSettingSetting.Text <> "" Then
            Dim bthisError As Boolean
            Dim sErrorMsg As String = ""
            sSQL = "UPDATE tblSettings SET SettingValue='" & Me.txtSettingSettingValue.Text & "' WHERE Setting='" & Me.lblSettingSetting.Text & "'"
            ProcessSQL(sSQL, "DeliveritSQL", 10000, bthisError)

            GetAllSettings(sErrorMsg)
        End If

        SwitchSettingFields(False)
    End Sub

    Private Function PopulateSettingFields() As Boolean
        Dim bReturn As Boolean = True

        Try
            Dim sSetting As String = ""
            ClearSettingFields()
            If Me.cmbSettingSetting.Text <> "" Then
                sSetting = GetSettingFromDatabase(Me.cmbSettingSetting.Text)
                'myDRString(MSDR, "Setting")
                'myDRString(MSDR, "DefaultValue")
                'myDRString(MSDR, "Comments")
                'myDRString(MSDR, "Category")
                'myDRString(MSDR, "SettingValue")
                Me.lblSettingSetting.Text = GetField(sSetting, CHAR_DELIM, 1)
                Me.txtSettingSettingValue.Text = GetField(sSetting, CHAR_DELIM, 5)
                Me.txtSettingDefaultValue.Text = GetField(sSetting, CHAR_DELIM, 2)
                Me.txtSettingCategory.Text = GetField(sSetting, CHAR_DELIM, 4)
                Me.txtSettingComment.Text = GetField(sSetting, CHAR_DELIM, 3)
            Else
                ClearSettingFields()
            End If

        Catch ex As Exception

        End Try

        Return bReturn
    End Function

    Private Sub ClearSettingFields()
        Me.lblSettingSetting.Text = ""
        Me.txtSettingSettingValue.Text = ""
        Me.txtSettingDefaultValue.Text = ""
        Me.txtSettingCategory.Text = ""
        Me.txtSettingComment.Text = ""
    End Sub

#End Region

    Private Sub DotNetBarTabcontrol1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DotNetBarTabcontrol1.SelectedIndexChanged
        Dim sError As String = ""
        If bChangeTab = False Then
            If Me.DotNetBarTabcontrol1.SelectedIndex <> sThisTabIndex Then
                sThisTabIndex = sThisTabIndex
                Me.DotNetBarTabcontrol1.SelectTab(sThisTabIndex)
            End If
        Else
            Dim sPrevTab As TabPage = Me.DotNetBarTabcontrol1.TabPages().Item(sThisTabIndex)
            Dim sPrevTabName As String = sPrevTab.Text

            If sPrevTabName = "Configurations" Then
                myAppIni(sError, False)
                Me.tbDatabase.SelectTab(0)
            ElseIf sPrevTabName = "Restore" Then
                myAppIni(sError, False)
            End If

            If Me.DotNetBarTabcontrol1.TabPages().Item(Me.DotNetBarTabcontrol1.SelectedIndex).Text = "DPos Settings" Then
                myAppIni(sError, False)
                FillMeSettingCombobox()
            End If

            sThisTabIndex = Me.DotNetBarTabcontrol1.SelectedIndex
        End If
    End Sub

    Private Sub btnLogsBack_Click(sender As Object, e As EventArgs) Handles btnLogsBack.Click
        If bChangeTab = False Then
            bChangeTab = True
        End If

        sThisTabIndex = sPrevTabIndex
        sPrevTabIndex = Me.DotNetBarTabcontrol1.SelectedIndex

        Me.DotNetBarTabcontrol1.SelectTab(sThisTabIndex)
        Me.btnLogsBack.Visible = False
    End Sub

End Class