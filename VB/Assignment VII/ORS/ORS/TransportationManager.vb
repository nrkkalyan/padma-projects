' File Name: CustomerContacts.vb
' Created By: Padma Priya Duvvuri
' Created On: 22-Dec-2011

Option Explicit On
Option Strict On

''' <summary>
''' A manager class that acts as a media between MainForm and the Transport Class
''' </summary>
Public Class TransportationManager
    'Instance Variables
    Private m_transportDetails As ArrayList 'arraylist to save transport details
    Private maxNoOfTransports As Integer = 100  ' max. no.of tranpsports
    Private m_transport As Transport 'transport object

    ''' <summary>
    ''' Default constuctor that initializes the arraylist
    ''' </summary>
    Public Sub New()
        m_transportDetails = New ArrayList()
    End Sub

    ''' <summary>
    ''' Read and write property for transportDetails
    ''' </summary>
    Public Property TransportDetails() As ArrayList
        Get
            Return m_transportDetails
        End Get
        Set(ByVal value As ArrayList)
            m_transportDetails = value
        End Set
    End Property

    ''' <summary>
    ''' Read and write property for maxNoOfTransports
    ''' </summary>
    Public ReadOnly Property MaxTransports() As Integer
        Get
            Return maxNoOfTransports
        End Get
    End Property


    ''' <summary>
    ''' This method checks wheter total number of transports is less than
    ''' max number of transports
    ''' </summary>
    ''' <returns>true if within range and false otherwise</returns>
    Private Function CheckTransporst() As Boolean
        If m_transportDetails.Count <= maxNoOfTransports Then
            Return True
        Else
            Return False
        End If
    End Function


    ''' <summary>
    ''' Read-only property to count no.of Transport details
    ''' </summary>
    Public ReadOnly Property CountTransport() As Integer
        Get
            Return m_transportDetails.Count
        End Get
    End Property


    ''' <summary>
    ''' Adds a new transport object to details arraylist
    ''' </summary>
    ''' <param name="transport">transport object</param>
    ''' <returns>true if new detail is added , false otherwise</returns>
    Public Function AddTransport(ByVal transport As Transport) As Boolean
        If CheckTransporst() Then
            m_transportDetails.Add(transport)
            Return True
        Else
            Return False
        End If
    End Function


    ''' <summary>
    ''' Returns details at perticular index
    ''' </summary>
    ''' <param name="index">index</param>
    ''' <returns>Transport object</returns>
    Public Function GetTransport(ByVal index As Integer) As Transport
        Return DirectCast(m_transportDetails(index), Transport)
    End Function

    ''' <summary>
    ''' Devides the perticular string and stores the values into array
    ''' of strings
    ''' </summary>
    ''' <param name="str">the string to be divided</param>
    ''' <returns>array of strings</returns>
    Public Function GetTransportationDetails(ByVal str As String) As String()

        Dim words As String() = str.Split(","c)
        Return words
    End Function

    ''' <summary>
    ''' write only property for m_transport
    ''' </summary>
    Public WriteOnly Property Transport() As Transport
        Set(ByVal value As Transport)
            m_transport = value
        End Set
    End Property

End Class
