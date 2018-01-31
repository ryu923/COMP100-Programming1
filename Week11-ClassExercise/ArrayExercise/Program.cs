using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 11 - Class Exercise : ARRAY
/// </summary>
namespace ArrayExercise
{
    class Program
    {
        static char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        static int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19 };
        static string[] poem = { "Mary", "had", "a", "little", "lamb" };
        static string[] obama = { "Barack", "Hussein", "Obama" };


        #region Question 1
        /*
         * Q1. Write a method that prints the string array obama in a global scope
         * Each element must be on a separate line.
         * From your main, call this method.
         * [Your method will not take any parameters and it does not return a value.]
         */

        public static void DisplayObama()
        {
            int counter = 0;

            do
            {
                Console.WriteLine(obama[counter]);

                counter++;
            } while (counter < obama.Length);
        }
        #endregion

        #region Question 2
        /*
         * Q2. Write a method that prints the string array poem.
         * All the items must be in the same line.
         * From your main, call this method.
         * [Your method will not take any parameters and it does not return a value.]
         */

        public static void DisplayPoem()
        {
            int counter = 0;

            while (counter < poem.Length)
            {
                Console.WriteLine(poem[counter]);

                counter++;
            }
        }
        #endregion


        #region Question 3
        /*
         * Q3. Write a method that sums all the items of the array primes, and then display this sum.
         * From your main, call this method.
         * [Your method will not take any parameters and it does not return a value.]
         */

        public static void DisplayPrimes()
        {
            int sum = 0;

            for (int counter = 0; counter < primes.Length; counter++)
            {
                sum += primes[counter];
            }

            Console.WriteLine("The sum of primes array is {0}", sum);
        }
        #endregion


        #region Question 4
        /*
         * Q4. Write a method that doubles all the items of the int array primes.
         * This method does not display anything.
         * From your main, call the previous method, this method and then the previous method again.
         * Because the previous method was called twice, you will have two printouts,
           one with the original value and the second one with the doubled values.
         * [Your method will not take any parameters and it does not return a value.]
         */

        public static void DisplayDoublePrimes()
        {
            int counter = 0, sum = 0;

            do
            {
                sum += primes[counter];

                counter++;
            } while (counter < primes.Length);

            Console.WriteLine("Double: The double sum of primes array is {0}", sum * 2);
        }
        #endregion


        #region Question 5
        /*
         * Q5. A) Write a method that will subtract 32 from each item of the char array vowels.
         *        You will have to cast the 32 to a char in order to do the subtraction.
         *     B) Write a second method that will display all the items of the char array vowels on a single line .
         *     C) From your main, call the second method, then the first and then the second again.

         * Subtracting or adding 32 is a common technique for converting from lower case alphabet to upper case alphabet and vice-versa.
         */

        public static void Subtract32()
        {
            int counter = 0, subtraction;

            while(counter < vowels.Length)
            {
                subtraction = Convert.ToInt32(vowels[counter]) - 32;

                vowels[counter] = Convert.ToChar(subtraction);

                Console.Write("{0}, ", vowels[counter]);

                counter++;
            }

            Console.WriteLine();
        }

        public static void DisplayVowels()
        {
            for(int counter = 0; counter < vowels.Length; counter++)
            {
                Console.Write("{0}, ", vowels[counter]);
            }

            Console.WriteLine();
        }
        #endregion


        #region Question 6
        /*
         * Q6. Modify your solution for Question 3 so that the method calculates the sum,
           but return this value instead of displaying it.
         * From your main, call this new method and display the return value.
         */

        public static int DisplayPrimes2()
        {
            int counter = 0, sum = 0;

            do
            {
                sum += primes[counter];

                counter++;
            } while (counter < primes.Length);

            return sum;
        }
        #endregion



        static void Main(string[] args)
        {
            Console.WriteLine("\n[Question 1]");
            DisplayObama();

            Console.WriteLine("\n[Question 2]");
            DisplayPoem();

            Console.WriteLine("\n[Question 3]");
            DisplayPrimes();

            Console.WriteLine("\n[Question 4]");
            Console.Write("Original: ");
            DisplayPrimes();

            DisplayDoublePrimes();

            Console.Write("Original: ");
            DisplayPrimes();

            Console.WriteLine("\n[Question 5]");
            Console.Write("Original: ");
            DisplayVowels();

            Console.Write("Convertion using 32: ");
            Subtract32();

            Console.Write("After convertion: ");
            DisplayVowels();

            Console.WriteLine("\n[Question 6]");
            Console.WriteLine(DisplayPrimes2());
        }
    }
}
