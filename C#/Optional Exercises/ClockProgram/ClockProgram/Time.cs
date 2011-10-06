using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClockProgram
{
    class Time
    {
        private string timeToday;
        private string timeInNewYork;
        private string timeInLondon;
        private string timeInMumbai;

        public void Start()
        {
            // calculate the time in different countries
            CalculateValues();

            // Print the values
            PrintValues();
        }

        public void CalculateValues()
        {
            timeToday = DateTime.Now.ToString("HH:mm");
            timeInNewYork = DateTime.Now.AddHours(-6).ToString("HH:mm");
            timeInLondon = DateTime.Now.AddHours(-1).ToString("HH:mm");
            timeInMumbai = DateTime.Now.AddHours(4).ToString("HH:mm");
        }

        public void PrintValues()
        {
            Console.WriteLine();
            Console.WriteLine("Time in Karlskrona: {0}", timeToday);
            Console.WriteLine("Time in New York: {0}", timeInNewYork);
            Console.WriteLine("Time in London: {0}", timeInLondon);
            Console.WriteLine("Time in Mumbai: {0}", timeInMumbai);
            Console.WriteLine();
        }
    }
}
