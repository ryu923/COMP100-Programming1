using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week05 - Class Exercise : ENUM Statement Exercise
/// </summary>
namespace Q07_Furniture
{
    class Program
    {
        enum Wood
        {
            Pine, Oak, Mahogany
        }

        static void Main(string[] args)
        {
            /*
             * Q7. Write a program for a furniture company.
             * Ask the user to choose Pine, Oak or Mahogany.
             * Show the price of a table manufactured with the chosen wood Pine tables cost $100, Oak tables cost $225,
               and Mahogany tables cost $310.
             * Use enum, named constants and switch.
             */

            Console.WriteLine("[Question 7 : Furniture]");

            Console.Write("Choose the wood talbe among below (0) Pine, (1) Oak, (2) Mahogany: ");
            int wood = Convert.ToInt32(Console.ReadLine());

            string message;

            switch((Wood)wood)
            {
                case Wood.Pine:
                    message = "Pine table cost $100";
                    break;
                case Wood.Oak:
                    message = "Oak table cost $225";
                    break;
                case Wood.Mahogany:
                    message = "Mahogany table cost $310";
                    break;
                default:
                    message = "Error! Please, enter the valid input.";
                    break;
            }

            Console.WriteLine(message);
        }
    }
}
