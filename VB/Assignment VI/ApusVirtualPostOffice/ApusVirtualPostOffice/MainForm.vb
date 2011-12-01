'File Name: MainForm.vb
'Created by: Padma Priya Duvvuri
'Created on: 12-Nov-2011

Option Strict On
Option Explicit On

Public Class MainForm
    'creates the customerMngr private object
    Private customerMngr As CustomerManager
    'form initialization
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        customerMngr = New CustomerManager()

    End Sub

    ''' <summary>
    ''' clears the listbox and updates it with the customer values of the 
    ''' customerMngr arraylist
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateCustomerList()
        lstCustomerDetails.Items.Clear()
        Dim index As Integer
        For index = 0 To customerMngr.Count - 1 Step 1
            lstCustomerDetails.Items.Add(customerMngr.GetCustomer(index).ToString())
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
End Class