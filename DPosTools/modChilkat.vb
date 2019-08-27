Imports System.IO
Imports Chilkat.Zip

Module modChilkat

    Public Function CheckFileIfExistInZip(ByVal sFileName As String, ByVal sZipFile As String) As Boolean
        Dim bReturn As Boolean = False

        Dim zip As New Chilkat.Zip()
        zip.UnlockComponent(ChilkatZipLicenseKey)

        Dim success As Boolean
        success = zip.OpenZip(sZipFile)

        Try
            Dim zipEntry As Chilkat.ZipEntry = zip.FirstEntry

            While Not zipEntry Is Nothing
                If zipEntry.FileName.ToString = sFileName Then
                    bReturn = True
                    Exit While
                End If
                zipEntry = zipEntry.NextEntry
            End While
        Catch ex As Exception

        End Try

        Return bReturn
    End Function

    Public Function CompressFiles(ByVal sType As String, ByVal sFilesToAdd As Chilkat.StringArray) As String
        Dim success As Boolean

        If sFilesToAdd.Count <> 0 Then
            Dim sZipFile As String = ""
            Dim sZipFileName As String
            Dim bZipFileExist As Boolean = True
            Dim zipCnt As Integer = 0

            If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
                sZipFileName = dirMSSERVER & "\Backups\"
            Else
                sZipFileName = dirMYSQL & "\Backups\"
            End If

            sZipFileName &= sType & " " & Date.Today.Year.ToString & Date.Today.Month.ToString.PadLeft(2, "0") & Date.Today.Day.ToString.PadLeft(2, "0")

            Do While bZipFileExist = True
                If zipCnt = 0 Then
                    sZipFile = sZipFileName & ".zip"
                Else
                    sZipFile = sZipFileName & "-" & myCStr(zipCnt) & ".zip"
                End If

                If File.Exists(sZipFile) Then
                    zipCnt += 1
                Else
                    bZipFileExist = False
                End If
            Loop

            Try
                Dim zip As New Chilkat.Zip
                success = zip.UnlockComponent(ChilkatZipLicenseKey)

                If success Then
                    'create a new zip
                    success = zip.NewZip(sZipFile)

                    If thisConfig.DatabaseType = eDatabaseType.MYSQL Then
                        zip.Encryption = 4
                        zip.EncryptKeyLength = 128
                        zip.EncryptPassword = thisConfig.MYCSVPass
                        zip.PasswordProtect = False
                    End If

                    zip.AppendMultiple(sFilesToAdd, False)

                    'write the zip file
                    success = zip.WriteZipAndClose
                End If

                If (Not success) Then
                    MsgBox(zip.LastErrorText)
                    Exit Try
                End If


                'delete the .BAK files now because they are in the zip.
                If sType = "Data" Then
                    Dim x As Integer
                    For x = 0 To (sFilesToAdd.Count - 1)
                        If IO.File.Exists(sFilesToAdd.GetString(x)) Then
                            IO.File.Delete(sFilesToAdd.GetString(x))
                        End If
                    Next
                End If

                Return sZipFile
            Catch ex As Exception

            End Try
        End If

        Return ""
    End Function

    Public Function ExtractZipFile(ByVal sZipFile As String, ByVal sExtractFolder As String, ByVal files As ArrayList) As String
        If sExtractFolder.StartsWith("\") = False Then
            sExtractFolder = "\" & sExtractFolder
        End If
        If sExtractFolder.EndsWith("\") = False Then
            sExtractFolder = sExtractFolder & "\"
        End If

        If thisConfig.DatabaseType = eDatabaseType.MSSERVER Then
            sExtractFolder = dirMSSERVER & sExtractFolder
        Else
            sExtractFolder = dirMYSQL & sExtractFolder
        End If

        Dim zip As New Chilkat.Zip()
        zip.UnlockComponent(ChilkatZipLicenseKey)


        Dim success As Boolean
        success = zip.OpenZip(sZipFile)
        If thisConfig.DatabaseType = eDatabaseType.MYSQL Then
            zip.DecryptPassword = thisConfig.MYCSVPass
        End If

        'Check zip if it has the correct files
        Try
            Dim zipEntry As Chilkat.ZipEntry = zip.FirstEntry
            Dim zipFiles As New ArrayList
            Dim iMatch As Integer = 0

            While Not zipEntry Is Nothing
                zipFiles.Add(zipEntry.FileName)
                zipEntry = zipEntry.NextEntry
            End While

            For x As Integer = 0 To files.Count - 1
                Dim sSelected As String = files.Item(x).ToString & ".BAK"
                For y As Integer = 0 To zipFiles.Count - 1
                    If sSelected.ToUpper = zipFiles.Item(y).ToString.ToUpper Then
                        iMatch += 1
                        Exit For
                    End If
                Next
                If (x + 1) <> iMatch Then
                    MessageBox.Show("Cannot find the file specified: " & sSelected & " on zip file")
                    Return ""
                End If
            Next
        Catch ex As Exception
            'ignore when error
        End Try

        'Create the extract folder, or clear it first.
        Dim directoryInfo As New DirectoryInfo(sExtractFolder)
        If directoryInfo.Exists Then
            '           directoryInfo.Delete(True)
        End If
        directoryInfo.Create()

        ' Unzip to a specific directory:
        Dim count As Integer
        count = zip.Unzip(sExtractFolder)
        If (count = -1) Then
            MsgBox(zip.LastErrorText)
            Return ""
            'Else
            'MsgBox("Unzipped " + Str(count) + " files and directories")
        End If

        Return sExtractFolder
    End Function
End Module
