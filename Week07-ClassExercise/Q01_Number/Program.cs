using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 7 - Class Exercise : DO WHILE, WHILE, FOR Loop
/// </summary>
namespace Q01_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q1. Write a program to print the numbers 2 to 10 in increments of two.
             * The output of your program should be 2 4 6 8 10.
             */

            Console.WriteLine("[Question 1A : DO-WHILE Loop]");
            
            int number = 2;
            
            do
            {
                Console.Write("{0} ", number);
            
                number += 2;
            } while (number <= 10);
            
            Console.WriteLine("\n\n[Question 1B : WHILE Loop]");
            
            int numberB = 2;
            
            while(numberB <= 10)
            {
                Console.Write("{0} ", numberB);
            
                numberB += 2;
            }
            
            Console.WriteLine("\n\n[Question 1C : FOR Loop]");
            
            for(int numberC = 2; numberC <= 10; numberC += 2)
            {
                Console.Write("{0} ", numberC);
            }
        }
    }
}
