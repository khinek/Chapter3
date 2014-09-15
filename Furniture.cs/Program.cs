using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter P for pine, O for oak, or M for mahogany to show on of their prices");
            char input = Convert.ToChar(Console.ReadLine());
            if (input.Equals('P'))
                Console.WriteLine("The price for a pine table is $100");
            else if (input.Equals('O'))
                Console.WriteLine("The price for an oak table is $225");
            else if (input.Equals('M'))
                Console.WriteLine("The price for a mahogany tabel is $310");
            else
                Console.WriteLine("The price is $0");

  
        }
    }
}
