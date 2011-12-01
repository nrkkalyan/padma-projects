//File Name: Rectangle.cs
//Created By: Padma Priya Duvvuri
//Created On: 01-Dec-2011
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversalCalc
{
    /// <summary>
    /// This class inherits the Shape2D class
    /// </summary>
    public class Rectangle : Shape2D
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {
            base.ShapeType = Shapes.Rectangle;
        }

        /// <summary>
        /// Calls the base class Area method to return area. It is a read only property.
        /// </summary>
        public double Area { get { return  base.GetArea(); } }

        /// <summary>
        /// Uses the base class height and width properties. It is a read only property to give Circumference
        /// </summary>
        public double Circum { get { return 2 *(base.Height + base.Width);} }
    }
}
