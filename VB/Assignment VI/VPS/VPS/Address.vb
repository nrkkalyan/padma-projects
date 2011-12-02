'File: Address.vb
'Created by: Padma Priya Duvvuri
'Created on: 10-Nov-2010

Option Strict On
Option Explicit On

''' <summary>
''' This class stores the information of Adress of the customer.
''' It calls list of enums from the countries.
''' </summary>
''' <remarks></remarks>
Public Class Address
    'declaring fields
    Private m_city As String
    Private m_country As Countries
    Private m_street As String
    Private m_strErrMessage As String
    Private m_zipCode As String

    'property to read and write m_city
    Public Property City() As String
        Get
            Return m_city
        End Get
        Set(ByVal value As String)
            m_city = value
        End Set
    End Property

    'property to read and write m_country
    Public Property Country() As Countries
        Get
            Return m_country
        End Get
        Set(ByVal value As Countries)
            m_country = value
        End Set
    End Property


    'property to read and write m_street
    Public Property Street() As String
        Get
            Return m_street
        End Get
        Set(ByVal value As String)
            m_street = value
        End Set
    End Property

    'property to read and write error message
    Public Property ErrorMessage() As String
        Get
            Return m_strErrMessage
        End Get
        Set(ByVal value As String)
            m_strErrMessage = value
        End Set
    End Property

    'property to read and write m_zipcode
    Public Property ZipCode() As String
        Get
            Return m_zipCode
        End Get
        Set(ByVal value As String)
            m_zipCode = value
        End Set
    End Property

    'defining constructors

    ''' <summary>
    ''' Consturctor with 4 parameters. This is constuctor that has most
    ''' number of paramets. It is in this constructor that all coding should
    ''' be done
    ''' </summary>
    ''' <param name="street">Input - street name</param>
    ''' <param name="zip">Input - zipcode</param>
    ''' <param name="city">Input - city name</param>
    ''' <param name="country">Input - country name</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal street As String, ByVal zip As String, ByVal city As String, ByVal country As Countries)
        m_street = street
        m_city = city
        m_zipCode = zip
        m_country = country
    End Sub

    ''' <summary>
    ''' Consturctor with 3 parameters. this consturctors calls the constructor with 
    ''' 4 parameters passing default value for country
    ''' </summary> 
    ''' <param name="street">Input - street name</param>
    ''' <param name="zip">Input - zipcode</param>
    ''' <param name="city">Input - city name</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal street As String, ByVal zip As String, ByVal city As String)
        Me.New(street, zip, city, Countries.Sverige)
    End Sub

    ''' <summary>
    ''' It is default constructor - calls the consturctor with 3 parameters,
    ''' using default values
    ''' </summary> 
    ''' <remarks></remarks>
    Public Sub New()
        Me.New(String.Empty, String.Empty, String.Empty)
    End Sub

    ''' <summary>
    ''' to perform validation for street and city names
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CheckIndex() As Boolean
        If (InputUtility.CheckString(m_city) = False) Then
            m_strErrMessage = "Enter proper city name"
            Return False
        ElseIf (InputUtility.CheckString(m_street) = False) Then
            m_strErrMessage = "Street name cannot be empty"
            Return False
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' replaces the '_' char of the country name 
    ''' if it has any
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetCountryString() As String
        Dim strCountry As String
        strCountry = Replace(Country.ToString(), "_", " ")
        Return strCountry
    End Function

    ''' <summary>
    '''  Delivers a formatted string with data stored in the object. The values will
    '''  appear as columns. 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function ToString() As String
        Dim str As String
        str = String.Format("{0,-10} {1,-5} {2,-8} {3,-13}", m_street, m_zipCode, m_city, GetCountryString())
        Return str
    End Function
End Class
