using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week03 - Class Exercise - Data Types
/// </summary>
namespace Q8_Wire
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q8. Write a program to calculate and display the potential difference between the ends of a wire.
             * The program will prompt the user for the current flowing and the resistance of the wire.
             * (Potential difference is the product of the current and the resistance of the wire and may include a fractional part)
             */

            Console.WriteLine("[Question 8 : Wire]");

            Console.Write("Enter the current flowing of the wire: ");
            double current = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the resistance of the wire: ");
            double resistance = Convert.ToDouble(Console.ReadLine());

            double pDifference = current * resistance;

            Console.WriteLine("\nThe Result as below -----");
            Console.WriteLine("The potential difference of the wire is " + pDifference);
        }
    }
}
