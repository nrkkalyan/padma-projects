using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORS
{
    public class Transport
    {
        string m_transportNumber;
        Stations fromStation;
        Stations toStation;
        DateTime timeOfTransport;
        decimal priceAdult = 100.00M;
        decimal priceChild = 50.00M;
       
        //TransportationType transportType;
       

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
         
         /* public TransportationType  TransportType
        {
            get
            {
                return transportType  ;
            }
            set
            {
                transportType   = value;
            }
        }
       */

        public Transport(string number, Stations from, Stations to, DateTime time, decimal price,decimal priceChildren)
        {
            m_transportNumber = number;
            fromStation = from;
            toStation = to;
            timeOfTransport = time;
            priceAdult = price;
            priceChild = priceChildren;
        }

        public Transport(int price) : this(string.Empty,Stations.Stockholm,Stations.Paris,DateTime.Now,price, price*0.5M)
        {
        }
        public Transport()
            : this(string.Empty, Stations.Stockholm, Stations.Paris, DateTime.Now, 0, 0)
        {
        }
        public Transport(decimal price)
            : this(string.Empty, Stations.Stockholm, Stations.Paris, DateTime.Now, price, price * 0.5M)
        {
        }
        public virtual decimal GetPrice(int adults, int children, decimal price)
        {
            priceAdult = price;
            priceChild = price * 0.5M;
            return (adults * priceAdult) + (children * priceChild);
        }

        public override string ToString()
        {
            string str = string.Format("{0} ,{1},{2},{3},{4},{5}", m_transportNumber, fromStation.ToString(), toStation.ToString(), timeOfTransport.ToString("hh:mm tt"), priceAdult.ToString("#.##"), priceChild.ToString("#.##"));
            return str;
        }
    }
}
