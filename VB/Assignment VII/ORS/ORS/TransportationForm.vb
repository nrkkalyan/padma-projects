' File Name: TransportationForm.vb
' Created By: Padma Priya Duvvuri
' Created On: 25-Dec-2011

Option Strict On
Option Explicit On

''' <summary>
''' This form is used to add new info of transportation (buss, train or flight)
''' </summary>
Public Class TransportationForm

    Private m_transport As Transport
    'flag to handle the closing of the form
    Private closeForm As Boolean

    'constructor with one parameter (title of the form)
    Public Sub New(ByVal title As String)
        InitializeComponent()
        'Other initalizations
        Me.Text = title
        closeForm = True

        UpdateGUI()
    End Sub

    ''' <summary>
    ''' Read only property for m_transport
    ''' </summary>
    Public ReadOnly Property TransportData() As Transport
        Get
            Return m_transport
        End Get
    End Property


    ''' <summary>
    ''' Event hadler for formclosing event event of the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Transportation_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
        If closeForm Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    ''' <summary>
    ''' Event-handler for click event of Transporation button. This will create a new tranport object and 
    ''' calls the transport constructor to add new details fo transport
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnTransportation_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTransportation.Click
        Dim ticketPrice As Integer = 0
        'if all fields are validated continue with adding new transportaion info
        If (ValidateInputFields() = True And ValidatePrice(ticketPrice) = True) Then
            m_transport = New Transport(ticketPrice)
            'assign the values
            m_transport.TransportationNumber = txtNumber.Text
            Dim fromStaion As Stations = DirectCast([Enum].Parse(GetType(Stations), DirectCast(cmbFrom.SelectedItem, String)), Stations)
            m_transport.FromStation = fromStaion
            Dim toStation As Stations = DirectCast([Enum].Parse(GetType(Stations), DirectCast(cmbTo.SelectedItem, String)), Stations)
            m_transport.ToStation = toStation
            'Dim time As DateTime = DirectCast(timeTransportation.Value, DateTime)
            m_transport.Time = timeTransportation.Value
            m_transport.PriceAdult = ticketPrice
            UpdateGUI()
            Me.DialogResult = DialogResult.OK
        End If

    End Sub

    ''' <summary>
    ''' validation for price field
    ''' </summary>
    ''' <param name="ticketPrice"></param>
    ''' <returns>a integer having ticket price</returns>
    Private Function ValidatePrice(ByRef ticketPrice As Integer) As Boolean
        Dim str As String = txtPrice.Text
        Dim isValid As Boolean = InputUtility.GetInteger(str, ticketPrice)
        If isValid Then
            Return True
        Else
            MessageBox.Show("Please enter valid price", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])

            Return False
        End If
    End Function

    ''' <summary>
    ''' validate all input fields
    ''' </summary>
    ''' <returns></returns>
    Private Function ValidateInputFields() As Boolean
        'calls checkstring method of inpututility class
        If InputUtility.CheckString(txtNumber.Text) = True Then
            MessageBox.Show("Number cannot be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            lblNumber.Text = "Number*"
            Return False
        End If
        If cmbFrom.SelectedItem.ToString() = cmbTo.SelectedItem.ToString() Then
            MessageBox.Show("Select different Stations", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            lblFrom.Text = "From*"
            lblTo.Text = "To*"
            Return False
        End If
        Return True
    End Function

    ''' <summary>
    ''' Update the controls of the form
    ''' </summary>
    Private Sub UpdateGUI()
        txtNumber.Text = String.Empty
        timeTransportation.Value = DateTime.Now
        ' clear and updated the cmbFrom with Station and select default value Stockholm.
        cmbFrom.Items.Clear()
        cmbFrom.Items.AddRange([Enum].GetNames(GetType(Stations)))

        ' clear and updated the cmbTo with Station and select default value Copenhagen.
        cmbTo.Items.Clear()
        cmbTo.Items.AddRange([Enum].GetNames(GetType(Stations)))
    End Sub

    ''' <summary>
    ''' Event hanlder for Click event of cancel button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        'to close the form.
        Me.Close()
    End Sub



End Class