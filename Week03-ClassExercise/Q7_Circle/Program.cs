using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week03 - Class Exercise - Data Types
/// </summary>
namespace Q7_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q7. Write a program to calculate the area of a circle.
             * The user will enter the radius of the circle and the program will calculate and display the area according to the formula.
             * (area = 3.14 * radius * radius)
             * You must accept fractions as the input.
             */

            Console.WriteLine("[Question 7 : Circle]");

            Console.Write("Enter the radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double areaOfCircle = 3.14 * radius * radius;

            Console.WriteLine("\nThe Result as below -----");
            Console.WriteLine("The area of the circle is " + areaOfCircle);
        }
    }
}
