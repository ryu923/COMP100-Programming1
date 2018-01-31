using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 6 - Class Exercise : DO WHILE Loop
/// </summary>
namespace Q10_Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q10. A conversion table of Celsius to Fahrenheit temperature.
             * The table must start with 0 Celsius and end at 100 Celsius with increments of 10.
             * (Fahrenheit = Celsius * 9/5 + 32)
             */

            Console.WriteLine("[Question 10]");

            double celsius = 0, fahrenheit = 0;

            Console.WriteLine("Celsius | Fahrenheit");
            Console.WriteLine("====================");

            do
            {
                fahrenheit = (celsius * 9 / 5) + 32;

                Console.WriteLine("{0,5}   |{1,8:F1}", celsius, fahrenheit);

                celsius += 10;
            } while (celsius <= 100);
        }
    }
}
