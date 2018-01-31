using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week04 - Class Exercise - Selection
/// </summary>
namespace Q7_Pay4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q7. Write a console-based program that prompts the user for an hourly pay rate and hours worked.
             * Compute gross pay (hours times pay rate), withholding tax, and net pay (gross pay minus withholding tax).
             * Withholding tax is computed as a percentage of gross pay based on the following:
             * 
             *          Gross Pay	         |   Withholding Percentage
             * ------------------------------|--------------------------
             * Up to and including 300.00	 |             10%
             *      More than 300.00	     |             12%
             */

            Console.WriteLine("[Question 7 : Pay4]");

            Console.Write("Enter the hourly pay rate: ");
            double hPay = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the hourly worked: ");
            double hWork = Convert.ToDouble(Console.ReadLine());

            double grossPay = hPay * hWork;
            double tax;
            double netPay;

            if(grossPay <= 300)
            {
                tax = grossPay * 0.1;
                netPay = grossPay - tax;

                Console.WriteLine("\nGross Pay: {0:C2}", grossPay);
                Console.WriteLine("   Tax   : {0:C2}", tax);
                Console.WriteLine(" Net Pay : {0:C2}", netPay);
            }
            else
            {
                tax = grossPay * 0.12;
                netPay = grossPay - tax;

                Console.WriteLine("\nGross Pay: {0:C2}", grossPay);
                Console.WriteLine("   Tax   : {0:C2}", tax);
                Console.WriteLine(" Net Pay : {0:C2}", netPay);
            }
        }
    }
}
