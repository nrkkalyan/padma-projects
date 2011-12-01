//File Name: Shape.cs
//Created By: Padma Priya Duvvuri
//Created On: 01-Dec-2011
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversalCalc
{
    /// <summary>
    /// This class defines the shapes in general.
    /// </summary>
    public class Shape
    {
        //private variable shapeType
        private Shapes shapeType;

        /*/// <summary>
        /// Constructor - assigns default value as BaseShape
        /// </summary>
        public Shape()
        {
            shapeType = Shapes.Rectangle;
        }*/

        /// <summary>
        /// Property to read and write shape type
        /// </summary>
        public Shapes ShapeType
        {
            get
            {
                return shapeType;
            }
            set
            {
                shapeType = value;
            }
        }

        /// <summary>
        /// This method checks wheter selected figure is a 2D or a 3D figure
        /// </summary>
        /// <returns>True if figure is 3D(prism, cylinder , sphere) and 
        /// false otherwise(rectagle, circle)</returns>
        public bool DimensionType()
        {
            //local variable to check dimension
            bool is3D = true;

            if (shapeType == Shapes.Rectangle || shapeType == Shapes.Circle)
            {
                is3D = false;
            }
            return is3D;
        }

        /// <summary>
        /// This returns a string formatted withe name of the shape
        /// </summary>
        /// <returns>String with name of Shape</returns>
        public override string ToString()
        {
            return shapeType.ToString();
        }
    }
}
