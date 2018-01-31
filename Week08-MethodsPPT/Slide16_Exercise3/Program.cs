using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 8 : METHODS PPT
/// </summary>
namespace Slide16_Exercise3
{
    class Program
    {
        public static double CalculateTax(double price)
        {
            double tax = price * 0.14;

            return tax;
        }

        static void Main(string[] args)
        {
            double price = 12.50;
            double tax = CalculateTax(price);
            double cost = price + tax;

            Console.WriteLine("Total cost: {0:c}", cost);
        }
    }
}
