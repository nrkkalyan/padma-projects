// File Name: Bus.cs
// Created By: Padma Priya Duvvuri
// Created On: 22-Dec-2011

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORS
{
    /// <summary>
    /// This class inherits from Transport Class
    /// </summary>
    class Bus : Transport 
    {
        /// <summary>
        /// Constructor that takes 6 parameters, It calls the base class contructor
        /// to set the values
        /// </summary>
        /// <param name="number">Bus Number</param>
        /// <param name="from">From station</param>
        /// <param name="to">to station</param>
        /// <param name="time">time of departure</param>
        /// <param name="priceA">price for adult</param>
        /// <param name="priceC">price for children</param>
        public Bus(string number,Stations from,Stations to, DateTime time, decimal priceA,decimal priceC) : base(number,from,to,time,priceA,priceC)
        { }
        
        /// <summary>
        /// Constructor that takes one parameter, It calls base class 
        /// constructor to set the values
        /// </summary>
        /// <param name="price">Price for adult</param>
        public Bus(decimal price ):base(price)
        { }
       
    }
}
