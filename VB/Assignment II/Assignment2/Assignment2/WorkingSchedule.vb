'WorkingSchedule.vb
'Created by: Padma Priya Duvvuri
'Created on: 28-Sept-2011


Option Strict On
Option Explicit On

''' <summary>
''' This class does the claculation for the 4th option of the main menu.
''' It reads the choice of the user to print on what weekends and nights the user needs to work.
''' It gives the schedule
''' </summary>
''' <remarks></remarks>
Public Class WorkingSchedule
    ' declaring instance variables
    Private weekNumber As Integer
    Private Const totalWeeks As Integer = 52

    'to print 3 values for row
    Private p As Integer = 0
    Private Const cols As Integer = 3

    ''' <summary>
    ''' Starts the WholeNumbersForAdd
    ''' 
    ''' Public sub-method that performs the whole process
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Start()

        Dim choice As Integer = -1

        While (choice <> 0) 'loop until the user enters a 0
            'Print menu for the user or display the menu
            WriteMenuText()

            Console.Write("Please enter your choice: ")
            'call the method in Input.vb to 
            'read the user input (0-2)
            'And check whether the input is valid or not
            choice = Input.ReadIntegerConsole()

            Select Case choice
                Case 0
                    'create instance of Menu.vb to call Start method
                    'this inturns shows the main menu
                    Dim menu As Menu = New Menu()
                    menu.Start()
                    Exit Select
                Case 1
                    'for the calculation of weekend work schedule
                    WeekendSchedule()
                    Exit Select
                Case 2
                    'for the calculation of Night work schedule
                    NightSchedule()
                    Exit Select
                Case Else
                    Console.WriteLine("Pleas enter numbers from 1 or 2 to select an option and 0 to exit the program")
                    Exit Select

            End Select
        End While


    End Sub

    'to show the menu text to select the work schedule
    Private Sub WriteMenuText()
        Console.WriteLine()
        Console.WriteLine("--------------------------------------------------------------------------------")
        Console.WriteLine("                                WORK SCHEDULE")
        Console.WriteLine("--------------------------------------------------------------------------------")
        Console.WriteLine("   1. Weekends to work")
        Console.WriteLine("   2. Nights to work")
        Console.WriteLine("   0. Exit")
        Console.WriteLine("--------------------------------------------------------------------------------")
        Console.WriteLine()
    End Sub

    ''' <summary>
    ''' It shows on which weekends of the year the user has to work
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub WeekendSchedule()

        Console.WriteLine()
        Console.WriteLine("***************** Weekends to work **************")
        Console.WriteLine()

        For Me.weekNumber = 6 To totalWeeks Step 3
            Console.Write("{0,15} {1,2}", "Week", weekNumber)

            'to format the output
            FormatOutPut()
        Next
        Me.p = 0
    End Sub

    ''' <summary>
    ''' It shows on which nights of the year the user has to work
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub NightSchedule()

        Console.WriteLine()
        Console.WriteLine("********** Nights to work **************")
        Console.WriteLine()

        For Me.weekNumber = 1 To totalWeeks Step 6
            Console.Write("{0,15} {1,2}", "Week", weekNumber)

            'to format the output
            FormatOutPut()
        Next
    End Sub

    ' to fomat the output
    Private Sub FormatOutPut()
        p = p + 1
        'print 3 values per coloumn
        If ((p >= cols) And (p Mod cols = 0)) Then
            Console.WriteLine()
        End If

    End Sub

End Class
