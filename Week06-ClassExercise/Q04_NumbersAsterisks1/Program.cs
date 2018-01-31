using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 6 - Class Exercise : DO WHILE Loop
/// </summary>
namespace Q04_NumbersAsterisks1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q4. To display the numbers 1 … 20 on separate lines with an asterisk next to multiples of 5. (multiples besides asterisk)
             */

            Console.WriteLine("[Question 4]");

            int number = 1;

            do
            {
                if (number % 5 == 0)
                {
                    Console.WriteLine("{0}*", number);
                }
                else
                {
                    Console.WriteLine("{0}", number);
                }

                number++;
            } while (number < 21);
        }
    }
}
