using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 6 - Class Exercise : DO WHILE Loop
/// </summary>
namespace Q12_Pattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q12.	
                        ********
                        ********
                        ********              
             */

            Console.WriteLine("[Question 12]");

            int i = 1;

            do
            {
                if (i % 9 == 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.Write("*");
                }

                i++;
            } while (i <= 27);
        }
    }
}
