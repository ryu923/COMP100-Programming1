using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 6 - Class Exercise : DO WHILE Loop
/// </summary>
namespace Q15_Pattern4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q15.
                         *******
                        * ******
                        ** *****
                        *** ****
                        **** ***
                        ***** **
                        ****** *
                        *******
             */

            Console.WriteLine("[Question 15]");

            int row = 0;

            do
            {
                int column = 0;

                do
                {
                    if(row == column)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                    column++;
                } while (column < 8);

                Console.WriteLine();

                row++;
            } while (row < 8);
        }
    }
}
