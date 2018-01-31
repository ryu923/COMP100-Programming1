using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week05 - Class Exercise : SWITCH Statement Exercise
/// </summary>
namespace Q06_FlowChart
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q6. Write a program to calculate the roots of a quadratic equation.
             * The flowchart below illustrates a possible solution.
             */

            Console.WriteLine("[Question 6 : Flow Chart]");

            Console.Write("Enter the number of a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number of b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number of c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a != 0)
            {
                double p = -b / 2 * a;
                double d = Math.Pow(b, 2) - 4 * a * c;

                if (d >= 0)
                {
                    double q = Math.Sqrt(d) / 2 * a;

                    Console.WriteLine("{0} + {1:F2}", p, q);
                    Console.WriteLine("{0} - {1:F2}", p, q);
                }
                else
                {
                    double q = Math.Sqrt(-d) / 2 * a;

                    Console.WriteLine("{0} + {1:F2}i", p, q);
                    Console.WriteLine("{0} - {1:F2}i", p, q);
                }
            }
            else
            {
                Console.WriteLine("Invalid input for a");
            }
        }
    }
}
