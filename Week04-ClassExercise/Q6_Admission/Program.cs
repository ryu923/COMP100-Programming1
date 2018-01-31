using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week04 - Class Exercise - Selection
/// </summary>
namespace Q6_Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q6. Write a console-based program for a college’s admissions office.
             * The user enters a numeric high school grade point average (for example, 3.2) and an admission test score.
             * Display the message “Accept” if the student meets either of the following requirements:
             * 
             * A grade point average of 3.0 or higher and an admission test score of at least 60
             * A grade point average of less than 3.0 and an admission test score of at least 80
             * If the student does not meet either of the qualification criteria, display “Reject”.
             */

            Console.WriteLine("[Question 6 : Admission]");

            Console.Write("Enter the high school grade point average: ");
            double grade = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the admission test score: ");
            double test = Convert.ToDouble(Console.ReadLine());

            if((grade >= 3.0 && test >= 60) || (grade < 3.0 && test >= 80))
            {
                Console.WriteLine("Accept");
            }
            else
            {
                Console.WriteLine("Reject");
            }
        }
    }
}
