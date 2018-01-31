using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 6 - Class Exercise : DO WHILE Loop
/// </summary>
namespace Q13_Pattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    
             *  Q13  
                        ********
                         ********
                          ********
                           ********
                            ********
             */

            Console.WriteLine("[Question 13]");

            int row = 0;
            string space = "";

            do
            {
                Console.WriteLine(space + "********");

                row++;
                space += " ";
            } while (row < 5);
        }
    }
}
