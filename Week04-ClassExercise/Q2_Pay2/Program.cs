using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week04 - Class Exercise - Selection
/// </summary>
namespace Q2_Pay2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q2. Write a console-based program that prompts a user for an hourly pay rate.
             * If the value entered is less than $7.50 or greater than $49.99, display an error message;
             * otherwise, display a message indicating that the rate is okay.
             */

            Console.WriteLine("[Question 2 : Pay2]");

            Console.Write("Enter the hourly pay rate: ");
            double hPay = Convert.ToDouble(Console.ReadLine());

            if(hPay >= 7.50 && hPay <= 49.99)
            {
                Console.WriteLine("Your hourly pay rate is {0:C2}", hPay);
            }
            else
            {
                Console.WriteLine("Error! hourly pay rate higher than $7.50 and less than $49.99");
            }
        }
    }
}
