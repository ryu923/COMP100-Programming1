using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week05 - Class Exercise : SWITCH Statement Exercise
/// </summary>
namespace Q01_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q1. Write a program that prompts the user for a menu choice.
             * The program will display a message based on the following table:

                       Choice	    |        Message
                ====================|=========================
                          1	        | "Calculate area"
                          2	        | "Calculate volume"
                          3	        | "Calculate surface area"
                          0	        | "Exit the program"
                << any other input>>| "ERROR: Invalid choice "

             */

            Console.WriteLine("[Question 1 : Menu]");

            Console.WriteLine("      Choice                  Message");
            Console.WriteLine("===============================================");
            Console.WriteLine("         1               Calculate area");
            Console.WriteLine("         2               Calculate volume");
            Console.WriteLine("         3               Calculate surface area");
            Console.WriteLine("         0               Exit the program");
            Console.WriteLine("<< any other input>>     ERROR: Invalid choice");
        }
    }
}
