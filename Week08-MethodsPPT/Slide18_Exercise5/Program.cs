using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 8 : METHODS PPT
/// </summary>
namespace Slide18_Exercise5
{
    class Program
    {
        public static void PrintNumbers(int row, int col)
        {
            for(int j = 0; j < row; j++)
            {
                for(int i = 0; i < col; i++)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            PrintNumbers(10, 5);
        }
    }
}
