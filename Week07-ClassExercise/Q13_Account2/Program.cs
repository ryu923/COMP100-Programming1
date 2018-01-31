using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 7 - Class Exercise : DO WHILE, WHILE, FOR Loop
/// </summary>
namespace Q13_Account2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q13.	Write a C# program that calculates and displays the yearly amount available
               if $1,000 is invested in a bank account for 10 years.
             * Your program should display the amounts available for interest rates from 6 percent to 12 percent inclusively, at 1 percent increments.
             * Use a nested loop, with the outer loop having a fixed count of 7 and the inner loop a fixed count of 10.
             * The first iteration of the outer loop should use an interest rate of 6 percent
               and display the amount of money available at the end of the first 10 years.
             * In each subsequent pass through the outer loop, the interest rate should be increased by 1 percent.
             * Use the relationship that the money available at the end of each year equals the amount of money in the account
               at the start of the year plus the interest rate times the amount available at the start of the year.
             * The output of this program should be in the form of a table.
             */

            Console.WriteLine("[Question 13A : DO-WHILE Loop]");

            double rate = 6;

            do
            {
                Console.WriteLine("[{0}% INTEREST]", rate);
                Console.WriteLine();
                Console.WriteLine(" Year | Balance");
                Console.WriteLine("================");

                int year = 1;
                double balance = 1000;

                do
                {
                    balance += (balance * rate / 100);

                    Console.WriteLine("{0,4}  | {1,7:C1}", year, balance);

                    year++;
                } while (year <= 10);

                Console.WriteLine("\n");
                rate++;
            } while (rate <= 12);


            Console.WriteLine("\n\n[Question 13B : WHILE Loop]");

            double rateB = 6;

            while (rateB <= 12)
            {
                Console.WriteLine("\n\n[{0}% INTEREST]", rateB);
                Console.WriteLine();
                Console.WriteLine(" Year | Balance");
                Console.WriteLine("================");

                int yearB = 1;
                double balanceB = 1000;

                while(yearB <= 10)
                {
                    balanceB += (balanceB * rateB / 100);

                    Console.WriteLine("{0,4}  | {1,7:C1}", yearB, balanceB);

                    yearB++;
                }

                rateB++;
            }


            Console.WriteLine("\n\n[Question 13C : FOR Loop]");

            for(double rateC = 6; rateC <= 12; rateC++)
            {
                Console.WriteLine("\n\n[{0}% INTEREST]", rateC);
                Console.WriteLine();
                Console.WriteLine(" Year | Balance");
                Console.WriteLine("================");

                for (double yearC = 1, balanceC = 1000; yearC <= 10; yearC++)
                {
                    balanceC += (balanceC * rateC / 100);

                    Console.WriteLine("{0,4}  | {1,7:C1}", yearC, balanceC);
                }
            }
        }
    }
}
