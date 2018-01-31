using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 7 - Class Exercise : DO WHILE, WHILE, FOR Loop
/// </summary>
namespace Q08_Conversion5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q8. Write a program to produce a table of numbers from 10 to 1, with their squares and cubes.
             */

            Console.WriteLine("[Question 8A : DO-WHILE Loop]");

            double number = 10, square, cube;

            Console.WriteLine("NUMBER | SQUARE | CUBE");
            Console.WriteLine("======================");

            do
            {
                square = Math.Pow(number, 2); // In order to use [Math.Pow();], variable should be double!!! (Not int!!!)
                cube = Math.Pow(number, 3);

                Console.WriteLine("{0,4}   | {1,4}   | {2,4}", number, square, cube);

                number--;
            } while (number >= 0);


            Console.WriteLine("\n\n[Question 8B : WHILE Loop]");

            double numberB = 10, squareB, cubeB;

            Console.WriteLine("NUMBER | SQUARE | CUBE");
            Console.WriteLine("======================");

            while(numberB >= 0)
            {
                squareB = Math.Pow(numberB, 2); // In order to use [Math.Pow();], variable should be double!!! (Not int!!!)
                cubeB = Math.Pow(numberB, 3);

                Console.WriteLine("{0,4}   | {1,4}   | {2,4}", numberB, squareB, cubeB);

                numberB--;
            }


            Console.WriteLine("\n\n[Question 8C : FOR Loop]");  

            Console.WriteLine("NUMBER | SQUARE | CUBE");
            Console.WriteLine("======================");

            for(double numberC = 10, squareC, cubeC; numberC >= 0;numberC--)
            {
                squareC = Math.Pow(numberC, 2); // In order to use [Math.Pow();], variable should be double!!! (Not int!!!)
                cubeC = Math.Pow(numberC, 3);

                Console.WriteLine("{0,4}   | {1,4}   | {2,4}", numberC, squareC, cubeC);
            }
        }
    }
}
