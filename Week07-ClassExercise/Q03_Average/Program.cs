using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 7 - Class Exercise : DO WHILE, WHILE, FOR Loop
/// </summary>
namespace Q03_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q3. Write a Program to compute the average of ten numbers which will be entered by the user.
             */

            Console.WriteLine("[Question 3A : DO-WHILE Loop]");

            int counter = 1, sum = 0, average;

            do
            {
                Console.Write("Enter the number {0}: ", counter);
                int number = Convert.ToInt32(Console.ReadLine());

                sum += number;

                counter++;
            } while (counter <= 10);

            average = sum / counter;

            Console.WriteLine("The average of your ten inputs is {0}", average);


            Console.WriteLine("\n\n[Question 3B : WHILE Loop]");

            int counterB = 1, sumB = 0, averageB;

            while(counterB <= 10)
            {
                Console.Write("Enter the number {0}: ", counterB);
                int numberB = Convert.ToInt32(Console.ReadLine());

                sumB += numberB;

                counterB++;
            }

            averageB = sumB / counterB;

            Console.WriteLine("The average of your ten inputs is {0}", averageB);


            Console.WriteLine("\n\n[Question 3C : FOR Loop]");

            int averageC = 0; // averageC should have Initialize number.

            for (int counterC = 1, sumC = 0; counterC <= 10; counterC++)
            {
                Console.Write("Enter the number {0}: ", counterC);
                int numberC = Convert.ToInt32(Console.ReadLine());

                sumC += numberC;

                averageC = sumC / counterC;
            }

            Console.WriteLine("The average of your ten inputs is {0}", averageC);
        }
    }
}
