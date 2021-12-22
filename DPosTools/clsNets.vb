Public Class clsNets
    Inherits ArrayList

    Public Sub New()
        MyBase.New()

    End Sub

    Public Overloads Sub Add(ByVal thisRec As clsNet)
        MyBase.Add(thisRec)
    End Sub
End Class
