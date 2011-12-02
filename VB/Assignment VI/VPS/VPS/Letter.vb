
Option Strict On
Option Explicit On

Public Class Letter
    Inherits MailItem

    Sub New(ByVal weight As Double, ByVal measures As MeasureData)
        MyBase.New(weight, measures)
    End Sub

    Public ReadOnly Property PriceString As String
        Get
            Return Me.ToString()
        End Get
    End Property


    Public Overrides Function CheckData() As Boolean
        If (MyBase.CheckData() = True) And (MyBase.Weight < 2000) And (MyBase.Measures.LongestSide < 500) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Sub SetPrice()
        If CheckData() = True Then
            If MyBase.Weight <= 20 Then
                MyBase.Price = CDec(5.3)
            ElseIf MyBase.Weight > 20 And MyBase.Weight <= 100 Then
                MyBase.Price = CDec(10.6)
            ElseIf MyBase.Weight > 100 And MyBase.Weight <= 250 Then
                MyBase.Price = CDec(21.3)
            ElseIf MyBase.Weight > 250 And MyBase.Weight <= 500 Then
                MyBase.Price = CDec(31.8)
            ElseIf MyBase.Weight > 500 And MyBase.Weight <= 1000 Then
                MyBase.Price = CDec(42.5)
            ElseIf MyBase.Weight > 1000 And MyBase.Weight <= 2000 Then
                MyBase.Price = CDec(63.6)
            End If
        End If
    End Sub

    Public Overrides Function ToString() As String
        Dim str As String = String.Empty
        If IsLarge() = True Then
            Me.SetPrice()
            str = Me.LargeEnvolopeCharger().ToString() + My.Resources.strLargeEnvolopeFee
        Else
            Me.SetPrice()
            str = MyBase.Price.ToString()
        End If
        Return str
    End Function

    Public Function IsLarge() As Boolean
        If (MyBase.CheckData() = True) And (MyBase.Measures.LongestSide() > 300) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function LargeEnvolopeCharger() As Decimal
        Dim extraprice As Decimal = 0
        If IsLarge() Then
            extraprice = CDec(12.0)
        End If
        Return Me.Price + extraprice
    End Function

End Class
