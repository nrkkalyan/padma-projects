//File Name: Cylinder.cs
//Created By: Padma Priya Duvvuri
//Created On: 01-Dec-2011
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversalCalc
{
    /// <summary>
    /// This class inherits Shape3D class and has a relation with Ellipse Clase
    /// </summary>
    public class Cylinder : Shape3D
    {// fields
        private Ellipse baseShape;

        /// <summary>
        /// constructor that takes 3 parameters. Sets the baseShapes values and passes the value of the 
        /// shape's lenght to the base class's length field
        /// </summary>
        /// <param name="width">Input - width Parameter</param>
        /// <param name="height">Input - height Parameter</param>
        /// <param name="lenght">Input - lenght parameter</param>
        public Cylinder(double horRadius, double verRadius, double lenght)
            : base(lenght)
        {
            baseShape = new Ellipse(horRadius,verRadius);
            baseShape.ShapeType = Shapes.Cylinder;
        }

        /// <summary>
        /// read only property for Volume
        /// </summary>
        public double Volume
        {
            get
            {
                return baseShape.Area * Length;
            }
        }

        /// <summary>
        /// read only property to calculate Mantel Area
        /// </summary>
        public double MantelArea
        {
            get
            {
                return baseShape.Circum * Length;
            }
        }

        /// <summary>
        /// read only property to calculate total Area.
        /// </summary>
        public double TotalArea
        {
            get
            { return MantelArea + (2 * baseShape.Area); }
        }

        /// <summary>
        /// returns a copy of baseShape
        /// </summary>
        public Ellipse BaseShape
        {
            get { return baseShape; }
            set { baseShape = value; }
        }
        
        public double BaseArea
        {
            get { return baseShape.Area; }
        }

        public double BaseCircum
        {
            get { return baseShape.Circum; }
        }

    }
}
