using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week05 - Class Exercise : SWITCH Statement Exercise
/// </summary>
namespace Q03_TuitionCost
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q3. Write a program that prompts the user for the number of courses
               and residency status (domestic or international) and calculates tuition cost.
             * Cost is based on the table below.
             
                Domestic	    $325 per course
                International	$1375 per course

             * You decide how you want the user to enter her/his residency status and prompt accordingly,
               also you should use named constants for the cost per course.
             */

            Console.WriteLine("[Question 3 : Tuition Cost]");

            Console.Write("Enter the number of course: ");
            int courses = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your residency status? ");
            Console.WriteLine("(A) Domestic");
            Console.WriteLine("(B) international");
            Console.Write(">> Select: ");
            char selection = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.WriteLine();

            double tuitionCost;

            switch(selection)
            {
                case 'A':
                    tuitionCost = courses * 325;

                    Console.WriteLine("Status      : Domestic");
                    Console.WriteLine("Courses     : {0}", courses);
                    Console.WriteLine("Tuition Cost: {0:C}", tuitionCost);
                    break;

                case 'B':
                    tuitionCost = courses * 1375;

                    Console.WriteLine("Status      : International");
                    Console.WriteLine("Courses     : {0}", courses);
                    Console.WriteLine("Tuition Cost: {0:C}", tuitionCost);
                    break;

                default:
                    Console.WriteLine("Error! Please, input correct value.");
                    break;
            }
        }
    }
}
