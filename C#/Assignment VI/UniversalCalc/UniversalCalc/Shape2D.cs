//File Name: Shape2D.cs
//Created By: Padma Priya Duvvuri
//Created On: 01-Dec-2011
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversalCalc
{
    /// <summary>
    /// This class inherits the Shape class and is to serve as a base class fto all the 2D figures
    /// </summary>
    public class Shape2D : Shape
    {
       // width of rectangle
        private double maxWidth;
        // height of rectangle
        private double maxHeight;

        /// <summary>
        /// Constructor with 2 parameters.
        /// </summary>
        public Shape2D(double width, double height)
        {
            maxWidth = width;
            maxHeight = height;
        }

        /// <summary>
        /// To read and write maxWidth
        /// </summary>
        public double Width
        {
            get
            {
                return maxWidth ;
            }
            set
            {
                maxWidth = value;
            }
        }

        /// <summary>
        /// To read and write maxHeight
        /// </summary>
        public double Height
        {
            get
            {
                return maxHeight ;
            }
            set
            {
                maxHeight = value;
            }
        }

        /// <summary>
        /// Calculates the are of the rectangle, It is overridable so as to 
        /// be usable by other classes which implements this class
        /// </summary>
        /// <returns>Area of the rectangle</returns>
        public virtual double GetArea()
        {
            return maxHeight * maxWidth;
        }
    }
}
