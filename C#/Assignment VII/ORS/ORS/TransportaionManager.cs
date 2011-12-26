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
        //Instance Cariables
        private ArrayList busDetails; //To store bus details and Max.no. busses
        int maxNoOfBusses = 70;
        private ArrayList trainDetails; //To store train details and Max.no. trains
        int maxNoOfTrains = 400;
        private ArrayList flightDetails; //To store flight details and Max.no. flights
        int maxNoOfFlights = 230;

        /// <summary>
        /// Default constuctor that initializes the arraylists
        /// </summary>
        public TransportationManager()
        {
            busDetails = new ArrayList();
            trainDetails = new ArrayList();
            flightDetails = new ArrayList();
        }

        /// <summary>
        /// Read and write property for busDetails
        /// </summary>
        public ArrayList Bus
        {
            get { return busDetails; }
            set { busDetails = value; }
        }

        /// <summary>
        /// Read and write property for trainDetails
        /// </summary>
        public ArrayList Train
        {
            get { return trainDetails ; }
            set { trainDetails  = value; }
        }

        /// <summary>
        /// Read and write property for flightDetails
        /// </summary>
        public ArrayList Flight
        {
            get { return flightDetails ; }
            set { flightDetails  = value; }
        }

        /// <summary>
        /// Read and write property for maxNoOfBusses
        /// </summary>
        public int BusSeats
        {
            get { return maxNoOfBusses; }
            set { maxNoOfBusses = value; }
        }

        /// <summary>
        /// Read and write property for maxNoOfTrains
        /// </summary>
        public int TrainSeats
        {
            get { return maxNoOfTrains ; }
            set { maxNoOfTrains  = value; }
        }

        /// <summary>
        /// Read and write property for maxNoOfFlights
        /// </summary>
        public int FlightSeats
        {
            get { return maxNoOfFlights ; }
            set { maxNoOfFlights  = value; }
        }

        /// <summary>
        /// This method checks wheter total number of busses is less than
        /// max number of busses
        /// </summary>
        /// <returns>true if within range and false otherwise</returns>
        private bool CheckBusses()
             {
            if (busDetails.Count <= maxNoOfBusses) 
                return true;
            else
                return false;
        }


        /// <summary>
        /// This method checks wheter total number of trains is less than
        /// max number of busses
        /// </summary>
        /// <returns>true if within range and false otherwise</returns>
        private bool CheckTrains()
        {
            if (trainDetails.Count <= maxNoOfTrains )
                return true;
            else
                return false;
        }


        /// <summary>
        /// This method checks wheter total number of flights is less than
        /// max number of busses
        /// </summary>
        /// <returns>true if within range and false otherwise</returns>
        private bool CheckFlights()
        {
            if (flightDetails.Count <= maxNoOfFlights )
                return true;
            else
                return false;
        }

        /// <summary>
        /// Read-only property to count no.of busses
        /// </summary>
        public int CountBusses
        {
            get { return busDetails.Count; }
        }

        /// <summary>
        /// Read-only property to count no.of trains
        /// </summary>
        public int CountTrains
        {
            get { return trainDetails.Count; }
        }

        /// <summary>
        /// Read-only property to count no.of flights
        /// </summary>
        public int CountFlights
        {
            get { return flightDetails.Count; }
        }
      
        /// <summary>
        /// Adds a new bus object to buss details arraylist
        /// </summary>
        /// <param name="bus">bus object</param>
        /// <returns>true if new detail is added , false otherwise</returns>
        public bool AddBus(Transport bus)
        {
            if (CheckBusses())
            {
                busDetails.Add(bus);
                return true;
            }
            else
                return false;
        }


        /// <summary>
        /// Adds a new train object to train details arraylist
        /// </summary>
        /// <param name="bus">bus object</param>
        /// <returns>true if new detail is added , false otherwise</returns>
        public bool AddTrain(Transport  train)
        {
            if (CheckTrains ())
            {
                trainDetails.Add(train);
                return true;
            }
            else
                return false;
        }


        /// <summary>
        /// Adds a new flight object to flight details arraylist
        /// </summary>
        /// <param name="bus">bus object</param>
        /// <returns>true if new detail is added , false otherwise</returns>
        public bool AddFlight(Transport flight)
        {
            if (CheckFlights())
            {
                flightDetails.Add(flight);
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
        public Transport  GetBus(int index)
        {
            return (Transport)busDetails[index];
        }

        /// <summary>
        /// Returns details at perticular index
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>Transport object</returns>
        public Transport GetTrain(int index)
        {
            return (Transport)trainDetails[index];
        }

        /// <summary>
        /// Returns details at perticular index
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>Transport object</returns>
        public Transport GetFlight(int index)
        {
            return (Transport)flightDetails[index];
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
        /// get and set transport property can be implemented if needed.
        /// </summary>
        public Transport Transport
        {
            get;
            set;
        }
    }
}
