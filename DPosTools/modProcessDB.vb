Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Chilkat.Zip

Module modProcessDB
    Public Function GetConnectionString(ByVal sDatabase As String) As String
        Dim sReturn As String = ""

        Try
            If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
                sReturn = "Data Source=" & thisConfig.ServerName & ";Integrated Security=False;Initial Catalog=" & sDatabase & ";User ID=" & thisConfig.MSUser & ";Password=" & thisConfig.MSPass
            Else
                If sDatabase = "" Then
                    sReturn = "server=" & thisConfig.ServerName & "; port=" & thisConfig.MYPort & "; user id=" & thisConfig.MYUser & "; password=" & thisConfig.MYPass & "; Connect Timeout=30; default command timeout=90;"
                Else
                    sReturn = "server=" & thisConfig.ServerName & "; port=" & thisConfig.MYPort & "; user id=" & thisConfig.MYUser & "; password=" & thisConfig.MYPass & "; database=" & sDatabase & "; Connect Timeout=30; default command timeout=90;"
                End If
            End If
        Catch ex As Exception

        End Try

        Return sReturn
    End Function

    Public Function GetConnectionString2(ByVal sDatabase As String) As String
        Dim sReturn As String = ""

        Try
            If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
                sReturn = "Data Source=" & thisConfig.ServerName & ";Integrated Security=False;Initial Catalog=" & sDatabase & ";User ID=" & thisConfig.MSUser & ";Password=" & thisConfig.MSPass
            Else
                If sDatabase = "" Then
                    sReturn = "server=" & thisConfig.ServerName & "; port=" & thisConfig.MYPort & "; user id=" & thisConfig.MYUser & "; password=" & thisConfig.MYPass & "; Connect Timeout=30; "
                Else
                    sReturn = "server=" & thisConfig.ServerName & "; port=" & thisConfig.MYPort & "; user id=" & thisConfig.MYUser & "; password=" & thisConfig.MYPass & "; database=" & sDatabase & "; Connect Timeout=30;"
                End If
            End If
        Catch ex As Exception

        End Try

        Return sReturn
    End Function

    Public Function ProcessSQL(ByVal sSQL As String, ByVal sDatabase As String, ByVal iTimeOut As Integer, ByRef bError As Boolean) As Long
        Dim iRows As Long

        bError = False

        Try
            If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
                Dim MSCON As New SqlConnection
                Dim MSCMD As New SqlCommand

                Try
                    MSCON.ConnectionString = GetConnectionString(sDatabase)
                    MyDBOpen(MSCON)

                    MSCMD.Connection = MSCON
                    MSCMD.CommandText = sSQL
                    MSCMD.CommandTimeout = iTimeOut

                    iRows = MyExecuteNonQuery(MSCMD, bError)

                    MSCMD.Dispose()

                Catch ex As Exception
                    bError = True
                    iRows = -2
                Finally
                    MSCON.Close()
                End Try
            Else
                Dim MYCON As New MySqlConnection
                Dim MYCMD As New MySqlCommand

                Try
                    MYCON.ConnectionString = GetConnectionString(sDatabase)
                    MyDBOpen(MYCON)

                    MYCMD.Connection = MYCON
                    MYCMD.CommandText = sSQL
                    MYCMD.CommandTimeout = iTimeOut

                    iRows = MyExecuteNonQuery(MYCMD, bError)

                    MYCMD.Dispose()

                Catch ex As Exception
                    bError = True
                    iRows = -2
                Finally
                    MYCON.Close()
                End Try
            End If
        Catch ex As Exception
            iRows = -2
        End Try

        Return iRows
    End Function

    Public Function ProcessSQL(ByVal sSQL As String, ByVal sDatabase As String, ByVal iTimeOut As Integer, ByRef sErrMsg As String) As Boolean
        'Returns True if failed
        Dim bReturn As Boolean = False

        sErrMsg = ""

        Try
            If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
                Dim MSCON As New SqlConnection
                Dim MSCMD As New SqlCommand

                Try
                    MSCON.ConnectionString = GetConnectionString(sDatabase)
                    MyDBOpen(MSCON)

                    MSCMD.Connection = MSCON
                    MSCMD.CommandText = sSQL
                    MSCMD.CommandTimeout = iTimeOut

                    iRows = MyExecuteNonQuery(MSCMD, sErrMsg)
                    If sErrMsg <> "" Then
                        bReturn = True
                    End If

                    MSCMD.Dispose()

                Catch ex As Exception
                    sErrMsg = ex.Message.ToString
                    bReturn = True
                    iRows = -2
                Finally
                    MSCON.Close()
                End Try
            Else
                Dim MYCON As New MySqlConnection
                Dim MYCMD As New MySqlCommand

                Try
                    MYCON.ConnectionString = GetConnectionString(sDatabase)
                    MyDBOpen(MYCON)

                    MYCMD.Connection = MYCON
                    MYCMD.CommandText = sSQL
                    MYCMD.CommandTimeout = iTimeOut

                    iRows = MyExecuteNonQuery(MYCMD, sErrMsg)
                    If sErrMsg <> "" Then
                        bReturn = True
                    End If

                    MYCMD.Dispose()

                Catch ex As Exception
                    sErrMsg = ex.Message.ToString
                    bReturn = True
                    iRows = -2
                Finally
                    MYCON.Close()
                End Try
            End If
        Catch ex As Exception
            iRows = -2
        End Try

        Return bReturn
    End Function

    Public Function ProcessSQL2(ByVal sSQL As String, ByVal sDatabase As String, ByVal iTimeOut As Integer, ByRef sErrMsg As String) As Boolean
        'Returns True if failed
        Dim bReturn As Boolean = False

        sErrMsg = ""

        Try
            If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
                Dim MSCON As New SqlConnection
                Dim MSCMD As New SqlCommand

                Try
                    MSCON.ConnectionString = GetConnectionString2(sDatabase)
                    MyDBOpen(MSCON)

                    MSCMD.Connection = MSCON
                    MSCMD.CommandText = sSQL
                    MSCMD.CommandTimeout = iTimeOut

                    iRows = MSCMD.ExecuteNonQuery()

                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString)
                    sErrMsg = ex.Message
                    bReturn = True
                    iRows = -2
                Finally
                    MSCON.Close()
                End Try
            Else
                Dim MYCON As New MySqlConnection
                Dim MYCMD As New MySqlCommand

                Try
                    MYCON.ConnectionString = GetConnectionString2(sDatabase)
                    MyDBOpen(MYCON)

                    MYCMD.Connection = MYCON
                    MYCMD.CommandText = sSQL
                    MYCMD.CommandTimeout = iTimeOut

                    iRows = MYCMD.ExecuteNonQuery()

                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString)
                    sErrMsg = ex.Message
                    bReturn = True
                    iRows = -2
                Finally
                    MYCON.Close()
                End Try
            End If
        Catch ex As Exception
            iRows = -2
        End Try

        Return bReturn
    End Function

    Public Function ReadOneDBItemNoError(ByVal sSQL As String, ByVal sDatabase As String) As Object
        Dim oResult As Object = Nothing

        If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
            Dim MSCON As New SqlConnection
            Dim MSCMD As New SqlCommand

            Try
                MSCON.ConnectionString = GetConnectionString(sDatabase)
                MyDBOpen(MSCON)

                MSCMD.Connection = MSCON
                MSCMD.CommandText = sSQL

                oResult = MyExecuteScalar(MSCMD)

                MSCMD.Dispose()
            Catch ex As Exception
                ' LogSQLError(ex.ToString)
            Finally
                MSCON.Close()
            End Try

        Else
            Dim MYCON As New MySqlConnection
            Dim MYCMD As New MySqlCommand

            Try
                MYCON.ConnectionString = GetConnectionString(sDatabase)
                MyDBOpen(MYCON)

                MYCMD.Connection = MYCON
                MYCMD.CommandText = sSQL

                oResult = MyExecuteScalar(MYCMD)

                MYCMD.Dispose()
            Catch ex As Exception
                ' LogSQLError(ex.ToString)
            Finally
                MYCON.Close()
            End Try


        End If

        Return oResult

    End Function

    Public Function isDBTableExist(ByVal sTable As String, ByVal sDatabase As String) As Boolean
        Dim bReturn As Boolean = True
        Dim sSQL As String
        Dim iTblCnt As Integer = 0

        Try
            If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
                sSQL = "SELECT count(*) from INFORMATION_SCHEMA.TABLES WHERE TABLE_CATALOG='" & sDatabase & "' AND = TABLE_NAME='" & sTable & "'"

                iTblCnt = myCInt(ReadOneDBItemNoError(sSQL, "DeliveritSQL"))
            Else
                sSQL = "USE sys; SELECT count(*) from INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='" & sDatabase & "' AND TABLE_NAME='" & sTable & "';"

                iTblCnt = myCInt(ReadOneDBItemNoError(sSQL, ""))
            End If

            bReturn = myCBool(iTblCnt)

        Catch ex As Exception
            bReturn = False
        End Try

        Return bReturn
    End Function

    Public Function MyDBOpen(ByVal MSCON As SqlConnection) As Boolean
        Try
            MSCON.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function MyDBOpen(ByVal MYCON As MySqlConnection) As Boolean
        Try
            MYCON.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function MyExecuteNonQuery(ByRef SQLCommand As SqlCommand, ByRef bError As Boolean) As Integer
        Dim NumberOfLinesAffected As Integer

        bError = False

        Try
            NumberOfLinesAffected = SQLCommand.ExecuteNonQuery()
        Catch ex As Exception
            bError = True
            MessageBox.Show("A database error has been detected: " & ex.Message)
        End Try

        Return NumberOfLinesAffected
    End Function

    Public Function MyExecuteNonQuery(ByRef SQLCommand As MySqlCommand, ByRef bError As Boolean) As Integer
        Dim NumberOfLinesAffected As Integer

        bError = False

        Try
            ConvertQueryBoolToInt(SQLCommand.CommandText)
            NumberOfLinesAffected = SQLCommand.ExecuteNonQuery()
        Catch ex As Exception
            bError = True
            MessageBox.Show("A database error has been detected: " & ex.Message)
        End Try

        Return NumberOfLinesAffected
    End Function

    Public Function MyExecuteNonQuery(ByRef SQLCommand As SqlCommand, ByRef sErrMsg As String) As Integer
        Dim NumberOfLinesAffected As Integer

        sErrMsg = ""

        Try
            NumberOfLinesAffected = SQLCommand.ExecuteNonQuery()
        Catch ex As Exception
            sErrMsg = ex.Message
            MessageBox.Show("A database error has been detected: " & ex.Message)
        End Try

        Return NumberOfLinesAffected
    End Function

    Public Function MyExecuteNonQuery(ByRef SQLCommand As MySqlCommand, ByRef sErrMsg As String) As Integer
        Dim NumberOfLinesAffected As Integer

        sErrMsg = ""

        Try
            ConvertQueryBoolToInt(SQLCommand.CommandText)
            NumberOfLinesAffected = SQLCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("A database error has been detected: " & ex.Message)
            sErrMsg = ex.Message
        End Try

        Return NumberOfLinesAffected
    End Function

    Public Function MyExecuteReader(ByRef SQLCommand As SqlCommand) As SqlDataReader
        Dim SQLDataReader As SqlDataReader

        Try
            SQLDataReader = SQLCommand.ExecuteReader()
            Return SQLDataReader
        Catch ex As Exception

        End Try

        Return Nothing
    End Function

    Public Function MyExecuteReader(ByRef SQLCommand As MySqlCommand) As MySqlDataReader
        Dim SQLDataReader As MySqlDataReader

        Try
            ConvertQueryBoolToInt(SQLCommand.CommandText)
            SQLDataReader = SQLCommand.ExecuteReader()
            Return SQLDataReader
        Catch ex As Exception

        End Try

        Return Nothing
    End Function

    Public Function MyExecuteScalar(ByRef SQLCommand As SqlCommand) As Object
        Dim Test As Object = Nothing
        Try
            Test = SQLCommand.ExecuteScalar()
        Catch ex As Exception

        End Try

        Return Test
    End Function

    Public Function MyExecuteScalar(ByRef SQLCommand As MySqlCommand) As Object
        Dim Test As Object = Nothing
        Try
            ConvertQueryBoolToInt(SQLCommand.CommandText)
            Test = SQLCommand.ExecuteScalar()
        Catch ex As Exception

        End Try

        Return Test
    End Function

    <CLSCompliant(False)>
    Function myDRString(ByVal dr As SqlClient.SqlDataReader, ByVal sField As String) As String
        Dim sData As String = ""

        Try
            If Not IsDBNull(dr.Item(sField)) Then
                sData = Trim(dr.Item(sField))
            End If
        Catch ex As Exception
            sData = ""
        End Try

        Return sData
    End Function

    <CLSCompliant(False)>
    Function myDRString(ByVal dr As MySqlDataReader, ByVal sField As String) As String
        Dim sData As String = ""

        Try
            If Not IsDBNull(dr.Item(sField)) Then
                sData = Trim(dr.Item(sField))
            End If
        Catch ex As Exception
            sData = ""
        End Try

        Return sData
    End Function

    <CLSCompliant(False)>
    Function myDRBool(ByVal dr As SqlDataReader, ByVal sField As String) As Boolean
        Dim bData As Boolean = True

        Try
            If Not IsDBNull(dr.Item(sField)) Then
                bData = dr.Item(sField)
            End If
        Catch ex As Exception
            bData = False
        End Try

        Return bData
    End Function

    <CLSCompliant(False)>
    Function myDRBool(ByVal dr As MySqlDataReader, ByVal sField As String) As Boolean
        Dim bData As Boolean = True

        Try
            If Not IsDBNull(dr.Item(sField)) Then
                bData = dr.Item(sField)
            End If
        Catch ex As Exception
            bData = False
        End Try

        Return bData
    End Function




End Module
