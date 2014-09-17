using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowAndHighRates.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hourly pay rate");
            string input = Console.ReadLine();
            double hpr;
            hpr = Convert.ToDouble(input);
            if (hpr < 5.65 || hpr > 49.99)
                Console.WriteLine("Error");
        }
    }
}
