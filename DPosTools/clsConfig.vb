Public Class clsConfig

    Private zDatabaseType As eDatabaseType
    Private zServerName As String
    Private zDPosIniLoc As String
    Private zMSUser As String
    Private zMSPass As String
    Private zMYPort As String
    Private zMYUser As String
    Private zMYPass As String
    Private zMYCSVPass As String

    Public Enum eDatabaseType As Byte
        MSSERVER = 0
        MYSQL = 1
    End Enum

    Public Sub New()
        MyBase.New
    End Sub

    Public Property DatabaseType() As eDatabaseType
        Get
            Return zDatabaseType
        End Get
        Set(value As eDatabaseType)
            zDatabaseType = value
        End Set
    End Property

    Public Property ServerName() As String
        Get
            Return zServerName
        End Get
        Set(value As String)
            zServerName = value
        End Set
    End Property

    Public Property DPosIniLoc() As String
        Get
            Return zDPosIniLoc
        End Get
        Set(value As String)
            zDPosIniLoc = value
        End Set
    End Property

    Public Property MSUser() As String
        Get
            Return zMSUser
        End Get
        Set(value As String)
            zMSUser = value
        End Set
    End Property

    Public Property MSPass() As String
        Get
            Return zMSPass
        End Get
        Set(value As String)
            zMSPass = value
        End Set
    End Property

    Public Property MYPort() As String
        Get
            Return zMYPort
        End Get
        Set(value As String)
            zMYPort = value
        End Set
    End Property

    Public Property MYUser() As String
        Get
            Return zMYUser
        End Get
        Set(value As String)
            zMYUser = value
        End Set
    End Property

    Public Property MYPass() As String
        Get
            Return zMYPass
        End Get
        Set(value As String)
            zMYPass = value
        End Set
    End Property

    Public Property MYCSVPass() As String
        Get
            Return zMYCSVPass
        End Get
        Set(value As String)
            zMYCSVPass = value
        End Set
    End Property
End Class
