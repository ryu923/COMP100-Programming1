using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week05 - Class Exercise : ENUM Statement Exercise
/// </summary>
namespace Q08_Day2
{
    class Program
    {
        enum Days
        {
            Mon, Tue, Wed, Thu, Fri, Sat, Sun
        }
        static void Main(string[] args)
        {
            /*
             * Q8. Saturdays and Wednesdays are your days off.
             * Write a program to prompt the user for the day of the week.
             * The program will display “Home day” or “Work day” depending on the input.
             * You and must use the following enum declaration: enum Days {Mon, Tue, Wed, Thu, Fri, Sat, Sun}
             */

            Console.WriteLine("[Question 8 : Days]");

            Console.Write("Enter a day of week for checking your work ((0)Mon, (1)Tue, (2)Wed, (3)Thu, (4)Fri, (5)Sat, (6)Sun): ");
            int days = Convert.ToInt32(Console.ReadLine());

            string message;

            switch((Days)days)
            {
                case Days.Mon:
                case Days.Tue:
                case Days.Thu:
                case Days.Fri:
                case Days.Sun:
                    message = "Work day";
                    break;

                case Days.Wed:
                case Days.Sat:
                    message = "Home day";
                    break;

                default:
                    message = "Error! Please, enter the valid input.";
                    break;
            }

            Console.WriteLine(message);
        }
    }
}
