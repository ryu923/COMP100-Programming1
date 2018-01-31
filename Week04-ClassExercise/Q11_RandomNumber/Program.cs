using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week04 - Class Exercise - Selection
/// </summary>
namespace Q11_RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q11. You can create a random number that is at least min but less than max using the following statements:
                Random ranNumberGenerator = new Random();
                int randomNumber;
                randomNumber = ranNumberGenerator.Next(min, max);
             * Write a console-based program that generates a random number between 1 and 10.
             * (In other words, min is 1 and max is 10.)
             * Ask a user to guess the random number,
             * then display the random number and a message indicating whether the user’s guess was too high, too low, or correct.
             */

            Console.WriteLine("[Question 11 : Radom Number]");

            Random randomNumberGenerator = new Random();
            int randomNumber = randomNumberGenerator.Next(1,10);

            Console.Write("Enter the number between 1 to 10: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number <= 0 || number >= 11)
            {
                Console.WriteLine("\nError! input number is out of range.");
            }
            else if(randomNumber > number)
            {
                Console.WriteLine("\nRandom number: {0}", randomNumber);
                Console.WriteLine("Input number: {0}", number);
                Console.WriteLine(">> User's guess too low.");
            }
            else if(randomNumber == number)
            {
                Console.WriteLine("\nRandom number: {0}", randomNumber);
                Console.WriteLine("Input number: {0}", number);
                Console.WriteLine(">> User's guess correct.");
            }
            else if(randomNumber < number)
            {
                Console.WriteLine("\nRandom number: {0}", randomNumber);
                Console.WriteLine("Input number: {0}", number);
                Console.WriteLine(">> User's guess too high.");
            }
            else
            {
                Console.WriteLine("Error! Please, input the correct value.");
            }
        }
    }
}
