using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week03 - Class Exercise - Data Types
/// </summary>
namespace Q3_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q3. Write a program that prompts the user for two integers.
             * The program will display the result of summing and finding the difference.
             * (If the user enters 8 and 3, the display should be 8 + 3 = 11 and 8 – 3 = 5)
             */

            Console.WriteLine("[Question 3 : Integers]");

            Console.Write("Enter the first integer: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;
            int difference = number1 - number2;

            Console.WriteLine("\nThe Result as below -----");
            Console.WriteLine(" The sum of two integers is " + sum);
            Console.WriteLine(" The difference of two integers is " + difference);
        }
    }
}
