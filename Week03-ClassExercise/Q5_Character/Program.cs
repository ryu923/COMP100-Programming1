using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week03 - Class Exercise - Data Types
/// </summary>
namespace Q5_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q5. Write a program to prompt the user to enter a single character.
             * The program should display a message like “Your response was y”.
             * For this question, you must use a variable of type char.
             */

            Console.WriteLine("[Question 5 : Character]");

            Console.Write("Enter a single character: ");
            char character = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("\nThe Result as below -----");
            Console.WriteLine("Your response was " + character);
        }
    }
}
