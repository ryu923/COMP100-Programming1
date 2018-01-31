using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week04 - Class Exercise - Structure Flow Chart
/// </summary>
namespace Q2_FlowChart2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q2. Write a program to display “Pass” or “Fail” depending on the user input.
             * The program prompts for a score (which may contain a decimal point),
               if the score is more than 70 then the output should be “Pass” otherwise the output should be “Fail”.
             */

            Console.WriteLine("[Question 2 : Flow Chart 2]");

            Console.Write("Enter the score: ");
            double score = Convert.ToDouble(Console.ReadLine());

            if (score > 70.00)
            {
                Console.WriteLine("You got {0:F2} points, you can pass", score);
            }
            else
            {
                Console.WriteLine("You got {0:F2} points, you can fail", score);
            }
        }
    }
}
