using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 6 - Class Exercise : DO WHILE Loop
/// </summary>
namespace Q06_Numbers3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q6. To display numbers 20 … 60 on separate lines skipping the multiple of 3.
             * You must print a blank line for each multiple.
             */

            Console.WriteLine("[Question 6]");

            int number = 20;

            do
            {
                if(number % 3 == 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("{0}", number);
                }

                number++;
            } while (number < 61);            
        }
    }
}
