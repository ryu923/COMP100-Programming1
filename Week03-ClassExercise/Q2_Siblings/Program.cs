using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week03 - Class Exercise - Data Types
/// </summary>
namespace Q2_Siblings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q2. Write a program that prompts the user for the number of siblings his has.
             * The program should display a message, “I also have 4 siblings”
             * (assuming that the user enters 4)
             */

            Console.WriteLine("[Question 2 : Siblings]");

            Console.Write("Enter the number of siblings you have: ");
            int numberOfSiblings = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nThe Result as below -----");
            Console.WriteLine("I also have " + numberOfSiblings + " siblings");
        }
    }
}
