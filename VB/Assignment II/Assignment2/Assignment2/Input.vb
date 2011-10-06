'Input.vb
'Created by: Padma Priya Duvvuri
'Created on: 28-Sept-2011


Option Strict On
Option Explicit On

''' <summary>
'''This class reads from the console until a correct input is entered or not
''' </summary>
''' <remarks></remarks>

Public Class Input

    ''' <summary>
    ''' Reads from the console until a correct integer is received
    ''' </summary>
    ''' <returns>An Integer</returns>
    ''' <remarks></remarks>
    Public Shared Function ReadIntegerConsole() As Integer
        Dim input As Integer
        If (Integer.TryParse(Console.ReadLine(), input)) Then
            Return input
        Else
            Console.Write("Wrong input. Please try again: ")
            Return ReadIntegerConsole()
        End If

    End Function

    '''<summary>
    ''' Reads from the console until a correct double is received
    ''' </summary>
    ''' <returns>An double</returns>
    ''' <remarks></remarks>
    Public Shared Function ReadDoubleConsole() As Double
        Dim input As Double
        If (Double.TryParse(Console.ReadLine(), input)) Then
            Return input
        Else
            Console.Write("Wrong input. Please try again: ")
            Return ReadDoubleConsole()
        End If
    End Function

    ''' <summary>
    ''' Reads from the console until string is received
    ''' </summary>
    ''' <returns>A string</returns>
    ''' <remarks></remarks>
    Public Shared Function ReadStringConsole() As String
        Dim input As String = Console.ReadLine()
        If (input = String.Empty) Then
            Console.Write("Wrong input. Please try again. ")
            Return ReadStringConsole()
        Else
            Return input
        End If
    End Function
End Class
