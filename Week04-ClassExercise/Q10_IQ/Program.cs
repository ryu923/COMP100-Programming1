using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week04 - Class Exercise - Selection
/// </summary>
namespace Q10_IQ
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q10. Write a console-based application that asks a user to enter an IQ score.
             * If the score is a number less than 0 or greater than 200, issue an error message;
             * otherwise, issue an “above average”, “average”, or “below average” message for scores over, at, or under 100, respectively.
             */

            Console.WriteLine("[Question 10 : IQ]");

            Console.Write("Enter the IQ score: ");
            int IQ = Convert.ToInt32(Console.ReadLine());

            if(IQ >= 0 && IQ < 100)
            {
                Console.Write("Below average");
            }
            else if(IQ == 100)
            {
                Console.Write("Average");
            }
            else if(IQ > 100 && IQ <= 200)
            {
                Console.Write("Above average");
            }
            else
            {
                Console.WriteLine("Error! IQ socre between 0 to 200.");
            }
        }
    }
}
