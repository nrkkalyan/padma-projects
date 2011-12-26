' File Name: CustomerForm.vb
' Created By: Padma Priya Duvvuri
' Created On: 24-Dec-2011

Option Explicit On
Option Strict On

Imports System.Text.RegularExpressions

Public Class CustomerForm

    'customer object receiving input and/or sending output
    Private m_customer As CustomerContacts
    'flag to handle the closing of the form
    Private closeForm As Boolean
    Private m_fullConact As String() 'to store value of customer details 

    ''' <summary>
    ''' Property CustomerData to read customer values, with access to 
    ''' read and write
    ''' </summary>
    ''' <value></value> 
    ''' <returns>Customer object</returns>

    Public Property CustomerData() As CustomerContacts
        Get
            Return m_customer
        End Get
        Set(ByVal value As CustomerContacts)
            If value IsNot Nothing Then
                m_customer = value
            End If
            'update input controls
            UpdateGUI()
        End Set
    End Property


    ''' <summary>
    ''' update the controls of customerForm to the m_customer object values
    ''' </summary>
    Private Sub UpdateGUI()
        txtCustomerEmail.Text = m_customer.Email
        txtCustomerFirstName.Text = m_customer.FirstName
        txtCustomerLastName.Text = m_customer.LastName
        txtCustomerPhone.Text = m_customer.Phone
    End Sub

    'constructor with one parameter (title of the form)
    Public Sub New(ByVal title As String)
        InitializeComponent()
        'Other initalizations
        Me.Text = title

        closeForm = True
    End Sub

    ''' <summary>
    ''' Write only property to set the value of m_fullContact
    ''' </summary>
    Public WriteOnly Property Details() As String()
        Set(ByVal value As String())
            If value IsNot Nothing Then
                m_fullConact = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' Constructor with 2 paramerts with custom title and details of customer
    ''' </summary>
    ''' <param name="title"></param>
    ''' <param name="details"></param>
    Public Sub New(ByVal title As String, ByVal details As String())
        InitializeComponent()
        'Other initalizations
        Me.Text = title
        closeForm = True
        m_customer = New CustomerContacts(details)
        UpdateGUI()
    End Sub



    ''' <summary>
    ''' Event hadler for formclosing event event of the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Customer_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
        If closeForm Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    ''' <summary>
    ''' Event-handler to handle click event of btnCustomer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCustomer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
        'validate the user given values for Name fields and phone number
        If ValidateInputFields() = False Then
            Return
        End If
        'if no customer is present then create a new customer
        If m_customer Is Nothing Then
            m_customer = New CustomerContacts()
        End If
        'set the values inputted by the user to m_customer object
        m_customer.Email = txtCustomerEmail.Text
        m_customer.Phone = txtCustomerPhone.Text
        m_customer.FirstName = txtCustomerFirstName.Text
        m_customer.LastName = txtCustomerLastName.Text
        UpdateGUI()
        Me.DialogResult = DialogResult.OK
    End Sub


    ''' <summary>
    ''' Validates the firstname, lastname and telephone numbers.
    ''' </summary>
    ''' <returns>returns true if all the three fields are validated, false
    ''' otherwise</returns>
    Private Function ValidateInputFields() As Boolean
        'calls checkstring method of inpututility class
        If InputUtility.CheckString(txtCustomerFirstName.Text) = True Then
            MessageBox.Show("First name cannot be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            lblFirstName.Text = "First Name*"
            Return False
        End If
        If InputUtility.CheckString(txtCustomerLastName.Text) = True Then
            MessageBox.Show("Last name cannot be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            lblLastName.Text = "Last Name*"
            Return False
        End If
        'validation for phone numbers
        If Not ValidationForPhoneNumbers() Then
            Return False
        End If
        'to validate email
        If Not ValidateEmail() Then
            MessageBox.Show("Enter a valid E-mail address", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            lblLastName.Text = "Email*"
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' It validates the email.
    ''' </summary>
    ''' <returns>true if email is valid and false otherwise</returns>
    Private Function ValidateEmail() As Boolean
        Dim pattern As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|" & "0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z]" & "[a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"
        Dim match As System.Text.RegularExpressions.Match = Regex.Match(txtCustomerEmail.Text.Trim(), pattern, RegexOptions.IgnoreCase)

        If match.Success Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' checks whehter atleast one telepone number is provided or not.And validates the
    ''' presented by the user
    ''' </summary>
    ''' <returns>true if atleast one phone number is given and validates the given
    ''' user input</returns>
    Private Function ValidationForPhoneNumbers() As Boolean
        If txtCustomerPhone.Text = String.Empty Then
            MessageBox.Show("Telephone number should be provided", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblPhone.Text = "Phone/Moble*"
            Return False
        End If
        If txtCustomerPhone.Text <> String.Empty Then
            Return ValidatePhoneNumber(txtCustomerPhone.Text)
        End If

        Return True
    End Function

    ''' <summary>
    ''' If atleast one phone number is provided, converts the value to long
    ''' by calling GetLong method of InputUtility
    ''' </summary>
    ''' <param name="phone">string value of the user input for phone number</param>
    ''' <returns>true if conversion is successful</returns>
    Private Function ValidatePhoneNumber(ByVal phone As String) As Boolean
        Dim number As Long
        Dim isValid As Boolean = InputUtility.GetLong(phone, number)
        If isValid Then
            Return True
        Else
            MessageBox.Show("Invalid Phone Format", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If
    End Function

    ''' <summary>
    ''' Event handler for the click event of btnCancel to close the form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class