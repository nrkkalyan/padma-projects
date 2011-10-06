// WholeNumberFor.cs
// Created by: Padma Priya Duvvuri
// Created on: 23-Sept-2011

/// <summary>
/// This class performs the first operation/case of Menu.cs
/// It calculates the sum of whole numbers upto the number given by the user.
/// 
/// This class takes care of the whole process of
/// (1) reading input from the console window
/// (2) performing the calculations and 
/// (3) printing the results
/// Let objects take care of everything that belongs to the object!!
/// </summary>


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    class WholeNumbersFor
    {
        //Declare a variable 
        private int numOfInput; // num of values to be added
        private int sum; // result of the summation

        // ---------------------------------------------
        // public void method that performs the whole process

        public void Start()
        {
            // to write the program info
            WriteProgramInfo();

            // to read input from the user
            ReadInput();

            // to perform the calculation / summation
            SumNumbers();

            // to show the result
            ShowResult();
        }

        // to write the information of the program
        private void WriteProgramInfo()
        {
            Console.WriteLine("\n\n +++++++ Summation of whole numbers +++++++++ ");
            Console.WriteLine("                using 'for' statement\n");
            Console.WriteLine();
        }

        // to read input from the user
        private void ReadInput()
        {
            // determine how many numbers there are to be added
            Console.Write("Number of values to sum: ");

            numOfInput = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        private void SumNumbers()
        {
            // declaring local variables to store the user input of numbers
            int index; // counter variable
            int num = 0; // stores the value that user gives

            // A for-statement that iterates

            for (index = 0; index < numOfInput; index++)
            {
                // get the numbers
                Console.Write("Enter the value no {0}: ", index + 1);
                
                // to store the input on each iteration
                int givenNumber = int.Parse(Console.ReadLine());
                num += givenNumber;
            }

            sum = num;
        }

        private void ShowResult()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine(" The sum of {0} numbers that you have entered is : {1}", numOfInput, sum);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
        }
    }
}
