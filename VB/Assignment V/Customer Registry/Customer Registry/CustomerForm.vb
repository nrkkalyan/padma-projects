'File Name: CustomerForm.vb
'Created by: Padma Priya Duvvuri
'Created on: 11-Nov-2011

Option Strict On
Option Explicit On

Public Class CustomerForm
    'customer object receiving input and/or sending output
    Private m_customer As Customer
    'flag to handle closing of the form
    Private closeForm As Boolean

    'constructor with one parameter(title of the form)
    Public Sub New(ByVal title As String)
        InitializeComponent()
        'other initializations
        Me.Text = title
        closeForm = True
        'populate the combo box with country names
        cmbCountry.Items.AddRange([Enum].GetNames(GetType(Countries)))
        cmbCountry.SelectedIndex = Countries.Sverige
    End Sub

    ''' <summary>
    ''' Property CustomerData to read customer values, with access to
    ''' read and write
    ''' </summary>
    ''' <value></value>
    ''' <returns>Customer object</returns>
    ''' <remarks></remarks>
    Public Property CustomerData As Customer
        Get
            CustomerData = m_customer
        End Get
        Set(ByVal value As Customer)
            If IsNothing(value) = False Then
                m_customer = value
                'Update input controls
                UpdateGUI()
            End If
        End Set
    End Property
    ''' <summary>
    ''' update controls of customerForm to the m_customer object values
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateGUI()
        txtCellPhone.Text = m_customer.ContactData.PhoneData.Cell
        txtHomePhone.Text = m_customer.ContactData.PhoneData.Home
        txtFirstName.Text = m_customer.ContactData.FirstName
        txtLastName.Text = m_customer.ContactData.LastName
        txtCity.Text = m_customer.ContactData.AddressData.City
        txtStreet.Text = m_customer.ContactData.AddressData.Street
        txtZip.Text = m_customer.ContactData.AddressData.ZipCode
        txtPersonalEmail.Text = m_customer.ContactData.EmailData.Personal
        txtProfessionalEmail.Text = m_customer.ContactData.EmailData.Work
        cmbCountry.SelectedIndex = DirectCast(m_customer.ContactData.AddressData.Country, Integer)
    End Sub

    ''' <summary>
    ''' Event handler for formclosing event of the customer form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CustomerForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If closeForm Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        'validate the user given values for Name fields and phone number
        If ValidateInputFields() = False Then
            Return
        End If
        'if no customer is present then create a new customer
        If IsDBNull(m_customer) Then
            m_customer = New Customer()
        End If
        'passing the values given by the user to the controls
        'get selected country
        Dim selectedCountry As Countries = CType(DirectCast(CType(cmbCountry.SelectedIndex, Countries), Integer), Countries)
        m_customer.ContactData.AddressData = New Address(txtStreet.Text, txtZip.Text, txtCity.Text, selectedCountry)
        m_customer.ContactData.EmailData = New Email(txtProfessionalEmail.Text, txtPersonalEmail.Text)
        m_customer.ContactData.PhoneData = New Phone(txtHomePhone.Text, txtCellPhone.Text)
        m_customer.ContactData.FirstName = txtFirstName.Text
        m_customer.ContactData.LastName = txtLastName.Text
        'return the dialog result value OK so as to perform next calculations
        Me.DialogResult = DialogResult.OK
    End Sub

    ''' <summary>
    ''' validate firstname, lastname and telephone numbers
    ''' </summary>
    ''' <returns>returns true if all fields are validated, false otherwise</returns>
    ''' <remarks></remarks>
    Private Function ValidateInputFields() As Boolean
        'calls checkstring method of inpututility class
        If InputUtility.CheckString(txtFirstName.Text) = False Then
            MessageBox.Show("First name cannot be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblFirstName.Text = "First Name*"
            Return False
        End If
        If InputUtility.CheckString(txtLastName.Text) = False Then
            MessageBox.Show("First name cannot be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblLastName.Text = "Last Name*"
            Return False
        End If
        'validation for the phone numbers
        If ValidationForPhoneNumbers() = False Then
            Return False
        End If
        Return True
    End Function

    ''' <summary>
    ''' checks whehter atleast one telepone number is provided or not.And validates the
    ''' presented by the user
    ''' </summary>
    ''' <returns>true if atleast one phone number is given and validates the given
    ''' user input</returns>
    ''' <remarks></remarks>
    Private Function ValidationForPhoneNumbers() As Boolean
        if (txtCellPhone.Text == string.Empty) and (txtHomePhone.Text == string.Empty) then
            MessageBox.Show("Atleast one telephone number should be provided", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If
        If txtCellPhone.Text <> String.Empty Then
            Return ValidatePhoneNumber(txtCellPhone.Text)
        End If
        If txtHomePhone.Text <> String.Empty Then
            Return ValidatePhoneNumber(txtHomePhone.Text)
        End If
        Return True
    End Function

    ''' <summary>
    ''' If atleast one phone number is provided, converts the value to long
    ''' by calling GetLong method of InputUtility
    ''' </summary>
    ''' <param name="phone">string value of the user input for phone number</param>
    ''' <returns>true if conversion is successful</returns>
    ''' <remarks></remarks>
    Private Function ValidatePhoneNumber(ByVal phone As String) As Boolean
        Dim number As Long
        Dim isValid As Boolean = InputUtility.GetLong(phone, number)
        If (isValid) Then
                return true
        Else
            MessageBox.Show("Invalid Phone Format", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If
    End Function

    ''' <summary>
    ''' event handler for click event of cancel button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class