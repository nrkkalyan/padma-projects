'File: MailItem.vb
'Created by: Padma Priya Duvvuri
'Created on: 02-Dec-2010

Option Strict On
Option Explicit On

''' <summary>
''' This is the base class for all other classes. This class has instance of 
''' Customer class, MeasureData class and MailType enum class
''' </summary>
''' <remarks></remarks>
Public Class MailItem
    'to store the values 
    Private m_measures As MeasureData
    Private m_price As Decimal
    Private m_receiver As Customer
    Private m_sender As Customer
    Private m_weight As Double
    Private m_mailType As MailType

    ''' <summary>
    ''' Constructor having 2 variables
    ''' </summary>
    ''' <param name="weight"></param>
    ''' <param name="measures"></param>
    ''' <remarks></remarks>
    Sub New(ByVal weight As Double, ByVal measures As MeasureData)
        m_weight = weight
        m_measures = measures
    End Sub

    ''' <summary>
    ''' Reads and writes property for m_measurs variable
    ''' of customer datatype
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Measures As MeasureData
        Get
            Return m_measures
        End Get
        Set(ByVal value As MeasureData)
            m_measures = value
        End Set
    End Property

    ''' <summary>
    ''' Reads and writes property for m_receiver variable
    ''' of Customer datatype
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Receiver As Customer
        Get
            Return m_receiver
        End Get
        Set(ByVal value As Customer)
            m_receiver = value
        End Set
    End Property

    ''' <summary>
    ''' Read and write property for m_mailType of
    ''' MailType datatype
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property MailType As MailType
        Get
            Return m_mailType
        End Get
        Set(ByVal value As MailType)
            m_mailType = value
        End Set
    End Property

    ''' <summary>
    ''' Read and writer property for m_price variable
    ''' of Decimal datatype
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Price As Decimal
        Get
            Return CDec(m_price)
        End Get
        Set(ByVal value As Decimal)
            m_price = value
        End Set
    End Property

    ''' <summary>
    ''' Read and Write property for m_sender
    ''' of Customer datatype
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Sender As Customer
        Get
            Return m_sender
        End Get
        Set(ByVal value As Customer)
            m_sender = value
        End Set
    End Property

    ''' <summary>
    ''' read and writer property for m_weight of
    ''' Double datatype
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Weight As Double
        Get
            Return m_weight
        End Get
        Set(ByVal value As Double)
            m_weight = value
        End Set
    End Property

    ''' <summary>
    ''' Ovveriadle CheckData() method which allows other classes
    ''' to override this method
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overridable Function CheckData() As Boolean
        If (m_weight > 0) And (Measures.CheckData() = True) Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' overridable SetPrice() method which allows other
    ''' classes to override this method
    ''' </summary>
    ''' <remarks></remarks>
    Public Overridable Sub SetPrice()
        Price = m_price
    End Sub

End Class
