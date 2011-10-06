// CurrencyConvDoWhile.cs
// Created by: Padma Priya Duvvuri
// Created on: 24-Sept-2011

/// <summary>
/// This class performs the third operation/case of Menu.cs
/// It reads the user input, one country currency, to another currency and 
/// gives the value
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
    class CurrencyConvDoWhile
    {
        // declare a instance variable to store the user output
        private decimal sum = 0;
        private decimal sumInForiegnCurrency = 0;

        // variables to store user input
        private decimal exchangeRate;
        private string foriegnCurrencyName;


        public void Start()
        {

            // to show the welcome message
            WriteProgramInfo();

            // to read input from the user and perform the calculation
            ReadAndPerformCalc();

            // to print the result
            ShowResult();

        }


        // to print the program information
        private void WriteProgramInfo()
        {
            Console.WriteLine("\n\n +++++++ Currency coverter using Do-While +++++++++ ");
            Console.WriteLine("                using 'Do-while' statement\n");
            Console.WriteLine();
        }


        // this method reads the input from the user on every iteration and 
        // calculates the values
        private void ReadAndPerformCalc()
        {
            // declare a variable to store input in each iteration
            decimal num = 0;

            bool notZero = false;
         
            
            // read the name of foriegn country

            Console.Write("Enter the name of the foriegn Currency: ");
            foriegnCurrencyName = Console.ReadLine();
 
            // read the exchange rate
            Console.Write("Enter the exchange rate: ");
            exchangeRate = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter '0' to see the Total\n");
                
            do
            {

                // read the input from the user
                Console.Write("Enter the value : ");
                num = decimal.Parse(Console.ReadLine());

                // terminate the iteration if the number entered is 0
                if (Math.Round(num, 7) == 0)
                    notZero = true;

                // perform calculation if number is not 0
                sum += num;

            } while (!notZero);

            sumInForiegnCurrency = sum * exchangeRate;

        }

        // to print the result
        private void ShowResult()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------");
            // to print the sum of numbers upto 2 decimals
            Console.WriteLine(" The total sum of the currencies you have entered is : {0} SEK\n", sum.ToString("#.##"));
            Console.WriteLine(" Equivalent foriegn currency with exchange rate of {0} is : {1} {2}", 
                exchangeRate, sumInForiegnCurrency.ToString("#.##"),foriegnCurrencyName.ToUpper());
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();

        }

    }
}
