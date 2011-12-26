' File Name: CustomerContacts.vb
' Created By: Padma Priya Duvvuri
' Created On: 23-Dec-2011

Option Explicit On
Option Strict On

''' <summary>
''' This class stores the information about a customer
''' </summary>
Public Class CustomerContacts

    'Instance variables
    Private m_firstName As String 'first name of customer
    Private m_lastName As String 'last name of customer
    Private m_phone As String 'phone nubmer of customer
    Private m_email As String 'email of customer


    ''' <summary>
    ''' Read and Write property for m_firstName
    ''' </summary>
    Public Property FirstName() As String
        Get
            Return m_firstName
        End Get
        Set(ByVal value As String)
            m_firstName = value
        End Set
    End Property

    ''' <summary>
    ''' Read and Write property for m_lastName
    ''' </summary>
    Public Property LastName() As String
        Get
            Return m_lastName
        End Get
        Set(ByVal value As String)
            m_lastName = value
        End Set
    End Property

    ''' <summary>
    ''' Read only property to get Full name of the customer
    ''' </summary> 
    Public ReadOnly Property FullName() As String
        Get
            Return m_firstName & " " & m_lastName
        End Get
    End Property

    ''' <summary>
    ''' Read and Write property for m_email
    ''' </summary> 
    Public Property Email() As String
        Get
            Return m_email
        End Get
        Set(ByVal value As String)
            m_email = value
        End Set
    End Property
    ''' <summary>
    ''' Read and Write property for m_phone
    ''' </summary> 
    Public Property Phone() As String
        Get
            Return m_phone
        End Get
        Set(ByVal value As String)
            m_phone = value
        End Set
    End Property

    ''' <summary>
    ''' Constructor that takes 4 parameters and sets the values
    ''' </summary>
    ''' <param name="firstName">first name of customer</param>
    ''' <param name="lastName">last name of customer</param>
    ''' <param name="phone">phone number of the customer</param>
    ''' <param name="email">email of the customer</param>
    Public Sub New(ByVal firstName As String, ByVal lastName As String, ByVal phone As String, ByVal email As String)
        m_firstName = firstName
        m_lastName = lastName
        m_phone = phone
        m_email = email
    End Sub

    ''' <summary>
    ''' Defaults constructor that calls constructor having 4 parameters
    ''' </summary>
    Public Sub New()
        Me.New(String.Empty, String.Empty, String.Empty, String.Empty)
    End Sub

    ''' <summary>
    ''' assigns the values of string array to customer contact details
    ''' </summary>
    ''' <param name="details">array of string containing customerInfo</param>
    Public Sub New(ByVal details As String())
        m_firstName = details(0)
        m_lastName = details(1)
        m_phone = details(2)
        m_email = details(3)
    End Sub

    ''' <summary>
    ''' overrides the ToString() method to give formatted string having customer details
    ''' </summary>
    ''' <returns>formatted strings</returns>
    Public Overrides Function ToString() As String
        Dim str As String = String.Format("{0} ,{1} ,{2,10} , {3,20}", m_firstName, m_lastName, m_phone.ToString(), m_email.ToString())
        Return str
    End Function
End Class
