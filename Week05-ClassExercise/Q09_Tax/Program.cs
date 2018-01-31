using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week05 - Class Exercise : ENUM Statement Exercise
/// </summary>
namespace Q09_Tax
{
    class Program
    {
        enum Province
        {
            ON, QC, NS, NB, MB, BC, PE, SK, AB, NL, YT, NT, NV
        }
        static void Main(string[] args)
        {
            /*
             * Q9. Harmonised tax exists in Ontario, New Brunswick, New Foundland, Nova Scotia, and British Columbia.
             * Use a suitable enum declaration and a switch statement to prompt the user for a province
               and display a message HST exist or HST does not exist.
             * enum {ON, QC, NS, NB, MB, BC, PE, SK, AB, NL, YT, NT, NV}
             * Write a program that calculates the tax on an item, based on the province code.
             * Your program will prompt the user for the 2-letter province code,
               and the cost of the item and then computes the tax based on the following table:

                      Province	     |   Rate
                =====================|==========
                         ON	         |   14%
                         QC	         |   13%
                Any other province	 |    0%

             * Use enums, named constants and if’s.
             * Try to accommodate all permutations of the 2-letter code.
             */

            Console.WriteLine("[Question 9 : Tax]");

            Console.WriteLine("Enter a number of provice code as below.");
            Console.WriteLine("(0)ON, (1)QC, (2)NS, (3)NB, (4)MB, (5)BC, (6)PE, (7)SK, (8)AB, (9)NL, (10)YT, (11)NT, (12)NV");
            Console.Write(">> Select: ");
            int select = Convert.ToInt32(Console.ReadLine());

            string message;

            switch ((Province)select)
            {
                case Province.ON:
                    message = "Tax rate: 14%";
                    break;

                case Province.QC:
                    message = "Tax rate: 13%";
                    break;

                case Province.NS:
                case Province.NB:
                case Province.MB:
                case Province.BC:
                case Province.PE:
                case Province.SK:
                case Province.AB:
                case Province.NL:
                case Province.YT:
                case Province.NT:
                case Province.NV:
                    message = "Tax rate: 0%";
                    break;

                default:
                    message = "Error! Please, enter the valid input.";
                    break;
            }

            Console.WriteLine(message);
        }
    }
}
