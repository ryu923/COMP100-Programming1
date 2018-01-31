using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week04 - Class Exercise - Structure Flow Chart
/// </summary>
namespace Q3_FlowChart3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q3. Write a program to display “Ontario” depending on the user input.
             * The program should prompt the user to enter the two letter province code (as a single input).
             * If the user enters “on” in any combination of uppercase or lowercase letter,
               the program should display “You live in Ontario”, otherwise it should display “You do not live in Ontario”.
             * [Hint use the statement .ToUpper() or .ToLower() to transform the input to upper case or lower case letters]
             */

            Console.WriteLine("[Question 3 : Flow Chart 3]");

            Console.Write("Enter the province code you live in: ");
            string province = Console.ReadLine().ToUpper();

            if (province == "ON")
            {
                Console.WriteLine("You live in Ontario.");
            }
            else
            {
                Console.WriteLine("You do not live in Ontario.");
            }
        }
    }
}
