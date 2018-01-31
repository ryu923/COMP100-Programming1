using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 8 : METHODS PPT
/// </summary>
namespace Slide19_Exercise6
{
    class Program
    {
        public static void PrintBlock(int row, int col)
        {
            for(int j = 0; j < row; j++)
            {
                PrintLine(col);

                Console.WriteLine();
            }
        }

        public static void PrintLine(int col)
        {
            for(int i = 0; i < col; i++)
            {
                Console.Write("*");
            }
        }

        static void Main(string[] args)
        {
            PrintBlock(10, 5);
        }
    }
}
