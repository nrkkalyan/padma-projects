// File Name: Transport.cs
// Created By: Padma Priya Duvvuri
// Created On: 22-Dec-2011

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORS
{
    /// <summary>
    /// Base class for Bus, Train and Flight Classes
    /// </summary>
    public class Transport
    {
        //Instance variables
        string m_transportNumber; //number or ID of transport
        Stations fromStation; // from station
        Stations toStation; // to station
        DateTime timeOfTransport; // time of transport
        decimal priceAdult; //ticket price for adult
        decimal priceChild; //ticket price for child
       
        /// <summary>
        /// Read and Write property for m_transportNumber
        /// </summary>
        public string TransportationNumber
        {
            get
            {
                return m_transportNumber ;
            }
            set
            {
                m_transportNumber  = value;
            }
        }
        
        /// <summary>
        /// Read and Write property for fromStation
        /// </summary>
        public Stations FromStation
        {
            get
            {
                return fromStation ;
            }
            set
            {
                fromStation  = value;
            }
        }
        
        /// <summary>
        /// Read and Writer property for toStation
        /// </summary>
        public Stations ToStation
        {
            get
            {
                return toStation;
            }
            set
            {
               toStation = value;
            }
        }
        
        /// <summary>
        /// Read and Write property for timeOfTransport
        /// </summary>
        public DateTime  Time
        {
            get
            {
                return timeOfTransport ;
            }
            set
            {
                timeOfTransport  = value;
            }
        }
        
        /// <summary>
        /// Read and Write property for priceAdult
        /// </summary>
        public decimal PriceAdult
        {
            get
            {
                return priceAdult ;
            }
            set
            {
                priceAdult  = value;
            }
        }
        
        /// <summary>
        /// Read and Write property for priceChild
        /// </summary>
        public decimal PriceChild
         {
             get
             {
                 return priceChild;
             }
             set
             {
                 priceChild = value;
             }
         }

        /// <summary>
        /// Constructor that takes 6 parameters,It initializes the values
        /// </summary>
        /// <param name="number">Bus Number</param>
        /// <param name="from">From station</param>
        /// <param name="to">to station</param>
        /// <param name="time">time of departure</param>
        /// <param name="priceA">price for adult</param>
        /// <param name="priceC">price for children</param>
        public Transport(string number, Stations from, Stations to, DateTime time, decimal price,decimal priceChildren)
        {
            m_transportNumber = number;
            fromStation = from;
            toStation = to;
            timeOfTransport = time;
            priceAdult = price;
            priceChild = priceChildren;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Transport()
            : this(string.Empty, Stations.Stockholm, Stations.Paris, DateTime.Now, 0, 0)
        {
        }

        /// <summary>
        /// Constructor that takes one parameter, It calls base class 
        /// constructor to set the values
        /// </summary>
        /// <param name="price">Price for adult</param>
        public Transport(decimal price)
            : this(string.Empty, Stations.Stockholm, Stations.Paris, DateTime.Now, price, price * 0.5M)
        {
        }
      
        /// <summary>
        /// Overrides the string to give formatted string having all details that are provided for a Transport
        /// </summary>
        /// <returns>a fromatted string</returns>
        public override string ToString()
        {
            string str = string.Format("{0} ,{1},{2},{3},{4},{5}", m_transportNumber, fromStation.ToString(), toStation.ToString(), timeOfTransport.ToString("hh:mm tt"), priceAdult.ToString("#.##"), priceChild.ToString("#.##"));
            return str;
        }
    }
}
