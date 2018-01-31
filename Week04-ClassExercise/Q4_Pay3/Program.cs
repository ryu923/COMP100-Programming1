using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week04 - Class Exercise - Selection
/// </summary>
namespace Q4_Pay3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q4. Write a console-based program that prompts a user for an hourly pay rate.
             * If the user enters values less than $7.50 or greater than $49.99, prompt the user again.
             * If the user enters an invalid value again, display an appropriate error message.
             * If the user enters a valid value on either the first or second attempt,
             * display the pay rate as well as the weekly rate,
             * which is calculated as 40 times the hourly rate.
             */

            Console.WriteLine("[Question 4 : Pay4]");

            Console.Write("Enter the hourly pay rate: ");
            double hPay = Convert.ToDouble(Console.ReadLine());

            if (hPay >= 7.50 && hPay <= 49.99)
            {
                Console.WriteLine("Your hourly pay rate is {0:C2}", hPay);

                double wPay = hPay * 40;

                Console.WriteLine("Your weekly pay rate is {0:C2}", wPay);
            }
            else
            {
                Console.WriteLine("Error! hourly pay rate higher than $7.50 and less than $49.99");
                Console.WriteLine("Please, try again.");

                Console.Write("\nEnter the hourly pay rate: ");
                double hPay2 = Convert.ToDouble(Console.ReadLine());

                if(hPay2 >= 7.50 && hPay2 <= 49.99)
                {
                    Console.WriteLine("Your hourly pay rate is {0:C2}", hPay2);

                    double wPay2 = hPay2 * 40;

                    Console.WriteLine("Your weekly pay rate is {0:C2}", wPay2);
                }
                else
                {
                    Console.WriteLine("Error, again! hourly pay rate higher than $7.50 and less than $49.99");
                }
            }
        }
    }
}
