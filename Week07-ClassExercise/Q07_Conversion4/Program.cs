using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 7 - Class Exercise : DO WHILE, WHILE, FOR Loop
/// </summary>
namespace Q07_Conversion4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q7. Write a program to produce a table of the numbers 0 through 20 in increments of 2, with their squares and cubes.
             */

            Console.WriteLine("[Question 7A : DO-WHILE Loop]");

            double number = 0, square, cube;

            Console.WriteLine("NUMBER | SQUARE | CUBE");
            Console.WriteLine("======================");

            do
            {
                square = Math.Pow(number, 2); // In order to use [Math.Pow();], variable should be double!!! (Not int!!!)
                cube = Math.Pow(number, 3);

                Console.WriteLine("{0,4}   | {1,4}   | {2,4}", number, square, cube);

                number += 2;
            } while (number <= 20);


            Console.WriteLine("\n\n[Question 7B : WHILE Loop]");

            double numberB = 0, squareB, cubeB;

            while(numberB <= 20)
            {
                squareB = Math.Pow(numberB , 2);
                cubeB = Math.Pow(numberB, 3);

                Console.WriteLine("{0,4}   | {1,4}   | {2,4}", numberB, squareB, cubeB);

                numberB += 2;
            }


            Console.WriteLine("\n\n[Question 7C : FOR Loop]");

           
            for(double numberC = 0, squareC, cubeC; numberC <= 20; numberC += 2)
            {
                squareC = Math.Pow(numberC, 2);
                cubeC = Math.Pow(numberC, 3);

                Console.WriteLine("{0,4}   | {1,4}   | {2,4}", numberC, squareC, cubeC);
            }
        }
    }
}
