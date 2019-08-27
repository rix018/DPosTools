Public Class clsInfo
    Public zDPosVersion As String
    Public zDBVersion As String
    Public zDocketHeading1 As String
    Public zEnableCloud As String
    Public zClientID As String
    Public zCloudURL As String
    Public zDPosIniDBType As eDatabaseType

    Public Enum eDatabaseType As Byte
        MSSERVER = 0
        MYSQL = 1
    End Enum

    Public Sub New()
        MyBase.New
    End Sub

    Public Property DPosVersion() As String
        Get
            Return zDPosVersion
        End Get
        Set(value As String)
            zDPosVersion = value
        End Set
    End Property

    Public Property DBVersion() As String
        Get
            Return zDBVersion
        End Get
        Set(value As String)
            zDBVersion = value
        End Set
    End Property

    Public Property DocketHeading1() As String
        Get
            Return zDocketHeading1
        End Get
        Set(value As String)
            zDocketHeading1 = value
        End Set
    End Property

    Public Property EnableCloud() As String
        Get
            Return zEnableCloud
        End Get
        Set(value As String)
            zEnableCloud = value
        End Set
    End Property

    Public Property ClientID() As String
        Get
            Return zClientID
        End Get
        Set(value As String)
            zClientID = value
        End Set
    End Property

    Public Property CloudURL() As String
        Get
            Return zCloudURL
        End Get
        Set(value As String)
            zCloudURL = value
        End Set
    End Property

    Public Property DPosIniDBType() As eDatabaseType
        Get
            Return zDPosIniDBType
        End Get
        Set(value As eDatabaseType)
            zDPosIniDBType = value
        End Set
    End Property
End Class
