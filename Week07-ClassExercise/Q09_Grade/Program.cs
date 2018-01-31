using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 7 - Class Exercise : DO WHILE, WHILE, FOR Loop
/// </summary>
namespace Q09_Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q9. Write a C program that continuously requests a grade to be entered.
             * If the grade is less than 0 or greater than 100,
               your program should print an appropriate message informing the user that an invalid grade has been entered,
               else the grade should be added to a total.
             * When a grade of 999 is entered the program should exit the repetition loop
               and compute and display the average of the valid grades entered.
             */

            Console.WriteLine("[Question 9A : DO-WHILE Loop]");

            double counter = 1, total = 0, average = 0;

            do
            {
                Console.Write("Enter the grade {0}: ", counter);
                int grade = Convert.ToInt32(Console.ReadLine());

                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Error! Please, enter the valid input between 0 to 100.");
                    continue;
                }
                else
                {
                    total += grade;
                }

                average = total / counter;

                counter++;
            } while (total <= 999);

            Console.WriteLine("The average grade of your inputs is {0}", average);


            Console.WriteLine("\n\n[Question 9B : WHILE Loop]");

            int counterB = 1, totalB = 0, averageB = 0;

            while (totalB <= 999)
            {
                Console.Write("Enter the grade {0}: ", counterB);
                int gradeB = Convert.ToInt32(Console.ReadLine());

                if (gradeB < 0 || gradeB > 100)
                {
                    Console.WriteLine("Error! Please, enter the valid input between 0 to 100.");
                    continue;
                }
                else
                {
                    totalB += gradeB;
                }

                averageB = totalB / counterB;

                counterB++;
            }

            Console.WriteLine("The average grade of your inputs is {0}", averageB);


            Console.WriteLine("\n\n[Question 9C : FOR Loop]");

            int averageC = 0;

            for (int counterC = 1, totalC = 0; totalC <= 999; ) // Updator should be not included in [for()] !!! *
            {
                Console.Write("Enter the grade {0}: ", counterC);
                int gradeC = Convert.ToInt32(Console.ReadLine());

                if (gradeC < 0 || gradeC > 100)
                {
                    Console.WriteLine("Error! Please, enter the valid input between 0 to 100.");
                    continue;
                }
                else
                {
                    totalC += gradeC;
                }

                averageC = totalC / counterC;

                counterC++; // Updator should be positioned here for error uncounting !!! * 
            }

            Console.WriteLine("The average grade of your inputs is {0}", averageC);
        }
    }
}
