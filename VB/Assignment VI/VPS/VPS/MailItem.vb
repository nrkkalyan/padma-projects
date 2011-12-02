

Option Strict On
Option Explicit On

Public Class MailItem
    Private m_measures As MeasureData
    Private m_price As Decimal
    Private m_receiver As Customer
    Private m_sender As Customer
    Private m_weight As Double
    Private m_mailType As MailType

    Sub New(ByVal weight As Double, ByVal measures As MeasureData)
        m_weight = weight
        m_measures = measures
    End Sub

    Public Property Measures As MeasureData
        Get
            Return m_measures
        End Get
        Set(ByVal value As MeasureData)
            m_measures = value
        End Set
    End Property

    Public Property Receiver As Customer
        Get
            Return m_receiver
        End Get
        Set(ByVal value As Customer)
            m_receiver = value
        End Set
    End Property

    Public Property MailType As MailType
        Get
            Return m_mailType
        End Get
        Set(ByVal value As MailType)
            m_mailType = value
        End Set
    End Property

    Public Property Price As Decimal
        Get
            Return CDec(m_price)
        End Get
        Set(ByVal value As Decimal)
            m_price = value
        End Set
    End Property

    Public Property Sender As Customer
        Get
            Return m_sender
        End Get
        Set(ByVal value As Customer)
            m_sender = value
        End Set
    End Property

    Public Property Weight As Double
        Get
            Return m_weight
        End Get
        Set(ByVal value As Double)
            m_weight = value
        End Set
    End Property

    Public Overridable Function CheckData() As Boolean
        If (m_weight > 0) And (Measures.CheckData() = True) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Overridable Sub SetPrice()
        Price = m_price
    End Sub

End Class
