
// Filename Book.cs
// Written by <Padma Priya Duvvuri>
// Written on <05-Sept-2011>

///<summary>
///This class reads the input from the command line and calcuates the values.
///Also prints the receipt.
///</summary>



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBookie
{
    class Book
    {
        // Declaring variables for storing input
        private string bookTitle;
        private string author;
        private double bookPrice;
        private int publishedYear;
        private int numberOfCopies;
        private bool isNewPrint;

        // Declaring variables for storing output
        private double finalDiscount;
        private double finalPrice;
        private string condition;

        // Declaring constants
        private const double discountA = 0.11, discountB = 0.18, discountC = 0.24;

        public void Start()
        {
            // Print welcome message
            WelcomeMessage();
            
            // read input
            ReadInput();
            
            // calculate the final price
            CalculatePrice();
            
            // print the receipt
            PrintReceipt();

        }

        // to print welcome message
        private void WelcomeMessage()
        {
            Console.WriteLine("+++++++++++++  WELCOME TO E-BOOKIE ++++++++++++");
            Console.WriteLine("+++");
            Console.WriteLine("+++ There is a 18% discount on New prints and 24% discount on Used books!");
            Console.WriteLine("+++ Order more than 5 books to get another 11% discount!!!");
            Console.WriteLine("+++");
            Console.WriteLine("++++++++++ Waiting for your order!!! ++++++++++");
            Console.WriteLine();
            Console.WriteLine();
        }

        // to read users input
        private void ReadInput()
        {
            // 1. Read title of the book
            ReadTitle();

            // 2. Read author's name
            ReadAuthorName();

            // 3. Read book's price
            ReadPrice();

            // 4. Read the pubhlished year
            ReadPublishedYear();
            
            // 5. Read no. of copies required
            ReadCopies();

            // 6. Ask the reading whether they want used one or a new print
            ReadIfIsNew();
        }

                private void ReadTitle()
                {
                    Console.Write("Enter the Title of the book: ");
                    bookTitle = Console.ReadLine();
                }

                private void ReadAuthorName()
                {
                    Console.Write("Enter the Author's Name: ");
                    author = Console.ReadLine();
                }

                private void ReadPrice()
                {
                    Console.Write("Enter the Price of the book: ");
                    bookPrice = Convert.ToDouble(Console.ReadLine());
                }

                private void ReadPublishedYear()
                {
                    Console.Write("Enter the published year: ");
                    publishedYear = Convert.ToInt16(Console.ReadLine());
                }

                private void ReadCopies()
                {
                    Console.Write("Enter the number of copies required: ");
                    numberOfCopies = Convert.ToInt16(Console.ReadLine());
                }

                private void ReadIfIsNew()
                {
                    Console.Write("Do you want a new print (Y/N)?: ");
                    char response = char.Parse(Console.ReadLine());

                    if (response == 'y' || response == 'Y')
                    {
                        isNewPrint = true;
                        condition = "New";
                    }
                    else
                    {
                        isNewPrint = false;
                        condition = "Used";
                    }
                }

         
        // to calcuate the prices
        private void CalculatePrice()
        {
            if (numberOfCopies > 5)
            {
                if (isNewPrint == true)
                    finalDiscount = numberOfCopies * bookPrice * (discountA + discountB);
                else
                    finalDiscount = numberOfCopies * bookPrice * (discountA + discountC);
            }
            else
            {
                if (isNewPrint == true)
                    finalDiscount = numberOfCopies * bookPrice * discountB;
                else
                    finalDiscount = numberOfCopies * bookPrice * discountC;
            }

            finalPrice = (numberOfCopies * bookPrice) - finalDiscount;
        }

        // to print receipt
        private void PrintReceipt()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("++++++++++++ WELCOME TO EBookie - Online book store +++++++++++++");
            Console.WriteLine("+++");
            Console.WriteLine("+++ Title of the Book  \t\t\t\t{0}", bookTitle);
            Console.WriteLine("+++ Author's name \t\t\t\t{0}", author);
            Console.WriteLine("+++ Published year\t\t\t\t{0}", publishedYear);
            Console.WriteLine("+++ Condition of the book\t\t\t{0}", condition);
            Console.WriteLine("+++ Unit Price\t\t\t\t\t{0}", bookPrice);
            Console.WriteLine("+++ Number of copies \t\t\t\t{0}", numberOfCopies);
            Console.WriteLine("+++");
            Console.WriteLine("+++ Total Price \t\t\t\t${0}", numberOfCopies * bookPrice);
            Console.WriteLine("+++ Final discount at {0}% \t\t\t${1}",(finalDiscount * 100 /(bookPrice * numberOfCopies)) ,finalDiscount);
            Console.WriteLine("+++ Final Price \t\t\t\t${0}", finalPrice);
            Console.WriteLine("+++");
            Console.WriteLine("+++++++++++++++++++++++++ VISIT AGAIN! +++++++++++++++++++++++++");
            Console.WriteLine();
            Console.WriteLine();
        }


    }
}
