// File Name: Months.cs
// Created by: Padma Priya Duvvuri
// Created on: 10-Oct-2011

///<summary>
///This is the main program. It calls the Month class to perform calculations.
///The user provides the year and month number and program calculates the 
///no. of days in that year.
///</summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaysInMonth
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            // calls start method of the Month class by creating an object of it.
            Months month = new Months();
            month.Start();


            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
    }
}
