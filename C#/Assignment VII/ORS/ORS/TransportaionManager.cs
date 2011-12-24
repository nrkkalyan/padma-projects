using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace ORS
{
    class TransportaionManager
    {
        private ArrayList busDetails;
        int noOfBusSeats = 70;
        private ArrayList trainDetails;
        int noOfTrainSeats = 400;
        private ArrayList flightDetails;
        int noOfFlightSeats = 230;

        public TransportaionManager()
        {
            busDetails = new ArrayList();
            trainDetails = new ArrayList();
            flightDetails = new ArrayList();
            
        }

        public ArrayList Bus
        {
            get { return busDetails; }
            set { busDetails = value; }
        }
        public ArrayList Train
        {
            get { return trainDetails ; }
            set { trainDetails  = value; }
        }
        public ArrayList Flight
        {
            get { return flightDetails ; }
            set { flightDetails  = value; }
        }

        public int BusSeats
        {
            get
            {
                return noOfBusSeats;
            }
            set
            {
                noOfBusSeats = value;
            }
        }
        public int TrainSeats
        {
            get
            {
                return noOfTrainSeats ;
            }
            set
            {
                noOfTrainSeats  = value;
            }
        }
        public int FlightSeats
        {
            get
            {
                return noOfFlightSeats ;
            }
            set
            {
                noOfFlightSeats  = value;
            }
        }

        private bool CheckBusSeats()
             {
            if (busDetails.Count <= noOfBusSeats) 
                return true;
            else
                return false;
        }
        private bool CheckTrainSeats()
        {
            if (trainDetails.Count <= noOfTrainSeats )
                return true;
            else
                return false;
        }
        private bool CheckFlightSeats()
        {
            if (flightDetails.Count <= noOfFlightSeats )
                return true;
            else
                return false;
        }

        public int CountBusses
        {
            get { return busDetails.Count; }
        }
        public int CountTrains
        {
            get { return trainDetails.Count; }
        }
        public int CountFlights
        {
            get { return flightDetails.Count; }
        }
      
        public bool AddBus(Transport bus)
        {
            if (CheckBusSeats())
            {
                busDetails.Add(bus);
                return true;
            }
            else
                return false;
        }
        public bool AddTrain(Transport  train)
        {
            if (CheckTrainSeats ())
            {
                trainDetails.Add(train);
                return true;
            }
            else
                return false;
        }
        public bool AddFlight(Transport flight)
        {
            if (CheckFlightSeats())
            {
                flightDetails.Add(flight);
                return true;
            }
            else
                return false;
        }

        public Transport  GetBus(int index)
        {
            return (Transport)busDetails[index];
        }
        public Transport GetTrain(int index)
        {
            return (Transport)trainDetails[index];
        }
        public Transport GetFlight(int index)
        {
            return (Transport)flightDetails[index];
        }

        public string[] GetTransportationDetails(string str)
        {

            string[] words = str.Split(',');
            return words;
        }
    }
}
