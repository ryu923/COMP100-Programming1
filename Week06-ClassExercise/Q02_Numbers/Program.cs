using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 6 - Class Exercise : DO WHILE Loop
/// </summary>
namespace Q02_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q2. To display the numbers 1 … 5 on separate lines
             */

            Console.WriteLine("[Question 2]");

            int i = 1;

            do
            {
                Console.WriteLine("{0}", i);

                i++;
            } while (i < 6);
        }
    }
}
