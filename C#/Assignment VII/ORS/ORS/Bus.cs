using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORS
{
    class Bus : Transport 
    {
        public Bus(string number,Stations from,Stations to, DateTime time, decimal priceA,decimal priceC) : base(number,from,to,time,priceA,priceC)
        { }
        public Bus(decimal price ):base(price)
        { }
        public override decimal GetPrice(int adults, int children, decimal price)
        {
            return base.GetPrice(adults, children,price);
        }
    }
}
