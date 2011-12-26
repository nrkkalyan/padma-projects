' File Name: MainForm.vb
' Created By: Padma Priya Duvvuri
' Created On: 24-Dec-2011

Option Strict On
Option Explicit On

Imports System.Collections
Imports System.IO
Imports System.Windows.Forms
Imports System.ComponentModel

''' <summary>
''' This is the mainForm class where the actual process happens
''' </summary>
Public Class MainForm
    'Instance variables
    Private customerMngr As CustomerManager
    'To manage customer details
    Private transportMngr As TransportationManager
    ' To manage Transportion details
    Private storedCustomers As ArrayList
    ' to store already store customers of the last instance
    Private storeNames As ArrayList
    'to store already store names of customers of the last instance
    Private reservation As String
    ' to store the value of reservations
    Private reservationSaved As Boolean
    ' to check wheter the reservations details are stored
    Private confirmCurrentReservation As Boolean
    ' to confirm current reservation
    'forms that will be shown
    Private frmSelectTime As SelectTimeForm
    ' to show the select time form
    Private frmCustomer As CustomerForm
    ' to show customer form
    Private frmTransport As TransportationForm
    ' toshow transport form
    Public Sub New()
        InitializeComponent()
        customerMngr = New CustomerManager()
        transportMngr = New TransportationManager()
        reservationSaved = False
        EmptyReservationLabels()
        'My initalization
        InitializeGUI()
    End Sub

    ''' <summary>
    ''' Other inializations that set default values for fields
    ''' </summary>
    Private Sub InitializeGUI()
        dateOfJourney.MinDate = DateTime.Today
        ' clear and updated the cmbTransportaion with Trasportation type and select default value as Train.
        cmbTranportation.Items.Clear()
        cmbTranportation.Items.AddRange([Enum].GetNames(GetType(TransportationType)))
        cmbTranportation.SelectedIndex = CInt(TransportationType.Train)

        ' clear and updated the cmbFrom with Station and select default value Stockholm.
        cmbFrom.Items.Clear()
        cmbFrom.Items.AddRange([Enum].GetNames(GetType(Stations)))
        cmbFrom.SelectedIndex = CInt(Stations.Stockholm)

        ' clear and updated the cmbTo with Station and select default value Copenhagen.
        cmbTo.Items.Clear()
        cmbTo.Items.AddRange([Enum].GetNames(GetType(Stations)))
        cmbTo.SelectedIndex = CInt(Stations.Copenhagen)

        numericAdults.Value = 0
        numericChildren.Value = 0
        checkBoxLessThan2.Checked = False
        'read customer data from files
        ReadFiles()

    End Sub

    ''' <summary>
    ''' Reads the customer data from the files if any customers are already added
    ''' </summary>
    Private Sub ReadFiles()
        lstCustomers.Items.Clear()
        cmbCustomer.Items.Clear()

        Dim lineCustomer As String
        Dim lineName As String
        'StreamReader object to read the customer details
        Dim trCustomers As StreamReader = Nothing
        Dim trNames As StreamReader = Nothing
        Try
            'Read data from CustomerNames.txt
            trNames = New StreamReader("CustomerNames.txt")
            lineName = trNames.ReadLine()
            While lineName IsNot Nothing
                cmbCustomer.Items.Add(lineName)
                lineName = trNames.ReadLine()
            End While
            'store the customer names in combobox
            storeNames = New ArrayList(cmbCustomer.Items)

            'read data from CustomerDetails.txt
            trCustomers = New StreamReader("CustomerDetails.txt")
            lineCustomer = trCustomers.ReadLine()
            While lineCustomer IsNot Nothing
                lstCustomers.Items.Add(lineCustomer)
                lineCustomer = trCustomers.ReadLine()
            End While
            'store teh customer details in lstCustomers
            storedCustomers = New ArrayList(lstCustomers.Items)
            trCustomers.Close()
            trNames.Close()
        Catch e As Exception
            'MessageBox.Show ("Exception: " + e.Message);
            Return
        End Try

    End Sub

    ''' <summary>
    ''' Event-handler for SelectedIndexChanged event of cmbTranportation
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmbTranportation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbTranportation.SelectedIndexChanged
        'change image in the image control according to the selection
        pictureBox.Image = Me.imgList.Images(cmbTranportation.SelectedIndex)
    End Sub

    ''' <summary>
    ''' Event-hanler for click event of about menu item in help menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub aboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles aboutToolStripMenuItem.Click
        'show the About form
        Dim about As New AboutBox()
        about.Show()
    End Sub

    ''' <summary>
    ''' Event-hanler for click event of train menu item in Transport Menu.
    ''' This is used to add new train info
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub trainToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles trainToolStripMenuItem.Click
        ' create and show teh Transportation form
        frmTransport = New TransportationForm("Add New Train Info")
        If frmTransport.ShowDialog() = DialogResult.OK Then
            'Add the details and call the UpdateTrain List() method to write the values in File
            transportMngr.AddTransport(frmTransport.TransportData)
            UpdateTransportList("TrainDetails.txt")
        End If

    End Sub

    ''' <summary>
    ''' Event-hanler for click event of train menu item in Transport Menu.
    ''' This is used to add new train info
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub bussToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bussToolStripMenuItem.Click
        ' create and show the Transportation form
        frmTransport = New TransportationForm("Add New Bus Info")

        If frmTransport.ShowDialog() = DialogResult.OK Then
            'Add the details and call the UpdateTrain List() method to write the values in File
            transportMngr.AddTransport(frmTransport.TransportData)
            UpdateTransportList("BusDetails.txt")
        End If
    End Sub

    ''' <summary>
    ''' Event-hanler for click event of train menu item in Transport Menu.
    ''' This is used to add new train info
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub flightToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles flightToolStripMenuItem.Click
        ' create and show teh Transportation form
        frmTransport = New TransportationForm("Add New Flight Info")

        If frmTransport.ShowDialog() = DialogResult.OK Then
            'Add the details and call the UpdateTrain List() method to write the values in File
            transportMngr.AddTransport(frmTransport.TransportData)
            UpdateTransportList("FlightDetails.txt")
        End If
    End Sub


    ''' <summary>
    ''' Writes theTransportDetails to chosen file name (eg. bussdetails.txt for bus, train
    ''' details for trains etc), if file already exits it will 
    ''' append to it, otherwise creates new.
    ''' </summary>
    Private Sub UpdateTransportList(ByVal fileName As String)
        Dim twTransport As StreamWriter = Nothing
        Dim fsTransport As New FileStream(fileName, FileMode.Append)
        'write data from transportMngr object to file
        Try

            twTransport = New StreamWriter(fsTransport)
            Dim index As Integer = 0
            index = (transportMngr.CountTransport - 1)
            twTransport.WriteLine(transportMngr.GetTransport(index).ToString())
        Catch e As Exception
            MessageBox.Show("Exception: " + e.Message)
        Finally
            twTransport.Close()
        End Try
    End Sub




    ''' <summary>
    ''' event-hanlre for the add customer menu item of customer Menu.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub addCustomerToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles addCustomerToolStripMenuItem.Click
        'show customerform to enter the values
        frmCustomer = New CustomerForm("Add New Customer Info")
        If frmCustomer.ShowDialog() = DialogResult.OK Then
            'add new customer with help of customerMngr object
            customerMngr.AddCustomer(frmCustomer.CustomerData)
            'Update the customer list and updates the files
            UpdateCustomerList()
        End If
    End Sub

    ''' <summary>
    ''' clears the listbox and updates it with the customer values of the 
    ''' customerMngr arraylist
    ''' </summary>
    Private Sub UpdateCustomerList()
        Dim twCustomer As StreamWriter = Nothing
        Dim twCustomerNames As StreamWriter = Nothing

        Dim fsCustomer As New FileStream("CustomerDetails.txt", FileMode.Append)
        Dim fsNames As New FileStream("CustomerNames.txt", FileMode.Append)
        'loop through and write the values to the files
        Try
            twCustomer = New StreamWriter(fsCustomer)
            twCustomerNames = New StreamWriter(fsNames)
            Dim index1 As Integer = 0
            index1 = (customerMngr.CountCustomers - 1)
            twCustomer.WriteLine(customerMngr.GetCustomer(index1).ToString())
            twCustomerNames.WriteLine(customerMngr.GetName(index1).ToString())
        Catch e As Exception
            Console.WriteLine("Exception: " + e.Message)
        Finally
            twCustomer.Close()
            twCustomerNames.Close()
        End Try
        'Read the files to get the updated list of customer and names
        ReadFiles()
    End Sub

    ''' <summary>
    ''' Update the customer list if any value of customer is updated by clicking 
    ''' update menu item of customer menu.
    ''' </summary>
    Private Sub ChangedCustomerList()
        Dim twCustomer As StreamWriter = Nothing
        Dim twCustomerNames As StreamWriter = Nothing

        Dim fsCustomer As New FileStream("CustomerDetails.txt", FileMode.Create)
        Dim fsNames As New FileStream("CustomerNames.txt", FileMode.Create)
        'update the values and write them to files
        Try
            twCustomer = New StreamWriter(fsCustomer)
            twCustomerNames = New StreamWriter(fsNames)
            For i As Integer = 0 To storedCustomers.Count - 1
                twCustomer.WriteLine(storedCustomers(i))
            Next
            For i As Integer = 0 To storeNames.Count - 1
                twCustomerNames.WriteLine(storeNames(i))
            Next
        Catch e As Exception
            Console.WriteLine("Exception: " + e.Message)
        Finally
            twCustomer.Close()
            twCustomerNames.Close()
        End Try
        'Read files again to get the updates values
        ReadFiles()
    End Sub

    ''' <summary>
    ''' Event-hanler for click event of update menu item of customer menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub updateToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles updateToolStripMenuItem.Click
        ' Perform updation only when some customers already present.
        If lstCustomers.Items.Count <> 0 Then
            Dim index As Integer = lstCustomers.SelectedIndex
            'if no index is selected show error
            If index = -1 Then
                MessageBox.Show("Please select an index", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return
            End If
            Dim str As String = lstCustomers.SelectedItem.ToString()
            Dim frmCustomer As New CustomerForm("Update Customer Info", InputUtility.GetWords(str))
            customerMngr.Customers = storedCustomers
            customerMngr.Names = storeNames
            'if the customer clicks on OK button of the customer form then continue with the updation
            If frmCustomer.ShowDialog() = DialogResult.OK Then
                customerMngr.ChangeCustomer(frmCustomer.CustomerData, lstCustomers.SelectedIndex)
                storedCustomers = customerMngr.Customers
                storeNames = customerMngr.Names
                'update the customer list
                ChangedCustomerList()
            End If
        Else
            'if listbox is empty show error
            ShowError()
            Return
        End If
    End Sub

    ''' <summary>
    ''' Show error if the no customers are present to update or delete
    ''' </summary>
    Private Sub ShowError()
        MessageBox.Show("Customer list is empty, choose the Add customer option to add a new customer.", "", MessageBoxButtons.OK)
    End Sub

    ''' <summary>
    ''' Event-handler for click event of submittt button. Here every calculation is performed and
    ''' the result for one reservations will be showed in the labels and the all the reservations are stored
    ''' in the Reservations tab.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        'if no customers are present prompt to add one
        If cmbCustomer.Items.Count = 0 Then
            MessageBox.Show("No Customers are registerd, add customers first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        'to check whether the user has provided all the input or not, if provided continue
        If ValidInput() Then
            'Show the Select time form by passing the type of form selected by the user, title and from and to stations
            frmSelectTime = New SelectTimeForm(cmbTranportation.SelectedIndex + 1, SelectTitle(), cmbFrom.SelectedItem.ToString(), cmbTo.SelectedItem.ToString())
            'if no matching transport between selected locations are found show the message
            If frmSelectTime.ListBoxDetails.Count = 0 Then
                MessageBox.Show("No transport available", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'do not show the selectTime form
                frmSelectTime.Close()
            Else
                'if some transports are available then continue
                If frmSelectTime.ShowDialog() = DialogResult.OK Then
                    'store the values of reservations in the labels
                    lblCustomerName.Text = cmbCustomer.SelectedItem.ToString()
                    Dim str As String() = InputUtility.GetWords(lstCustomers.Items(cmbCustomer.SelectedIndex).ToString())
                    lblCustomerPhone.Text = str(2)
                    lblReservationUpto.Text = frmSelectTime.Detail
                    Dim str1 As String() = InputUtility.GetWords(frmSelectTime.Detail)
                    Dim price As String = str1(4)
                    'calculate the total Price
                    lblPrice.Text = GetPrice(price).ToString("#.##")
                    lblTotalTickets.Text = (numericInfants.Value + numericChildren.Value + numericAdults.Value).ToString()
                    'shwo the controls to confrim or cancel the reservations
                    btnSubmit.Enabled = False
                    btnConfirm.Enabled = True
                    btnCancel.Enabled = True
                Else
                    'to empty labels which save the reservation details
                    EmptyReservationLabels()
                End If
            End If
            're-initialize all fields
            InitializeGUI()
        End If

    End Sub

    Private Sub EmptyReservationLabels()
        lblCustomerName.Text = "No Reservations are made"
        lblCustomerPhone.Text = String.Empty
        lblReservationUpto.Text = String.Empty
        lblPrice.Text = String.Empty
        lblTotalTickets.Text = String.Empty
    End Sub

    ''' <summary>
    ''' Add the reservation details in the listbox
    ''' </summary>
    ''' <param name="name">Customer Name parameter</param>
    ''' <param name="phone">Customer phone number</param>
    ''' <param name="fromto">transport details</param>
    ''' <param name="price">Total price</param>
    Private Sub AddReservations(ByVal name As String, ByVal phone As String, ByVal fromto As String, ByVal price As String, ByVal tickets As String)
        reservation = String.Format("{0}- Phone:{1}- Details:{2}- Price: {3} SEK- Tickets: {4}", name, phone, fromto, price, tickets)
        lstReservations.Items.Add(reservation)
        ' add the reservations to the lstReservations
    End Sub

    ''' <summary>
    ''' To save the reservations in the file ReservationDetails.txt, if file exits then append the
    ''' values or create a new file
    ''' </summary>
    Private Sub UpdateReservations()
        Dim twReservation As StreamWriter = Nothing
        Dim fsReservation As New FileStream("Reservations.txt", FileMode.Append)
        'loop through the lstReservations and add the details to File
        Try
            twReservation = New StreamWriter(fsReservation)
            For i As Integer = 0 To lstReservations.Items.Count - 1
                twReservation.WriteLine(lstReservations.Items(i).ToString())
            Next
        Catch e As Exception
            MessageBox.Show("Exception: " + e.Message)
        Finally
            twReservation.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Calcuate the total price to be paid by the customer
    ''' </summary>
    ''' <param name="priceValue">price per adult</param>
    ''' <returns>Total price to be paid by customer</returns>
    Private Function GetPrice(ByVal priceValue As String) As Decimal
        Dim adultPrice As Decimal = Decimal.Parse(priceValue)
        'ticket price per adult
        Dim childPrice As Decimal = adultPrice / 2
        Dim totalPrice As Decimal
        If numericInfants.Value <> 0 Then
            numericChildren.Value = numericChildren.Value - numericInfants.Value
        End If
        totalPrice = (CInt(numericAdults.Value) * adultPrice) + (CInt(numericChildren.Value) * childPrice)
        Return totalPrice
    End Function

    ''' <summary>
    ''' Depending on the user chosen mode of transportion pass the title of the 
    ''' SelectTime Form
    ''' </summary>
    ''' <returns>A string containing the title</returns>
    Private Function SelectTitle() As String
        Dim str As String = String.Empty
        If cmbTranportation.SelectedIndex = 0 Then
            str = "Select Bus"
        ElseIf cmbTranportation.SelectedIndex = 1 Then
            str = "Select Train"
        Else
            str = "Select Flight"
        End If

        Return str
    End Function

    ''' <summary>
    ''' Event hanlder for the click event of delete menu item of customer menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub deleteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles deleteToolStripMenuItem.Click
        'if no customer are present show error otherwise continue
        If lstCustomers.Items.Count <> 0 Then
            Dim index As Integer = lstCustomers.SelectedIndex
            customerMngr.Customers = storedCustomers
            customerMngr.Names = storeNames
            'show error if no index is selected, otherwise call the removeCustomer method of customerMngr for
            'deleting specific customerdetails at selected index
            If index = -1 Then
                MessageBox.Show("Please select an index from Customer list", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return
            End If
            customerMngr.RemoveCustomer(index)
            storedCustomers = customerMngr.Customers
            storeNames = customerMngr.Names
            'update the customerlist
            ChangedCustomerList()
        Else
            'if listbox is empty show error
            ShowError()
            Return
        End If
    End Sub

    ''' <summary>
    ''' To validate the user input in the main Form.
    ''' </summary>
    ''' <returns>true if all fields are entered otherwise false</returns>
    Public Function ValidInput() As Boolean
        'if from staiton and to station are same show error
        If cmbFrom.SelectedItem.ToString() = cmbTo.SelectedItem.ToString() Then
            MessageBox.Show("Select different Stations", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            lblFrom.Text = "From*"
            lblTo.Text = "To*"
            Return False
        End If
        'if no customer is selected show error
        If cmbCustomer.SelectedIndex = -1 Then
            MessageBox.Show("Select Customer", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            lblName.Text = "Customer Name*"
            Return False
        End If
        'If none of the passangers are selected then show error
        If numericAdults.Value = 0 AndAlso numericChildren.Value = 0 Then
            MessageBox.Show("At least one passenger must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            lblPassengers.Text = "No.Of Passengers *"
            Return False
        End If
        'If none of transport mode are selected then show error
        If cmbTranportation.SelectedIndex = -1 Then
            MessageBox.Show("Select Transportation Type", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            lblTransportType.Text = "Select the means of Transportaione*"
            Return False
        End If
        Return True
    End Function


    ''' <summary>
    ''' //show infant controls
    ''' </summary>
    Private Sub ShowInfantControls()
        If checkBoxLessThan2.Checked = True Then
            If numericChildren.Value > 1 Then
                'if the children are less than 2 years of age show the infant controls
                lblInfants.Visible = True
                numericInfants.Visible = True
                numericInfants.Maximum = numericChildren.Value
                'if number of infants is selected are not 0 perform calulations 
                If numericInfants.Value = 0 Then
                    MessageBox.Show("Please select the no. of infants, otherwise uncheck the checkbox", "Info!", MessageBoxButtons.OK)
                End If
            Else
                numericInfants.Value = 1
            End If
        Else
            'if the children are less than 2 years of age show the infant controls
            lblInfants.Visible = False
            numericInfants.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Event-hanler for the click event of close menu item of File menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub exitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles exitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Event-handler for the click event of Save Reservations menu item of File menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub saveResToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveResToolStripMenuItem.Click
        'if the reservations are not saved before and list has some reservations then update the reservations
        'otherwise show the message
        If reservationSaved = False AndAlso lstReservations.Items.Count <> 0 Then
            UpdateReservations()
            reservationSaved = True
            MessageBox.Show("Reservations are saved", "Info", MessageBoxButtons.OK)
        Else
            reservationSaved = False
            MessageBox.Show("No reservations are made!", "Info", MessageBoxButtons.OK)
        End If
    End Sub


    ''' <summary>
    ''' Event-handler for the click event of View help menu item of Help Menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub viewHelpToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles viewHelpToolStripMenuItem.Click
        MessageBox.Show("Hover the mouse over the controls to see the help.", "Help", MessageBoxButtons.OK)
    End Sub

    ''' <summary>
    ''' Event handler for the formclosing event of Mainform. It checks with the user whether he wants to close the application
    ''' or not. If he wants to close then asks them wheter to save the reservations or not.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        'if the reservations are not saved and some reservations are present then show message
        If reservationSaved = False AndAlso lstReservations.Items.Count <> 0 Then
            Dim result As DialogResult = MessageBox.Show("Do you want to Save reservations before closing the application?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            'If user wants to save info show message and close the form
            If result = DialogResult.Yes Then
                e.Cancel = False
                UpdateReservations()
                Dim showMessage As DialogResult = MessageBox.Show("Reservations are saved", "Info", MessageBoxButtons.OK)
                If showMessage = DialogResult.OK Then
                    reservationSaved = True
                    ' e.Cancel = true;
                    Me.Dispose()
                End If
            Else
                'if user don't want to save reservations then close the form
                Me.Dispose()
            End If
        Else
            'if there are no reservations are there to save then ask the user whether he wants to close the application or not
            Dim result As DialogResult = MessageBox.Show("Do you want to close the application?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If

    End Sub

    ''' <summary>
    ''' Event-handler for value changed event of number of children control(numericChildren)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub numericChildren_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericChildren.ValueChanged
        checkBoxLessThan2.Checked = False
        'if number of children are not 0 then show the controls 
        If numericChildren.Value <> 0 Then
            checkBoxLessThan2.Visible = True
        Else
            checkBoxLessThan2.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Event-handler for CheckedChaged event of checkbox to show teh controls are not
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub checkBoxLessThan2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxLessThan2.CheckedChanged
        ShowInfantControls()
    End Sub

    ''' <summary>
    ''' Event-handlre for click event of Save button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnConfirm_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConfirm.Click
        'save the current reservation
        'to save the reservations to reservations listbox
        AddReservations(lblCustomerName.Text, lblCustomerPhone.Text, lblReservationUpto.Text, lblPrice.Text, lblTotalTickets.Text)
        UpdateReservations()
        confirmCurrentReservation = True
        Dim result As DialogResult = MessageBox.Show("Do you want to save the current reservation to a file?", "Info!", MessageBoxButtons.OKCancel)

        If result = DialogResult.OK Then
            SaveResult()
        Else
            EmptyReservationLabels()
        End If
        btnSubmit.Enabled = True
        btnCancel.Enabled = False
        btnConfirm.Enabled = False
    End Sub



    ''' <summary>
    ''' To save current reservation details
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub saveCurrentToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveCurrentToolStripMenuItem.Click
        If confirmCurrentReservation = True Then
            SaveResult()
        Else
            MessageBox.Show("Please confirm the reservation before saving", "Info!", MessageBoxButtons.OK)
            Return
        End If

    End Sub

    ''' <summary>
    ''' To save the current reservation details in the a file
    ''' provided by the user at user specified location
    ''' </summary>
    Private Sub SaveResult()
        'saveFileDialog1.ShowDialog();
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim name As String = saveFileDialog1.FileName
            WriteToFile(name)
        End If
    End Sub


    ''' <summary>
    ''' Write current reservation details to specic file provided by the user
    ''' </summary>
    Private Sub WriteToFile(ByVal name As String)
        'Create a file stream using the file name
        name = name & ".txt"
        Dim fs As New FileStream(name, FileMode.Create)

        'Create a writer that will write to the stream
        Dim writer As New StreamWriter(fs)
        Dim str As [String]() = New String(4) {}
        str(0) = "Name of Customer: " + lblCustomerName.Text
        str(1) = "Phone Number: " + lblCustomerPhone.Text
        str(2) = "Reservation details: " + lblReservationUpto.Text
        str(3) = "Total Price: " + lblPrice.Text
        str(4) = "Total no.of Tickets: " + lblTotalTickets.Text

        For Each detail As String In str
            writer.WriteLine(detail)
        Next
        writer.Close()
    End Sub

    ''' <summary>
    ''' Event-handler for MouseHover event of Submit button, this will show help for
    ''' the button control.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSubmit_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.MouseHover
        Dim toolTip1 As New ToolTip()
        toolTip1.SetToolTip(btnSubmit, "To get available options and to continue with reservation. Press Confirm the button to save the reservation")
    End Sub

    ''' <summary>
    ''' Event-handler for MouseHover event of Confirm button, this will show help for
    ''' the button control
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnConfirm_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles btnConfirm.MouseHover
        Dim toolTip1 As New ToolTip()
        toolTip1.SetToolTip(btnConfirm, "Press this button to save the current reservation, otherwise the reservation won't be saved!")
    End Sub

    ''' <summary>
    ''' Event-handler for Click event of Cancel button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        'Reinitialize form controls so no reservation is saved.
        InitializeGUI()
        btnConfirm.Enabled = False
        btnCancel.Enabled = False
        btnSubmit.Enabled = True
        EmptyReservationLabels()
        reservationSaved = True
    End Sub

    ''' <summary>
    ''' Event-handler for MouseHover event of Confirm button, this will show help for
    ''' the button control
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCancel_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.MouseHover
        Dim toolTip1 As New ToolTip()
        toolTip1.SetToolTip(btnCancel, "Press this button to cancel the current reservation.")
    End Sub


End Class
