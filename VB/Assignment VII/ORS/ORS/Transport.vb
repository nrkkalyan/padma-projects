' File Name: CustomerContacts.vb
' Created By: Padma Priya Duvvuri
' Created On: 22-Dec-2011

Option Explicit On
Option Strict On

''' <summary>
''' Base class for Bus, Train and Flight Classes
''' </summary>
Public Class Transport
    'Instance variables
    Private m_transportNumber As String 'number or ID of transport
    Private m_fromStation As Stations  ' from station
    Private m_toStation As Stations ' to station
    Private timeOfTransport As DateTime ' time of transport
    Private m_priceAdult As Decimal  'ticket price for adult
    Private m_priceChild As Decimal 'ticket price for child

    ''' <summary>
    ''' Read and Write property for m_transportNumber
    ''' </summary>
    Public Property TransportationNumber() As String
        Get
            Return m_transportNumber
        End Get
        Set(ByVal value As String)
            m_transportNumber = value
        End Set
    End Property

    ''' <summary>
    ''' Read and Write property for fromStation
    ''' </summary>
    Public Property FromStation() As Stations
        Get
            Return m_fromStation
        End Get
        Set(ByVal value As Stations)
            m_fromStation = value
        End Set
    End Property

    ''' <summary>
    ''' Read and Writer property for toStation
    ''' </summary>
    Public Property ToStation() As Stations
        Get
            Return m_toStation
        End Get
        Set(ByVal value As Stations)
            m_toStation = value
        End Set
    End Property

    ''' <summary>
    ''' Read and Write property for timeOfTransport
    ''' </summary>
    Public Property Time() As DateTime
        Get
            Return timeOfTransport
        End Get
        Set(ByVal value As DateTime)
            timeOfTransport = value
        End Set
    End Property

    ''' <summary>
    ''' Read and Write property for priceAdult
    ''' </summary>
    Public Property PriceAdult() As Decimal
        Get
            Return m_priceAdult
        End Get
        Set(ByVal value As Decimal)
            m_priceAdult = value
        End Set
    End Property

    ''' <summary>
    ''' Read and Write property for priceChild
    ''' </summary>
    Public Property PriceChild() As Decimal
        Get
            Return m_priceChild
        End Get
        Set(ByVal value As Decimal)
            m_priceChild = value
        End Set
    End Property

    ''' <summary>
    ''' Constructor that takes 6 parameters,It initializes the values
    ''' </summary>
    ''' <param name="number">Bus Number</param>
    ''' <param name="from">From station</param>
    ''' <param name="toStation">to station</param>
    ''' <param name="time">time of departure</param>
    ''' <param name="priceAdult">price for adult</param>
    ''' <param name="priceChildren">price for children</param>
    Public Sub New(ByVal number As String, ByVal from As Stations, ByVal toStation As Stations, ByVal time As DateTime, ByVal priceAdult As Decimal, ByVal priceChildren As Decimal)
        m_transportNumber = number
        m_fromStation = from
        m_toStation = toStation
        timeOfTransport = time
        m_priceAdult = PriceAdult
        m_priceChild = priceChildren
    End Sub

    ''' <summary>
    ''' Default constructor
    ''' </summary>
    Public Sub New()
        Me.New(String.Empty, Stations.Stockholm, Stations.Paris, DateTime.Now, 0, 0)
    End Sub

    ''' <summary>
    ''' Constructor that takes one parameter, It calls base class 
    ''' constructor to set the values
    ''' </summary>
    ''' <param name="price">Price for adult</param>
    Public Sub New(ByVal price As Decimal)
        Me.New(String.Empty, Stations.Stockholm, Stations.Paris, DateTime.Now, price, price * 0.5D)
    End Sub

    ''' <summary>
    ''' Overrides the string to give formatted string having all details that are provided for a Transport
    ''' </summary>
    ''' <returns>a fromatted string</returns>
    Public Overrides Function ToString() As String
        Dim str As String = String.Format("{0} ,{1},{2},{3},{4},{5}", m_transportNumber, m_fromStation.ToString(), m_toStation.ToString(), timeOfTransport.ToString("hh:mm tt"), m_priceAdult.ToString("#.##"), _
         m_priceChild.ToString("#.##"))
        Return str
    End Function
End Class

