using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 7 - Class Exercise : DO WHILE, WHILE, FOR Loop
/// </summary>
namespace Q05_Conversion2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q5. Write a C# program that converts feet to meters.
             * The program should display feet from 3 to 30 in three-foot increments and the corresponding meter equivalents.
             * Use the relationship that 1 meter is equivalent to 3.28 feet.
             */

            Console.WriteLine("[Question 5A : DO-WHILE Loop]");

            Console.WriteLine("  FEET | METER  ");
            Console.WriteLine("================");

            int feet = 3;
            double meter;

            do
            {
                meter = feet * 3.28;

                Console.WriteLine("{0,5}  | {1,4:F2}", feet, meter);

                feet += 3;
            } while (feet <= 30);


            Console.WriteLine("\n\n[Question 5B : WHILE Loop]");

            Console.WriteLine("  FEET | METER  ");
            Console.WriteLine("================");

            int feetB = 3;
            double meterB;

            while(feetB <= 30)
            {
                meterB = feetB * 3.28;

                Console.WriteLine("{0,5}  | {1,4:F2}", feetB, meterB);

                feetB += 3;
            }


            Console.WriteLine("\n\n[Question 5C : FOR Loop]");

            Console.WriteLine("  FEET | METER  ");
            Console.WriteLine("================");

            double meterC;

            for(int feetC = 3; feetC <= 30; feetC +=3)
            {
                meterC = feetC * 3.28;

                Console.WriteLine("{0,5}  | {1,4:F2}", feetC, meterC);
            }
        }
    }
}
