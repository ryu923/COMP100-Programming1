using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week04 - Class Exercise - Selection
/// </summary>
namespace Q14_LotteryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q14. Create a console-based lottery game application.
             * Generate three random numbers, each between 1 and 4.
             * Allow the user to guess three numbers.
             * Compare each of the user’s guesses to the three random numbers and display a message that includes the user’s guess,
               the randomly determined three-digit number, and the amount of money the user has won as follows:

                    Matching Numbers	       |     Award ($)
                ===============================|==================
                Any one matching	           |          10
                Two matching	               |         100
                Three matching, not in order   |       1,000
                Three matching in exact order  |      10,000
                No matches	                   |           0

             * Make certain that your application accommodates repeating digits.
             * For example, if a user guesses 1, 2, and 3, and the randomly generated digits are 1, 1, and 1,
               do not give the user credit for three correct guesses—just one.
             */

            Console.WriteLine("[Question 14 : Lottery Game]");

            Random randomNumberGenerator = new Random();

            int randomNumber1 = randomNumberGenerator.Next(1, 4);
            int randomNumber2 = randomNumberGenerator.Next(1, 4);
            int randomNumber3 = randomNumberGenerator.Next(1, 4);

            Console.WriteLine("Random numbers are {0}, {1}, {2}", randomNumber1, randomNumber2, randomNumber3);

            Console.Write("1. Pick the number between 1 to 4: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Pick the number between 1 to 4: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("3. Pick the number between 1 to 4: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            // For three matching, in exact order
            if ((number1 == randomNumber1) && (number2 == randomNumber2) && (number3 == randomNumber3))
            {
                Console.WriteLine("You picked {0}, {1}, {2} and lottery number is {3}, {4}, {5}", number1, number2, number3, randomNumber1, randomNumber2, randomNumber3);
                Console.WriteLine("Three matching in exact order)! $10,000 award.");
            }

            // For three matching, not in order
            else if ((number1 == randomNumber2) && (number2 == randomNumber3) && (number3 == randomNumber1))
            {
                Console.WriteLine("You picked {0}, {1}, {2} and lottery number is {3}, {4}, {5}", number1, number2, number3, randomNumber1, randomNumber2, randomNumber3);
                Console.WriteLine("Three matching(not in order)! $1000 award.");
            }
            else if ((number1 == randomNumber3) && (number2 == randomNumber1) && (number3 == randomNumber2))
            {
                Console.WriteLine("You picked {0}, {1}, {2} and lottery number is {3}, {4}, {5}", number1, number2, number3, randomNumber1, randomNumber2, randomNumber3);
                Console.WriteLine("Three matching(not in order)! $1000 award.");
            }

            // For two matching
            else if ((number1 == randomNumber1) && (number2 == randomNumber2))
            {
                Console.WriteLine("You picked {0}, {1}, {2} and lottery number is {3}, {4}, {5}", number1, number2, number3, randomNumber1, randomNumber2, randomNumber3);
                Console.WriteLine("Two matching! $100 award.");
            }
            else if ((number1 == randomNumber1) && (number2 == randomNumber3))
            {
                Console.WriteLine("You picked {0}, {1}, {2} and lottery number is {3}, {4}, {5}", number1, number2, number3, randomNumber1, randomNumber2, randomNumber3);
                Console.WriteLine("Two matching! $100 award.");
            }
            else if ((number1 == randomNumber1) && (number3 == randomNumber2))
            {
                Console.WriteLine("You picked {0}, {1}, {2} and lottery number is {3}, {4}, {5}", number1, number2, number3, randomNumber1, randomNumber2, randomNumber3);
                Console.WriteLine("Two matching! $100 award.");
            }
            else if ((number1 == randomNumber1) && (number3 == randomNumber3))
            {
                Console.WriteLine("You picked {0}, {1}, {2} and lottery number is {3}, {4}, {5}", number1, number2, number3, randomNumber1, randomNumber2, randomNumber3);
                Console.WriteLine("Two matching! $100 award.");
            }

            else if ((number2 == randomNumber1) && (number3 == randomNumber2))
            {
                Console.WriteLine("You picked {0}, {1}, {2} and lottery number is {3}, {4}, {5}", number1, number2, number3, randomNumber1, randomNumber2, randomNumber3);
                Console.WriteLine("Two matching! $100 award.");
            }
            else if ((number2 == randomNumber1) && (number3 == randomNumber3))
            {
                Console.WriteLine("You picked {0}, {1}, {2} and lottery number is {3}, {4}, {5}", number1, number2, number3, randomNumber1, randomNumber2, randomNumber3);
                Console.WriteLine("Two matching! $100 award.");
            }
            else if ((number2 == randomNumber1) && (number1 == randomNumber2))
            {
                Console.WriteLine("You picked {0}, {1}, {2} and lottery number is {3}, {4}, {5}", number1, number2, number3, randomNumber1, randomNumber2, randomNumber3);
                Console.WriteLine("Two matching! $100 award.");
            }
            else if ((number2 == randomNumber1) && (number1 == randomNumber3))
            {
                Console.WriteLine("You picked {0}, {1}, {2} and lottery number is {3}, {4}, {5}", number1, number2, number3, randomNumber1, randomNumber2, randomNumber3);
                Console.WriteLine("Two matching! $100 award.");
            }

            else if ((number3 == randomNumber1) && (number1 == randomNumber2))
            {
                Console.WriteLine("You picked {0}, {1}, {2} and lottery number is {3}, {4}, {5}", number1, number2, number3, randomNumber1, randomNumber2, randomNumber3);
                Console.WriteLine("Two matching! $100 award.");
            }
            else if ((number3 == randomNumber1) && (number1 == randomNumber3))
            {
                Console.WriteLine("You picked {0}, {1}, {2} and lottery number is {3}, {4}, {5}", number1, number2, number3, randomNumber1, randomNumber2, randomNumber3);
                Console.WriteLine("Two matching! $100 award.");
            }
            else if ((number3 == randomNumber1) && (number2 == randomNumber2))
            {
                Console.WriteLine("You picked {0}, {1}, {2} and lottery number is {3}, {4}, {5}", number1, number2, number3, randomNumber1, randomNumber2, randomNumber3);
                Console.WriteLine("Two matching! $100 award.");
            }
            else if ((number3 == randomNumber1) && (number2 == randomNumber3))
            {
                Console.WriteLine("You picked {0}, {1}, {2} and lottery number is {3}, {4}, {5}", number1, number2, number3, randomNumber1, randomNumber2, randomNumber3);
                Console.WriteLine("Two matching! $100 award.");
            }

            // For any one matching
            else if ((number1 == randomNumber1) || (number1 == randomNumber2) || (number1 == randomNumber3))
            {
                Console.WriteLine("You picked {0}, {1}, {2} and lottery number is {3}, {4}, {5}", number1, number2, number3, randomNumber1, randomNumber2, randomNumber3);
                Console.WriteLine("One matching! $10 award.");
            }
            else if((number2 == randomNumber1) || (number2 == randomNumber2) || (number2 == randomNumber3))
            {
                Console.WriteLine("You picked {0}, {1}, {2} and lottery number is {3}, {4}, {5}", number1, number2, number3, randomNumber1, randomNumber2, randomNumber3);
                Console.WriteLine("One matching! $10 award.");
            }
            else if ((number3 == randomNumber1) || (number3 == randomNumber2) || (number3 == randomNumber3))
            {
                Console.WriteLine("You picked {0}, {1}, {2} and lottery number is {3}, {4}, {5}", number1, number2, number3, randomNumber1, randomNumber2, randomNumber3);
                Console.WriteLine("One matching! $10 award.");
            }

            // No matches  
            else
            {
                Console.WriteLine("\nNo matches.");
            }
        }
    }
}
