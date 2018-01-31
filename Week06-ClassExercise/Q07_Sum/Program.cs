using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 6 - Class Exercise : DO WHILE Loop
/// </summary>
namespace Q07_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q7. To repeatedly prompt for a number and sum it.
             * When the sum just exceeds 100, stop the prompting and display the sum at the end.
             * You must not display the sum while the user in typing in numbers.
             * (You do not need a counter but you will need some way of terminating the loop)
             */

            Console.WriteLine("[Question 7]");

            int sum = 0;

            do
            {
                Console.Write("Enter the number: ");
                int input = Convert.ToInt32(Console.ReadLine());

                sum = sum + input; // Same with [sum += input;]

            } while (sum <= 100);

            Console.WriteLine("The sum of your inputs are {0}", sum);
        }
    }
}
