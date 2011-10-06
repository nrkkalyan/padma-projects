// WasteSchedule.cs
// Created by: Padma Priya Duvvuri
// Created on: 24-Sept-2011

/// <summary>
/// This class performs the fourth operation/case of Menu.cs
/// First it gives the option to select bin and then calcuates and prints
/// the weeks in which the selected bin is emptied.
/// 
/// This class takes care of the whole process of
/// (1) reading input from the console window
/// (2) performing the calculations and 
/// (3) printing the results
/// 
/// </summary>



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    class WasteSchedule : Menu // Menu.cs is extended so as to redirected to the Main menu
    {
        // for week number
        private int weekNumber;

        //total number of weeks
        private const int totalWeeks = 52;

        // for the selection of bin
        private int binChoice = -1;


        // variable to be used to print 3 values per row
        private int p = 0;
        private const int cols = 3;


        public void BinStart()
        {
            while (binChoice != 0)
            {
                //write menu text
                WriteMenuForBinSelection();

                Console.Write("Enter your bin selection: ");

                // read the users choice
                binChoice = int.Parse(Console.ReadLine());

                // perform the different operations of the menu depending on the choice of the user
                switch (binChoice)
                {
                    // Bin 1 (for kitchen and house hold wastes)
                    case 1:
                        BinOne();
                        break;

                    // Bin 2 (for paper and other wastes)
                    case 2:
                        BinTwo();
                        break;

                    // exit to the main menu
                    default:
                        {
                            if (binChoice == 0)
                            {
                                //call the Start method of Menu.cs to give main menu again
                                Start();
                            }
                            else
                            {
                                Console.WriteLine("Please select Bin by entering 1 or 2 , and 0 to exit");
                            }
                            break;
                        }
                }
            }
        }

        //to show the options for the user
        private void WriteMenuForBinSelection()
        {
            Console.WriteLine();
            Console.WriteLine("\n\n ++++++++++++++ WASTE SCHEDULE +++++++++++++++ ");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Choose type of trash bin: ");
            Console.WriteLine("\n Bin no 1: Kitchen trash, household wastes (every other week)");
            Console.WriteLine("\n Bin no 2: Paper, cartoon packages, yard wastes, etc (every 6th week)");
            Console.WriteLine("\n 0 to exit");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine();
        }

        // calculation for bin 1
        private void BinOne()
        {
            PrintMessage();
            // loop through the year and print every other week
            for (weekNumber = 1; weekNumber <= totalWeeks; weekNumber += 2)
            {
                Console.Write("{0,15} {1,2}", "Week", weekNumber);
                
                //to format output
                FormatOutput();
            }

            p = 0;
            Console.WriteLine("\n------------------------------------------------------------------------");
        }

        // calculation for bin 2
        private void BinTwo()
        {
            PrintMessage();

            // loop through the year and print 6th other week
            for (weekNumber = 5; weekNumber <= totalWeeks; weekNumber += 6)
            {
                Console.Write("{0,15} {1,2}", "Week", weekNumber);

                // to format output
                FormatOutput();
            }

            p = 0;
            Console.WriteLine("\n------------------------------------------------------------------------");

        }

       
        // to print the results

        private void PrintMessage()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Bin number {0} is emptied in the following weeks", binChoice);
            Console.WriteLine("------------------------------------------------------------------------");

        }
        
        // to format out put to print only 3 values per line
        private void FormatOutput()
        {
            p++;
            // print 3 values per coloumn
            if ((p >= cols) && (p % cols == 0))
                Console.WriteLine();
           
        }
    }
}


