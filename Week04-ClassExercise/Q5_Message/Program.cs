using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week04 - Class Exercise - Selection
/// </summary>
namespace Q5_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q5. Write a console-based program that accepts a user’s message and determines
             * whether it is short enough for a social networking service
             * that does not accept messages of more than 140 characters.
             * [Hint: if the user’s input is assigned to the variable message
             * then message.Length with give the number of characters in the input]
             */

            Console.WriteLine("[Question 5 : Message]");

            Console.Write("Enter your message: ");
            string message = Console.ReadLine();

            if(message.Length <= 140)
            {
                Console.WriteLine("\nYour message is as below.");
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Message should be less than 140 characters.");
            }
        }
    }
}
