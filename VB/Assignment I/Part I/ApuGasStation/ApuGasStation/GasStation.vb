
Option Explicit On
Option Strict On

'GasStation.vb
'Created by: Padma Priya Duvvuri
'Created on: 08-Sept-2011

''' <summary>
''' This program is made for pay-at-the-pump gas stations. It interacts with the customer and calculates
''' the amount to be paid before filling up the car
''' </summary>
''' <remarks></remarks>
Module GasStation
    ''' <summary>
    ''' This is where the program begins when the program starts.
    ''' </summary>
    ''' <remarks></remarks>
    Sub Main()

        Dim pump As GasPump 'Declare a ref variable
        pump = New GasPump() 'Create to object

        'call the Start method of the pump to initiate the calculations
        pump.Start()

        'Make the Console window wait on the screen ("Read Nothing")
        Console.WriteLine("Press Enter to Exit!")
        Console.ReadKey()

    End Sub

End Module
