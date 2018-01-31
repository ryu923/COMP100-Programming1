using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 7 - Class Exercise : DO WHILE, WHILE, FOR Loop
/// </summary>
namespace Q02_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q2. Write a Program to compute the sum of eight numbers that will be provided by the user.
             */

            Console.WriteLine("[Question 2A : DO-WHILE Loop]");

            int counter = 1, sum = 0;

            do
            {
                Console.Write("Enter the number {0}: ", counter);
                int number = Convert.ToInt32(Console.ReadLine());

                sum += number;

                counter++;
            } while (counter < 9);

            Console.WriteLine("Sum of eight input numbers is {0}", sum);


            Console.WriteLine("\n\n[Question 2B : WHILE Loop]");
            int counterB = 1, sumB = 0;

            while(counterB <= 8)
            {
                Console.Write("Enter the number {0}: ", counterB);
                int numberB = Convert.ToInt32(Console.ReadLine());

                sumB += numberB;

                counterB++;
            }

            Console.WriteLine("Sum of eight input numbers is {0}", sumB);


            Console.WriteLine("\n\n[Question 2C : FOR Loop]");

            int sumC = 0;

            for(int counterC = 1; counterC <= 8; counterC++)
            {
                Console.Write("Enter the number {0}: ", counterC);
                int numberC = Convert.ToInt32(Console.ReadLine());

                sumC += numberC;
            }

            Console.WriteLine("Sum of eight input numbers is {0}", sumC);
        }
    }
}
