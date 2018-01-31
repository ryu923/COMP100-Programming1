using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 6 - Class Exercise : DO WHILE Loop
/// </summary>
namespace Q14_Pattern3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q14.
                        ********
                        *      *
                        *      *
                        *      *
                        ********
             */

            Console.WriteLine("[Question 14]");

            int row = 0;

            do
            {
                if(row == 0 || row == 4)
                {
                    Console.WriteLine("*******");
                }
                else
                {
                    Console.WriteLine("*     *");
                }

                row++;
            } while (row < 5);
        }
    }
}
