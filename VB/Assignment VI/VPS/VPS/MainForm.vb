'File Name: MainForm.vb
'Created by: Padma Priya Duvvuri
'Created on: 12-Nov-2011
'Updated on: 02-Dec-2011

Option Strict On
Option Explicit On

Public Class MainForm
    'creates the customerMngr private object
    Private customerMngr As CustomerManager
    'fields to store the values
    Private weight As Double = 0D
    Private lenght As Double = 0D
    Private widthValue As Double = 0D
    Private thickness As Double = 0D

    'form initialization
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'My initialization
        MyInitialization()
        customerMngr = New CustomerManager()

    End Sub

    ''' <summary>
    ''' clears the listbox and updates it with the customer values of the 
    ''' customerMngr arraylist
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateCustomerList()
        lstCustomerDetails.Items.Clear()
        cmbReceiver.Items.Clear()
        cmbSender.Items.Clear()
        Dim index As Integer
        For index = 0 To customerMngr.Count - 1 Step 1
            lstCustomerDetails.Items.Add(customerMngr.GetCustomer(index).ToString())
            'To populate the Receiver and Sender Combo boxes
            cmbReceiver.Items.Add(customerMngr.GetName(index).ToString())
            cmbSender.Items.Add(customerMngr.GetName(index).ToString())
        Next
    End Sub

    ''' <summary>
    ''' event handler for click event of Exit menu item of File menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'call the closing event of the form
        Me.Close()
    End Sub
    ''' <summary>
    ''' Event handler for click event of Add menu item of Customer Menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        'create and show the new instance of the CustomerForm
        Dim frmCustomer As New CustomerForm("Add New Customer")
        'if the user clicks OK on the customer form then call the UpdateCustomerList()
        'to populate the listbox
        If frmCustomer.ShowDialog() = DialogResult.OK Then
            customerMngr.AddCustomer(frmCustomer.CustomerData)
            UpdateCustomerList()
            frmCustomer.Dispose()
        End If
    End Sub

    ''' <summary>
    ''' Event handler for teh click event of Change menuitme of the Customer Menu.
    ''' If list box is not empty then allow the user to change details of the customer
    ''' at the selected index, else call showError() method
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ChangeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeToolStripMenuItem.Click
        'perform the update if the customer box is not empty
        If lstCustomerDetails.Items.Count <> 0 Then
            Dim frmCustomer As New CustomerForm("Update Customer Details")
            Dim index As Integer = lstCustomerDetails.SelectedIndex
            If index <> -1 Then
                frmCustomer.CustomerData = New Customer(customerMngr.GetCustomer(index).ContactData)
            Else
                MessageBox.Show("Please select an index", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            'if the customer clicks on OK button of the customer form then continue with the updation
            If frmCustomer.ShowDialog() = DialogResult.OK Then
                customerMngr.ChangeCustomer(frmCustomer.CustomerData.ContactData, lstCustomerDetails.SelectedIndex)
                UpdateCustomerList()
            End If
        Else
            'if listbox is empty show error
            ShowError()
            Return
        End If
    End Sub

    ''' <summary>
    ''' If list box is empty then user will not be able to update or delete any values.
    ''' This method is called form click event of Delete and Change menuitems of Customer menu.
    ''' </summary>
    Private Sub ShowError()
        MessageBox.Show("Customer list is empty, choose the Add customer option to add a new customer.", "", MessageBoxButtons.OK)
    End Sub

    ''' <summary>
    ''' event handler for click event of Delete menu item of Customer menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DeleteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem1.Click
        'perform the update if the customer box is not empty
        If lstCustomerDetails.Items.Count <> 0 Then
            Dim index As Integer = lstCustomerDetails.SelectedIndex
            'show error if no index is selected, otherwise call the removeCustomer method of customerMngr for
            'deleting specific customerdetails at selected index
            If index = -1 Then
                MessageBox.Show("Please select an index", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            customerMngr.RemoveCustomer(index)
            UpdateCustomerList()
        Else
            'if listbox is empty show error
            ShowError()
            Return
        End If
    End Sub

    ''' <summary>
    ''' Event handler for FormClosing event of MainForm
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MainForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'show message box to check whether user wants to close the form
        Dim result As DialogResult = MessageBox.Show("Do you want to exit the application?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        'close the form only if the user clicks on Yes button of the messagebox.
        If result = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    ''' <summary>
    ''' My initializations to set all the usercontrols to string.empty
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MyInitialization()
        lstCustomerDetails.Items.Clear()
        txtLength.Text = String.Empty
        txtThickness.Text = String.Empty
        txtWeight.Text = String.Empty
        txtWidth.Text = String.Empty
        'Set the image and deatils of Info tab to default values
        imgInfo.Image = My.Resources.Letter
        rtbDetails.Text = My.Resources.strPostCard
        'to set up the default value for combobox
        FillComboBoxes()
    End Sub

    ''' <summary>
    ''' To populate the cmbMailType combobox and sets the default
    ''' as postcard
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FillComboBoxes()
        cmbMailType.Items.AddRange([Enum].GetNames(GetType(MailType)))
        cmbMailType.SelectedIndex = MailType.Postcard
    End Sub

    ''' <summary>
    ''' Event handler for the SelectedIndexChanged event of the cmbMailType
    ''' combobox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmbMailType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMailType.SelectedIndexChanged
        If cmbMailType.SelectedIndex = 0 Then 'for Letter MailType
            imgInfo.Image = My.Resources.Letter
            rtbDetails.Text = My.Resources.strLetter
            pcboxTable.Image = My.Resources.LetterPrices
        ElseIf cmbMailType.SelectedIndex = 1 Then 'for Postcard MailType
            imgInfo.Image = My.Resources.Postcard
            rtbDetails.Text = My.Resources.strPostCard
            pcboxTable.Image = My.Resources.LetterPrices
        ElseIf cmbMailType.SelectedIndex = 2 Then 'for Package MailType
            imgInfo.Image = My.Resources.Package
            rtbDetails.Text = My.Resources.strPackageParcel
            pcboxTable.Image = My.Resources.PackagePrices
        ElseIf cmbMailType.SelectedIndex = 3 Then 'for Parcel MailType
            imgInfo.Image = My.Resources.Parcel
            rtbDetails.Text = My.Resources.strPackageParcel
            pcboxTable.Image = My.Resources.PackagePrices
        End If
    End Sub

    ''' <summary>
    ''' Event hadler for the Click event of the OK button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Dim mailObj As MailItem = Nothing
        'switch case to select different mail types
        Select Case cmbMailType.SelectedIndex
            'for Letter Type
            Case MailType.Letter
                ReadAndValidateInput(weight, lenght, widthValue, thickness)
                Dim measures As MeasureData = New MeasureData(lenght, widthValue, thickness)
                mailObj = New Letter(weight, measures)
                If mailObj.CheckData() = True Then
                    rtbPostage.Text = My.Resources.strSwedishKronar + mailObj.ToString()
                Else
                    MessageBox.Show(My.Resources.strError, My.Resources.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                'for Package Type
            Case MailType.Package
                ReadAndValidateInput(weight, lenght, widthValue, thickness)

                Dim measures As MeasureData = New MeasureData(lenght, widthValue, thickness)
                mailObj = New Package(weight, measures)
                If mailObj.CheckData() = True Then
                    rtbPostage.Text = My.Resources.strSwedishKronar + mailObj.ToString()
                Else
                    MessageBox.Show(My.Resources.strError, My.Resources.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                'for Parcel Type
            Case MailType.Parcel
                ReadAndValidateInput(weight, lenght, widthValue, thickness)
                Dim measures As MeasureData = New MeasureData(lenght, widthValue, thickness)
                mailObj = New Parcel(weight, measures)
                If mailObj.CheckData() = True Then
                    rtbPostage.Text = My.Resources.strSwedishKronar + mailObj.ToString()
                Else
                    MessageBox.Show(My.Resources.strError, My.Resources.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                'For Postcard Type
            Case MailType.Postcard
                mailObj = New PostCard()
                If mailObj.CheckData() = True Then
                    rtbPostage.Text = My.Resources.strSwedishKronar + mailObj.ToString()
                Else
                    MessageBox.Show(My.Resources.strError, My.Resources.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
        End Select

        ' End If
    End Sub

    ''' <summary>
    ''' This method validates the input fields of the forma nd converts them to double values.
    ''' If all fields are valid as double values it returns true
    ''' </summary>
    ''' <param name="weight"></param>
    ''' <param name="length"></param>
    ''' <param name="width"></param>
    ''' <param name="thickness"></param>
    ''' <returns>true if all fields are valid and false otherwise</returns>
    ''' <remarks></remarks>
    Private Function ReadAndValidateInput(ByRef weight As Double, ByRef length As Double, ByRef width As Double, ByRef thickness As Double) As Boolean
        Dim weightValid As Boolean = InputUtility.GetDouble(txtWeight.Text, weight)
        Dim lengthValid As Boolean = InputUtility.GetDouble(txtLength.Text, length)
        Dim widthValid As Boolean = InputUtility.GetDouble(txtWidth.Text, width)
        Dim thicknessValid As Boolean = InputUtility.GetDouble(txtThickness.Text, thickness)

        If thicknessValid And weightValid And lengthValid And thicknessValid Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Event handler for the click event of the Help tool strip menu item
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        AboutBox.Show() 'shows the AboutBox
    End Sub

    ''' <summary>
    ''' Event handler for the SelectedIndexChange event of the cmbSender 
    ''' combobox. It assigns the values to the lables of the From groupbox.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmbSender_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSender.SelectedIndexChanged
        lstCustomerDetails.SelectedIndex = cmbSender.SelectedIndex
        lblSenderName.Text = customerMngr.GetCustomer(lstCustomerDetails.SelectedIndex).ContactData.FullName
        lblSenderStreetAdr.Text = customerMngr.GetCustomer(lstCustomerDetails.SelectedIndex).ContactData.AddressData.Street
        lblSendPostCity.Text = customerMngr.GetCustomer(lstCustomerDetails.SelectedIndex).ContactData.AddressData.ZipCode _
            + customerMngr.GetCustomer(lstCustomerDetails.SelectedIndex).ContactData.AddressData.City
        lblSenderCountry.Text = customerMngr.GetCustomer(lstCustomerDetails.SelectedIndex).ContactData.AddressData.Country.ToString()
    End Sub

    ''' <summary>
    ''' Event handler for the SelectedIndexChange event of the cmbReciever
    ''' combobox. It assigns the values to the lables of the To groupbox.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmbReceiver_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReceiver.SelectedIndexChanged
        lstCustomerDetails.SelectedIndex = cmbReceiver.SelectedIndex
        lblReceiverName.Text = customerMngr.GetCustomer(lstCustomerDetails.SelectedIndex).ContactData.FullName
        lblRecStreetAdr.Text = customerMngr.GetCustomer(lstCustomerDetails.SelectedIndex).ContactData.AddressData.Street
        lblRecPostCity.Text = customerMngr.GetCustomer(lstCustomerDetails.SelectedIndex).ContactData.AddressData.ZipCode _
            + customerMngr.GetCustomer(lstCustomerDetails.SelectedIndex).ContactData.AddressData.City
        lblReceiverCountry.Text = customerMngr.GetCustomer(lstCustomerDetails.SelectedIndex).ContactData.AddressData.Country.ToString()
    End Sub
End Class