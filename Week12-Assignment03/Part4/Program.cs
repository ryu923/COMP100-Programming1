using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 12 : Assignment 3 - Part 4 : Advanced Method usage: Passing argument using the ref, out and param modifiers
/// </summary>
namespace Part4
{
    class Program
    {
        #region Question 1
        /*
         * Q1. Write a method call DoubleIt(ref int x) that takes a single argument and does not return a value.
         * The method will double the value of its argument.
         */

        public static void DoubleIt(ref int x)
        {
            x *= 2;

            Console.WriteLine("The value will be {0}", x);
        }
        #endregion

        #region Question 2
        /*
         * Q2. Write a method call CubeIt(int x, ref int cube) that takes two arguments and does not return a value.
         * The method will cube the first argument and assign it to the second argument.
         */

        public static void CubeIt(int x, ref int cube)
        {
            cube = Convert.ToInt32(Math.Pow(x, 3)); // Or [cube = (int)Math.Pow(x, 3);]

            Console.WriteLine("The cube of {0} is {1}", x, cube);
        }
        #endregion

        #region Question 3
        /*
         * Q3. Write a method with the following header: static void CaculateTuitionFee(int numberOfCourses, double costPerCourse, ref double fees).
         * This method will calculate and assign the required fees amount to the third argument.
         * [Fees = number of courses * cost per course + 15.25].
         * From your program Main() method, call the CaculateTuitionFee() method four times supplying different arguments each time
           and display the value of the third argument.
         */

        public static void CaculateTuitionFee(int numberOfCourses, double costPerCourse, ref double fees)
        {
            fees = numberOfCourses * costPerCourse + 15.25;

            Console.WriteLine("The fees for {0} is {1:C2} and cost per each course {2:C2}", numberOfCourses, fees, costPerCourse);
        }
        #endregion

        #region Question 4
        /*
         * Q4. Write a method that takes four parameter of type int.
         * The method will assign the sum of the first two arguments to the third and the difference of the first two to the fourth.
         * This method should be coded so that the calling method will use the value of the third and fourth parameters.
         * Call this method about three times and print out the value of the four parameters after each method calls.
         */

        public static void SumAndDifference(int number1, int number2, ref int sum, ref int difference)
        {
            sum = number1 + number2;
            difference = number1 - number2;

            Console.WriteLine("\nThe sum of {0} and {1} is {2}", number1, number2, sum);
            Console.WriteLine("The difference of {0} and {1} is {2}", number1, number2, difference);
        }
        #endregion

        #region Question 5
        /*
         * Q5. Write a method with header static void CalculateTrigValues(double degrees, out double sine, out double cosine, out double tangent).
         * The method will use the first argument to compute the values of the other three arguments.
         * Used the method Math.Sin, Math.Cos and Math.Tan to compute the second to fourth arguments respectively.
         * [radians = degrees * Math.Pi /180].
         * In the Main() method, invoke this method 20 times with the first argument taking the values 0, 5, 10, … 95
           and display the four arguments in a professional tabular format.
         */

        public static void CalculateTrigValues(double degrees, out double sine, out double cosine, out double tangent)
        {
            int counter = 0;
            do
            {
                sine = Math.Sin(degrees);
                cosine = Math.Cos(degrees);
                tangent = Math.Tan(degrees);

                Console.WriteLine("{0,6:F1}  | {1,4:F1} | {2,4:F1}   | {3,5:F1}", degrees, sine, cosine, tangent);

                degrees += 5;
                counter++;
            } while (counter < 20);
        }
        #endregion

        #region Question 6
        /*
         * Q6. Write a method that takes three parameters of type double:
           the first represents an angle, the other two represents the sine and cosine of the angle respectively.
         * The method must be able to change the actual value of the second and third argument.
         * In your Main() method, call the above method ten times with values 0.500, 0.501, 0.502 … 0.509
           and printout the values for angle, sine and cosine in a tabular format.
         */

        public static void CalculateAngleValues(double angle, out double sine, out double cosine)
        {
            int counter = 0;

            // Just only DO-WHILE Loop : Post-Test Loop (WHILE Loop and FOR Loop is invalid!!!)
            do
            {
                sine = Math.Sin(angle);
                cosine = Math.Cos(angle);

                Console.WriteLine("{0,6:F3}  | {1,4:F3} | {2,4:F3}", angle, sine, cosine);

                angle += 0.001;
                counter++;

            } while (counter < 10);

            //while (counter < 10)
            //{
            //    sine = Math.Sin(angle);
            //    cosine = Math.Cos(angle);

            //    Console.WriteLine("{0,6:F1}  | {1,4:F1} | {2,4:F1}", angle, sine, cosine);

            //    angle += 0.001;
            //    counter++;
            //}

            //for(;counter < 10; counter++)
            //{
            //    sine = Math.Sin(angle);
            //    cosine = Math.Cos(angle);

            //    Console.WriteLine("{0,6:F3}  | {1,4:F3} | {2,4:F3}", angle, sine, cosine);

            //    angle += 0.001;
            //    counter++;
            //}
        }
        #endregion

        #region Question 7
        /*
         * A quadratic equation is one in the form of ax2+bx+c = 0.
         * Normally, there are two solutions to such equations given by the expression x=(-b∓√(b^2-4ac))/2a.
         * The Write a method that takes five double arguments,
           the first three represents a, b and c respectively and the last two the solutions to the equation.
         * [You can check your implementation, the quadratic equation 12x2+x-6 will yield solutions -0.750 & 0.667]
         */

        public static void QuadraticEquation(double a, double b, double c, out double x1, out double x2)
        {
            x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);

            Console.WriteLine("The results of quadratic equation which has a = {0}, b {1}, c = {2} are {3:F3} and {4:F3}", a, b, c, x1, x2);
        }
        #endregion



        static void Main(string[] args)
        {
            Console.WriteLine("\n[Part IV - Question 1]");
            int valueQ1 = 10;
            DoubleIt(ref valueQ1); // Do not input the integer directly. It will be error!
            
        
            Console.WriteLine("\n[Part IV - Question 2]");
            int valueQ2 = 10;
            CubeIt(valueQ2, ref valueQ2);
        
            Console.WriteLine("\n[Part IV - Question 3]");
            double fees = 0;
            CaculateTuitionFee(1, 100, ref fees);
            CaculateTuitionFee(2, 95, ref fees);
            CaculateTuitionFee(3, 90, ref fees);
            CaculateTuitionFee(4, 85, ref fees);
        
            Console.WriteLine("\n[Part IV - Question 4]");
            int sum = 0;
            int difference = 0;
            SumAndDifference(10, 1, ref sum, ref difference);
            SumAndDifference(20, 2, ref sum, ref difference);
            SumAndDifference(30, 3, ref sum, ref difference);
        
            Console.WriteLine("\n[Part IV - Question 5]");
            Console.WriteLine("\nDEGREES | SINE | COSINE | TANGENT");
            Console.WriteLine("=================================");
        
            double sine, cosine, tangent;
            CalculateTrigValues(0, out sine, out cosine, out tangent);
            CalculateTrigValues(100, out sine, out cosine, out tangent);
            CalculateTrigValues(200, out sine, out cosine, out tangent);
            CalculateTrigValues(300, out sine, out cosine, out tangent);

            Console.WriteLine("\n[Part IV - Question 6]");
            Console.WriteLine("\nDEGREES | SINE  | COSINE");
            Console.WriteLine("=========================");

            double sine2, cosine2;
            CalculateAngleValues(0.500, out sine2, out cosine2);
            CalculateAngleValues(0.600, out sine2, out cosine2);

            Console.WriteLine("\n[Part IV - Question 7]");
            double x1, x2;
            QuadraticEquation(12, 1, -6, out x1, out x2);
            QuadraticEquation(10, 2, -5, out x1, out x2);
        }
    }
}
