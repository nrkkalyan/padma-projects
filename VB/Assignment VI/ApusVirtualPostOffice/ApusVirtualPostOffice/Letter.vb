
Public Class Letter
    Inherits MailItem

    Sub New(ByVal weight As Double, ByVal measures As MeasureData)

    End Sub

    Public Property PriceString As String
        Get

        End Get
        Set(ByVal value As String)

        End Set
    End Property


    Public Function CheckDate() As Boolean

    End Function

    Public Sub SetPrice()

    End Sub

    Public Overrides Function ToString() As String
        Return "value"

    End Function

    Public Function IsLarge() As Boolean

    End Function

    Public Function LargeEnvolopeCharger() As Decimal

    End Function

End Class
