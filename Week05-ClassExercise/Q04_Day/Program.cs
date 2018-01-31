using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week05 - Class Exercise : SWITCH Statement Exercise
/// </summary>
namespace Q04_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q4. Write a program that prompts the user for a day of the week.
             * The program will display a message based on the following table:

                Choice	    Message
                 Sun	     "Home"
                 Mon	     "Work"
                 Tue	     "Work"
                 Wed	     "Home"
                 Thu	     "Work"
                 Fri	     "Work"
                 Sat	     "Work"
             */

            Console.WriteLine("[Question 4 : Day]");

            Console.Write("Enter the day of week (ex: Mon): ");
            string day = Console.ReadLine().ToUpper();

            switch(day)
            {
                case "SUN":
                case "WED":
                    Console.WriteLine("Home");
                    break;

                case "MON":
                case "TUE":
                case "THU":
                case "FRI":
                case "SAT":
                    Console.WriteLine("Work");
                    break;

                default:
                    Console.WriteLine("Error! Please, input correct value.");
                    break;
            }
        }
    }
}
