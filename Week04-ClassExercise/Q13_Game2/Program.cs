using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week04 - Class Exercise - Selection
/// </summary>
namespace Q13_Game2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q13. Create a console-based game in which the computer randomly chooses rock, paper, or scissors.
             * Let the user enter a character, ‘r’, ‘p’, or ‘s’, each representing one of the three choices.
             * Then, determine the winner.
             */

            Console.WriteLine("[Question 13 : Game 2]");

            Console.Write("Player1: Choose the options character (r: rock, p: paper, s: scissors): ");
            char player1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Player2: Choose the options character (r: rock, p: paper, s: scissors): ");
            char player2 = Convert.ToChar(Console.ReadLine());

            if (player1 == 'r' && player2 == 'r')
            {
                Console.WriteLine("\nGame is tied");
            }
            else if (player1 == 'r' && player2 == 'p')
            {
                Console.WriteLine("\nPlayer 2 is winner.");
            }
            else if (player1 == 'r' && player2 == 's')
            {
                Console.WriteLine("\nPlayer 1 is winner.");
            }

            else if (player1 == 'p' && player2 == 'r')
            {
                Console.WriteLine("\nPlayer 1 is winner.");
            }
            else if (player1 == 'p' && player2 == 'p')
            {
                Console.WriteLine("\nGame is tied");
            }
            else if (player1 == 'p' && player2 == 's')
            {
                Console.WriteLine("\nPlayer 2 is winner.");
            }

            else if (player1 == 's' && player2 == 'r')
            {
                Console.WriteLine("\nPlayer 2 is winner.");
            }
            else if (player1 == 's' && player2 == 'p')
            {
                Console.WriteLine("\nPlayer 1 is winner.");
            }
            else if (player1 == 's' && player2 == 's')
            {
                Console.WriteLine("\nGame is tied");
            }

            else
            {
                Console.WriteLine("\nError! Please, choose correct option number.");
            }
        }
    }
}
