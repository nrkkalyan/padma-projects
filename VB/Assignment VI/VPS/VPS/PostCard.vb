
Option Strict On
Option Explicit On

Public Class PostCard
    Inherits Letter

    Public Sub New()
        MyBase.New(30, New MeasureData)

    End Sub

    Public Overrides Function CheckData() As Boolean
        If MyBase.CheckData() = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Sub SetPrice()
        MyBase.Price = 5
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.Price.ToString()
    End Function

End Class
