'File Name: MainForm.vb
'Created by: Padma Priya Duvvuri
'Created on: 21-Oct-2011

Option Strict On
Option Explicit On

''' <summary>
''' This class performs necessary operations to manage the seat details that 
''' are reserved or not reserved along with the calculations needed to 
''' cancel a reservation
''' </summary>
''' <remarks></remarks>
Public Class SeatManager

    'declaring variables to store the total number of seats,name and price
    Private m_totNumOfSeats As Integer
    Private m_nameList() As String
    Private m_price() As Double

    'to define a number of choice
    Public Enum DisplayOptions
        AllSeats
        VacantSeats
        ReservedSeats
    End Enum

    ''' <summary>
    ''' Consturctor - do all your initializations here
    ''' </summary>
    ''' <param name="maxNumberOfSeats">Total Number of seats</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal maxNumberOfSeats As Integer)
        'only time m_totNumOfSeats can be assigned a value
        m_totNumOfSeats = maxNumberOfSeats
        m_nameList = New String(m_totNumOfSeats - 1) {}
        m_price = New Double(m_totNumOfSeats - 1) {}
    End Sub

    ''' <summary>
    ''' Check so the value of an index is within the array range,
    ''' i.e. index >= 0 and index is less than m_totNumOfSeats.
    ''' </summary>
    ''' <param name="index"></param>
    ''' <returns>The index selected by the user in the list box</returns>
    ''' <remarks></remarks>
    Private Function CheckIndex(ByVal index As Integer) As Boolean
        If (index >= 0 And index <= m_totNumOfSeats) Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Calculate the number of seats reserved
    ''' </summary>
    ''' <returns>number of reserved seats</returns>
    ''' <remarks></remarks>
    Public Function GetNumReserved() As Integer
        Dim count As Integer = 0
        Dim i As Integer
        For i = 0 To m_totNumOfSeats - 1 Step 1
            If (m_nameList(i) <> Nothing) Then
                count = count + 1
            End If
        Next
        Return count
    End Function

    ''' <summary>
    ''' Calculate the number of seats vacant
    ''' </summary>
    ''' <returns>number of vacant seats</returns>
    ''' <remarks></remarks>
    Public Function GetNumVacant() As Integer
        Dim count As Integer = 0
        Dim i As Integer
        For i = 0 To m_totNumOfSeats - 1 Step 1
            If (m_nameList(i) = Nothing) Then
                count = count + 1
            End If
        Next
        Return count
    End Function


    ''' <summary>
    ''' Get number of seats depending on the value of choice
    ''' defined in the enum DisplayOptions
    ''' </summary>
    ''' <param name="choice">a member of the enum DisplayOptions</param>
    ''' <returns>the number of seats for the chosen option</returns>
    ''' <remarks></remarks>
    Public Function GetNumOfSeats(ByVal choice As DisplayOptions) As Integer
        If choice = DisplayOptions.ReservedSeats Then
            Return GetNumReserved()
        ElseIf choice = DisplayOptions.VacantSeats Then
            Return GetNumVacant()
        Else
            Return m_totNumOfSeats
        End If
    End Function

    ''' <summary>
    ''' Adds a reservation. Save name in teh nameList and the price in the priceList
    ''' in the position = index
    ''' </summary>
    ''' <param name="name">name of the cinema customer</param>
    ''' <param name="price">price paid for the seat</param>
    ''' <param name="index">index of the array position</param>
    ''' <returns>true if the seat is successfully reserved, false if it is already occupied</returns>
    ''' <remarks></remarks>
    Public Function ReserveSeat(ByVal name As String, ByVal price As Double, ByVal index As Integer) As Boolean
        If (CheckIndex(index)) Then
            m_price(index) = price
            m_nameList(index) = name
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Cancel a reservation. Assign a value nothing in teh namelist, and 0.0D in the 
    ''' priceList in the position = index
    ''' </summary>
    ''' <param name="index">Index for array position</param>
    ''' <returns>true if the seat was successully cancelled or false otherwise</returns>
    ''' <remarks></remarks>
    Public Function CancelSeat(ByVal index As Integer) As Boolean
        If (CheckIndex(index)) Then
            m_price(index) = 0D
            m_nameList(index) = Nothing
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Returns the status for a seat in a postion = index
    ''' </summary>
    ''' <param name="index">Index of the array position</param>
    ''' <returns>A formatted string containing information about availability of seat</returns>
    ''' <remarks></remarks>
    Public Function GetSeatInfoAt(ByVal index As Integer) As String
        Dim isValid As Boolean = CheckIndex(index)
        If (isValid) Then
            If (m_nameList(index) = Nothing) Then
                Return "Vacant"
            Else
                Return "Reserved"
            End If
        Else
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' This method prepares an array of strings with information about all seats.
    ''' Each element is a string formatted using the GetSeatInfo function.
    ''' </summary>
    ''' <param name="choice">Choice of seats that needs to be displayed</param>
    ''' <param name="strSeatInfoStrings">updates the array</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetSeatInfoStrings(ByVal choice As DisplayOptions, ByRef strSeatInfoStrings As String()) As Integer
        Dim count As Integer = GetNumOfSeats(choice)
        strSeatInfoStrings = New String(m_totNumOfSeats - 1) {}

        If (count < 0) Then
            Return 0
        End If

        Dim strOut As String = "Vacant"
        Dim i As Integer = 0 'counter for return array
        'is the element corresponding with the index empty
        Dim index As Integer = 0
        For index = 0 To m_totNumOfSeats - 1 Step 1

            strOut = GetSeatInfoAt(index)
            strSeatInfoStrings(index) = String.Format("{0,-10} {1,-15}  {2,-20} {3,-50}", index + 1, strOut, m_price(index).ToString("F"), m_nameList(index))

            If (choice = DisplayOptions.ReservedSeats And strOut = "Vacant") Then
                strSeatInfoStrings(index) = Nothing
            End If

            If (choice = DisplayOptions.VacantSeats And strOut = "Reserved") Then
                strSeatInfoStrings(index) = Nothing
            End If
        Next index
        Return count
    End Function
End Class
