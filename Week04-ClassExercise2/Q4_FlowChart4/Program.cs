using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week04 - Class Exercise - Structure Flow Chart
/// </summary>
namespace Q4_FlowChart4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q4. Write a program to display the tuition fee for students at Centennial College.
             * Fees is depends on the number of courses taken and the residency status of the student
               and it calculated according the to the table below

                    Residency  |	  Number of courses	    |           Price
                ===============|============================|=========================
                    Domestic   |     Less than 4 courses	|    $425.00 per course
                		       |     More than 4 cources    |    $350.00 per course
                               |     (Including 4 cources)  |
                ---------------|----------------------------|-------------------------
                    Foreign	   |     Less than 4 courses	|    $1225.00 per course
                		       |     More than 4 cources    |    $1175.00 per course
                               |     (Including 4 cources)  |
            
             * The program should prompt the user to indicate if she is a domestic student or not.
             * An input of Y or Y would indicate domestic (any other input can be consider foreign).
             * The program should then prompt the use for the number of course that he/she is taking.
             * Based on the above table the program will print her tuition cost.
             * [Hint use the statement .ToUpper() or .ToLower() to transform the input to upper case or lower case string]
             */

            Console.WriteLine("[Question 4 : Flow Chart 4]");

            Console.Write("Are you a domestic student (Y/N)? ");
            string status = Console.ReadLine().ToUpper();

            Console.Write("Enter the number of courses that you taking: ");
            int numberOfCourses = Convert.ToInt32(Console.ReadLine());

            double tuitionCost;

            if (status == "Y")
            {
                if (numberOfCourses < 4)
                {
                    tuitionCost = numberOfCourses * 425;

                    Console.WriteLine("\nStatus       : Domestic Student");
                    Console.WriteLine("Courses      : {0}", numberOfCourses);
                    Console.WriteLine("Tuition Cost : {0:C2}", tuitionCost);
                }
                else
                {
                    tuitionCost = numberOfCourses * 350;

                    Console.WriteLine("\nStatus       : Domestic Student");
                    Console.WriteLine("Courses      : {0}", numberOfCourses);
                    Console.WriteLine("Tuition Cost : {0:C2}", tuitionCost);
                }
            }
            else
            {
                if (numberOfCourses < 4)
                {
                    tuitionCost = numberOfCourses * 1225;

                    Console.WriteLine("\nStatus       : International Student");
                    Console.WriteLine("Courses      : {0}", numberOfCourses);
                    Console.WriteLine("Tuition Cost : {0:C2}", tuitionCost);
                }
                else
                {
                    tuitionCost = numberOfCourses * 1175;

                    Console.WriteLine("\nStatus       : International Student");
                    Console.WriteLine("Courses      : {0}", numberOfCourses);
                    Console.WriteLine("Tuition Cost : {0:C2}", tuitionCost);
                }
            }
        }
    }
}
