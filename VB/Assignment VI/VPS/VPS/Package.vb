
Option Strict On
Option Explicit On

Public Class Package
    Inherits Parcel

    Sub New(ByVal weight As Double, ByVal measures As MeasureData)
        MyBase.New(weight, measures)
    End Sub

    Public Overrides Function CheckData() As Boolean
        Return MyBase.CheckData()
    End Function

    Public Overrides Sub SetPrice()
        MyBase.SetPrice()
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

End Class
