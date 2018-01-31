using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week04 - Class Exercise - Selection
/// </summary>
namespace Q12_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q12. In the game Rock Paper Scissors, two players simultaneously choose one of three options: rock, paper, or scissors.
             * If both players choose the same option, then the result is a tie.
             * However, if they choose differently, the winner is determined as follows:

                Rock beats scissors, because a rock can break a pair of scissors.
                Scissors beats paper, because scissors can cut paper.
                Paper beats rock, because a piece of paper can cover a rock.

             */

            Console.WriteLine("[Question 12 : Game]");

            Console.Write("Player1: Choose the options number among (1) Rock, (2) Paper, (3) Scissors: ");
            int player1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Player2: Choose the options number among (1) Rock, (2) Paper, (3) Scissors: ");
            int player2 = Convert.ToInt32(Console.ReadLine());

            if (player1 == 1 && player2 == 1)
            {
                Console.WriteLine("\nGame is tied");
            }
            else if(player1 == 1 && player2 == 2)
            {
                Console.WriteLine("\nPlayer 2 is winner.");
            }
            else if (player1 == 1 && player2 == 3)
            {
                Console.WriteLine("\nPlayer 1 is winner.");
            }

            else if (player1 == 2 && player2 == 1)
            {
                Console.WriteLine("\nPlayer 1 is winner.");
            }
            else if (player1 == 2 && player2 == 2)
            {
                Console.WriteLine("\nGame is tied");
            }
            else if (player1 == 2 && player2 == 3)
            {
                Console.WriteLine("\nPlayer 2 is winner.");
            }

            else if (player1 == 3 && player2 == 1)
            {
                Console.WriteLine("\nPlayer 2 is winner.");
            }
            else if (player1 == 3 && player2 == 2)
            {
                Console.WriteLine("\nPlayer 1 is winner.");
            }
            else if (player1 == 3 && player2 == 3)
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
