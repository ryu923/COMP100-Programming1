using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week03 - Class Exercise - Data Types
/// </summary>
namespace Q4_Siblings_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q4. Write a program that prompts the user for the number of siblings his has.
             * The program should display a message, “I have 4 siblings”
             * (assuming that the user enters 3).
             */

            Console.WriteLine("[Question 4 : Siblings 2]");

            Console.Write("Enter the number of siblings you have: ");
            int numberOfSiblings = Convert.ToInt32(Console.ReadLine());

            int modified = numberOfSiblings + 1;

            Console.WriteLine("\nThe Result as below -----");
            Console.WriteLine("I Have " + modified + " siblings");
        }
    }
}
