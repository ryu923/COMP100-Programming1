using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week04 - Class Exercise - Structure Flow Chart
/// </summary>
namespace Q1_FlowChart1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q1. Write a program to find the difference or sum of two numbers.
             * The program should prompt for the operation and the two numbers.
             * If the operation is “+” then the program should add the two numbers and display the sum,
             * else the program should subtract the second number from the first and display the difference.
             */

            Console.WriteLine("[Question 1 : Flow Chart 1]");

            Console.Write("Enter the first number: ");
            int fNumber = Convert.ToInt32(Console.ReadLine());
            
                    Console.Write("Enter the second number: ");
            int sNumber = Convert.ToInt32(Console.ReadLine());
            
                    Console.Write("Choose the operation between + and - : ");
            string operation = Console.ReadLine();
            
                    int result;
            
            if(operation == "+")
            {
                result = fNumber + sNumber;
            
                Console.WriteLine("The result is {0}", result);
            }
            else
            {
                result = fNumber - sNumber;
            
                Console.WriteLine("The result is {0}", result);
            }
        }
    }
}
