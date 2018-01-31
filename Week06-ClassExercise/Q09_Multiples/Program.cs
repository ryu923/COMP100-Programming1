using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 6 - Class Exercise : DO WHILE Loop
/// </summary>
namespace Q09_Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q9. To display the sum of all the multiples of 3 between 1000000 and 2000000.
             * (Answer = 499,999,500,000).
             * If the sum might be larger than 2billion then the type of sum should be a long and not an int.
             */

            Console.WriteLine("[Question 9]");

            double number = 1000000, sum = 0;

            do
            {
                if (number % 3 == 0)
                    sum += number; 

                number++;
            } while (number <= 2000000);

            Console.WriteLine("{0:N0}", sum);
        }
    }
}
