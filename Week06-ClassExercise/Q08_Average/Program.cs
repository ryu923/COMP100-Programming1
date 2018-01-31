using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 6 - Class Exercise : DO WHILE Loop
/// </summary>
namespace Q08_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q8. Same as the previous question but additionally displays the average of the numbers at the end of the loop.
             * You will need a counter but not as a loop terminator.
             */

            Console.WriteLine("[Question 8]");

            int sum = 0, counter = 1;

            do
            {
                Console.Write("Enter the number: ");
                int input = Convert.ToInt32(Console.ReadLine());

                sum += input;
                counter++;
            } while (sum < 100);

            double average = sum / counter;

            Console.WriteLine("Sum of your inputs is {0} and average is {1:F1}", sum, average);
        }
    }
}
