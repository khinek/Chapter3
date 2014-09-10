using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
            {
            Console.WriteLine("value not in range");
            string input = Console.ReadLine();
            double hpr;
            hpr = Convert.ToDouble(input);

            if (hpr < 5.65)
                Console.WriteLine("ERROR");
            
            }
    }
}
