using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 11 : Class Exercise - ARRAY 2
/// </summary>
namespace ArrayExercise2
{
    class Program
    {
        #region Question 1
        /*
         * Q1. Write a method that takes an argument (a char array) and print each item on a single line separated by a space.
         * From your main, call this method with letters as argument
         */

        public static void DisplayLetters(char[] arrayName)
        {
            int counter = 0;

            do
            {
                Console.Write("{0} ", arrayName[counter]);

                counter++;
            } while (counter < arrayName.Length);
        }
        #endregion


        #region Question 2
        /*
         * Q2. Write a method that takes an argument (an int array) and print each item on a single line separated by a space.
         * From your main, call this method with numbers as argument.
         */

        public static void DisplayNumbers(int[] arrayName)
        {
            int counter = 0;

            while(counter < arrayName.Length)
            {
                Console.Write("{0} ", arrayName[counter]);

                counter++;
            }
        }
        #endregion


        #region Question 3
        /*
         * Q3. Write a method that takes an argument (a string array) and print each item on a single line separated by a space.
         * From your main, call this method with poem as argument
         */

        public static void DisplayPoem(string[] arrayName)
        {
            for(int counter = 0; counter < arrayName.Length; counter++)
            {
                Console.Write("{0} ", arrayName[counter]);
            }
        }
        #endregion


        #region Question 4
        /*
         * Q4. In your main method use the Array.Reverse() method to reverse the letters array and then call the appropriate method to print it
         */
        #endregion


        #region Question 5
        /*
         * Q5. In your main method use the Array.Sort() method to sort the poem array and then call the appropriate method to print it
         */
        #endregion


        #region Question 6
        /*
         * Q6. In your main method use the Array.Binarysearch() method to try to find the position of 3 in the numbers array.
         * What is your answer?
         * Now repeat the same steps after you have sorted the array
         */
        #endregion


        #region Question 7
        /*
         * Q7. Write a method that creates and return an array of ints.
         * The method takes a single argument that represents the number of items in the resulting array and does the following:

            - Declare an array of the required type
            - Allocate memory for the intended number of items
            - Using any looping structure, prompt the user for a number and then assign to each element. 
            - In your main method call this method and display the returned value.

         */

        public static int[] UserInputNumber(int numberOfItems)
        {
            int counter = 0;

            // Declaration and Allocating Storage
            int[] newArray = new int[numberOfItems];

            do
            {
                Console.Write("Enter the number {0}: ", counter + 1);
                int number = Convert.ToInt32(Console.ReadLine());

                // Allocating elements each by each 
                newArray[counter] = number;

                counter++;
            } while (counter < numberOfItems);

            return newArray;
        }

        public static void DisplayNewArray(int[] arrayName)
        {
            int counter = 0;

            while(counter < arrayName.Length)
            {
                Console.Write("{0} ", arrayName[counter]);

                counter++;
            }
        }
        #endregion

        #region Question 8
        /*
         * Q8. Write another method that creates and return an array of ints.
         * The method takes a single argument that represents the number of items in the resulting array and does the following:

            - Declare an array of the required type
            - Allocate memory for the intended number of items
            - Using any looping structure, assign to each element a random integer in the range 100 to 200. 
         
            - In your main method call this method and display the returned value.

                Radom rand = new Random();
                rand.Next(100, 200);

         */
        
        public static int[] CreateNewArray(int numberOfItems)
        {
            // Declaration of new array and allocation of storage
            int[] newArray = new int[numberOfItems];

            Random rand = new Random();

            for(int counter = 0; counter < numberOfItems; counter++)
            {
                int randomNumber = rand.Next(100, 200);

                newArray[counter] = randomNumber;
            }

            return newArray;
        }

        public static void DisplayCreateNewArray(int[] arrayName)
        {
            int counter = 0;

            do
            {
                Console.Write("{0} ", arrayName[counter]);

                counter++;
            } while (counter < arrayName.Length);
        }
        #endregion


        static void Main(string[] args)
        {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = { 0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2 };
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();


            Console.WriteLine("\n\n[Question 1]");
            DisplayLetters(letters);

            Console.WriteLine("\n\n[Question 2]");
            DisplayNumbers(numbers);

            Console.WriteLine("\n\n[Question 3]");
            DisplayPoem(poem); // Output is same as original one.

            Console.WriteLine("\n\n[Question 4]");
            Console.Write("- Original char[] letter: ");
            DisplayLetters(letters);

            Console.Write("\n- After reverse char[] letter: ");
            Array.Reverse(letters);
            DisplayLetters(letters);

            Console.WriteLine("\n\n[Question 5]");
            Console.Write("\n\n- Original string[] poem: ");
            DisplayPoem(poem);

            Console.Write("\n- After Sort string[] poem: ");
            Array.Sort(poem);
            DisplayPoem(poem);

            Console.WriteLine("\n\n[Question 6]");
            Console.Write("- Original int[] numbers: ");
            DisplayNumbers(numbers);

            Console.Write("\n- Array.BinarySearch(numbers, 3): ");
            int index3 = Array.BinarySearch(numbers, 3);
            Console.Write(index3);

            Console.Write("\n- After Sort int[] numbers: ");
            Array.Sort(numbers);
            DisplayNumbers(numbers);

            Console.Write("\n- Array.BinarySearch(numbers, 3) after Sort int[] numbers: ");
            int index3Sort = Array.BinarySearch(numbers, 3);
            Console.WriteLine(index3Sort);

            Console.WriteLine("\n\n[Question 7]***");
            Console.Write("Enter the number items: ");
            int numberOfItems = Convert.ToInt32(Console.ReadLine());
            DisplayNewArray(UserInputNumber(numberOfItems));

            Console.WriteLine("\n\n[Question 8]**");
            DisplayCreateNewArray(CreateNewArray(10));
        }
    }
}
