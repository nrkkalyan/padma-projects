// Filename MainProgram.cs
// Written by <Padma Priya Duvvuri>
// Written on <05-Sept-2011>


///<Summary>
///This program computes the final sell prices for the books in a book store.
///Given the price of the book, quantity needed and whether customer's want a new prints or the used books.
///The program caculates the final amount to be paid by the customer.
///
/// This class creates an object(instance) of the Book Class which 
/// encapsulates all data and operations about a book.
///</Summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBookie
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            // Declare and create an instance of the Book class
            Book book = new Book();

            // Call the book-object's start method
            book.Start();

            //Let the prompt window wait for an input
            Console.WriteLine("Press Enter to Exit!");
            Console.ReadLine();
        }
    }
}
