using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORS
{
    class Flight : Transport
    {
        public Flight(string number, Stations from, Stations to, DateTime time, decimal priceA, decimal priceC)
            : base(number, from, to, time, priceA,priceC)
        { }
        public Flight(decimal price):base(price)
        { }

        public override decimal GetPrice(int adults, int children,decimal price)
        {
            decimal flightAdultPrice = base.PriceAdult + 2500.00M;
            decimal flightChildPrice = base.PriceChild + 1000.00M;
            return (adults * flightAdultPrice) + (children * flightChildPrice);
        }
    }
}
