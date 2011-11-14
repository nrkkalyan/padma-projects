'File: Contact.vb
'Created by: Padma Priya Duvvuri
'Created on: 10-Nov-2010

Option Strict On
Option Explicit On

Public Class Contact

    'private address, email, phone objects and
    'private firstname and last name fields
    Private m_address As Address
    Private m_email As Email
    Private m_firstName As String
    Private m_lastName As String
    Private m_phone As Phone

    ''' <summary>
    ''' Constructor with 5 parameters.This is  constructor that has most
    ''' number of parameters. It is in tis constructor that all coding 
    ''' should be done.
    ''' </summary>
    ''' <param name="firstName">Input - first name</param>
    ''' <param name="lastName">Input - last name</param>
    ''' <param name="adr">Input - address object</param>
    ''' <param name="mail">Input - mail object</param>
    ''' <param name="tel">Input - phone object</param>
    Public Sub New(ByVal firstName As String, ByVal lastName As String, ByVal adr As Address, ByVal tel As Phone, ByVal mail As Email)
        m_firstName = firstName
        m_lastName = lastName
        m_address = adr
        m_phone = tel
        m_email = mail
    End Sub


    ''' <summary>
    ''' Default constuctor. It calls constructor with 5 parameters
    ''' passing the defaluts values.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Me.New(String.Empty, String.Empty, New Address, New Phone, New Email)
    End Sub


    ''' <summary>
    ''' Property related to the field m_address
    ''' Both read and write access
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property AddressData As Address

        Get
            AddressData = m_address
        End Get
        Set(ByVal value As Address)
            m_address = value
        End Set
    End Property

    ''' <summary>
    ''' Property related to the field m_email
    ''' Both read and write access
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property EmailData As Email

        Get
            EmailData = m_email
        End Get
        Set(ByVal value As Email)
            m_email = value
        End Set
    End Property


    ''' <summary>
    ''' Property related to the field m_firstname
    ''' Both read and write access
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FirstName As String

        Get
            FirstName = m_firstName
        End Get
        Set(ByVal value As String)
            m_firstName = value
        End Set
    End Property

    ''' <summary>
    ''' Property related to the field m_lastname
    ''' Both read and write access
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property LastName As String

        Get
            LastName = m_lastName
        End Get
        Set(ByVal value As String)
            m_lastName = value
        End Set
    End Property

    ''' <summary>
    ''' It creates a string fullname by adding
    ''' firstname and last name
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property FullName As String
        Get
            FullName = m_firstName + " " + m_lastName
        End Get
    End Property


    ''' <summary>
    ''' Property related to the field m_phone
    ''' Both read and write access
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PhoneData As Phone
        Get
            PhoneData = m_phone
        End Get
        Set(ByVal value As Phone)
            m_phone = value
        End Set
    End Property


    ''' <summary>
    '''  Delivers a formatted string with data stored in the object. The values will
    '''  appear as columns. 
    ''' </summary>
    ''' <returns>formatted string </returns>
    ''' <remarks></remarks>
    Public Overrides Function ToString() As String
        Dim str As String
        str = String.Format("{0,-15} {1} {2} {3}", FullName, m_address.ToString(), m_phone.ToString(), m_email.ToString())
        Return str
    End Function

End Class
