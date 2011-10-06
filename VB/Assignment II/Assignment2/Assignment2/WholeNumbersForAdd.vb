'WholeNumbersForAdd.vb
'Created by: Padma Priya Duvvuri
'Created on: 28-Sept-2011


Option Strict On
Option Explicit On
''' <summary>
''' This class is executed when 1st option of the program is selected.
''' It reads the whole numbers from the user and makes a sum of it.. but first it asks
''' how many numbers the user wishes to enter. And finally prints the totatl.And it uses
''' 'For' loop to perform the calculations.
''' </summary>
''' <remarks></remarks>


Public Class WholeNumbersForAdd

    'declaring instance variables
    Private numberOfInputs As Integer 'num of values to add
    Private sum As Integer 'the result of the summation

    ''' <summary>
    ''' Starts the WholeNumbersForAdd
    ''' 
    ''' Public sub-method that performs the whole process
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Start()
        'to write the program info
        WriteProgramInfo()

        'to read input from the user
        ReadInput()

        'to perform calculation
        SumNumbers()

        'to write the output
        WriteResult()

    End Sub

    ''' <summary>
    ''' Writes the welcome text to the console
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub WriteProgramInfo()
        Console.WriteLine()
        Console.WriteLine("****************** Summation of whole numbers **********************")
        Console.WriteLine("                     Using a For statement")
        Console.WriteLine()
        Console.WriteLine()
        Console.Write("Number of integers to add: ")
    End Sub
    ''' <summary>
    ''' Reads the amount of numbers to add
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ReadInput()
        numberOfInputs = Input.ReadIntegerConsole()
    End Sub
    ''' <summary>
    ''' Sub-method that sums up the numbers as they are read
    ''' and the result is stored in the instance variable sum
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SumNumbers()
        Dim index As Integer 'counter variable
        Dim num As Integer 'stores the value that the user gives

        'for-statemnent that itterates
        For index = 0 To numberOfInputs - 1 Step 1
            Console.Write("Enter the number: ")
            num = Input.ReadIntegerConsole()
            sum = sum + num
        Next
    End Sub
    ''' <summary>
    ''' Writes the result
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub WriteResult()
        Console.WriteLine()
        Console.Write("The sum of {0} numbers you have entered is: {1}", numberOfInputs, sum)
        Console.WriteLine()
    End Sub

End Class
