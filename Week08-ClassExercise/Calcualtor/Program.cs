using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 08 : METHOD Exercise
/// </summary>
namespace Calcualtor
{
    class Program
    {
        /*
         * Q1. Write a method with the following specifications:
         * 
         * name: DisplayMenu
         * arguments: none
         * return value: none
         * tasks: display the following menu choice on the screen

            Calculation Menu
            1) Calculate Sum 
            2) Calculate Sum of Squares
            3) Calculate Sum of Cubes
            0) To Exit

            Enter the number that corresponds to your choice: 

         * You may beautify the output to your own likings.
         * You don’t have to implement the functionalities of the various menu choices at this stage Call this method from your main.
         */
         
        public static void DisplayMenu()
        {
            Console.WriteLine("\n\nCalculation Menu");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1) Calculate Sum");
            Console.WriteLine("2) Calculate Sum of Squares");
            Console.WriteLine("3) Calculate Sum of Cubes");
            Console.WriteLine("4) Calculate Average");
            Console.WriteLine("0) To Exit");
            Console.WriteLine("---------------------------");
            Console.Write("Enter the number that corresponds to your choice: ");     
        }

        /*
         * Q3. Write a method with the following specifications:
         * 
         * name: CalculateSum
         * arguments: int representing the number of input that will constitute the sum
         * return value: int representing the sum of its input
         * tasks: prompt and accepts inputs (as many as specified by the argument), and sum them,
           Finally the method will return the sum of all the inputs (the sum)

         * In your main you will call this method when the user enters 1 in response to the menu choices.
         * You will invoke this method with argument 5 and display the resulting value.
         */

        public static int CalculateSum(int numberOfInputs)
        {
            int counter = 1, sum = 0;

            Console.WriteLine("\nYou selected 1) Calculate Sum option");

            while (counter <= numberOfInputs)
            {
                Console.Write("Input number {0}: ", counter);
                int number = Convert.ToInt32(Console.ReadLine());

                sum += number;

                counter++;
            }

            return sum;
        }

        /*
         * Q4. Write a method with the following specifications:
         * name: CalculateSumOfSquares
         * arguments: int representing the number of input that will constitute the sum
         * return value: int representing the sum of the squares of its input
         * tasks: prompt the user for inputs and accumulates the sum of the squares of the input.
                  This is repeated as specified by the argument. Returns the final sum.

         * In your main when the user enters 2 in response to the menu choices,
           you will prompt the user for the number of inputs that she will be working with.
         * You will invoke this method with this value and display the resulting value.
         */

        public static int CalculateSumOfSquares(int numberOfinputs)
        {
            int squareSum = 0;

            for (int counter = 1, square; counter <= numberOfinputs; counter++)
            {
                Console.Write("Input number {0}: ", counter);
                int number = Convert.ToInt32(Console.ReadLine());

                square = number * number;

                squareSum += square;
            }

            return squareSum;
        }

        /*
         * Q5. Write a method with the following specifications:
         * name: CalculateSumOfCubes
         * arguments: none
         * return value: int representing the sum of the cubes of its input
         * tasks: prompt the user for the number of inputs that she will be working with.
                  Prompts the user for the required number of inputs.
                  Accumulates the sum of the cubes input. Returns the final sum 

         * In your main when the user enters 3 in response to the menu choices,
           you will invoke this method and display the resulting value.
         */

        public static int CalculateSumOfCubes()
        {
            Console.Write("Enter the number of inputs: ");
            int numberOfInputs = Convert.ToInt32(Console.ReadLine()); 

            int cubesSum = 0;

            for(int counter = 1, cubes; counter <= numberOfInputs; counter++)
            {
                Console.Write("Enter the number {0}: ", counter);
                int number = Convert.ToInt32(Console.ReadLine());

                cubes = number * number * number;

                cubesSum += cubes;
            }

            return cubesSum;
        }


        /*
         * 6. Write a method with the following specifications:
         * name: CalculateAverage
         * arguments: none
         * return value: double representing the mathematical average of its inputs
         * tasks: prompt the user for the number of inputs that she will be working with.
                  Prompts the user for the required number of inputs.
                  Calculate and return the average of the inputs. 
         * 
         * Modify your DisplayMenu method by adding another choice below CalculateSumOfCubes to In your main
           when the user enters the appropriate choice in response to the menu choices,
           you will invoke this method and display the resulting value.
         */

        public static double CalculateAverage()
        {
            Console.Write("Enter the number of inputs: ");
            int numberOfInputs = Convert.ToInt32(Console.ReadLine());

            int counter = 1, sum = 0;
            double average;

            do
            {
                Console.Write("Enter the number {0}: ", counter);
                int number = Convert.ToInt32(Console.ReadLine());

                sum += number;

                average = sum / counter;

                counter++;
            } while (counter <= numberOfInputs);

            return average;
        }


        static void Main(string[] args)
        {
            // Call the Method of Question 1 
            //DisplayMenu();

            /*
             * Q2. Modify your main so that the above method is call repeatedly.
             * The program will terminate when the user enters 0.
             * Because you will not be doing any arithmetic you may res the user response as an int, a char or a string.
             */

            string choice;

            do
            {
                DisplayMenu();
                choice = Console.ReadLine();

                // Call the other methods
                switch(choice)
                {
                    // Call the [CalculateSum()] Method
                    case "1":
                        Console.WriteLine("The sum of your inputs is {0}", CalculateSum(5));
                        break;

                    // Call the [CalculateSumOfSquares()] Method
                    case "2":
                        Console.Write("Enter the number of inputs: ");
                        int numberOfinputs = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("The square sum of your inputs is {0}", CalculateSumOfSquares(numberOfinputs));
                        break;

                    // Call the [CalculateSumOfCubes()] Method
                    case "3":
                        Console.WriteLine("The cubes sum of your inputs is {0}", CalculateSumOfCubes());
                        break;

                    // Call the [CalculateAverage()] Method
                    case "4":
                        Console.WriteLine("The cubes average of your inputs is {0}", CalculateAverage());
                        break;
                }
            } while (choice != "0");
        }
    }
}
