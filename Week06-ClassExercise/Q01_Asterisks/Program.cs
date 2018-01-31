using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 6 - Class Exercise : DO WHILE Loop
/// </summary>
namespace Q01_Asterisks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q1. To display five asterisks on a single line.
             * Each asterisk must be separated by a space.
             * You must use a do-while loop to solve this program
             */

            Console.WriteLine("[Question 1]");

            int i = 0;

            do
            {
                Console.Write("* ");
                i++;
            } while (i < 5);

            Console.WriteLine();
        }
    }
}
