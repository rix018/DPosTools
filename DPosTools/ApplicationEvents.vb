Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub AppStart(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf ResolveAssemblies
        End Sub

        Private Function ResolveAssemblies(sender As Object, e As System.ResolveEventArgs) As Reflection.Assembly
            Dim desiredAssembly = New Reflection.AssemblyName(e.Name)

            Try
                Select Case desiredAssembly.Name
                    Case "DPosSecurity"
                        Return Reflection.Assembly.Load(My.Resources.DPosSecurity)
                    Case "MetroFramework"
                        Return Reflection.Assembly.Load(My.Resources.MetroFramework)
                    Case "MetroFramework.Fonts"
                        Return Reflection.Assembly.Load(My.Resources.MetroFramework_Fonts)
                    Case "MySql.Data"
                        Return Reflection.Assembly.Load(My.Resources.MySql_Data)
                    Case "MySqlBackup"
                        Return Reflection.Assembly.Load(My.Resources.MySqlBackup)
                    Case "Newtonsoft.Json.dll"
                        Return Reflection.Assembly.Load(My.Resources.Newtonsoft_Json)
                    Case Else
                        Return Nothing
                End Select

            Catch ex As Exception
                Return Nothing
            End Try
        End Function
    End Class
End Namespace
