using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 7 - Class Exercise : DO WHILE, WHILE, FOR Loop
/// </summary>
namespace Q11_Conversion6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q11.	Print the decimal, octal, and hexadecimal values of all characters between the start
               and stop characters entered by a user.
             * For example, if the user enters an a and a z,
               the program should print all the characters between a and z and their respective numerical values.
             * Make sure that the second character entered by the user occurs later in the alphabet than the first character.
             * If it does not, write a loop that repeatedly asks the user for a valid second character until one is entered.
             * Your output should be formatted as shown below

                        Letter	Decimal	Octal	Hex
                           a	   97	 141	 61
                           b	   98	 142	 62
                           c	   99	 143	 63
                           d	   100	 144	 64
                           e	   101	 145	 65

             * to obtain an int from a char use casting
             * to obtain an octal from an int use Convert.ToString(«value», 8)
             * to obtain a hexadecimal from an int use Convert.ToString(«value», 16)
             */

            Console.WriteLine("[Question 11A : DO-WHILE Loop]");

            Console.Write("Enter a starting char: ");
            char startingChar = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter a ending char: ");
            char endingChar = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine(" Letter | Decimal | Octal | Hex ");
            Console.WriteLine("================================");

            do
            {
                int convertToDecimal = Convert.ToInt32(startingChar);
                string convertToOctal = Convert.ToString(startingChar, 8);
                string convertToHex = Convert.ToString(startingChar, 16);

                Console.WriteLine("{0,5}   | {1,5}   | {2,5} | {3,3} ", startingChar, convertToDecimal, convertToOctal, convertToHex);

                startingChar++;
            } while (startingChar <= endingChar);


            Console.WriteLine("\n\n[Question 11B : WHILE Loop]");

            Console.Write("Enter a starting char: ");
            char startingCharB = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter a ending char: ");
            char endingCharB = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine(" Letter | Decimal | Octal | Hex ");
            Console.WriteLine("================================");

            while(startingCharB <= endingCharB)
            {
                int convertToDecimalB = Convert.ToInt32(startingCharB);
                string convertToOctalB = Convert.ToString(startingCharB, 8);
                string convertToHexB = Convert.ToString(startingCharB, 16);

                Console.WriteLine("{0,5}   | {1,5}   | {2,5} | {3,3} ", startingCharB, convertToDecimalB, convertToOctalB, convertToHexB);

                startingCharB++;
            }


            Console.WriteLine("\n\n[Question 11C : FOR Loop]");

            Console.Write("Enter a starting char: ");
            char startingCharC = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter a ending char: ");
            char endingCharC = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine(" Letter | Decimal | Octal | Hex ");
            Console.WriteLine("================================");

            for(; startingCharC <= endingCharC; startingCharC++)
            {
                int convertToDecimalC = Convert.ToInt32(startingCharC);
                string convertToOctalC = Convert.ToString(startingCharC, 8);
                string convertToHexC = Convert.ToString(startingCharC, 16); 

                Console.WriteLine("{0,5}   | {1,5}   | {2,5} | {3,3} ", startingCharC, convertToDecimalC, convertToOctalC, convertToHexC);
            }
        }
    }
}
