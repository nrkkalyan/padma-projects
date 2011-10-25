'File Name: MainForm.vb
'Created by: Padma Priya Duvvuri
'Created on: 04-Oct-2011



Public Class MainForm
    'Test variables to test the application
    Private revenue As Double = 0.0 'accumulate every time a new
    Private Const totalNumOfSeats As Integer = 240 'default number of seats
    Private numOfReservedSeats As Integer = 0 'Increase by 1 when a reservatio is made

    'Constructor - a good place for initializations and creation of the objects 
    'used as fields, eg: seatMngr

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' My initializations
        InitializeGUI()

    End Sub

    ''' <summary>
    ''' Clear the input and output controls(if needed)
    ''' Do other inializatios for example, select one of the radiobuttons as default.
    ''' </summary>
    ''' <remarks>This is to be called from the constructor, AFTER the call to
    ''' InitializeComponent</remarks>
    Private Sub InitializeGUI()

        rbtnReserved.Checked = True
        lstReservations.Items.Clear()
        txtName.Text = String.Empty
        txtPrice.Text = String.Empty

        txtName.Focus() ' focus is set to the name field
        txtName.SelectAll()


        lblNumOfReserved.Text = String.Empty
        lblNumOfSeats.Text = String.Empty
        lblNumOfVacant.Text = String.Empty
        lblTotalRevenue.Text = String.Empty



    End Sub

    ''' <summary>
    ''' Event-handler method for the Click-event of the button,when the user 
    ''' clicks the button, this method will be executed automatically.
    ''' Call the ReadAndValidateInput method, save its return value in a Boolean variable.
    ''' If the return value is true, tehn call the UpdateGUI method to display the results.
    ''' </summary>
    ''' <param name="sender">Reference to the object that has fired the Click event (the button)</param>
    ''' <param name="e">Contains information about the event</param>
    ''' <remarks>Send and e are part of event delegate hadling</remarks>
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        'declaring variable to store user input
        Dim customerName As String = String.Empty
        Dim seatPrice As Double = 0.0

        'to validate user input
        Dim inputOk As Boolean = ReadAndValidateInput(customerName, seatPrice)

        If inputOk = True Then
            numOfReservedSeats = numOfReservedSeats + 1

            revenue = revenue + seatPrice
            UpdateGUI(customerName, seatPrice) 'perform calculations and updateGUI

            'calling SeatCheck method
            SeatCheck()

            'highlight text box for next values
            txtName.Focus()
            txtName.SelectAll()

        End If

    End Sub

    ''' <summary>
    ''' This method checks for seats that can be allocated. And if available 
    ''' seats are over then will display that info to the user
    ''' </summary>
    ''' <remarks>As of now the text boxes and buttons are disabled, they will be implemented in later
    ''' versions when the cancellation of reservation is available</remarks>
    Private Sub SeatCheck()
        If (numOfReservedSeats >= totalNumOfSeats) Then

            MessageBox.Show("This is the last seat, No more left for reservation!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtName.Enabled = False
            txtPrice.Enabled = False
            ' as of now this button is disabled, in later versions when Cancellation is implemented code will be changed
            btnOK.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' This updates GUI to show the updated values, by perfoming necessary calculations if needed.
    ''' </summary>
    ''' <param name="customerName">Receives customer name after performing the validations</param>
    ''' <param name="seatPrice">Receives teh price after the validation</param>
    ''' <remarks>It adds name and price to the listbox for display</remarks>
    Private Sub UpdateGUI(ByVal customerName As String, ByVal seatPrice As Double)

        UpdateLabels() ' to update lable values

        Dim str As String = String.Format("{0,-10}{1,-15} {2,-20} {3,-50}", 0, "Reserved", seatPrice.ToString("F"), customerName)

        lstReservations.Items.Add(str)
    End Sub

    ''' <summary>
    ''' This method updates the labels of the output group with the values 
    ''' after the button is clicked
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateLabels()

        lblNumOfSeats.Text = Convert.ToString(totalNumOfSeats)
        lblNumOfReserved.Text = Convert.ToString(numOfReservedSeats)
        lblNumOfVacant.Text = Convert.ToString(totalNumOfSeats - numOfReservedSeats)
        lblTotalRevenue.Text = revenue.ToString("F")
    End Sub

    ''' <summary>
    ''' Parse the user input, validate and save the data for later use.
    ''' In this version, all inputs are saved in local variables and therefore values are passed
    ''' as parameters in method calls.
    ''' this method calls two other methods to read and validate name and price respectively
    ''' </summary>
    ''' <param name="customerName">the name of the customer</param>
    ''' <param name="seatPrice">the price to be paid by the customer</param>
    ''' <returns>True if input is valid, False otherwise</returns>
    ''' <remarks></remarks>
    Private Function ReadAndValidateInput(ByRef customerName As String, ByRef seatPrice As Double) As Boolean

        Dim nameValid As Boolean = ReadAndValidateName(customerName)
        Dim priceValid As Boolean = ReadAndValidatePrice(seatPrice)

        If (nameValid And priceValid) Then
            Return True
        Else
            If nameValid = False Then
                MessageBox.Show("Invalid input in name field! Name cannot be empty, and must have atleast one character(not a blank)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtName.Focus() ' set focus to name textbox
                txtName.SelectAll() ' to select all the text present
            ElseIf priceValid = False Then
                MessageBox.Show("Invalid input in price field!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPrice.Focus() 'set focus to price textbox
                txtPrice.SelectAll() ' to select all text
            End If
            Return False
        End If
    End Function

    ''' <summary>
    ''' Check so the user has entered a text in the TextBox for name
    ''' </summary>
    ''' <param name="customerName">A string variable passing customer name inputted by the user</param>
    ''' <returns> True validation (name must have atleast one character other than
    ''' a blank space) is OK, false otherwise</returns>
    ''' <remarks></remarks>
    Private Function ReadAndValidateName(ByRef customerName As String) As Boolean
        customerName = txtName.Text

        'calling CheckString method in InputUtility Class to validate name
        Dim isInValid As Boolean = InputUtility.CheckString(customerName)
        If isInValid = False Then
            Return True
        Else

            Return False
        End If
    End Function

    ''' <summary>
    ''' Call the GetDouble method of InputUtility class to convert the text given by the user
    ''' in the price textbox.Validates and then the converted value is checked with a value >= 0 and less than or 
    ''' equal to a max ticket price (3500.00)
    ''' </summary>
    ''' <param name="seatPrice">Variable receiving the converted value</param>
    ''' <returns>True if the convertion is successful and validation is OK,False otherwise</returns>
    ''' <remarks></remarks>
    Private Function ReadAndValidatePrice(ByRef seatPrice As Double) As Boolean
        Dim str As String = txtPrice.Text

        Dim min As Double = 0.0
        Const max As Double = 3500.0 'declaring a constant for max value

        Dim isValid As Boolean = InputUtility.GetDouble(str, seatPrice, min, max)

        If isValid = True Then
            Return True
        Else

            Return False
        End If
    End Function

    ''' <summary>
    ''' Event-handler method for the CheckedChanged -event of the Reserved radiobutton, when the user 
    ''' selection this option, this method will be executed automatically
    ''' Enables the textboxes and button for the user to enter the inputs.
    ''' </summary>
    ''' <param name="sender">Reference to the object that has fired the CheckedChanged event (the Radio-button)</param>
    ''' <param name="e">Contains information about the event</param>
    ''' <remarks>Send and e are part of event delegate hadling</remarks>
    Private Sub rbtnReserved_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnReserved.CheckedChanged

        txtName.Enabled = True
        txtPrice.Enabled = True

        btnOK.Enabled = True

        txtName.Focus()
    End Sub


    ''' <summary>
    ''' Event-handler method for the CheckedChanged -event of the cancel radiobutton, when the user 
    ''' selection this option, this method will be executed automatically
    ''' Disables the textboxes and button for the user to enter the inputs.
    ''' </summary>
    ''' <param name="sender">Reference to the object that has fired the CheckedChanged event (the Radio-button)</param>
    ''' <param name="e">Contains information about the event</param>
    ''' <remarks>Send and e are part of event delegate hadling</remarks>
    Private Sub rbtnCancel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnCancel.CheckedChanged
        txtName.Enabled = False
        txtPrice.Enabled = False

        btnOK.Enabled = False
    End Sub

End Class
