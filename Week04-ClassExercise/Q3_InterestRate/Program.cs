using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week04 - Class Exercise - Selection
/// </summary>
namespace Q3_InterestRate
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q3. If money is left in a particular bank for more than 5 years,
             * the interest rate given by the bank is 7.5%,
             * else the interest rate is 5.4%.
             * Write a program that prompt the user for the number of years
             * that the money was left in the bank
             * and display the appropriate interest rate depending on the value input.
             * How many runs should you make to very that it works correctly?
             */

            Console.WriteLine("[Question 3 : InterestRate]");

            Console.Write("How many years do you want to left your money in the bank? ");
            int years = Convert.ToInt32(Console.ReadLine());

            if(years > 5)
            {
                Console.WriteLine("Your can get 7.5% interest rate for {0} years", years);
            }
            else
            {
                Console.WriteLine("Your can get 5.4% interest rate for {0} year(s)", years);
            }
        }
    }
}
