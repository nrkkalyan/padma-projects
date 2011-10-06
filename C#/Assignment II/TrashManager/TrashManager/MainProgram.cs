// MainProgram.cs
// Created by: Padma Priya Duvvuri
// Created on: 23-Sept-2011

/// <summary>
/// 
/// This Program demonstrates the usage of For, While and Do-while loop. 
/// This program gives the user the option to choose between various options and
/// will do the calculations depending on the selected choice. 
/// 
/// </summary>


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    class MainProgram
    {
    
        static void Main(string[] args)
        {
            // Creates an object of Menu.cs and calls its main method to initialize the program

            Menu menu = new Menu();

            // calling Start method of the Menu.cs
            menu.Start();

            // make the window wait till the execution is competed

            Console.ReadLine();
        }
    }
}
