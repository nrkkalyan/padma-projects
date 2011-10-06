
Option Explicit On
Option Strict On

'Product.vb
'Created by: Padma Priya Duvvuri
'Created on: 09-Sept-2011

''' <summary>
''' This class reads the input form the user and prints out the 
''' finaly price the customer have to pay.
''' </summary>
''' <remarks></remarks>

Public Class Product

    'delcaring variables to store the input values
    Private customerName As String
    Private productName As String
    Private unitPrice As Double
    Private livingInSweden As Boolean
    Private streetName As String
    Private countryName As String

    'declaring variables to store the output
    Private totalToPay As Double
    Private shippingRate As Double
    Private applyDiscount As Double

    'declaring constants
    Private Const discount As Double = 15.0
    Private Const shippingPrice As Double = 200.0

    Public Sub Start()

        'print welcome message
        PrintWelcomeMessage()

        'read input from the user
        ReadInput()

        'calculate the price to be paid
        CalculateTotalPay()

        'Print the final Receipt
        PrintReceipt()


    End Sub

    Private Sub PrintWelcomeMessage()

        Console.WriteLine()
        Console.WriteLine("+++++++++++++++++ WELCOME TO ELECTRO MART +++++++++++++++++++++++++++")
        Console.WriteLine("+++")
        Console.WriteLine("+++ There is a discount of 15% if you purchase any item worth ")
        Console.WriteLine("+++ more than 1500 SEK")
        Console.WriteLine("+++")
        Console.WriteLine("+++ Free shipping within Sweden and we offer flat shipping price")
        Console.WriteLine("+++ for rest of world.")
        Console.WriteLine("+++")
        Console.WriteLine("+++++++++++++++++ ENTER DETAILS REQUESTED BELOW ++++++++++++++++++++++")
        Console.WriteLine()

    End Sub

    Private Sub ReadInput()

        '1. read the name of the customer
        ReadName()

        '2. read the name of product
        ReadProductName()

        '3. read the price of the product
        ReadUnitPrice()

        '4. check whether customer living in sweden or not
        IsLivingInSweden()


    End Sub

    Private Sub ReadName()
        Console.Write("Please Enter your Name: ")
        customerName = Convert.ToString(Console.ReadLine())
    End Sub

    Private Sub ReadProductName()
        Console.Write("Enter the name of the Product: ")
        productName = Convert.ToString(Console.ReadLine())
    End Sub

    Private Sub ReadUnitPrice()
        Console.Write("Enter the Unit Price: ")
        unitPrice = Convert.ToDouble(Console.ReadLine())

    End Sub

    Private Sub IsLivingInSweden()
        Console.Write("Are you living in Sweden ( Y/N )?: ")
        Dim response As Char = Console.ReadLine().Chars(0)

        If ((response = "Y") Or (response = "y")) Then
            Console.WriteLine()
            Console.WriteLine("You are eligable for free shipping!!! ")
            Console.WriteLine()
            livingInSweden = True
            shippingRate = 0.0
        Else
            Console.WriteLine()
            Console.WriteLine("There will be a flat shipping rate of 200 SEK")
            Console.WriteLine()
            livingInSweden = False
            shippingRate = shippingPrice
        End If

        GetAdress()

    End Sub

    Private Sub GetAdress()
        Console.Write("Enter the street Name: ")
        streetName = Convert.ToString(Console.ReadLine())

        If livingInSweden = True Then
            countryName = "Sweden"
        Else
            Console.Write("Enter the country Name: ")
            countryName = Convert.ToString(Console.ReadLine())
        End If
    End Sub

    Private Sub CalculateTotalPay()

        'apply discount if price is more than 1500SEK and apply shipping charges if living outside sweden

        ' Check whether discount is applicable or not
        CheckDisount()

        If (livingInSweden = True) Then
            totalToPay = unitPrice * (1 - (applyDiscount / 100))
        Else
            totalToPay = (unitPrice * (1 - (applyDiscount / 100))) + shippingPrice
        End If

    End Sub

    Private Sub CheckDisount()
        If (unitPrice > 1500) Then
            applyDiscount = discount
        Else
            applyDiscount = 0.0
        End If
    End Sub


    Private Sub PrintReceipt()
        Console.WriteLine()
        Console.WriteLine("++++++++++++++++++++ Welcome to Electro Mart ++++++++++++++++++ ")
        Console.WriteLine("+++")
        Console.WriteLine("+++ Product Name             {0}", productName)
        Console.WriteLine("+++ Unit Price               {0} SEK", unitPrice)
        Console.WriteLine("+++ Shipping Price           {0} SEK", shippingRate)
        Console.WriteLine("+++ Discount                 {0} SEK", (unitPrice * applyDiscount / 100))
        Console.WriteLine("+++")
        Console.WriteLine("+++ Total price to pay       {0} SEK", totalToPay)
        Console.WriteLine("+++")
        Console.WriteLine("+++ Shipping Adress:")
        Console.WriteLine("+++ Street name              {0}", streetName)
        Console.WriteLine("+++ Country                  {0}", countryName)
        Console.WriteLine("+++")
        Console.WriteLine("++++++++++++++++++ Please Visit again, {0}!!!+++++++++++++++++++", customerName)
        Console.WriteLine()
    End Sub

    

End Class
