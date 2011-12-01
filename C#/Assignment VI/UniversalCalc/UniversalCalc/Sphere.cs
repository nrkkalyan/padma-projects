//File Name: Sphere.cs
//Created By: Padma Priya Duvvuri
//Created On: 01-Dec-2011
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversalCalc
{
    /// <summary>
    /// This class inherits the Shape3D class and has a relation with the Ellipse class
    /// </summary>
    public class Sphere : Shape3D
    {
        //feild
        private Ellipse baseShape;

        /// <summary>
        /// constructor that initilaizes the values
        /// </summary>
        /// <param name="radius"></param>
        public Sphere(double radius)
            : base(radius)
        {
            baseShape = new Ellipse(radius);
            baseShape.ShapeType = Shapes.Sphere;
        }

        /// <summary>
        /// read only propterty to calculate the volume of the sphere
        /// </summary>
        public double Volume 
        {
            get
            {
                return 4 * baseShape.Area * base.Length/ 3;
            } 
        }

       /// <summary>
       /// read only property to calculate the Mantel Area of the sphere
       /// </summary>
        public double MantelArea 
        {
            get
            {
                return 4 * baseShape.Area;
            }
        }

        /// <summary>
        /// Read only property to calculate the total Area of the sphere
        /// </summary>
        public double TotalArea { get { return MantelArea; } }

        /// <summary>
        /// returns a copy of baseShape Object
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
