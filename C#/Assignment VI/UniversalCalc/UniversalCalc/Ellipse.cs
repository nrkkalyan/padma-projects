//File Name: Ellipse.cs
//Created By: Padma Priya Duvvuri
//Created On: 01-Dec-2011
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversalCalc
{
    /// <summary>
    /// This class inherists the Shape2D class
    /// </summary>
    public class Ellipse : Shape2D
    {
        const double PI = (22 / 7);
        /// <summary>
        /// constructor having 2 parameters, it initializes the base class values.
        /// </summary>
        public Ellipse(double horRadius, double verRadius) : base(2*horRadius,2*verRadius)
        {
            base.ShapeType = Shapes.Ellipse;
        }

        /// <summary>
        /// constructoer having only 1 parameter, it in chains calls the constructor having 2 parameters.
        /// </summary>
        public Ellipse(double radius) : base(2*radius,2*radius)
        {
            base.ShapeType = Shapes.Circle;
        }

        /// <summary>
        /// Read only property for Area
        /// </summary>
        public double Area 
        { 
            get{
            return GetArea();
            }  
        }

        /// <summary>
        /// It overrides the base class area method
        /// </summary>
        /// <returns>Area of the ellipse</returns>
        public override double GetArea()
        {
            return base.GetArea() * PI /4;
        }

        /// <summary>
        /// read only property for the Circumference
        /// </summary>
        public double Circum { get { return GetCircum(); } }
        
        /// <summary>
        /// It calculates the cirucmference of the BaseShape
        /// </summary>
        /// <returns>Circumference</returns>
        private double GetCircum()
        {
            double xRadius = base.Width / 2;
            double yRadius = base.Height / 2;

            return 2 * PI * Math.Sqrt((Math.Pow(xRadius,2) + Math.Pow(yRadius,2))/2);
        }

        

    }
}
