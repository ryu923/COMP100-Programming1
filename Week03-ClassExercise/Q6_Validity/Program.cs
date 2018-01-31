using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week03 - Class Exercise - Data Types
/// </summary>
namespace Q6_Validity
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q6. Write a program to ask the user about the validity of a simple statement.
             * The program should accept the response then display the statement as well as the response.
             * The response should be true or false. For this question, you must use a variable of type bool.
             */

            Console.WriteLine("[Question 6 : Validity]");

            Console.Write("Are You a Student?(True/False) ");
            bool validity = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("\nThe Result as below -----");
            Console.WriteLine(" Answer for the question is " + validity);
        }
    }
}
