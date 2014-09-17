using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hourly pay rate");
            double HPR = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter hours worked");
            double HW = Convert.ToDouble(Console.ReadLine());


            double gross = HPR * HW;
            double witholding;
            if (gross > 300)
                witholding = .12;
            else
                witholding = .10;

            double NP = gross - (gross * witholding);

            Console.WriteLine("\n\nYour gross pay is $" + gross);
            Console.WriteLine("Your witholding tax is " + (witholding * 100) + "%");
            Console.WriteLine("Your net pay is $" + NP);
            Console.ReadLine();
        }
    }
}