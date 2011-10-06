// Filename MainProgram.cs
// Written by <Padma Priya Duvvuri>
// Written on <29-Aug-2011>

/// <summary>
/// This program computes the final sell prices for products in a drugstore. 
/// Given the net price, type of product and the corresponding taxrate,
/// The program calculates the final amount to be paid by a customer.
/// This class creates an object (instance) of the Procut class which
/// encapsulate all data and operations about a product.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxCalculator
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            // Declare and create an instance of the product class.
            Product product = new Product();

            // Call the product-object's Start method
            product.Start();

            // The command prompt will close quickly after the program has executed
            // the instructions under the start method.
            // In order to see teh results, let the prompt window wait for an input (return)

            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
    }
}
