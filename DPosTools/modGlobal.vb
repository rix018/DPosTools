Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Module modGlobal
    Public bDemo As Boolean = False

    Public sConfigFile As String
    Public sCSVRestoreLogsFile As String
    Public sCloudURLPresets As String
    Public dirMSSERVER As String = Application.StartupPath & "\Database\MSSERVER"
    Public dirMYSQL As String = Application.StartupPath & "\Database\MYSQL"

    Public thisConfig As New clsConfig
    Public thisInfo As New clsInfo
    Public arSettings As New ArrayList
    Public arCloudPresets As New ArrayList

    Public bChangeTab As Boolean
    Public sThisTabIndex As Integer
    Public sPrevTabIndex As Integer = 0 'For Logs Back

    Public ChilkatMailLicenseKey As String = "ABRYCEMAIL_NVfSRcDJ8K8F"
    Public ChilkatZipLicenseKey As String = "BRYCEJZIP_B7JckLgw7FyG"

    Public Const CHAR_DELIM As Char = "¶"

    Public Enum eDatabaseType As Byte
        MSSERVER = 0
        MYSQL = 1
    End Enum

    Public Function GetAllSettings(ByVal sErrMsg As String) As Boolean
        Dim bOK As Boolean = True

        Try
            arSettings.Clear()

            If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
                Dim MSCON As New SqlClient.SqlConnection
                Dim MSCMD As New SqlClient.SqlCommand
                Dim MSDR As SqlClient.SqlDataReader

                MSCON.ConnectionString = GetConnectionString("DeliveritSQL")
                MyDBOpen(MSCON)
                MSCMD.Connection = MSCON

                MSCMD.CommandText = "SELECT Setting, SettingValue FROM tblSettings ORDER BY Setting"
                MSDR = MyExecuteReader(MSCMD)

                If MSDR.HasRows Then
                    Do While MSDR.Read()
                        arSettings.Add(myDRString(MSDR, "Setting") & "¶" & myDRString(MSDR, "SettingValue"))
                    Loop
                End If

                MSDR.Close()
                MSCMD.Dispose()
                MSCON.Close()
            Else
                Dim MYCON As New MySqlConnection
                Dim MYCMD As New MySqlCommand
                Dim MYDR As MySqlDataReader

                MYCON.ConnectionString = GetConnectionString("DeliveritSQL")
                MyDBOpen(MYCON)
                MYCMD.Connection = MYCON

                MYCMD.CommandText = "SELECT Setting, SettingValue FROM tblSettings ORDER BY Setting"
                MYDR = MyExecuteReader(MYCMD)

                If MYDR.HasRows Then
                    Do While MYDR.Read()
                        arSettings.Add(myDRString(MYDR, "Setting") & "¶" & myDRString(MYDR, "SettingValue"))
                    Loop
                End If

                MYDR.Close()
                MYCMD.Dispose()
                MYCON.Close()
            End If

        Catch ex As Exception
            bOK = False
            sErrMsg = "Failed to load settings: " & ex.Message.ToString
        End Try

        Return bOK
    End Function

    Public Function GetSettingFromDatabase(ByVal sSetting As String, ByVal bLike As Boolean) As String
        Dim sReturn As String = ""

        Try
            If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
                Dim MSCON As New SqlClient.SqlConnection
                Dim MSCMD As New SqlClient.SqlCommand
                Dim MSDR As SqlClient.SqlDataReader

                MSCON.ConnectionString = GetConnectionString("DeliveritSQL")
                MyDBOpen(MSCON)
                MSCMD.Connection = MSCON

                If bLike Then
                    MSCMD.CommandText = "SELECT * FROM tblSettings WHERE Setting LIKE '%" & sSetting & "%' ORDER BY Setting"
                Else
                    MSCMD.CommandText = "SELECT * FROM tblSettings WHERE Setting='" & sSetting & "' ORDER BY Setting"
                End If

                MSDR = MyExecuteReader(MSCMD)

                Try
                    If MSDR.HasRows Then
                        MSDR.Read()
                        sReturn = myDRString(MSDR, "Setting") & "¶" & myDRString(MSDR, "DefaultValue") & "¶" & myDRString(MSDR, "Comments") & "¶" & myDRString(MSDR, "Category") & "¶" & myDRString(MSDR, "SettingValue")
                    Else
                        sReturn = "¶¶¶¶"
                    End If
                Catch ex As Exception

                End Try

                MSDR.Close()
                MSCMD.Dispose()
                MSCON.Close()
            Else
                Dim MYCON As New MySqlConnection
                Dim MYCMD As New MySqlCommand
                Dim MYDR As MySqlDataReader

                MYCON.ConnectionString = GetConnectionString("DeliveritSQL")
                MyDBOpen(MYCON)
                MYCMD.Connection = MYCON

                If bLike Then
                    MYCMD.CommandText = "SELECT * FROM tblSettings WHERE Setting LIKE '%" & sSetting & "%' ORDER BY Setting"
                Else
                    MYCMD.CommandText = "SELECT * FROM tblSettings WHERE Setting='" & sSetting & "' ORDER BY Setting"
                End If

                MYDR = MyExecuteReader(MYCMD)

                Try
                    If MYDR.HasRows Then
                        MYDR.Read()
                        sReturn = myDRString(MYDR, "Setting") & "¶" & myDRString(MYDR, "DefaultValue") & "¶" & myDRString(MYDR, "Comments") & "¶" & myDRString(MYDR, "Category") & "¶" & myDRString(MYDR, "SettingValue")
                    Else
                        sReturn = "¶¶¶¶"
                    End If
                Catch ex As Exception

                End Try

                MYDR.Close()
                MYCMD.Dispose()
                MYCON.Close()
            End If

        Catch ex As Exception

        End Try

        Return sReturn
    End Function

    Public Function Triggers(ByVal bEnable As Boolean) As Boolean
        Dim sSQL As String = ""
        Dim sProcess As String = ""
        Dim bError As Boolean = False

        If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
            Try
                Select Case bEnable
                    Case True 'TO ENABLE TRIGGERS
                        sSQL = "sp_msforeachtable 'ALTER TABLE ? ENABLE TRIGGER all'"
                        sProcess = "Enable Triggers"
                    Case False 'TO DISABLE TRIGGERS
                        sSQL = "sp_msforeachtable 'ALTER TABLE ? DISABLE TRIGGER all'"
                        sProcess = "Disable Triggers"
                End Select
                ProcessSQL(sSQL, "DeliveritSQL", 10000, bError)
                ProcessSQL(sSQL, "StreetsSQL", 10000, bError)
                ProcessSQL(sSQL, "DPosSysSQL", 10000, bError)
                ProcessSQL(sSQL, "TimeClockSQL", 10000, bError)
                ProcessSQL(sSQL, "StockSQL", 10000, bError)
                ProcessSQL(sSQL, "master", 10000, bError)
            Catch ex As Exception
                bError = True
                MsgBox(sProcess & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
            Try
                If isDBTableExist("mysql_trigger", "deliveritsql") Then ProcessSQL(SQLScriptStringUpdateTriggerMySQL("deliveritsql", bEnable), "", 10000, bError)
                If isDBTableExist("mysql_trigger", "streetssql") Then ProcessSQL(SQLScriptStringUpdateTriggerMySQL("streetssql", bEnable), "", 10000, bError)
                If isDBTableExist("mysql_trigger", "dpossyssql") Then ProcessSQL(SQLScriptStringUpdateTriggerMySQL("dpossyssql", bEnable), "", 10000, bError)
                If isDBTableExist("mysql_trigger", "timeclocksql") Then ProcessSQL(SQLScriptStringUpdateTriggerMySQL("timeclocksql", bEnable), "", 10000, bError)
                If isDBTableExist("mysql_trigger", "stocksql") Then ProcessSQL(SQLScriptStringUpdateTriggerMySQL("stocksql", bEnable), "", 10000, bError)
            Catch ex As Exception
                bError = True
                MsgBox(sProcess & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If

        Return bError
    End Function

    Public Function SQLScriptStringUpdateTriggerMySQL(ByVal sSchemaName As String, ByVal bTrigEnabled As Boolean) As String
        Dim sReturn As String = ""
        Dim sSQL As String
        Dim bHasRows As Integer = 0
        Dim sError As String = ""

        Try
            sSQL = "USE " & sSchemaName & "; "
            sSQL &= "SELECT count(*) as DBRows from mysql_trigger; "

            bHasRows = myCInt(ReadOneDBItemNoError(sSQL, ""))

            Select Case bTrigEnabled
                Case True 'TO ENABLE TRIGGERS
                    If bHasRows = 1 Then
                        sReturn = "USE " & sSchemaName & "; UPDATE mysql_trigger set trigger_enabled=1;"
                    Else
                        sReturn = "USE " & sSchemaName & "; INSERT INTO mysql_trigger (trigger_enabled) VALUES(1);"
                    End If
                Case False 'TO DISABLE TRIGGERS
                    If bHasRows = 1 Then
                        sReturn = "USE " & sSchemaName & "; UPDATE mysql_trigger set trigger_enabled=0;"
                    Else
                        sReturn = "USE " & sSchemaName & "; INSERT INTO mysql_trigger (trigger_enabled) VALUES(0);"
                    End If
            End Select
        Catch ex As Exception

        End Try

        Return sReturn
    End Function

    Public Sub WritetoLog(ByVal sOutputText As String, ByVal sStatus As String, ByVal thisDatagridobj As DataGridView)
        Dim iGetLastRow As DataGridViewRow

        Try
            thisDatagridobj.Rows.Add(sOutputText, sStatus)

            iGetLastRow = thisDatagridobj.Rows(thisDatagridobj.Rows.Count - 1)
            iGetLastRow.Selected = True
            thisDatagridobj.FirstDisplayedScrollingRowIndex = thisDatagridobj.Rows.Count - 1

            thisDatagridobj.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ReWritetoLog(ByVal sOutputText As String, ByVal sStatus As String, ByVal thisDatagridobj As DataGridView)
        Dim iGetLastRow As DataGridViewRow

        Try
            iGetLastRow = thisDatagridobj.Rows(thisDatagridobj.Rows.Count - 2)
            thisDatagridobj.Rows.Remove(iGetLastRow)
            thisDatagridobj.Rows.Add(sOutputText, sStatus)

            iGetLastRow = thisDatagridobj.Rows(thisDatagridobj.Rows.Count - 2)
            iGetLastRow.Selected = True
            thisDatagridobj.FirstDisplayedScrollingRowIndex = thisDatagridobj.Rows.Count - 2

            thisDatagridobj.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub KillKybRunning(ByVal str As String)
        Try
            Dim ItemProcess() As Process = Process.GetProcessesByName(str)

            If Not ItemProcess Is Nothing Then
                For Each SubProcess As Process In ItemProcess
                    SubProcess.Kill()
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function thisOpenFile(ByVal sTitle As String, ByVal sIniFolder As String, ByVal sFN As String, ByVal oOpenFile As OpenFileDialog) As String
        Dim sReturn As String = ""

        Try
            oOpenFile.Title = ""
            oOpenFile.FileName = ""
            If oOpenFile.ShowDialog() = DialogResult.OK Then
                sReturn = oOpenFile.FileName
            End If
        Catch ex As Exception

        End Try

        Return sReturn
    End Function

    Public Function thisOpenDir(ByVal sTitle As String, ByVal oOpenDir As FolderBrowserDialog) As String
        Dim sReturn As String = ""

        Try
            oOpenDir.Description = sTitle
            oOpenDir.SelectedPath = ""
            If oOpenDir.ShowDialog() = DialogResult.OK Then
                sReturn = oOpenDir.SelectedPath
            End If
        Catch ex As Exception

        End Try

        Return sReturn
    End Function

    Public Function GetSetting(ByVal sSetting As String) As String
        Dim s As String
        Dim sOut As String = ""

        For Each s In arSettings
            If GetField(s, CHAR_DELIM, 1) = sSetting Then
                sOut = GetField(s, CHAR_DELIM, 2)
                Exit For
            End If
        Next

        Return sOut
    End Function

    Function GetField(ByVal sRec As String, ByVal sDelim As Char, ByVal sCount As Integer) As String
        If sRec = "" Then
            'nothing to check
            Return ""
            Exit Function
        End If

        Dim iCharCnt, iItemCnt, iRecLength As Integer
        Dim sTemp As String = ""
        Dim sOut As String = ""
        Try
            iRecLength = sRec.Length
            Do
                Do While sRec.Substring(iCharCnt, 1) <> sDelim
                    sTemp = sTemp & sRec.Substring(iCharCnt, 1)
                    iCharCnt += 1
                    If iRecLength = iCharCnt Then Exit Do
                Loop
                iCharCnt += 1
                iItemCnt += 1
                If iItemCnt = sCount Then
                    sOut = sTemp
                Else
                    sTemp = ""
                End If
            Loop Until iCharCnt >= iRecLength
        Catch ex As Exception

        End Try

        Return sOut
    End Function

    Public Function ExtraFilesAppPath(ByVal sFileName As String) As String
        Dim sReturn As String
        Try
            If sFileName.Substring(0, 1) = "\" Then
                sFileName = sFileName.Substring(1, Len(sFileName) - 1)
            End If

            sReturn = Application.StartupPath & "\Database\" & sFileName
        Catch ex As Exception
            sReturn = Application.StartupPath & "\Database\" & sFileName
        End Try

        Return sReturn
    End Function

    Public Sub ExitProgram()
        GC.Collect()
        End

        If (Application.MessageLoop) Then
            ' Use this since we are a WinForms app.
            Application.Exit()
        Else
            ' Use this since we are a console app.
            Environment.Exit(1)
        End If
    End Sub

    Public Sub ConvertQueryBoolToInt(ByRef sString As String)
        Try
            sString = Regex.Replace(sString, "'false'", "0", RegexOptions.IgnoreCase)
            sString = Regex.Replace(sString, "'true'", "1", RegexOptions.IgnoreCase)
        Catch ex As Exception
            sString = 0
        End Try
    End Sub

    Public Function GetDSoftPassword() As String
        Dim i As Integer
        Dim s As String
        Dim iOut As Integer
        Dim sOut As String = ""

        s = Date.Today.Day.ToString.PadLeft(2, "0") & Date.Today.Month.ToString.PadLeft(2, "0") & Date.Today.Year.ToString.Substring(2, 2)
        For i = 0 To 3
            iOut += myCInt(s.Substring(i, 1))
        Next
        sOut = myCStr(iOut)
        sOut = sOut.PadLeft(3, CChar("0"))

        Return sOut
    End Function

    Public Function GetChainPassword() As String
        Dim i As Integer
        Dim s As String
        Dim iOut As Integer
        Dim sOut As String = ""

        s = Date.Today.Day.ToString.PadLeft(2, "0") & Date.Today.Month.ToString.PadLeft(2, "0") & Date.Today.Year.ToString.Substring(2, 2)
        For i = 0 To 2
            iOut = myCInt(s.Substring(i, 1)) + myCInt(s.Substring(5 - i, 1))
            sOut &= myCStr(iOut)
        Next

        Return sOut
    End Function

    Public Function myBooltoDBType(ByVal i As Object) As String
        Dim sOut As String
        Try
            If i Is Nothing OrElse IsDBNull(i) Then
                Return "MSSERVER"
            End If
            sOut = CStr(i)
            If sOut Is Nothing OrElse IsDBNull(sOut) Then
                sOut = "MSSERVER"
            End If
            If sOut = "1" Then
                sOut = "MYSQL"
            Else
                sOut = "MSSERVER"
            End If
        Catch
            sOut = "MSSERVER"
        End Try
        Return sOut
    End Function

    Public Function myBooltoInt(ByVal o As Object) As Integer
        Dim iOut As Integer
        If IsDBNull(o) Then
            Return 0
        End If
        If o Is Nothing Then
            Return 0
        End If
        If o.ToString = "" Then
            Return 0
        End If
        Try
            If o.ToString = "True" Then
                iOut = 1
            Else
                iOut = 0
            End If
        Catch
            iOut = 0
        End Try
        Return iOut
    End Function

    Public Function myCInt(ByVal o As Object) As Integer
        Dim iOut As Integer
        If IsDBNull(o) Then
            Return 0
        End If
        If o Is Nothing Then
            Return 0
        End If
        If o.ToString = "" Then
            Return 0
        End If
        Try
            iOut = CInt(o)
        Catch
            iOut = 0
        End Try
        Return iOut
    End Function

    Public Function myCDec(ByVal o As Object) As Decimal
        Dim iOut As Decimal
        Try
            iOut = CDec(o)
        Catch
            iOut = 0
        End Try
        Return iOut
    End Function

    Public Function myDouble(ByVal o As Object) As Decimal
        Dim iOut As Double
        Try
            iOut = CDbl(o)
        Catch
            iOut = 0
        End Try
        Return iOut
    End Function

    Public Function myCLong(ByVal o As Object) As Long
        Dim iOut As Long
        Try
            iOut = CLng(o)
        Catch
            iOut = 0
        End Try
        Return iOut
    End Function

    Public Function myCDate(ByVal s As String) As Date
        Dim iOut As DateTime
        Try
            iOut = CDate(s)
        Catch
            iOut = Format(Now, "Short Time")
        End Try
        Return iOut
    End Function

    Public Function myCStr(ByVal i As Object) As String
        Dim sOut As String
        Try
            If i Is Nothing OrElse IsDBNull(i) Then
                Return ""
            End If
            sOut = CStr(i)
            If sOut Is Nothing OrElse IsDBNull(sOut) Then
                sOut = ""
            End If
        Catch
            sOut = ""
        End Try
        Return sOut
    End Function

    Public Function myCBool(ByVal b As Object) As Boolean
        Dim bVal As Boolean = False

        If b Is Nothing Then
            Return bVal
        End If

        If myCStr(b).Trim = "" Then
            Return bVal
        End If

        Try
            bVal = CBool(b)
        Catch ex As Exception
        End Try

        Return bVal

    End Function

End Module
