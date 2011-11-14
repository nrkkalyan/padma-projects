//File: Customer.cs
//Created by: Padma Priya Duvvuri
//Created on: 10-Nov-2011

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Customer_Registry.Customer_Files
{
    public class Phone
    {
        // private fields for home and cell hone numbers
        private string m_home;
        private string m_cell;


        /// <summary>
        /// Constructor with two parameters. This is  constructor that has most
        /// number of parameters. It is in tis constructor that all coding 
        /// should be done.
        /// </summary>
        /// <param name="homePhone">Input - Home Phone</param>
        /// <param name="cellPhone">Input - Cell Phone</param>
        /// <remarks></remarks>
        public Phone(string homePhone, string cellPhone)
        {
            m_cell = cellPhone;
            m_home = homePhone;
           
        }


        /// <summary>
        /// Constructor with one parameter - calls the constructor with 
        /// two parameters, using a default value as the second argument.
        /// </summary>
        /// <param name="homePhone">input coming from the client object</param>
        /// <remarks></remarks>
        public Phone(string homePhone)
            :this(homePhone,string.Empty)
        { }


        /// <summary>
        /// Default constructor - calls another constructor in this class
        /// </summary>
        /// <remarks></remarks>
        public Phone()
            : this(string.Empty, string.Empty)
        { }


        /// <summary>
        /// Property related to the field m_home
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string Home
        {
            get { return m_home; }
            set { m_home = value; }
        }


        /// <summary>
        /// Property related to the field m_cell
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string Cell
        {
            get { return m_cell; }
            set { m_cell = value; }
        }


        /// <summary>
        /// Delivers a formatted string with data stored in the object. The values will
        /// appear as columns. 
        /// </summary>
        /// <returns>the Formatted strings.</returns>
        /// <remarks></remarks>
        public override string ToString()
        {
            string strOut = string.Format("{0,-12} {1,-12}",m_home,m_cell);
            return strOut;
        }

    }
}
