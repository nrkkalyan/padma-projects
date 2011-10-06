
// Filename Product.cs
// Written by <Padma Priya Duvvuri>
// Written on <29-Aug-2011>

///<summary>
///This class reads the input from the command line and calcuates the values.
///Also prints the receipt.
///</summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxCalculator
{
    class Product
    {
        // declaring variables for saving input
        private string name;
        private int count;
        private double unitPrice;
        private bool foodItem;

        // declaring variables for storing output
        private double totalVAT, totalNetValue;
        private int assignedVAT;

        // declaring constants
        private const double foodVATRate = 0.12, otherVATRate = 0.25;

        public void Start()
        {
            // Read input
            ReadInput();

            // Calculate total tax
            CalculateValues();

            // Calculate totalNetPrice, total Price
            PrintReceipt();
        }


        // reading the input from the user
        private void ReadInput()
        {
            //1. Read name of the product
            ReadName();

            //2. Read Price without VAT
            ReadNetUnitPrice();

            //3. Ask the user if the item is a food item
            ReadIfFoodItem();

            //4. Read number of items (quantity)
            ReadCount();
        }

        private void ReadCount()
        {
            Console.Write("Quantity: ");

            count = Convert.ToInt16(Console.ReadLine());
        }

        private void ReadIfFoodItem()
        {
            Console.Write("Food item (y/n): ");

            char response = char.Parse(Console.ReadLine());

            if ( (response == 'y') || (response == 'Y') )
                foodItem = true;
            else
                foodItem = false;
        }

        private void ReadNetUnitPrice()
        {
            Console.Write("Net Unit Price: ");

            unitPrice = Convert.ToDouble(Console.ReadLine());
        }

        private void ReadName()
        {
            Console.Write("Enter the product name: ");

            name = Console.ReadLine();
        }


        //Calculate totalnetValue TotalVat
        private void CalculateValues()
        {
            //check and calculate the totalVAT
            if (foodItem == true)
            {
                totalVAT = count * (unitPrice * foodVATRate);
                assignedVAT = Convert.ToInt16(foodVATRate * 100);
            }
            else
            {
                totalVAT = count * (unitPrice * otherVATRate);
                assignedVAT = Convert.ToInt16(otherVATRate * 100);
            }

            //calculate totalnetValue
            totalNetValue = (count * unitPrice) + totalVAT;
        }
        
        
        // Printing the Receipt
        private void PrintReceipt()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("++++++++++++++ WELCOME TO MY VIRTUAL DRUGSTORE +++++++++++++++");
            Console.WriteLine("+++");
            Console.WriteLine("+++ Name of the product  \t\t{0}", name);
            Console.WriteLine("+++ Quantity \t\t\t\t{0}", count);
            Console.WriteLine("+++ Unit Price\t\t\t\t{0}", unitPrice);
            Console.WriteLine("+++ Food item\t\t\t\t{0}", Convert.ToString(foodItem));
            Console.WriteLine("+++");
            Console.WriteLine("+++ Total amount to pay  \t\t{0}", totalNetValue);
            Console.WriteLine("+++ Including VAT at {0}%\t\t{1}", assignedVAT, totalVAT);
            Console.WriteLine("+++");
            Console.WriteLine("+++++++++++++++++++++ PLEASE COME AGAIN! +++++++++++++++++++++");
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
