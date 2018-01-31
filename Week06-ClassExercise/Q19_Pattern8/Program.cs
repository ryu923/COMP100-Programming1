using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q19_Pattern8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q19.
             
                            *
                           ***
                          *****
                         *******
                        *********
                         *******
                          *****
                           ***
                            *

             */

Console.WriteLine("[Question 19]");

int row = 0;

do
{
    int column = 0;

    do
    {
        if((row + column < 4) || (column - row > 4) || (row - column > 4) || (row + column > 12))
        {
            Console.Write(" ");
        }
        else
        {
            Console.Write("*");
        }

        column++;
    } while (column < 9);

    Console.WriteLine();

    row++;
} while (row < 9);
        }
    }
}
