// File Name: Months.cs
// Created by: Padma Priya Duvvuri
// Created on: 10-Oct-2011

///<summary>
/// In this class the required classifications are performed...
///</summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaysInMonth
{
    class Months
    {
        //to store user input
        private int monthName;
        private int year;

        //to store output
        private int numberOfDays;
        private string givenMonth;

        /// <summary>
        /// This is the main method which inturn calls other methods to perform calculations
        /// </summary>
        public void Start()
        {
            // Print welcome message to the user
            PrintWelcomeMessage();

            // Read the user input
            ReadValues();

            // Show Output
            ShowResults();
        }

        /// <summary>
        /// This method prints the welcome message to the user.
        /// </summary>
        private void PrintWelcomeMessage()
        {
            Console.WriteLine();
            Console.WriteLine("*******************  WELCOME TO THE PROGRAM ******************");
            Console.WriteLine();
            Console.WriteLine("Write your favourite month, 1(Jan) to 12(Dec) and the year to ");
            Console.WriteLine("see number of days in that month. Enter 0 to exit the program.");
            Console.WriteLine();
            Console.WriteLine("**************************************************************");
            Console.WriteLine();
        }

        /// <summary>
        /// This method reads the user input and performs necessary operations.
        /// </summary>
        private void ReadValues()
        {
            Console.WriteLine();
            Console.Write("Enter the month number: ");
            monthName = Convert.ToInt16(Console.ReadLine());

            //validate the month number
            bool isMonthValid = ValidateMonth(monthName);

            if (isMonthValid && (monthName != 0))
            {

                Console.Write("Enter the year: ");
                year = Convert.ToInt16(Console.ReadLine());

                //validate the year
                bool isValidYear =  ValidateYear(year);

                if (isValidYear)
                {

                    //calculate values
                    CalculateDays(monthName, year);
                }
                else
                {
                    ShowErrorMessage(2);
                    ReadValues();
                }
            }
            else if (isMonthValid && (monthName == 0))
            {
                Environment.Exit(0);
            }
            else
            {
                ShowErrorMessage(1);
                Console.WriteLine(" Or enter 0 to exit!");
                ReadValues();
            }
        }


        /// <summary>
        /// This method show the error message if the input is not valid
        /// </summary>
        /// <param name="number">this is passed to show which message to display to user</param>
        private void ShowErrorMessage(int number)
        {
            int max;
            int min;

            if (number == 1)
            {
                max = 12;
                min = 1;
            }
            else
            {
                max = 3000;
                min = 1900;
            }
           
            Console.WriteLine();
            Console.WriteLine("********************************************************");
            Console.WriteLine("Number is not valid, Please enter a number between {0} to {1}.",min,max);
            Console.WriteLine("********************************************************");
            Console.WriteLine();
        }
        /// <summary>
        /// This validates the year provided by the user
        /// </summary>
        /// <param name="yearNumber">the year parameter given by the user</param>
        /// <returns>True if it is in the given range</returns>
        private bool ValidateYear(int yearNumber)
        {
            const int min = 1900;
            const int max = 3000;

            if (yearNumber >= min && yearNumber <= max)
                return true;
            else
                return false;
        }

        /// <summary>
        /// This validates the number provided by the user
        /// </summary>
        /// <param name="monthName">the month parameter given by the user</param>
        /// <returns>True if the month is in range and and displays the value </returns>
        private bool ValidateMonth(int month)
        {
            const int min = 0;
            const int max = 12;

            if (month >= min && month <= max)
                return true;
            else
                return false;
        }

        /// <summary>
        /// this method calculates teh no. of days in the month.
        /// </summary>
        /// <param name="monthName">the month given by the user</param>
        /// <param name="year">the year given by the user</param>
        private void CalculateDays(int monthName, int year)
        {
            bool isLeapYear = CheckLeapYear(year);

            if (isLeapYear)
            {
                if (monthName == 2)
                    numberOfDays = 29;
                else if (monthName % 2 == 0)
                    numberOfDays = 30;
                else
                    numberOfDays = 31;
            }
            else
            {

                if (monthName == 2)
                    numberOfDays = 28;
                else if (monthName % 2 == 0)
                    numberOfDays = 30;
                else
                    numberOfDays = 31;
            }

            WriteMonthName(monthName); // finds out the month name
        }

        /// <summary>
        /// This method creates an array of names of the months and stores thier values to 
        /// show to the user
        /// </summary>
        /// <param name="x"> the month number provided by the user</param>
        private void WriteMonthName(int x)
        {
            string[] monthsName = new string[12] {"January", "February","March","April","May",
                "June", "July", "August","September","October","November","December" };

            givenMonth = monthsName[x - 1];

        }

        /// <summary>
        /// checks for the leap year or not
        /// </summary>
        /// <param name="year">year provided by the user</param>
        /// <returns></returns>
        private bool CheckLeapYear(int year)
        {
            bool leapYear = false;

            leapYear = (((year % 4) == 0) && ((year % 100) != 0) || ((year % 400) == 0));
            if (leapYear.Equals(true))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Prints the result to the user
        /// </summary>
        private void ShowResults()
        {
            Console.WriteLine();
            RepeatChar(); // show the symbol till end of line
            Console.WriteLine();
            Console.WriteLine("Number of days in {0} month of {1} year: {2} days", givenMonth, year, numberOfDays);
            RepeatChar();
            Console.WriteLine();
            Console.WriteLine();

            RepeatFromStart();
        }

        /// <summary>
        /// Option is provided for the user if he wants to repeat the process and wants to calculate for another month
        /// </summary>
        private void RepeatFromStart()
        {
            char c;

            Console.Write("Do you want to calculate days for another month? (y / n): ");
            c = Convert.ToChar(Console.ReadLine());

            if (c == 'Y' || c == 'y')
                Start();
            else
                Environment.Exit(0);

        }
        /// <summary>
        /// A char is repeated to print a border
        /// </summary>
        private void RepeatChar()
        {
            char c = '¤';

            for (int x = 0; x <= 60; x++)
                Console.Write(c);
        }
    }
}
