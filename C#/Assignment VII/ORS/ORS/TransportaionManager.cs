// File Name: TransportationManager.cs
// Created By: Padma Priya Duvvuri
// Created On: 22-Dec-2011

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace ORS
{
    /// <summary>
    /// A manager class that acts as a media between MainForm and the Transport Class
    /// </summary>
    class TransportationManager
    {
        //Instance Variables
        private ArrayList m_transportDetails; //arraylist to save transport details
        private int maxNoOfTransports = 100; // max. no.of tranpsports
        Transport m_transport; //transport object

        /// <summary>
        /// Default constuctor that initializes the arraylist
        /// </summary>
        public TransportationManager()
        {
            m_transportDetails = new ArrayList();
        }

        /// <summary>
        /// Read and write property for transportDetails
        /// </summary>
        public ArrayList TransportDetails
        {
            get { return m_transportDetails; }
            set { m_transportDetails  = value; }
        }

        /// <summary>
        /// Read and write property for maxNoOfTransports
        /// </summary>
        public int MaxTransports
        {
            get { return maxNoOfTransports; }
        }

 
        /// <summary>
        /// This method checks wheter total number of transports is less than
        /// max number of transports
        /// </summary>
        /// <returns>true if within range and false otherwise</returns>
        private bool CheckTransporst()
             {
            if (m_transportDetails.Count <= maxNoOfTransports) 
                return true;
            else
                return false;
        }


        /// <summary>
        /// Read-only property to count no.of Transport details
        /// </summary>
        public int CountTransport
        {
            get { return m_transportDetails.Count; }
        }

     
        /// <summary>
        /// Adds a new transport object to details arraylist
        /// </summary>
        /// <param name="transport">transport object</param>
        /// <returns>true if new detail is added , false otherwise</returns>
        public bool AddTransport(Transport transport)
        {
            if (CheckTransporst())
            {
                m_transportDetails.Add(transport);
                return true;
            }
            else
                return false;
        }


        /// <summary>
        /// Returns details at perticular index
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>Transport object</returns>
        public Transport  GetTransport(int index)
        {
            return (Transport)m_transportDetails[index];
        }

        /// <summary>
        /// Devides the perticular string and stores the values into array
        /// of strings
        /// </summary>
        /// <param name="str">the string to be divided</param>
        /// <returns>array of strings</returns>
        public string[] GetTransportationDetails(string str)
        {

            string[] words = str.Split(',');
            return words;
        }

        /// <summary>
        /// write only property for m_transport
        /// </summary>
        public Transport Transport
        {  
            set { m_transport   = value; }
        
        }
    }
}
