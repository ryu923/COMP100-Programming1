using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 12 : Assignment 3 - Part 5 : More difficult Methods
/// </summary>
namespace Part5
{
    class Program
    {
        #region Question 1
        /*
         * Q1. Write a method with header static void DisplayIntArray(int[] numbers).
         * The first argument is an array of ints.
         * There is no return value.
         * This method displays all the elements of the argument on a single line.
         * Each item will occupy three columns.
         * Call this method from main with a suitable argument.
         */

        public static void DisplayIntArray(int[] numbers)
        {
            int counter = 0;

            do
            {
                Console.Write("|{0}|", numbers[counter]);

                counter++;
            } while (counter < numbers.Length);

            Console.WriteLine();
        }
        #endregion


        #region Question 2
        /*
         * Q2. Write a method with header static int[] GenerateRandomIntArray(int numberOfItems, int largestValue).
         * The first argument is an int indicating the number of elements that will be present in the return array.
         * The second argument is an int representing the largest item in the array.
         * The returned value is an array of integers.
         * This method does the following:
         
            a.	Declare and initialized a variable of type Random (Random generator = new Random();)
            b.	Declare an array of type int (you may call it result)
            c.	Allocate storage for the correct number of items
            d.	Using your favorite looping statement, assign a random integer to each element of the array (result[i] = generator.Next(largestValue);)

         * In your main method, call the above method three times with arguments 15, 10 and 25 and 10 and 30 and 100.
         * In each case assignment the results to a suitable variable and use the DisplayIntArray() method to display the value.
         */

        public static int[] GenerateRandomIntArray(int numberOfItems, int largestValue)
        {
            Random generator = new Random();

            int[] result = new int[numberOfItems];

            int i = 0;

            while(i < numberOfItems)
            {
                result[i] += generator.Next(largestValue);

                i++;
            }

            return result;
        }
        #endregion

        

        #region Question 3
        /*
         * Q3. Write a method with header static int[] CountEvenOdd(int[] array).
         * The argument is an int array. The returned value is an array of 2 integers.
         * The elements of the return array will be a count of the odd and even items in the argument.
         * The first element of the returned array represents the number of odds in the argument
           and the second element indicates the number of evens in the argument.
         * The method will create an int array of 2 elements (call this the result).
         * Each item of the argument is examined and the appropriate element of the result array is incremented.
         * In your main method, create an int array using the GenerateRandomIntArray() method
           and then print out the elements using the DisplayIntArray() method.
         * Call the above method and display the return value.
         * Do a count to verify that your method is working correctly.
         */

        public static int[] CountEvenOdd(int[] array)
        {
            int counterEven = 0, counterOdds = 0;

            for (int counter = 0; counter < array.Length; counter++)
            {
                if(array[counter] % 2 == 0)
                {
                    counterEven++;
                }
                else
                {
                    counterOdds++;
                }
            }

            int[] result = {counterOdds, counterEven};

            return result;
        }
        #endregion


        #region Question 4
        /*
         * Q4. Write a method with header static int[] CalculateDigitFrequencies(int[] array).
         * The argument is an int array with values ranging from 0 to 9. The returned value is an array of 10 integers.
         * The elements of the return array will be a count of the frequencies of the items in the argument.
         * The first element of the returned array represents the number of 0’s in the argument,
           the second element indicates the number of 1’s in the argument and the third element will indicate the number of 2’s in the argument.
         * The method will create an int array of 10 elements (call this the result).
         * Each item of the argument is examined and the appropriate element of the result array is incremented.
         * In your main method, create an int array using the GenerateRandomIntArray() method
           and then print out the elements using the DisplayIntArray() method.
         * Call the above method and display the return value. Do a count to verify that your method is working correctly.
         */

        public static int[] CalculateDigitFrequencies(int[] array)
        {
            int counter = 0;
            int counter0 = 0, counter1 = 0, counter2 = 0;

            do
            {
                if(array[counter] == 0)
                {
                    counter0++;
                }
                else if(array[counter] == 1)
                {
                    counter1++;
                }
                else if(array[counter] == 2)
                {
                    counter2++;
                }

                counter++;
            } while (counter < array.Length);

            int[] result = {counter0, counter1, counter2};

            return result;
        }
        #endregion


        #region Question 5
        /*
         * Q5. Write a method with header static int[] CalculateLastDigitFrequencies(int[] array).
         * The argument is an int array.
         * The returned value is an array of 10 integers.
         * The elements of the return array will be a count of the frequencies of the items in the argument.
         * The first element of the returned array represents the number with last digit of 0’s in the argument,
           the second element indicates the number with last digit of 1’s in the argument
           and the third element will indicate the number with last digit of 2’s in the argument.
         * The method will create an int array of 10 elements (call this the result).
         * Each item of the argument is examined and the appropriate element of the result array is incremented.
         * In your main method, create an int array using the GenerateRandomIntArray() method
           and then print out the elements using the DisplayIntArray() method.
         * Call the above method and display the return value.
         * Do a count to verify that your method is working correctly.
         */

        public static int[] CalculateLastDigitFrequencies(int[] array)
        {
            int counter = 0;
            int counter0 = 0, counter1 = 0, counter2 = 0;

            while(counter < array.Length)
            {
                switch(array[counter] % 10)
                {
                    case 0:
                        counter0++;
                        break;
                    case 1:
                        counter1++;
                        break;
                    case 2:
                        counter2++;
                        break;
                }

                counter++;
            }

            int[] result = {counter0, counter1, counter2};

            return result;
        }
        #endregion


        #region Question 6
        /*
         * Q6. Write a method with header static int[] CalculateNumberFrequencies(int[] array).
         * The argument is an int array with values ranging from 0 to 99.
         * The returned value is an array of 10 integers.
         * The first element will indicate the number or unit values in the argument (i.e. values 0-9),
           the second element will indicate the number of 10 values (i.e. values 10-19),
           the third element will indicate the number of 20 values (i.e. values 20-29) etc.
         * The method will create an int array of 10 elements (call this the result).
         * Each item of the argument is examined and the appropriate element of the result array is incremented. 
         * In your main method, create an int array using the GenerateRandomIntArray() method
           and then print out the elements using the DisplayIntArray() method.
         * Call the above method and display the return value.
         * Do a count to verify that your method is working correctly.
         */

        public static int[] CalculateNumberFrequencies(int[] array)
        {
            int counter0 = 0, counter10 = 0, counter20 = 0;

            for(int counter = 0; counter < array.Length; counter++)
            {
                if(array[counter] >=0 && array[counter] < 10)
                {
                    counter0++;
                }
                else if(array[counter] >= 10 && array[counter] < 20)
                {
                    counter10++;
                }
                else if(array[counter] >= 10 && array[counter] < 20)
                {
                    counter20++;
                }
            }

            int[] result = {counter0, counter10, counter20};

            return result;
        }
        #endregion


        #region Question 7
        /*
         * Q7. Write a method that takes a string and return a distribution of the letter in the string.
         * A distribution can be an array of the letter frequencies.
         * To simplify code, you may assume that all the letters will be lowercased (or uppercased) and there are no periods or spaces.
         * Call the above method and display the return value.
         * Do a count to verify that your method is working correctly.
         */
        
        public static int[] CalculateCharacterFrequencies(string letter)
        {
            string letterUpper = letter.ToUpper();

            char[] letters = letterUpper.ToCharArray();

            int counter = 0;
            int counterA = 0, counterE = 0, counterI = 0, counterO = 0, counterU = 0;

            do
            {
                switch(letters[counter])
                {
                    case 'A':
                        counterA++;
                        break;

                    case 'E':
                        counterE++;
                        break;

                    case 'I':
                        counterI++;
                        break;

                    case 'O':
                        counterO++;
                        break;

                    case 'U':
                        counterU++;
                        break;
                }

                counter++;
            } while (counter < letterUpper.Length);

            int[] result = {counterA, counterE, counterI, counterO, counterU};

            return result;
        }
        #endregion


        #region Question 8
        /*
         * Q8. Write a method that returns a binary string representation of its argument.
         * Call this method from your main and display the returned values.
         * If you call the method three times with the integers 7, 128 and 15 respectively,
           the method will return the binary strings 111, 10000000 and 1111 respectively.
         */

        public static string IntToBinary(int integer)
        {
            string binary = Convert.ToString(integer, 2);

            return binary;
        }
        #endregion


        #region Question 9
        /*
         * Q9. Write a method that will return the year-end balance for a mortgage,
           given the beginning balance, the yearly interest rate, and the bi-weekly payments.
         * You can assume that there are 26 payments in the year and the mortgage is re-calculated after each payment.*
         * For each period, you will need to calculate the interest
           (you will need to calculate the daily interest and times it by the number of days in each period),*
           then add this to the starting balance and then subtract the payment.
         * If the starting principal is $300,000, the interest rate is 2.5% and the bi-weekly payment is $1,000, what will be the year-end balance?
         * How much would you save if you increased the monthly payment by $100?
         */

        public static double Mortgage1(double balance, double interestRate, double biWeeklyPayment)
        {
            int counter = 1;

            while(counter <= 26)
            {
                balance = balance + (balance * (interestRate / 100) / 365 * 14) - biWeeklyPayment;

                counter++;
            }

            return balance;
        }

        public static double Mortgage2(double balance, double interestRate, double biWeeklyPayment)
        {
            int counter = 1;

            while (counter <= 26)
            {
                balance = balance + (balance * (interestRate / 100) / 365 * 14) - biWeeklyPayment;

                if(counter % 2 == 0)
                {
                    biWeeklyPayment += 100;
                }

                counter++;
            }

            return balance;
        }
        #endregion


        #region Question 10
        /*
         * Q10.	Write a method that will display the nth term of a Fibonacci sequence.
         * The nth term is defined as the sum of the two previous terms.
         * The first few terms of the Fibonacci series are 1, 1, 2, 3, 5, 8, 13, 21, etc.
         */
        public static void FibonacciSequence(int numberOfTerm)
        {
            int[] fibonacciArray = new int[numberOfTerm];

            int counter = 0;

            if (numberOfTerm == 1 || numberOfTerm == 2)
            {
                fibonacciArray[0] = 1;
                fibonacciArray[1] = 1;
            }
            else
            {
                fibonacciArray[0] = 1;
                fibonacciArray[1] = 1;

                for (counter = 2; counter < numberOfTerm; counter++)
                {
                    fibonacciArray[counter] = fibonacciArray[counter - 2] + fibonacciArray[counter - 1];
                }
            }

            Console.WriteLine("The number of {0}th term in Fibonacci sequence is {1}", counter, fibonacciArray[numberOfTerm - 1]);
        }
        #endregion


        #region Question 11
        /*
         * Q11. Write a method that will return the factorial of its argument number. [n! = n(n-1)(n-2)(n-3)… (1)] 
         */
        
        public static int DisplayFactorial(int factorial)
        {
            int[] factorialArray = new int[factorial];

            int counter = 0;

            do
            {
                factorialArray[counter] = factorial;

                factorial--;
                counter++;
            } while (counter < factorialArray.Length);


            int result = 1;
            int counter2 = 0;

            while(counter2 < factorialArray.Length)
            {
                result = result * factorialArray[counter2];

                counter2++;
            }

            return result;
        }
        #endregion


        #region Question 12
        /*
         * Q12. Write a method that computes the value of PI given by the expression π/4 = 1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 ⋯.
         * How many terms are needed to match Math.PI?
         */

        public static void ComputePI()
        {
            //int[] dominatorArray = new int[] { };

            int counter = 0;
            int dominator = 1;
            double result = 0;
            //double target = 3.14 / 4;

            for (; result <= Math.PI / 4;)
            {
                if (counter % 2 == 0)
                {
                    result = result + (1 / dominator);
                }
                else
                {
                    result = result - (1 / dominator);
                }

                counter++;
                dominator += 2;
            }

            Console.WriteLine("{0}", counter);
        }
        #endregion


        #region Question 13
        /*
         * Q13. Write a method that takes two integers and returns the greatest common divisor (gcd)
         */

        public static void DisplayGCD(int number1, int number2)
        {
            for(; number1 != number2;)
            {
                if(number1 > number2)
                {
                    number1 -= number2;
                }

                else if(number2 > number1)
                {
                    number2 -= number1;
                }
            }

            Console.WriteLine("The GCD is {0}", number1);
        }
        #endregion


        #region Question 14
        /*
         * Q14.	Write a method similar to question 3, that counts the distribution of two-letters combinations i.e. digrams
         */

        public static void CountsLetterCombinations(string sentence, char charactor1, char charactor2)
        {
            char[] sentenceArray = sentence.ToCharArray();

            int counter = 0;
            int number = 0;

            do
            {
                if(sentenceArray[counter] == charactor1 && sentenceArray[counter + 1] == charactor2)
                {
                    number++;
                }

                counter++;
            } while (counter < sentenceArray.Length);

            Console.WriteLine("In the sentence of [{0}]. \nThe number of combination {1} and {2} is {3}", sentence, charactor1, charactor2, number);
        }
        #endregion


        static void Main(string[] args)
        {
            Console.WriteLine("\n[Part V - Question 1]");
            int[] numberQ1 = { 1, 2, 3, 4, 5 };
            DisplayIntArray(numberQ1);


            Console.WriteLine("\n\n[Part V - Question 2]");
            DisplayIntArray(GenerateRandomIntArray(15, 10));
            DisplayIntArray(GenerateRandomIntArray(25, 10));
            DisplayIntArray(GenerateRandomIntArray(30, 100));


            Console.WriteLine("\n\n[Part V - Question 3]");
            Console.Write("Number of Odds and Even : ");
            DisplayIntArray(CountEvenOdd(GenerateRandomIntArray(10, 20)));
            Console.Write("Number of Odds and Even : ");
            DisplayIntArray(CountEvenOdd(GenerateRandomIntArray(20, 40)));


            Console.WriteLine("\n\n[Part V - Question 4]");
            Console.Write("Numbers of frequency of 0, 1, and 2 : ");
            DisplayIntArray(CalculateDigitFrequencies(GenerateRandomIntArray(10, 9)));


            Console.WriteLine("\n\n[Part V - Question 5]");
            Console.Write("Numbers of last digit frequency of 0, 1, and 2 : ");
            DisplayIntArray(CalculateLastDigitFrequencies(GenerateRandomIntArray(10, 99)));


            Console.WriteLine("\n\n[Part V - Question 6]");
            Console.Write("Numbers of frequency in 0 to 9, 10 to 19, and 20 to 29 : ");
            DisplayIntArray(CalculateNumberFrequencies(GenerateRandomIntArray(10, 99)));


            Console.WriteLine("\n\n[Part V - Question 7]");
            Console.Write("Numbers of vowel frequencies of A, E, E, O, and U : ");
            DisplayIntArray(CalculateCharacterFrequencies("You never know what is coming for you."));


            Console.WriteLine("\n\n[Part V - Question 8]");
            Console.WriteLine("The binary of 7 is {0}", IntToBinary(7));
            Console.WriteLine("The binary of 18 is {0}", IntToBinary(128));
            Console.WriteLine("The binary of 15 is {0}", IntToBinary(15));


            Console.WriteLine("\n\n[Part V - Question 9]");
            Console.WriteLine("The mortgage balance at end year is {0:C2}", Mortgage1(300000, 0.025, 1000));
            Console.WriteLine("The mortgage balance at end year is {0:C2} with increased the monthly payment by $100 ", Mortgage2(300000, 0.025, 1000));
            Console.WriteLine("The mortgage balance difference between above two options is {0:C2}", Mortgage1(300000, 0.025, 1000) - Mortgage2(300000, 0.025, 1000));

            Console.WriteLine("\n[Part V - Question 10]");
            FibonacciSequence(5);
            FibonacciSequence(8);

            Console.WriteLine("\n[Part V - Question 11]");
            Console.WriteLine("The result of 5 factorial is {0}", DisplayFactorial(5));
            Console.WriteLine("The result of 5 factorial is {0}", DisplayFactorial(10));

            Console.WriteLine("\n[Part V - Question 12]");
            ComputePI();

            Console.WriteLine("\n[Part V - Question 13]");
            DisplayGCD(4, 8);
            DisplayGCD(8, 14);
            DisplayGCD(36, 42);

            Console.WriteLine("\n[Part V - Question 14]");
            CountsLetterCombinations("Who is the best? It is Me!!!", 'i', 's');
        }
    }
}
