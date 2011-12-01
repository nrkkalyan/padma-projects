//File Name: Shape3D.cs
//Created By: Padma Priya Duvvuri
//Created On: 01-Dec-2011
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversalCalc
{
    /// <summary>
    /// This class inherits the class Shape and is the base class to all the 3D figures
    /// </summary>
    public class Shape3D : Shape
    {
        private double maxLenght;

        /// <summary>
        /// constructor with one paramter.
        /// </summary>
        /// <param name="lenght">Input - lenght</param>
        public Shape3D(double lenght)
        {
            maxLenght = lenght;
        }

        /// <summary>
        /// read and write property for lenght
        /// </summary>
        public double Length
        { 
            get { return maxLenght; }
            set { maxLenght = value;}
        }
    }
}
