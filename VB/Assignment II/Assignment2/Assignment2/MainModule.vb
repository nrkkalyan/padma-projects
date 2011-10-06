'MainModule.vb
'Created by: Padma Priya Duvvuri
'Created on: 28-Sept-2011

Option Explicit On
Option Strict On

''' <summary>
''' In this instance of Main.vb is created and its start method is called to start the program.
''' </summary>
''' <remarks></remarks>

Module MainModule

    Sub Main()

        Dim menu As Menu = New Menu() 'instance of menu class

        'call the start method of menu
        menu.Start()

        Console.ReadLine()


    End Sub

End Module
