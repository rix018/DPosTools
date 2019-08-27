Imports System.IO
Imports Microsoft.Win32

Module modRegis
    Public Function isThisSoftwareInstalled(ByVal sDisplayName As String, ByVal bExactProgramName As Boolean) As Boolean
        Dim b32 As Boolean = False
        Dim b64 As Boolean = False

        b32 = isThisSoftwareInstalled(sDisplayName, "SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall", RegistryView.Default, bExactProgramName)
        b64 = isThisSoftwareInstalled(sDisplayName, "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", RegistryView.Registry64, bExactProgramName)

        If b32 Or b64 Then
            Return True
        End If

        Return False
    End Function

    Public Function isThisSoftwareInstalled(ByVal sDisplayName As String, ByVal RegisKey As String, ByRef RegisView As RegistryView, ByVal bExactProgramName As Boolean) As Boolean
        'Dim HKLMPath As RegistryKey

        Try
            Using HKLMPath As RegistryKey = Microsoft.Win32.RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegisView)
                Using key As RegistryKey = Registry.LocalMachine.OpenSubKey(RegisKey)
                    For Each subkey_name In key.GetSubKeyNames
                        Using subkey As RegistryKey = key.OpenSubKey(subkey_name)
                            Dim thisDisplayName As String = myCStr(subkey.GetValue("DisplayName"))
                            If bExactProgramName Then
                                If thisDisplayName = sDisplayName Then
                                    Return True
                                End If
                            Else
                                Dim bMatched As Boolean = thisDisplayName Like sDisplayName & "*"

                                If bMatched Then
                                    Return True
                                End If
                            End If
                        End Using
                    Next
                End Using
            End Using
        Catch ex As Exception
            'do not do anything
        End Try

        Return False
    End Function

    Public Function GetSoftwareInfoByDisplayName(ByVal sDisplayName As String, ByVal sKeyName As String, ByVal RegisKey As String, ByRef RegisView As RegistryView, ByVal bExactProgramName As Boolean) As String
        Dim sReturn As String = ""

        Try
            Using HKLMPath As RegistryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegisView)
                Using key As RegistryKey = Registry.LocalMachine.OpenSubKey(RegisKey)
                    For Each subkey_name In key.GetSubKeyNames
                        Using subkey As RegistryKey = key.OpenSubKey(subkey_name)
                            Dim thisDisplayName As String = myCStr(subkey.GetValue("DisplayName"))
                            If bExactProgramName Then
                                If thisDisplayName = sDisplayName Then
                                    sReturn = myCStr(subkey.GetValue(sKeyName))
                                End If
                            Else
                                Dim bMatched As Boolean = thisDisplayName Like sDisplayName & "*"

                                If bMatched Then
                                    sReturn = myCStr(subkey.GetValue(sKeyName))
                                End If
                            End If
                        End Using
                    Next
                End Using
            End Using
        Catch ex As Exception
            'do not do anything
        End Try

        Return sReturn
    End Function

End Module
