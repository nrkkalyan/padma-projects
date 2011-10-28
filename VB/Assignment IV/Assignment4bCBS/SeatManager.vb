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

    'Fields
    Private ReadOnly m_totNumOfRows As Integer 'number of rows in the cinema
    Private ReadOnly m_totNumOfCols As Integer 'number of columns in the cinema
    Private m_nameMatrix As String(,) 'two dimensional array to store seat names



    'to define a number of choice
    Public Enum DisplayOptions
        AllSeats
        VacantSeats
        ReservedSeats
    End Enum
    ''' <summary>
    ''' Custructor with initial values for number of seats
    ''' </summary>
    ''' <param name="totNumOfRows">number of rows</param>
    ''' <param name="totNumOfCols">number of columns</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal totNumOfRows As Integer, ByVal totNumOfCols As Integer)
        'Intialize the matrix to have total num of rows and columns
        m_totNumOfRows = totNumOfRows
        m_totNumOfCols = totNumOfCols
        m_nameMatrix = New String(m_totNumOfRows - 1, m_totNumOfCols - 1) {}
    End Sub

    ''' <summary>
    ''' Check so the value of an row and column are within the range
    ''' </summary>
    ''' <param name="row">row number</param>
    ''' <param name="col">column number</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CheckIndex(ByVal row As Integer, ByVal col As Integer) As Boolean
        If (row >= 0 And row < m_totNumOfRows And col >= 0 And col < m_totNumOfCols) Then
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
        Dim j As Integer

        For i = 0 To m_totNumOfRows - 1 Step 1
            For j = 0 To m_totNumOfCols - 1 Step 1
                If (m_nameMatrix(i, j) <> Nothing) Then
                    count = count + 1
                End If
            Next
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
        Dim j As Integer
        For i = 0 To m_totNumOfRows - 1 Step 1
            For j = 0 To m_totNumOfCols - 1 Step 1
                If (m_nameMatrix(i, j) = Nothing) Then
                    count = count + 1
                End If
            Next
        Next
        Return count
    End Function

    ''' <summary>
    ''' Calculate the total number of seats
    ''' </summary>
    ''' <returns>Total number of seats</returns>
    ''' <remarks></remarks>
    Public Function TotNumOfSeats() As Integer
        Return m_nameMatrix.Length
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
            Return TotNumOfSeats()
        End If
    End Function

    ''' <summary>
    ''' Adds a reservation. Save name in teh nameList and the price in the priceList
    ''' in the position = index
    ''' </summary>
    ''' <param name="name">name of the cinema customer</param>
    ''' <param name="index">index of the array position</param>
    ''' <returns>true if the seat is successfully reserved, false if it is already occupied</returns>
    ''' <remarks></remarks>
    Public Function ReserveSeat(ByVal name As String, ByVal index As Integer) As Boolean
        Dim col As Integer = 0
        Dim row As Integer = index
        IndexToRowCol(row, col)
        If (CheckIndex(row, col)) Then
            m_nameMatrix(row, col) = name
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
        Dim col As Integer = 0
        Dim row As Integer = index
        IndexToRowCol(row, col)
        If (CheckIndex(row, col) = True) Then
            m_nameMatrix(row, col) = Nothing
            Return True
        Else
            Return False
        End If
    End Function


    ''' <summary>
    ''' Converts matrix row and col values into a single vector index value
    ''' </summary>
    ''' <param name="row">Row</param>
    ''' <param name="col">Col</param>
    ''' <returns>Index Value</returns>

    Public Function ConvertToIndex(ByVal row As Integer, ByVal col As Integer) As Integer
        Dim index As Integer = row * m_totNumOfRows + col
        Return index
    End Function


    ''' <summary>
    ''' Determines the index in the matrix (row, col) that corresponds to a given
    ''' index in a on.dim array(listbox). This method actully is a reverse process of the method 
    ''' ConvertToIndex. The parameter row contains the input, i.e. index of the element in a one.dim array. 
    ''' The results(row, col) are saved and sent back to the caller via the ref variables row,col.
    ''' </summary>
    ''' <param name="row">Input and output parameter</param>
    ''' <param name="col">Output parameter</param>

    Public Sub IndexToRowCol(ByRef row As Integer, ByRef col As Integer)
        Dim indexRow As Integer = row 'row in the index

        row = CInt(Math.Floor((indexRow / m_totNumOfRows))) 'row in seat matrix
        col = indexRow Mod m_totNumOfRows 'col in seat matrix
    End Sub


    ''' <summary>
    ''' Returns the status for a seat in position = index
    ''' </summary>
    ''' <param name="index">Index of the array position</param>
    ''' <returns>A formatted string containing information about the 
    ''' seat customername, price and whether the seat is
    ''' reserved or vacant.</returns>
    Public Function GetSeatInfoAt(ByVal index As Integer) As String
        Dim row As Integer = index
        Dim col As Integer = 0
        IndexToRowCol(row, col)
        Dim isValid As Boolean = CheckIndex(row, col)

        If isValid Then
            If m_nameMatrix(row, col) = Nothing Then
                Return "Vacant"
            Else
                Return "Reserved"
            End If
        Else
            Return Nothing
        End If
    End Function


    ''' <summary>
    ''' overloaded method/Function of GetSeatInfoAt which Gets the information about the seat
    ''' </summary>
    ''' <param name="row">row of the seat</param>
    ''' <param name="col">col of the seat</param>
    ''' <returns>A formatted string containing information about the 
    ''' seat whether the seat is
    ''' reserved or vacant.</returns>

    Public Function GetSeatInfoAt(ByVal row As Integer, ByVal col As Integer) As String
        Dim isValid As Boolean = CheckIndex(row, col)
        If (isValid) Then
            If (m_nameMatrix(row, col) = Nothing) Then
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
        strSeatInfoStrings = New String(TotNumOfSeats()) {}

        If (count < 0) Then
            Return 0
        End If

        Dim strOut As String = "Vacant"
        Dim index As Integer = 0

        For index = 0 To TotNumOfSeats() - 1 Step 1
            Dim row As Integer = index
            Dim col As Integer = 0
            IndexToRowCol(row, col)

            strOut = GetSeatInfoAt(row, col)
            strSeatInfoStrings(index) = String.Format("{0,-10} {1,-5}    {2,-20} {3,-50}", row + 1, col + 1, strOut, m_nameMatrix(row, col))

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
