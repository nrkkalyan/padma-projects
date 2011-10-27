'File Name: MainForm.vb
'Created by: Padma Priya Duvvuri
'Created on: 21-Oct-2011



Public Class MainForm2b
    'Test variables to test the application
    'Declare a constant for max number of rows and colums of seats in the cinema
    Private Const m_numOfRows As Integer = 7
    Private Const m_numOfCols As Integer = 7

    'Declare a reference variable of teh SeatManager type
    Private m_seatManager As SeatManager

    ''' <summary>
    ''' custructor is a special method that is automatically called
    ''' when an instance of the class is created by using the keyword
    ''' new. It is a good place for initializations and creation of the objects 
    ''' that are used as fields, e.g. m_seatManager
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' My initializations
        m_seatManager = New SeatManager(m_numOfRows, m_numOfCols)
        InitializeGUI()

    End Sub

    ''' <summary>
    ''' Clear the input and output controls(if needed)
    ''' Do other inializatios for example, select one of the radiobuttons as default.
    ''' </summary>
    ''' <remarks>This is to be called from the constructor, AFTER the call to
    ''' InitializeComponent</remarks>
    Private Sub InitializeGUI()

        lstReservations.Items.Clear()
        txtName.Text = String.Empty

        lblNumOfReserved.Text = String.Empty
        lblNumOfSeats.Text = m_seatManager.TotNumOfSeats().ToString()
        lblNumOfVacant.Text = String.Empty

        cmboxChoice.Items.AddRange([Enum].GetNames(GetType(SeatManager.DisplayOptions)))
        cmboxChoice.SelectedIndex = SeatManager.DisplayOptions.AllSeats

        UpdateGUI()

    End Sub

    ''' <summary>
    ''' Clear output controls (if needed)
    ''' Fill the listbox with infor for each seat. Each row in teh
    ''' listbox is to represent a seat
    ''' Update also the lables with values for the num of reserved/vacant
    ''' seats.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateGUI()
        lstReservations.Items.Clear() 'empty the list box

        Dim strSeatInfoStrings() As String = Nothing
        Dim selected As SeatManager.DisplayOptions = DirectCast(cmboxChoice.SelectedIndex, SeatManager.DisplayOptions)
        m_seatManager.GetSeatInfoStrings(selected, strSeatInfoStrings)

        For Each str As String In strSeatInfoStrings
            If IsNothing(str) = False Then
                lstReservations.Items.Add(str)
            End If
        Next

        UpdateLabels() 'to update the labels

    End Sub

    ''' <summary>
    ''' The user must highlight an item in the ListBox before a reservation or
    ''' cancellation can be performed. If an item in the ListBox is not 
    ''' highlighted, give an error message to the user
    ''' </summary>
    ''' <returns>true if the user selects the row, otherwise false</returns>
    ''' <remarks></remarks>
    Private Function CheckSelectedIndex() As Boolean
        If lstReservations.SelectedIndex = -1 Then
            MessageBox.Show("Please select a seat first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' Event-hanlder method for click-event ot the button. When the user clicks the buttons
    ''' this method will be executed automatically.
    ''' If the cancel Radiobutton is checked, no need to read customer name or
    ''' seatPrice
    ''' Call the method ReserveOrCancelSeat to process the reservation / cancellation
    ''' of the seat
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If CheckSelectedIndex() = True Then
            ReserveOrCancelSeat()
        Else
            Return
        End If
    End Sub

    ''' <summary>
    ''' Reserve or cancel a seat
    ''' 
    ''' If reserve radiobutton is selected then
    '''      1. If seat is reserved check with user to update or not that seat
    '''      2. If seat is empty validate  name
    '''      3. Call the reserve method of m_seatManager to reserve or update
    '''      
    ''' If cancel radiobutton is selected then
    '''      Call the cancel method of m_seatManager to canel 
    '''      
    ''' call UpdateGUI
    ''' 
    ''' </summary>
    Private Sub ReserveOrCancelSeat()
        Dim customerName As String = Nothing
        Dim price As Double = 0D

        If rbtnReserved.Checked = True Then
            If ReadAndValidateInput(customerName) = True Then
                If m_seatManager.GetSeatInfoAt(lstReservations.SelectedIndex) = "Vacant" Then
                    m_seatManager.ReserveSeat(customerName, lstReservations.SelectedIndex)
                Else
                    Dim result As DialogResult = MessageBox.Show("This seat is reserved, do you want to update it?", "Info!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    If result = DialogResult.Yes Then
                        m_seatManager.ReserveSeat(customerName, price, lstReservations.SelectedIndex)
                    End If
                End If
            Else
                Return
            End If
        End If

        If rbtnCancel.Checked = True Then
            Dim result As DialogResult = MessageBox.Show("Do you want to cancel the reservation?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
            If result = DialogResult.Yes Then
                m_seatManager.CancelSeat(lstReservations.SelectedIndex)
            End If
        End If

        UpdateGUI()
    End Sub

    ''' <summary>
    ''' This method updates the labels of the output group with the values 
    ''' after the button is clicked
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateLabels()

        lblNumOfSeats.Text = Convert.ToString(m_numOfSeats)
        lblNumOfReserved.Text = Convert.ToString(m_seatManager.GetNumReserved())
        lblNumOfVacant.Text = Convert.ToString(m_seatManager.GetNumVacant())
        If rbtnReserved.Checked Then
            btnOK.Text = "Reserve"
        End If
    End Sub

    ''' <summary>
    ''' Parse the user input, validate and save the data for later use.
    ''' this method calls other method to read and validate name
    ''' </summary>
    ''' <param name="customerName">the name of the customer</param>
    ''' <returns>True if input is valid, False otherwise</returns>
    ''' <remarks></remarks>
    Private Function ReadAndValidateInput(ByRef customerName As String) As Boolean

        Dim nameValid As Boolean = ReadAndValidateName(customerName)

        If (nameValid) Then
            Return True
        Else
            If nameValid = False Then
                MessageBox.Show("Invalid input in name field! Name cannot be empty, and must have atleast one character(not a blank)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtName.Focus() ' set focus to name textbox
                txtName.SelectAll() ' to select all the text present
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
    ''' Event-handler method for the CheckedChanged -event of the Reserved radiobutton, when the user 
    ''' selection this option, this method will be executed automatically
    ''' Enables the textboxes and button for the user to enter the inputs.
    ''' </summary>
    ''' <param name="sender">Reference to the object that has fired the CheckedChanged event (Reserve Radio-button)</param>
    ''' <param name="e">Contains information about the event</param>
    ''' <remarks>Send and e are part of event delegate hadling</remarks>
    Private Sub rbtnReserved_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnReserved.CheckedChanged

        txtName.Enabled = True
        txtPrice.Enabled = True
        If lstReservations.SelectedIndex >= 0 Then
            btnOK.Text = "Update"
        Else
            btnOK.Text = "Reserve"
        End If
    End Sub


    ''' <summary>
    ''' Event-handler method for the CheckedChanged -event of the cancel radiobutton, when the user 
    ''' selection this option, this method will be executed automatically
    ''' Disables the textboxes and button for the user to enter the inputs.
    ''' </summary>
    ''' <param name="sender">Reference to the object that has fired the CheckedChanged event (Cancel Radio-button)</param>
    ''' <param name="e">Contains information about the event</param>
    ''' <remarks>Send and e are part of event delegate hadling</remarks>
    Private Sub rbtnCancel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnCancel.CheckedChanged
        txtName.Enabled = False
        txtPrice.Enabled = False
        btnOK.Text = "Cancel Reservation"
    End Sub


    ''' <summary>
    ''' Event-handler method for the SelectedIndexChanged event of the Combobox.
    ''' The method is automatically called when the user select an entry in the combobox.
    ''' The user will be able to update or reserve the seat only when the allseats of the 
    ''' combox is selected.
    ''' </summary>
    ''' <param name="sender">The object that fired the event (combobox)</param>
    ''' <param name="e">An object containing useful information about the event.</param>

    Private Sub cmboxChoice_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmboxChoice.SelectedIndexChanged
        Dim enableOrDisable As Boolean = True

        ' Dim selected As SeatManager.DisplayOptions = CType(cmboxChoice.SelectedValue, SeatManager.DisplayOptions)
        If cmboxChoice.SelectedIndex = 1 Or cmboxChoice.SelectedIndex = 2 Then
            enableOrDisable = False
        End If

        txtName.Enabled = enableOrDisable
        txtPrice.Enabled = enableOrDisable
        btnOK.Enabled = enableOrDisable

        UpdateGUI() 'update listbox depending on the choice of the combo box
    End Sub



    ''' <summary>
    ''' Event-handler method for the SelectedIndexChanged event of the listbox.
    ''' The method is automatically called when the user select an entry in the listbox.
    ''' </summary>
    ''' <param name="sender">The object that fired the event (listbox)</param>
    ''' <param name="e">An object containing useful information about the event.</param>
    Private Sub lstReservations_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstReservations.SelectedIndexChanged
        If rbtnReserved.Checked Then
            If m_seatManager.GetSeatInfoAt(lstReservations.SelectedIndex) = "Vacant" Then
                btnOK.Text = "Reserve"
            Else
                btnOK.Text = "Update"
            End If
        Else
            btnOK.Text = "Cancel Reservation"
        End If
    End Sub

    ''' <summary>
    ''' Event handler method for the DoubleClick even of listbox index
    ''' </summary>
    ''' <param name="sender">The object that fired the event (listbox index)</param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub lstReservations_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstReservations.DoubleClick
        ReserveOrCancelSeat()
    End Sub
End Class
