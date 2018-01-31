using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week03 - Class Exercise - Data Types
/// </summary>
namespace Q1_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q1. Create a program that prompts the user for her first name, middle initial and last name.
             * The program will display the user name three times using the following three formats:
             * 
             * first name and last name
             * first name middle initial and last name
             * last name, first name and middle initial
             * 
             * For inputs Barack H Obama
             * Barack Obama
             * Barack H Obama
             * Obama, Barack H
             */

            Console.WriteLine("[Question 1 : Name]");

            Console.Write("Enter user first name: ");
            string fName = Console.ReadLine(); // Convert.ToString() is not needed in!

            Console.Write("Enter user middle name: ");
            string mName = Console.ReadLine();

            Console.Write("Enter user last name: ");
            string lName = Console.ReadLine();

            Console.WriteLine("\nThe Result as below -----");
            Console.WriteLine(" " + fName + " " + lName);
            Console.WriteLine(" " + fName + " " + mName + " " + lName);
            Console.WriteLine(" " + lName + ", " + fName + " " + mName);
        }
    }
}
