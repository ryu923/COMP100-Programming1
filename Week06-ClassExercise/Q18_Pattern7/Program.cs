using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 6 - Class Exercise : DO WHILE Loop
/// </summary>
namespace Q18_Pattern7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q18.
             
                         *          *
                          *        *
                           *      *
                            *    *
                             *  *
                              *

             */

            Console.WriteLine("[Question 18]");

            int row = 0;

            do
            {
                int column = 0;

                do
                {
                    if((row == column) || (row + column == 10))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                    column++;
                } while (column < 11);

                Console.WriteLine();

                row++;
            } while (row < 6);
        }
    }
}
