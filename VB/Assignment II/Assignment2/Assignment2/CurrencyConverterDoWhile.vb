'CurrencyConverter.vb
'Created by: Padma Priya Duvvuri
'Created on: 28-Sept-2011


Option Strict On
Option Explicit On
''' <summary>
''' This class is executed when 3rd option of the program is selected.
''' It reads the currency name and exchange rate from the user first. 
''' Then it reads the numbers and makes sum and prints the total both in local currency and in 
''' foreign currency
''' </summary>
''' <remarks></remarks>

Public Class CurrencyConverterDoWhile
    ' declaring instance variables
    Private currencyName As String
    Private exchangeRate As Double
    Private sum As Double
    Private sumInForiegnCurrency As Double
    ''' <summary>
    ''' Starts the CurrencyConvertorDoWhile
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub Start()
        ' to write the program info
        WriteProgramInfo()

        'to read users input
        ReadAndcalculateValues()

        'write the result
        WriteResult()

    End Sub

    ''' <summary>
    ''' Writes the welcome text to the console
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub WriteProgramInfo()
        Console.WriteLine()
        Console.WriteLine("************************ Currency Converter ****************************")
        Console.WriteLine("                       Using a Do-While statement")
        Console.WriteLine()
        Console.WriteLine("Enter 0 to see the total")
        Console.WriteLine()
    End Sub
    ''' <summary>
    ''' Read the values from the user and calculates the sum
    ''' and convert the value to foriegn currency
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ReadAndCalculateValues()
        Dim done As Boolean = False
        sum = 0
        Do
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

        Loop While (Not done)

        GetCurrencyName() 'get the currency name
        GetExchangeRate() 'get the exchage rate form the user

        sumInForiegnCurrency = exchangeRate * sum

    End Sub

    ''' <summary>
    ''' Reads the user input and and checks whether he entered a value or not
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GetCurrencyName()
        Console.WriteLine()
        Console.Write("Enter the name of the foriegn Currency: ")
        'check for empty string
        currencyName = Input.ReadStringConsole().ToUpper()
    End Sub
    ''' <summary>
    ''' Reads the user input and and checks whether he entered a value or not
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GetExchangeRate()
        Console.Write("Enter the exchange rate: ")
        'check for empty string

        exchangeRate = Input.ReadDoubleConsole()

        ' Check for exchange rate.. if it is lessthan or equal to 0 ask for rate again
        If exchangeRate <= 0 Then
            Console.WriteLine()
            Console.WriteLine("Exchange rate should be greater than 0")
            GetExchangeRate()
        End If
          
    End Sub

    ''' <summary>
    ''' Writes the result
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub WriteResult()
        Console.WriteLine()
        Console.WriteLine("The sum in local currency: {0} SEK", sum) 'assuming users local currency is SEK
        Console.WriteLine("Sum in Foreign Currency with exchange rate of {0} is : {1} {2}", exchangeRate, sumInForiegnCurrency, currencyName)
        Console.WriteLine()
    End Sub
End Class
