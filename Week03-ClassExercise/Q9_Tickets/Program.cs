using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week03 - Class Exercise - Data Types
/// </summary>
namespace Q9_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q9. Adult ticket cost $3.75 and child ticket cost $2.25.
             * Write a program to prompt the user for the amount of adult and child ticket that she needs.
             * The program will display a user friendly message of the number of tickets brought as well as the total cost.
             * (Use the "C" format-specifier for currency)
             */

            Console.WriteLine("[Question 9 : Tickets]");

            Console.Write("Enter the number of adult tickets: ");
            double adult = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number of child tickets: ");
            double child = Convert.ToDouble(Console.ReadLine());

            double numberOfTickets = adult + child;
            double totalCost = (adult * 3.75) + (child * 2.25);

            Console.WriteLine("\nThe Result as below -----");
            Console.WriteLine("The total number of tickets are " + numberOfTickets);
            Console.WriteLine("The total cost is {0:C}", totalCost);
        }
    }
}
