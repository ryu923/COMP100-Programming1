using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week04 - Class Exercise - Selection
/// </summary>
namespace Q1_Pay
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q1. Write a console-based program that prompts the user for an hourly pay rate.
             * If the value entered is less than $7.50, display an error message.
             */

            Console.WriteLine("[Question 1 : Pay]");

            Console.Write("Enter the hourly pay rate: ");
            double hPay = Convert.ToDouble(Console.ReadLine());

            if(hPay >= 7.50)
            {
                Console.WriteLine("Your hourly pay rate is {0:C2}", hPay);
            }
            else
            {
                Console.WriteLine("Error! hourly pay rate higher than $7.50");
            }
        }
    }
}
