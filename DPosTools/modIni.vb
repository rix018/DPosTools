Imports System.IO
Imports System.Text

Module modIni

    Public Class clsIni
        Public Property Header As String
        Public Property Value As String
    End Class

    Public Function MergeTextFiles(ByVal sFile1 As String, ByVal sFile2 As String)

        Dim bOK As Boolean = False

        Try
            FileOpen(1, sFile1, OpenMode.Append)
            For Each line As String In File.ReadLines(sFile2)
                PrintLine(1, line)
            Next
            FileClose(1)

            DeletethisFile(sFile2)

            bOK = True
        Catch ex As Exception

        End Try

        Return bOK

    End Function

    Public Function DeletethisFile(ByVal sFile As String) As Boolean
        Dim bOk As Boolean = True

        Try
            If File.Exists(sFile) Then
                File.Delete(sFile)

                ' Give enough time for the file to be deleted.
                System.Threading.Thread.Sleep(1000)
            End If

        Catch ex As Exception
            bOk = False
        End Try

        Return bOk

    End Function

    Public Function myDirExist(ByVal sPath As String) As Boolean
        Dim bReturn As Boolean = False

        If Directory.Exists(sPath) = True Then
            bReturn = True
        Else
            bReturn = False
        End If

        Return bReturn
    End Function

    Public Function myFileExist(ByVal sFullPath As String) As Boolean
        Dim bReturn As Boolean = False

        If System.IO.File.Exists(sFullPath) = True Then
            bReturn = True
        Else
            bReturn = False
        End If

        Return bReturn
    End Function

    Public Function CreateIni(ByVal sFilePath As String) As Boolean
        Dim bReturn As Boolean = True

        Try
            Dim thisFileIO As New FileInfo(sFilePath)

            If Directory.Exists(thisFileIO.DirectoryName) = False Then
                Directory.CreateDirectory(thisFileIO.DirectoryName)
            End If

            If myFileExist(sFilePath) = False Then
                File.Create(sFilePath).Close()
                System.Threading.Thread.Sleep(2000)
            End If

        Catch ex As Exception
            bReturn = False
        End Try

        Return bReturn
    End Function

    Public Sub LogDataImport(ByVal sWrite As String)
        Try
            Dim sFileName As String

            sFileName = sCSVRestoreLogsFile

            Try
                'Save error to server Errors.txt in Database location
                FileOpen(1, sFileName, OpenMode.Append)
                PrintLine(1, sWrite)
                FileClose(1)
            Catch e As Exception

            End Try

        Catch e As Exception
            'Ignore showerror errors
        End Try

    End Sub

    Public Sub LogDataImportDetails(ByVal sTableName As String, ByVal sDB As String, ByVal sErrorMsg As String, ByVal sImportCMM As String)
        Try
            Dim sLogMsg As New System.Text.StringBuilder

            sLogMsg.Append("Table Name: " & sTableName & vbCrLf)
            sLogMsg.Append("Database: " & sDB & vbCrLf)
            sLogMsg.Append("Time: " & DateTime.Now.ToString & vbCrLf)
            sLogMsg.Append("Error: " & sErrorMsg & vbCrLf & vbCrLf)
            sLogMsg.Append("Import Command: " & vbCrLf & sImportCMM & vbCrLf & vbCrLf)

            LogDataImport(sLogMsg.ToString)
        Catch e As Exception
            'Ignore showerror errors
        End Try

    End Sub

    Public Function WriteToIni(ByVal sData As String, ByVal sFilter As String, ByVal sPath As String) As Boolean
        Dim sIniFilePath As String = sPath
        Dim iIndex As Integer = 0
        Dim bFound As Boolean = False
        Dim bReturn = False

        Try
            Dim lines() As String = System.IO.File.ReadAllLines(sIniFilePath)

            For iIndex = 0 To lines.Count - 1
                If lines(iIndex).StartsWith(sFilter) Then
                    ' The line was located.
                    bFound = True
                    Exit For
                End If
            Next

            If bFound = True Then
                ' Update the line.
                If sData.Substring(0, 1) = vbCrLf Then
                    sData = sData.Substring(0, Len(sData) - 1)
                End If

                lines(iIndex) = sData
                lines.ToString.Replace(vbCrLf & vbCrLf, vbCrLf)
                File.WriteAllLines(sIniFilePath, lines)
            Else
                ' The line was not located, directly write the line.
                FileOpen(1, sIniFilePath, OpenMode.Append)
                PrintLine(1, sData)
                FileClose(1)
            End If

            bReturn = True
        Catch ex As Exception

        End Try

        Return bReturn
    End Function

    Public Function GetInfoFromIni(ByVal sFilter As String, ByVal sIniFileName As String, ByVal bShowError As Boolean) As String
        Dim sInfo As String = ""
        Dim iniItem As New clsIni
        Dim sIniList As New ArrayList

        Try
            ' Get the list of settings from the ini file.
            sIniList = ReadIniFile(sFilter, sIniFileName, bShowError)

            ' Browse the contents of the ini file.
            For Each iniItem In sIniList
                ' Check if this is the info that we are looking for.
                If iniItem.Header = sFilter Then
                    sInfo = iniItem.Value
                    Exit For
                End If
            Next
        Catch ex As Exception
            If bShowError Then

            End If
        End Try

        Return sInfo
    End Function

    Public Function ReadIniFile(ByVal sFilter As String, ByVal sIniFileName As String, ByVal bShowError As Boolean) As ArrayList
        Dim iniContents As New ArrayList

        Try
            ' Check if the file exists in the directory.
            If myFileExist(sIniFileName) = True Then
                Dim lineList As New List(Of Object)(File.ReadAllLines(sIniFileName))

                ' Check if the ini file has any contents.
                If lineList.Count <> 0 Then
                    ' Loop through the ini file.
                    For Each line In lineList
                        Dim iniSetting As New clsIni
                        If line.ToString.Contains("=") Then
                            Try
                                iniSetting.Header = GetField(line.ToString, "=", 1)
                                iniSetting.Value = line.ToString.Substring(Len(sFilter & "="), Len(line.ToString) - Len(sFilter & "="))
                                iniContents.Add(iniSetting)
                            Catch ex As Exception

                            End Try
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            If bShowError = True Then

            End If
        End Try

        Return iniContents
    End Function

End Module
