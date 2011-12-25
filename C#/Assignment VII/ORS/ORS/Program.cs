// File Name: Program.cs
// Created By: 
// Created On: 19-Dec-2011

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ORS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
