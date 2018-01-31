using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week05 - Class Exercise : SWITCH Statement Exercise
/// </summary>
namespace Q02_TwoIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q2. Write a program that allows the user to enter two integers and a character.
             * If the character is A, add the two integers.
             * If it is S, subtract the second integer from the first.
             * If it is M, multiply the integers.
             * Display the results of the arithmetic.
             */

            Console.WriteLine("[Question 2 : Two Integers]");

            Console.Write("Enter the first integer: ");
            int fInteger = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int sInteger = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nChoose the character");
            Console.WriteLine("(A) Add");
            Console.WriteLine("(S) Subtract");
            Console.WriteLine("(M) Multiply");
            Console.Write(">> Select: ");
            char option = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.WriteLine();

            int result;

            switch (option)
            {
                case 'A':
                    result = fInteger + sInteger;

                    Console.WriteLine("{0} + {1} = {2}", fInteger, sInteger, result);
                    break;

                case 'S':
                    result = fInteger - sInteger;

                    Console.WriteLine("{0} - {1} = {2}", fInteger, sInteger, result);
                    break;

                case 'M':
                    result = fInteger * sInteger;

                    Console.WriteLine("{0} X {1} = {2}", fInteger, sInteger, result);
                    break;

                default:
                    Console.WriteLine("Error! Please, Enter correct character.");
                    break;
            }
        }
    }
}
