using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 7 - Class Exercise : DO WHILE, WHILE, FOR Loop
/// </summary>
namespace Q12_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 12. Write a program to reverse the digits of a positive integer number.
             * For example, if the number 8735 is entered, the number displayed should be 5378.
             * (Hint: Use a do statement and continuously strip off and display the units digit of the number.
             * If the variable num initially contains the number entered,
               the units digit is obtained as (num % 10).
             * After a units digit is displayed, dividing the number by 10 sets up the number for the next iteration.
             * Thus, (8735 % 10) is5and (8735 / 10) is 873. The do statement should continue as long as the remaining number is not zero).
             */

            Console.WriteLine("[Question 12A : DO-WHILE Loop]");

            Console.Write("Enter a positive integer: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            int remainder;

            do
            {
                remainder = inputNumber % 10;

                Console.Write("{0}", remainder);

                inputNumber = inputNumber / 10;
            } while (inputNumber > 0);


            Console.WriteLine("\n\n[Question 12B : WHILE Loop]");

            Console.Write("Enter a positive integer: ");
            int inputNumberB = Convert.ToInt32(Console.ReadLine());

            int remainderB;

            while(inputNumberB > 0)
            {
                remainderB = inputNumberB % 10;

                Console.Write("{0}", remainderB);

                inputNumberB = inputNumberB / 10;
            }


            Console.WriteLine("\n\n[Question 12C : FOR Loop]");

            Console.Write("Enter a positive integer: ");
            int inputNumberC = Convert.ToInt32(Console.ReadLine());

            for(int remainderC; inputNumberC > 0; inputNumberC = inputNumberC / 10)
            {
                remainderC = inputNumberC % 10;

                Console.Write("{0}", remainderC);
            }
        }
    }
}
