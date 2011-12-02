
Option Strict On
Option Explicit On

Public Class Parcel
    Inherits MailItem

    Sub New(ByVal weight As Double, ByVal measures As MeasureData)
        MyBase.New(weight, measures)
    End Sub

    Public ReadOnly Property ExtraLenghtPrice As Decimal
        Get
            Dim extraprice As Decimal = 0
            If IsLong() Then
                extraprice = CDec(30.0)
            End If
            Return Me.Price + extraprice

        End Get
    End Property

    Public ReadOnly Property IsLong As Boolean
        Get
            If (MyBase.CheckData() = True) And (MyBase.Measures.LongestSide() > 1200) Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Public ReadOnly Property PriceString As String
        Get
            Return Me.ToString()
        End Get
    End Property

    Public Overrides Function CheckData() As Boolean
        If (MyBase.CheckData() = True) And (MyBase.Weight < 20000) And (MyBase.Measures.LongestSide < 1500) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Sub SetPrice()
        If CheckData() = True Then
            If MyBase.Weight <= 3000 Then
                MyBase.Price = CDec(132.5)
            ElseIf MyBase.Weight > 3000 And MyBase.Weight <= 5000 Then
                MyBase.Price = CDec(155.6)
            ElseIf MyBase.Weight > 5000 And MyBase.Weight <= 10000 Then
                MyBase.Price = CDec(197.2)
            ElseIf MyBase.Weight > 10000 And MyBase.Weight <= 20000 Then
                MyBase.Price = CDec(197.2 + ((20000 - MyBase.Weight) * 30))
            End If
        End If
    End Sub

    Public Overrides Function ToString() As String
        Dim str As String = String.Empty
        If IsLong() = True Then
            Me.SetPrice()
            str = Me.ExtraLenghtPrice.ToString() + My.Resources.strLargePackageFee
        Else
            Me.SetPrice()
            str = MyBase.Price.ToString()
        End If
        Return str
    End Function

End Class
