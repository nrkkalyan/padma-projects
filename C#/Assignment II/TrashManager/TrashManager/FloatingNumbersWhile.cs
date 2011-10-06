// FloatingNumbersWhile.cs
// Created by: Padma Priya Duvvuri
// Created on: 24-Sept-2011

/// <summary>
/// This class performs the second operation/case of Menu.cs
/// It calculates the sum of all real numbers untill
/// the user enters a '0'
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
    class FloatingNumbersWhile
    {
        // declare a instance variable to store the user output
        private double sum = 0.0;

        // variable to count the no. of numbers entered
        private int count = 0;


        public void Start()
        {
            
            // to show the welcome message
            WriteProgramInfo();

            

            // to read input from the user and perform the calculation
            ReadAndPerformCalc();

            // to print the result
            ShowResult();
            
        }

        // to write the information of the program
     
        private void WriteProgramInfo()
        {
            Console.WriteLine("\n\n +++++++ Summation of floating numbers +++++++++ ");
            Console.WriteLine("                using 'while' statement\n");
            Console.WriteLine();
        }
        
        
        // this method reads the input from the user on every iteration and 
        // calculates the values
        private void ReadAndPerformCalc()
        {
            // declare a variable to store input in each iteration
            double num = 0.0;

            bool notZero = false;

            Console.WriteLine("Enter '0' to see the sum of values");

            while (!notZero)
            {
                // read the input from the user
                Console.Write("Enter the value : ");
                num = float.Parse(Console.ReadLine());

                // terminate the iteration if the number entered is 0
                if (Math.Round(num, 7) == 0.0)
                    notZero = true;

                // perform calculation if number is not 0
                sum += num;
                count++;

            }

        }

        private void ShowResult()
        {

            Console.WriteLine("------------------------------------------------------------");
            // to print the sum of numbers upto 2 decimals
            Console.WriteLine(" The sum of {0} numbers that you have entered is : {1}",count - 1 , sum.ToString("#.##"));
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
            
        }
    }
}
