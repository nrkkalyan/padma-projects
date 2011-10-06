'FloatingPointsNumberWhileAdd.vb
'Created by: Padma Priya Duvvuri
'Created on: 28-Sept-2011


Option Strict On
Option Explicit On

''' <summary>
''' This class is executed when 2nd option of the program is selected.
''' It reads the numbers and makes sum and prints it. And it uses 'While' statement.
''' And the numbers are read from the user until the user enters 0.
''' </summary>
''' <remarks></remarks>



Public Class floatingPointsNumberWhileAdd
    Private sum As Double 'to store the final output
    ''' <summary>
    ''' Starts the FloatingPointsNumberWhileAdd
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Start()
        'to write program info
        WriteProgramInfo()

        'to read the input and calcuate the sum of given numbers
        ReadAndSumNumbers()

        'to Print the result
        WriteResult()

    End Sub
    ''' <summary>
    ''' Writes the welcome text to the console
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub WriteProgramInfo()
        Console.WriteLine()
        Console.WriteLine("****************** Summation of Floating Point numbers **********************")
        Console.WriteLine("                       Using a While statement")
        Console.WriteLine()
        Console.WriteLine("Enter 0 to see the total")
        Console.WriteLine()
    End Sub
    ''' <summary>
    ''' Reads teh data and calculates the sum
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ReadAndSumNumbers()
        Dim done As Boolean = False
        sum = 0
        While (Not done)
            Dim num As Double
            'Reads number from the console (Input.ReadDoubleConsole)
            Console.Write("Enter the number: ")
            num = Input.ReadDoubleConsole()
            'If number is 0 end the iteration otherwise add it to the sum
            If (Math.Round(num, 7) = 0.0) Then
                done = True
            Else
                sum += num
            End If

        End While
    End Sub

    ''' <summary>
    ''' Writes the result
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub WriteResult()
        Console.WriteLine()
        Console.Write("The sum of numbers you have entered is: {0}", sum)
        Console.WriteLine()
    End Sub

End Class
