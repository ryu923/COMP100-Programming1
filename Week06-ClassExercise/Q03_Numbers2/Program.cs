using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 6 - Class Exercise : DO WHILE Loop
/// </summary>
namespace Q03_Numbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q3. To display the numbers 1 … 20 on separate lines
             */

            Console.WriteLine("[Question 3]");

            int i = 1;

            do
            {
                Console.WriteLine("{0}", i);

                i++;
            } while (i < 21);
        }
    }
}
