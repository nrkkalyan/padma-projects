' File Name: TransportationForm.vb
' Created By: Padma Priya Duvvuri
' Created On: 25-Dec-2011

Option Strict On
Option Explicit On

Imports System.IO

''' <summary>
''' This form shows the available transport between the locations provided
''' by the user in the main form.
''' </summary>
Public Class SelectTimeForm
    'flag to handle the closing of the form
    Private closeForm As Boolean
    Private details As ArrayList
    'to store the transports between user provided locations or stations
    Private m_detail As String
    'get selected transport details
    Private fromStation As String
    'from station
    Private toStation As String
    'tostation
    Private m_listBoxDetails As ArrayList
    'to show the filtered results to the user
    ''' <summary>
    ''' Constructor that takes 4 paramerters
    ''' </summary>
    ''' <param name="choice">To get user choice of transport</param>
    ''' <param name="title">Title of the form</param>
    ''' <param name="from">from station</param>
    ''' <param name="to">to station</param>
    Public Sub New(ByVal choice As Integer, ByVal title As String, ByVal from As String, ByVal [to] As String)
        InitializeComponent()
        lstSelectedTime.Items.Add(String.Empty)
        lstSelectedTime.SetSelected(0, True)

        Me.Text = title
        SetValues(from, [to])
        'get the user selected stations
        ReadTransportFiles(choice)
        'read the transportdetails
        m_listBoxDetails = New ArrayList()
        FilterResults()
        'filter the results to match customer needs
        m_detail = String.Empty
    End Sub

    ''' <summary>
    ''' Read and write property for listBoxDetails
    ''' </summary>
    Public Property ListBoxDetails() As ArrayList
        Get
            Return m_listBoxDetails
        End Get
        Set(ByVal value As ArrayList)
            value = m_listBoxDetails
        End Set
    End Property

    ''' <summary>
    ''' Depending on user selected stations filter the results
    ''' and show them in listbox
    ''' </summary>
    Private Sub FilterResults()
        lstSelectedTime.Items.Clear()
        For Each str As String In details
            Dim fromString As String() = InputUtility.GetWords(str)
            If fromString(1) = fromStation AndAlso fromString(2) = toStation Then
                lstSelectedTime.Items.Add(str)
            End If
        Next
        'add the results to the listboxdetails for the use in main menu
        m_listBoxDetails.AddRange(lstSelectedTime.Items)
    End Sub

    ''' <summary>
    ''' Set the values of user selected station to the use if for filter results
    ''' </summary>
    ''' <param name="from"></param>
    ''' <param name="to"></param>
    Private Sub SetValues(ByVal from As String, ByVal [to] As String)
        fromStation = from
        toStation = [to]
    End Sub

    ''' <summary>
    ''' Depening on user choice of transport, read the corresponding 
    ''' files
    ''' </summary>
    ''' <param name="choice"></param>
    Private Sub ReadTransportFiles(ByVal choice As Integer)
        details = New ArrayList()
        Select Case choice
            'For Bus
            Case 1
                If True Then
                    Dim transportBus As String
                    Dim trTransportBus As StreamReader = Nothing
                    Try
                        'to fill names combobx
                        trTransportBus = New StreamReader("BusDetails.txt")
                        transportBus = trTransportBus.ReadLine()
                        While transportBus IsNot Nothing
                            details.Add(transportBus)
                            transportBus = trTransportBus.ReadLine()
                        End While


                        trTransportBus.Close()
                    Catch e As Exception
                        'MessageBox.Show ("Exception: " + e.Message);
                        Return
                    End Try
                    Exit Select
                End If
                'for train
            Case 2
                If True Then
                    Dim transportTrain As String
                    Dim trTransportTrain As StreamReader = Nothing

                    Try
                        'to fill names combobx
                        trTransportTrain = New StreamReader("TrainDetails.txt")
                        transportTrain = trTransportTrain.ReadLine()
                        While transportTrain IsNot Nothing
                            details.Add(transportTrain)
                            transportTrain = trTransportTrain.ReadLine()
                        End While
                        trTransportTrain.Close()
                    Catch e As Exception
                        'MessageBox.Show ("Exception: " + e.Message);
                        Return
                    End Try
                    Exit Select
                End If
                'for flight
            Case 3
                If True Then
                    Dim transportFlight As String
                    Dim trTransportFlight As StreamReader = Nothing

                    Try
                        'to fill names combobx
                        trTransportFlight = New StreamReader("FlightDetails.txt")
                        transportFlight = trTransportFlight.ReadLine()
                        While transportFlight IsNot Nothing

                            details.Add(transportFlight)

                            transportFlight = trTransportFlight.ReadLine()
                        End While


                        trTransportFlight.Close()
                    Catch e As Exception
                        'MessageBox.Show ("Exception: " + e.Message);
                        Return
                    End Try
                    Exit Select
                End If

        End Select

    End Sub

    ''' <summary>
    ''' Read and write property for detail variable
    ''' </summary>
    Public Property Detail() As String
        Get
            Return m_detail
        End Get
        Set(ByVal value As String)
            value = m_detail
        End Set
    End Property

    ''' <summary>
    ''' stores the value of user selected choice of travel time
    ''' </summary>
    ''' <returns>a string containing the user choice</returns>
    Public Function GetValue() As String
        Dim str As String = lstSelectedTime.SelectedItem.ToString()
        Return str

    End Function

    ''' <summary>
    ''' Event handler for Click event of btnContinue button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnContinue_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnContinue.Click
        'If no matching transport is found get the selected string else show the messsage
        If lstSelectedTime.SelectedIndex <> -1 Then
            m_detail = GetValue()

            Me.DialogResult = DialogResult.OK
        Else
            MessageBox.Show("Please select an index", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If

    End Sub

    ''' <summary>
    ''' Event hadler for formclosing event event of the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SelectTime_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
        If closeForm Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    ''' <summary>
    ''' Event-handler for Click for btnBack button. If this button is clicked reservation
    ''' will not be continued.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click
        Me.DialogResult = DialogResult.No
    End Sub

End Class