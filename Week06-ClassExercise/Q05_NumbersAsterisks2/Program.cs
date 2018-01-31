using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 6 - Class Exercise : DO WHILE Loop
/// </summary>
namespace Q05_NumbersAsterisks2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q5. To display the numbers 10 … 40 on separate lines with an asterisk before the multiples of 7.
             * (asterisk besides multiples)
             */

            Console.WriteLine("[Question 5]");

            int number = 10;

            do
            {
                if(number % 7 == 0)
                {
                    Console.WriteLine("*{0}", number);
                }
                else
                {
                    Console.WriteLine("{0}", number);
                }

                number++;
            } while (number < 41);
        }
    }
}
