
Option Explicit On
Option Strict On

'MainShop.vb
'Created by: Padma Priya Duvvuri
'Created on: 09-Sept-2011

''' <summary>
''' This program is developed for a Electric shop, Which offers online sale
''' on TV and other Electronic items.
''' 
''' At the end the program prints the receipt showing how much discount the user will get along with 
''' the final price he has to pay for the Product.
''' </summary>
''' <remarks></remarks>

Module MainShop
    ''' <summary>
    ''' This is where the program begins when the program starts.
    ''' </summary>
    ''' <remarks></remarks>
    Sub Main()

        'Declare a ref variable and create to object
        Dim product As Product
        product = New Product()

        'Call start method of the product class
        product.Start()

        'Make the console window wait on the screen
        Console.WriteLine("Press to Enter to Exit!")
        Console.ReadKey()

    End Sub

End Module
