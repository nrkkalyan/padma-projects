'Menu.vb
'Created by: Padma Priya Duvvuri
'Created on: 28-Sept-2011


Option Strict On
Option Explicit On

''' <summary>
''' The main menu class
''' Handles the main functionality of the program
''' </summary>
''' <remarks></remarks>

Public Class Menu
    '''<summary>
    ''' The main loop of the program
    ''' </summary>
    Public Sub Start()
        Dim choice As Integer = -1

        While (choice <> 0) 'loop until the user enters a 0
            'Print menu for the user or display the menu
            WriteMenuText()

            Console.Write("Please enter your choice: ")

            'call the method in Input.vb to 
            'read the user input (0-4)
            'And check whether the input is valid or not
            choice = Input.ReadIntegerConsole()

            Select Case choice

                Case 0
                    ' to exit the program
                    Environment.Exit(0)
                    Exit Select

                Case 1
                    'to calculate sum of whole numbers using For loop
                    Dim wholeNumbersFor As WholeNumbersForAdd = New WholeNumbersForAdd() 'make an instance of the WholeNumbersForAdd class

                    'call the start method of the class
                    wholeNumbersFor.Start()
                    Exit Select

                Case 2
                    'to calculate sum of floating numbers using while loop
                    Dim floatingPointsNumbersWhile As floatingPointsNumberWhileAdd = New floatingPointsNumberWhileAdd() 'instance of the class

                    'call start method
                    floatingPointsNumbersWhile.Start()
                    Exit Select

                Case 3
                    'for convertion of the local currency
                    Dim currencyConv As CurrencyConverterDoWhile = New CurrencyConverterDoWhile() 'instance of the class

                    'execute the start method
                    currencyConv.Start()
                    Exit Select

                Case 4
                    'to calculate working schedule
                    Dim workingSchedule As WorkingSchedule = New WorkingSchedule() 'instance of the class

                    'call the scheduleStart method
                    workingSchedule.Start()
                    Exit Select

                Case Else
                    'prompt a message if none of the options is selected
                    Console.WriteLine("Pleas enter numbers from 1 to 4 select an option and 0 to exit the program")
                    Exit Select

            End Select

        End While
    End Sub

    'to show the menu for the user
    Private Sub WriteMenuText()
        Console.WriteLine()
        Console.WriteLine("--------------------------------------------------------------------------------")
        Console.WriteLine("                                 PROGRAM MENU")
        Console.WriteLine("--------------------------------------------------------------------------------")
        Console.WriteLine("   1. Whole numbers with For")
        Console.WriteLine("   2. Floating point numbers with While")
        Console.WriteLine("   3  Currency Converter with do while")
        Console.WriteLine("   4. Work schedule")
        Console.WriteLine("   0. Exit")
        Console.WriteLine("--------------------------------------------------------------------------------")
        Console.WriteLine()
    End Sub

End Class
