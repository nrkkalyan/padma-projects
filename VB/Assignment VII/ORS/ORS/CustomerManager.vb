' File Name: CustomerManager.vb
' Created By: Padma Priya Duvvuri
' Created On: 23-Dec-2011

Option Explicit On
Option Strict On

''' <summary>
''' A manager class that acts as a media between MainForm and the CustomerContacts Class
''' </summary>
Public Class CustomerManager
    'private arraylist to store customer details
    Private m_customers As ArrayList
    Private m_names As ArrayList

    ''' <summary>
    ''' default constructor. It creates a new arraylist object.
    ''' </summary>
    Public Sub New()
        m_customers = New ArrayList()
        m_names = New ArrayList()
    End Sub

    ''' <summary>
    ''' Read and Write propety for customers arraylist
    ''' </summary>
    Public Property Customers() As ArrayList
        Get
            Return m_customers
        End Get
        Set(ByVal value As ArrayList)
            m_customers = value
        End Set
    End Property

    ''' <summary>
    ''' Read and Write propery for names arraylist
    ''' </summary>
    Public Property Names() As ArrayList
        Get
            Return m_names
        End Get
        Set(ByVal value As ArrayList)
            m_names = value
        End Set
    End Property

    ''' <summary>
    ''' implementd if needed.
    ''' </summary>
    Public Property contact() As CustomerContacts
        Get
            Return m_contact
        End Get
        Set(ByVal value As CustomerContacts)
            m_contact = Value
        End Set
    End Property
    Private m_contact As CustomerContacts


    ''' <summary>
    ''' It counts the number of customers objects that are 
    ''' present in the arraylist.
    ''' </summary>
    ''' <returns>no.of customers present</returns>
    Public ReadOnly Property CountCustomers() As Integer
        Get
            Return m_customers.Count
        End Get
    End Property


    ''' <summary>
    ''' It stores the new customer details entered by the user, and returns
    ''' true if added.
    ''' </summary>
    ''' <param name="customerIn">Input - customer details</param>
    ''' <returns>True when the new customer is added</returns>
    Public Function AddCustomer(ByVal customerIn As CustomerContacts) As Boolean
        m_customers.Add(customerIn)
        m_names.Add(customerIn.FullName)
        Return True
    End Function
    ''' <summary>
    ''' validates the index of the array list.
    ''' </summary>
    ''' <param name="index">selected index</param>
    ''' <returns>true if index is less than the arraysize</returns>
    Private Function IsValidIndex(ByVal index As Integer) As Boolean
        If index >= 0 AndAlso index <= CountCustomers Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' If the index is valid then it will allow the updation 
    ''' of the fields
    ''' </summary>
    ''' <param name="contactIn">details of selected customer</param>
    ''' <param name="index">selected index</param>
    ''' <returns>true if value is changed</returns>
    Public Function ChangeCustomer(ByVal contactIn As CustomerContacts, ByVal index As Integer) As Boolean
        If IsValidIndex(index) Then

            Dim str As String = m_customers(index).ToString()
            Dim details As String() = InputUtility.GetWords(contactIn.ToString())
            'create a new customercontacts object with selected string values
            Dim customer As New CustomerContacts(details)
            m_customers.RemoveAt(index)
            m_names.RemoveAt(index)
            m_customers.Insert(index, customer)
            m_names.Insert(index, customer.FullName)
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' If index is valid then it will remove that customer 
    ''' from the arraylist.
    ''' </summary>
    ''' <param name="index">index at which customer need to be deleted</param>
    ''' <returns></returns>
    Public Function RemoveCustomer(ByVal index As Integer) As Boolean
        If IsValidIndex(index) Then
            m_customers.RemoveAt(index)
            m_names.RemoveAt(index)
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' returns the customer object at the selected 
    ''' index of the customers arraylist
    ''' </summary>
    ''' <param name="index">selected index by the user</param>
    ''' <returns>customer object</returns>
    Public Function GetCustomer(ByVal index As Integer) As CustomerContacts
        Return DirectCast(m_customers(index), CustomerContacts)
    End Function


    ''' <summary>
    ''' Gets the value of string at a perticular index of names arrayList
    ''' </summary>
    ''' <param name="index">index</param>
    ''' <returns>a name as string</returns>
    Public Function GetName(ByVal index As Integer) As String
        Return DirectCast(m_names(index), String)
    End Function

End Class
