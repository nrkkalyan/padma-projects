
Public Class Parcel
    Inherits MailItem

    Sub New(ByVal weight As Double, ByVal measures As MeasureData)

    End Sub

    Public Property ExtraLenghtPrice As Decimal
        Get

        End Get
        Set(ByVal value As Decimal)

        End Set
    End Property

    Public Property IsLong As Boolean
        Get

        End Get
        Set(ByVal value As Boolean)

        End Set
    End Property

    Public Property PriceString As String
        Get

        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Function CheckData() As Boolean

    End Function

    Public Sub SetPrice()

    End Sub

    Public Function ToString() As String

    End Function

End Class
