using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 7 - Class Exercise : DO WHILE, WHILE, FOR Loop
/// </summary>
namespace Q04_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q4. Write a C# program that displays a conversion table from gallons to liters.
             * The program should display gallons from 10 to 20 in one-gallon increments and the corresponding litre equivalents.
             * Use the relationship that 1 gallon contains 3.785 liters.
             */

            Console.WriteLine("[Question 4A : DO-WHILE Loop]");

            Console.WriteLine("GALLONS | LITERS");
            Console.WriteLine("================");

            int gallon = 10;
            double liter;


            do
            {
                liter = gallon * 3.785;

                Console.WriteLine("{0,5}   | {1,5:F3}", gallon, liter);

                gallon++;
            } while (gallon <= 20);


            Console.WriteLine("\n\n[Question 4B : WHILE Loop]");

            Console.WriteLine("GALLONS | LITERS");
            Console.WriteLine("================");

            int gallonB = 10;
            double literB;

            while(gallonB <= 20)
            {
                literB = gallonB * 3.785;

                Console.WriteLine("{0,5}   | {1,5:F3}", gallonB, literB);

                gallonB++;
            }


            Console.WriteLine("\n\n[Question 4C : FOR Loop]");

            Console.WriteLine("GALLONS | LITERS");
            Console.WriteLine("================");

            double literC;

            for (int gallonC = 10; gallonC <= 20; gallonC++)
            {
                literC = gallonC * 3.785;

                Console.WriteLine("{0,5}   | {1,5:F3}", gallonC, literC);
            }
        }
    }
}
