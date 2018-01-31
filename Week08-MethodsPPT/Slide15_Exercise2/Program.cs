using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 8 : METHODS PPT
/// </summary>
namespace Slide15_Exercise2
{
    class Program
    {
        public static void DisplayAreaOfCircle(double radius)
        {
            double area = Math.PI * radius * radius;

            Console.WriteLine("A circle with radius of {0:f2} will have an area of {1:f2}", radius, area);
        }

        static void Main(string[] args)
        {
            DisplayAreaOfCircle(1.0);
        }
    }
}
