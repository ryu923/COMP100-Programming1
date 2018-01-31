using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 7 - Class Exercise : DO WHILE, WHILE, FOR Loop
/// </summary>
namespace Q06_Conversion3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q6. Write a program that displays a conversion table from Fahrenheit to Celsius.
             * The program must request the starting Fahrenheit value, the ending Fahrenheit value, and the increment.
             * Thus, instead of the condition checking for a fixed count, the condition checks for the ending Fahrenheit value
             */

            Console.WriteLine("[Question 6A : DO-WHILE Loop]");

            Console.Write("Enter the starting FAHRENHEIT number: ");
            double startFahrenheit = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the ending FAHRENHEIT number: ");
            double endFahrenheit = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number of increment: ");
            double increment = Convert.ToDouble(Console.ReadLine());

            double celsius;

            Console.WriteLine();

            Console.WriteLine("FAHRENHEIT | CELSIUS");
            Console.WriteLine("====================");

            do
            {
                celsius = (startFahrenheit - 32) * 5 / 9;

                Console.WriteLine("{0,6}     | {1,6:F1}", startFahrenheit, celsius);

                startFahrenheit += increment;
            } while (startFahrenheit <= endFahrenheit);


            Console.WriteLine("\n\n[Question 6B : WHILE Loop]");

            Console.Write("Enter the starting FAHRENHEIT number: ");
            double startFahrenheitB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the ending FAHRENHEIT number: ");
            double endFahrenheitB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number of increment: ");
            double incrementB = Convert.ToDouble(Console.ReadLine());

            double celsiusB;

            Console.WriteLine();

            Console.WriteLine("FAHRENHEIT | CELSIUS");
            Console.WriteLine("====================");

            while(startFahrenheitB <= endFahrenheitB)
            {
                celsiusB = (startFahrenheitB - 32) * 5 / 9;

                Console.WriteLine("{0,6}     | {1,6:F1}", startFahrenheitB, celsiusB);

                startFahrenheitB += incrementB;
            }


            Console.WriteLine("\n\n[Question 6C : FOR Loop]");

            Console.Write("Enter the starting FAHRENHEIT number: ");
            double startFahrenheitC = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the ending FAHRENHEIT number: ");
            double endFahrenheitC = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number of increment: ");
            double incrementC = Convert.ToDouble(Console.ReadLine());

            double celsiusC;

            Console.WriteLine();

            Console.WriteLine("FAHRENHEIT | CELSIUS");
            Console.WriteLine("====================");

            for(; startFahrenheitC <= endFahrenheitC; startFahrenheitC += incrementC)
            {
                celsiusC = (startFahrenheitC - 32) * 5 / 9;

                Console.WriteLine("{0,6}     | {1,6:F1}", startFahrenheitC, celsiusC);
            }
        }
    }
}
