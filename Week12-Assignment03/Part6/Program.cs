using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 12 : Assignment 3 - Part 6 : Exotic Methods
/// </summary>
namespace Part6
{
    class Program
    {
        #region Question 1
        /*
         * Q1. In cryptography, a Caesar cipher, also known as Caesar's cipher, the shift cipher, Caesar's code or Caesar shift,
           is one of the simplest and most widely known encryption techniques.
         * It is a type of substitution cipher in which each letter in the plaintext is replaced by a letter some fixed number of positions down the alphabet.
         * For example, with a left shift of 3, D would be replaced by A, E would become B, and so on.
         * The method is named after Julius Caesar, who used it in his private correspondence. … source: https://en.wikipedia.org/wiki/Caesar_cipher
         
            a)	Write a method call “Encrypt” that takes two arguments: a string that represents the message to encrypt and an int that represents the shift amount.
                The method returns a string of the encrypted message.
                The method should shift each letter of the message by the amount specified by the second argument.
                It might be a good idea to convert the string to a char array, do the shift and then convert the array back to a string.
            b)	Write a method call “Decrypt” that takes two arguments: a string that represents a secret message to decrypt and an int that represents the shift amount.
                The method returns a string of the original message.
                The method should shift each letter of the message by the amount specified by the second argument.
                It might be a good idea to convert the string to a char array, do the shift and then convert the array back to a string.
            c)	Write the necessary statements in your main method to work the two methods above.

         */

        #region Question 1-A
        public static string Encrypt(string message, int shiftAmount)
        {
            char[] messageArray = message.ToCharArray();

            for(int counter = 0; counter < messageArray.Length; counter++)
            {
                char letter = messageArray[counter];

                letter = (char)(letter + shiftAmount);

                messageArray[counter] = letter;
            }

            return new string(messageArray);
        }
        #endregion

        #region Question 1-B
        public static string Decrypt(string secretMessage, int deShiftAmount)
        {
            char[] secretMessageArray = secretMessage.ToCharArray();

            for(int counter = 0; counter < secretMessageArray.Length; counter++)
            {
                char letter = secretMessageArray[counter];

                letter = (char)(letter - deShiftAmount);

                secretMessageArray[counter] = letter;
            }

            return new string(secretMessageArray);
        }
        #endregion

        #region Question 1-C
        #endregion

        #endregion


        #region Question 2
        /*
         * Q2. Numerical integration is a technique that is particular suitable for computer applications.
         * In exercise we will try to implement the trapezoidal rule.
         * The integral of a mathematical function is the area between the curve and the x-axis.
         * If the area is divided into little trapezoids, then the integral is approximated by the area of these geometrical figures.
         * You will try to find the area under the curve y = 6x^2-7x+2 in the region from x = 0.5 to x = 1.5
         * (N.B. your answer should work out to about be 1.54, however the actual answer is 1.5).
         * The area is given by the formula (x_b-x_a)/2N(y_0+〖2y〗_1+2y_2+ ⋯+〖2y〗_n+y_(n+1))  
           where y0 and y1 are the height of the vertical lines
           i.e. the value of the function. 

           a) Write a method called EvaluateQuadraticValue(double x, double a, double b, double c) that takes four double arguments:
              the value of x, the coefficient of the x^2 term, the coefficient of the x and the constant.
              The method will compute and return the result value of y given by the expression y = ax^2+bx+c. 
           b) Write a method called ComputeQuadraticValues(double startX, double increments, int numberOfIntervals, double a, double b, double c)
              that takes six arguments: the start value of x, the increments and the number of intervals and the coefficients of the quadratic equation.
              This method will figure out the values of x0, x1, x2 etc. by invoking the previous question.
              The results of the methods calls are collected and returned as a double array.
           C) Write a method called ApplyTrapeziodalRule(double startX, double endX, int numberOfIntervals, double a, double b, double c).
              The arguments are described in the previous question.
              This method calls the previous method and process the double array that is returned to compute the area under the curve by applying the formula (x_b-x_a)/2N(y_0+〖2y〗_1+2y_2+ ⋯+〖2y〗_n+y_(n+1)).

         */

        #region Question 2-A
        public static double EvaluateQuadraticValue(double x, double a, double b, double c)
        {
            double y = a * Math.Pow(x, 2) + (b * x) + c;

            // Check the EvaluateQuadraticValue() Method
            // Console.WriteLine("The Evaluate Quadratic Value: {0}", y);

            return y;
        }
        #endregion

        #region Question 2-B
        public static double[] ComputeQuadraticValues(double startX, double increments, int numberOfIntervals, double a, double b, double c)
        {
            double[] yArray = new double[numberOfIntervals + 1];

            int counter = 0;
            double sum = 0;

            do
            {
                yArray[counter] = EvaluateQuadraticValue(startX, a, b, c);

                // Check the Element of Quadratic Values in Array
                Console.Write("{0}, ", yArray[counter]);

                sum += yArray[counter];

                startX += increments;
                counter++;
            } while (counter < numberOfIntervals);

            // Check the Sum of Quadratic Values 1
            Console.WriteLine("\nThe sum of Quadratic Values in array: {0}", sum);

            return yArray;
        }
        #endregion

        #region Question 1-C
        public static double ApplyTrapeziodalRule(double startX, double endX, int numberOfIntervals, double a, double b, double c)
        {
            double sum = 0;

            int counter = 0;

            double increments = (endX - startX) / numberOfIntervals;

            double[] yArray = ComputeQuadraticValues(startX, increments, numberOfIntervals, a, b, c);

            while (counter < numberOfIntervals)
            {
                double sumOfTwoY = yArray[counter] + yArray[counter + 1];

                sum += sumOfTwoY;

                counter++;
            }

            sum /= 2; //  This is for eliminate duplicated values
            double area = (endX - startX) / (2 * numberOfIntervals) * sum;

            return area;
        }
        #endregion
        #endregion



        static void Main(string[] args)
        {
            Console.WriteLine("\n[Part VI - Question 1]");
            Console.WriteLine(Encrypt("I love dogs.", 3));
            Console.WriteLine(Decrypt(Encrypt("I love dogs.", 3), 3));

            Console.WriteLine("\n[Part VI - Question 2]");
            Console.WriteLine("\nQ2-A: {0}", EvaluateQuadraticValue(1, 1, 2, 3));
            Console.WriteLine("\nQ2-B: {0}", ComputeQuadraticValues(1, 1, 10, 1, 2, 3));
            Console.WriteLine("\nQ2-C: {0}", ApplyTrapeziodalRule(1, 11, 10, 1, 2, 3));
        }
    }
}
