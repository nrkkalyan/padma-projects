
Public Class MailItem
    Private m_measures As MeasureData
    Private m_price As Double
    Private m_receiver As Customer
    Private m_sender As Customer
    Private m_weight As Double

    Sub New(ByVal weight As Double, ByVal measures As MeasureData)

    End Sub

    Public Property Measures As MeasureData
        Get

        End Get
        Set(ByVal value As MeasureData)

        End Set
    End Property

    Public Property Receiver As Customer
        Get

        End Get
        Set(ByVal value As Customer)

        End Set
    End Property

    Public Property MailType As MailType
        Get

        End Get
        Set(ByVal value As MailType)

        End Set
    End Property

    Public Property Price As Decimal
        Get

        End Get
        Set(ByVal value As Decimal)

        End Set
    End Property

    Public Property Sender As Customer
        Get

        End Get
        Set(ByVal value As Customer)

        End Set
    End Property

    Public Property Weight As Double
        Get

        End Get
        Set(ByVal value As Double)

        End Set
    End Property

    Public Function CheckData() As Boolean

    End Function

    Public Sub SetPrice()

    End Sub

End Class
