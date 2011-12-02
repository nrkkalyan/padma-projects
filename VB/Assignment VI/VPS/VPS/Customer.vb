'File: Customer.vb
'Created by: Padma Priya Duvvuri
'Created on: 10-Nov-2010

Option Strict On
Option Explicit On

Public Class Customer
    'private fields
    Private m_contact As Contact
    Private m_id As String

    ''' <summary>
    ''' constructor that takes 2 parameters.
    ''' And adds id for the customer
    ''' </summary>
    ''' <param name="contact">the contact object</param>
    ''' <param name="id">id for the customer</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal contact As Contact, ByVal id As String)
        m_contact = contact
        m_id = id
    End Sub

    ''' <summary>
    ''' constructor that takes 1 parameter.
    ''' It calls the constructor with 2 parameters
    ''' </summary>
    ''' <param name="customerIn">Input - customer object</param>
    Public Sub New(ByVal customerIn As Customer)
        Me.New(customerIn.ContactData, customerIn.ID)
    End Sub

    ''' <summary>
    ''' default constructor that creates a new contact 
    ''' object
    ''' </summary>
    Public Sub New()
        Me.New(New Contact)
    End Sub

    ''' <summary>
    ''' constructor with one parameter which calls the constructor
    ''' with two parameters passing default value for id
    ''' </summary>
    ''' <param name="contactIn"></param>
    Public Sub New(ByVal contactIn As Contact)
        Me.New(contactIn, String.Empty)
    End Sub

    ''' <summary>
    ''' Property related to the field contact object
    ''' Both read and write access
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ContactData As Contact
        Get
            Return m_contact
        End Get
        Set(ByVal value As Contact)
            m_contact = value
        End Set
    End Property

    ''' <summary>
    ''' Property related to the field m_id
    ''' Both read and write access
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ID As String
        Get
            Return m_id
        End Get
        Set(ByVal value As String)
            m_id = value
        End Set
    End Property


    ''' <summary>
    '''  Delivers a formatted string with data stored in the object. The values will
    '''  appear as columns. 
    ''' </summary>
    ''' <returns>formatted string </returns>
    ''' <remarks></remarks>
    Public Overrides Function ToString() As String
        Return m_id + "   " + m_contact.ToString()
    End Function
End Class
