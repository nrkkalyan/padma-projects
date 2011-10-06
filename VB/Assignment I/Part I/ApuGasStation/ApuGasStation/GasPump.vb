

Option Explicit On
Option Strict On

'GasPump.vb
'Created by: Padma Priya Duvvuri
'Created on: 08-Sept-2011

''' <summary>
''' This class reads the input from the user to make the calcuations. It reads user's name,
''' quanitity user needs along with the quality of the petrol user wants.
''' Then the program prints the receipt for the user
''' </summary>
''' <remarks></remarks>
Public Class GasPump

    'Declaring variables to store input
    Private customerName As String
    Private quantity As Double
    Private premiumQuality As Boolean
    Private quality As String

    'Declaring variables to store output
    Private totalToPay As Double
    Private unitPrice As Double

    'Declaring constants
    Private Const regularPrice As Double = 13.09
    Private Const primePrice As Double = 13.59

    Public Sub Start()

        ' To read users inpu
        ReadInput()

        'To calculate the values
        CalcTotalToPay()

        'To print results
        PrintReceipt()

    End Sub

    Private Sub ReadInput()

        '1. Read Customers name
        ReadCustomerName()

        '2. Read Quantity
        ReadQuantity()

        '3. Read Quality
        ReadQuality()

    End Sub

    Private Sub ReadCustomerName()

        Console.Write("Please let me know your nickname: ")
        customerName = Convert.ToString(Console.ReadLine())

        'To print a thank you message
        WriteThankU()


    End Sub

    Private Sub WriteThankU()

        Console.WriteLine()
        Console.Write("Thank you very much {0}!", customerName)
        Console.WriteLine()

    End Sub

    Private Sub ReadQuantity()

        Console.WriteLine()
        Console.Write("How many Liters {0} (only whole number please)?: ", customerName)

        quantity = Convert.ToInt16(Console.ReadLine())

    End Sub

    Private Sub ReadQuality()

        Console.Write("Premium Quality? (Y/N): ")
        ' declaring a variable to store the respose
        Dim response As Char = Console.ReadLine().Chars(0)
        If ((response = "y") Or (response = "Y")) Then
            premiumQuality = True
        Else
            premiumQuality = False
        End If

    End Sub


    Private Sub CalcTotalToPay()

        If (premiumQuality = True) Then
            quality = "Premium"
            unitPrice = primePrice
        Else
            quality = "Regular"
            unitPrice = regularPrice
        End If

        totalToPay = quantity * unitPrice

    End Sub

    Private Sub PrintReceipt()

        Console.WriteLine()
        Console.WriteLine("+++++++++++++++ WELCOME TO APU'S GAS STATION +++++++++++++++")
        Console.WriteLine("+++")
        Console.WriteLine("+++ Quality                    {0}", quality)
        Console.WriteLine("+++ Quantiy (in liters)        {0}", quantity)
        Console.WriteLine("+++ Price per liter            {0}SEK", unitPrice)
        Console.WriteLine("+++ Sum To Pay                 {0}SEK", totalToPay)
        Console.WriteLine("+++")
        Console.WriteLine("++++++++++++++ PLEASE COME AGAIN {0}! +++++++++++++++++++", customerName)
        Console.WriteLine()

    End Sub




End Class
