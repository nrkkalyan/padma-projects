using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORS
{
    class Train :Transport 
    {
        public Train(string number, Stations from, Stations to, DateTime time, decimal priceA, decimal priceC)
            : base(number, from, to, time, priceA, priceC)
        { }
        public Train(decimal price):base(price)
        { }

        public override decimal GetPrice(int adults, int children,decimal price)
        {
            decimal trainAdultPrice = base.PriceAdult + 250.00M;
            decimal trainChildPrice = base.PriceChild + 100.00M;
            return (adults * trainAdultPrice) + (children * trainChildPrice);
        }
    }
}
