using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week04 - Class Exercise - Selection
/// </summary>
namespace Q8_lawnMowing
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q8. Write a console-based program for a lawn-mowing service.
             * The lawn-mowing season lasts 20 weeks.
             * The weekly fee for mowing a lot under 400 square feet is $25 per week.
             * The fee for a lot that is 400 square feet or more, but under 600 square feet, is $35 per week.
             * The fee for a lot that is 600 square feet or over is $50 per week.
             * Prompt the user for the length and width of a lawn, and then display the weekly mowing fee,
             * as well as the total fee for the 20-week season.
             */

            Console.WriteLine("[Question 8 : Lawn Mowing]");

            Console.Write("Enter the length of lawn: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the width of lawn: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;
            double cost;

            if(area < 400)
            {
                cost = 25 * 20;

                Console.WriteLine("\nTotal fee for {0} square feet is {1:C}", area, cost);
            }
            else if(area >= 400 && area < 600)
            {
                cost = 35 * 20;

                Console.WriteLine("\nTotal fee for {0} square feet is {1:C}", area, cost);
            }
            else
            {
                cost = 50 * 20;

                Console.WriteLine("Total fee for {0} square feet is {1:C}", area, cost);
            }
        }
    }
}
