// Menu.cs
// Created by: Padma Priya Duvvuri
// Created on 23-sept-2011

/// <summary>
/// This is the class which shows the options to the user for furthur selection.
/// In this class object of class, which perform other tasks, are created and their methods are called.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Assignment2
{
    class Menu
    {
    
        public void Start()
        {
            int choice = -1;

            while ( choice != 0 ) 
            {
                WriteMenuText(); // show the menu

                // read the users choice
                choice = int.Parse(Console.ReadLine());

                // perform the different operations of the menu depending on the choice of the user
                switch(choice)
                {
                    // Whole numbers with For
                    case 1:
                        {
                            // Declare a local reference variable and create an instance of WholeNumbersFor
                            WholeNumbersFor wholeNumbersFor = new WholeNumbersFor();
                            wholeNumbersFor.Start();
                            break;
                        }
                    
                    // Floating numbers with While
                    case 2:
                        {
                            // Declare a local reference variable and create an instance of FloatingNumbersWhile
                            FloatingNumbersWhile floatingNumberWhile = new FloatingNumbersWhile();
                            floatingNumberWhile.Start();
                            break;
                        }

                    // Currency Convertor with Do-While loop
                    case 3:
                        {
                            // Declare a local reference variable and create an instance of CurrencyConvDoWhile
                            CurrencyConvDoWhile currencyConvDoWhile = new CurrencyConvDoWhile();
                            currencyConvDoWhile.Start();
                            break;
                        }

                    // Waste Schedule
                    case 4:
                        {
                            // Declare a local reference variable and create an instance of WasteSchedule
                            WasteSchedule wasteSchedule = new WasteSchedule();
                            wasteSchedule.BinStart();
                            break;
                        }

                    // exit the program
                    default:
                        {
                            if (choice == 0)
                            {
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Please enter choice between 1 to 4 (or) 0 to exit the program");
                            }
                            break;
                        }
                       
                }
            }
        }

        // to show the menu options
        private void WriteMenuText()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("                               PROGRAM MENU");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("       Whole Numbers with For                       : 1");
            Console.WriteLine("       Floating Point Numbers with While            : 2");
            Console.WriteLine("       Currency Convertor with Do While-loop        : 3");
            Console.WriteLine("       Waste Schedule                               : 4");
            Console.WriteLine("       Exit the program                             : 0");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Enter your choice: ");
            
        }
    }
}
