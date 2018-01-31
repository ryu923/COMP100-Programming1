using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 12 : Assignment 3 - Part 3 : Methods that return a value and may or may not arguments
/// </summary>
namespace Part3
{
    class Program
    {
        #region Question 1
        /*
         * Q1. Write a method called CaculateDifference(int firstNumber, int secondNumber).
         * This method will calculate and return the difference between the two number
           i.e. it will subtract the smaller one from the larger one and then return that value.
         * Call the CaculateDifference() method four times from your program Main() method supplying different arguments each time.
         */
        
        public static int CaculateDifference(int firstNumber, int secondNumber)
        {
            int result;

            if(firstNumber > secondNumber)
            {
                result = firstNumber - secondNumber;;
            }
            else if(firstNumber == secondNumber)
            {
                result = firstNumber - secondNumber;
            }
            else
            {
                result = secondNumber - firstNumber;
            }

            return result;
        }
        #endregion


        #region Question 2
        /*
         * Q2. Write a method called CalculatePower(double current, double resistance).
         * The method will calculate and return the electrical power dissipated in a circuit.
         * [P=I2R]
         * Call the CalculatePower() method two times from your program Main() method supplying different arguments each time.
         */

        public static double CalculatePower(double current, double resistance)
        {
            double power = Math.Pow(current, 2) * resistance;

            return power;
        }
        #endregion


        #region Question 3
        /*
         * Q3. Write a method called CaculateTuitionFee(int numberOfCourses, double costPerCourse = 449.99).
         * This method will calculate and return the required fees amount.
         * [Fees = number of courses * cost per course + 15.25].
         * Call the CaculateTuitionFee() method four times from your program Main() method supplying different arguments each time.
         */

        public static double CaculateTuitionFee(int numberOfCourses, double costPerCourse = 449.99)
        {
            double fees = numberOfCourses * costPerCourse + 15.25;

            return fees;
        }
        #endregion


        #region Question 4
        /*
         * Q4. Write a method called CalculateCommission(double saleAmount).
         * This method will calculate and return a sales representation’s commission.
         * [over $1000 the commission will be 1%].
         * Call the CalculateCommission() method three times from your program Main() method, supplying arguments 900, 1000 and 2000.
         */

        public static double CalculateCommission(double saleAmount)
        {
            double commission;

            if(saleAmount > 1000)
            {
                commission = saleAmount * 0.01;
            }
            else
            {
                commission = 0;
            }

            return commission;
        }
        #endregion


        #region Question 5
        /*
         * Q5. Write a method that does not take any argument.
         * The method will prompt the user for the number of burgers that he wants to buy.
         * The method will calculate and return the amount of money that will be required.
         * [One burger cost $1.39].
         * From your program Main() method, call the above method two times
         */

        public static double CostOfBurgers()
        {
            Console.Write("Enter the number that you want to buy: ");
            int numberOfBurgers = Convert.ToInt32(Console.ReadLine());

            double cost = numberOfBurgers * 1.39;

            return cost;
        }
        #endregion


        #region Question 6
        /*
         * Q6. “Newton's law of universal gravitation states that
           every point mass in the universe attracts every other point mass with a force that is directly proportional to the product of their masses
           and inversely proportional to the square of the distance between them.”
         * Write a method called CalculateGravitationalAttraction() that takes three double arguments
           (masses of the two bodies and the distance between them).
         * The method will calculate and return the force of attraction between them.
         * [F=G (m_1 m_2)/d^2  , where G = 6.673x10-11].
         * In your main call this method with the masses of the earth, moon and the distance between themand display the resulting force.
         * Mass of Earth = 5.972 × 1024, moon = 7.348 × 1022, Distance = 384,400000m.
         */

        public static double CalculateGravitationalAttraction(double mass1, double mass2, double distance)
        {
            double g = 6.673E-11; // When E is used in code, there should be no spaces in code!

            double forceOfAttraction = g * (mass1 * mass2 / Math.Pow(distance, 2));

            return forceOfAttraction;
        }
        #endregion


        #region Question 7
        /*
         * Q7. Heron’s formula allows you to calculate the area of any triangle given the length of the three sides.
         * Write a method that takes the length of the three sides and return the area of the specified triangle.
         * A=√(s(s-a)(s-b)(s-c) ) where s=(a+b+c)/2.
         * In your main call this method with arguments 5.83, 4.24 and 8.00, and display the area. [Answer = 12.0].
         */
        
        public static double HeronFormula(double a, double b, double c)
        {
            double s = (a + b + c) / 2;

            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }
        #endregion


        #region Question 8
        /*
         * Q8. Write a method called ConvertCelsiusToFahrenheit that takes a double argument.
         * The method will calculate and return the Fahrenheit equivalent of the argument.
         * [F = C * 9 / 5 + 32].
         * In your main call this method three times with arguments 0, 50 and 100 respectively and display the results.
         */

        public static double ConvertCelsiusToFahrenheit(double c)
        {
            double f = c * 9 / 5 + 32;

            return f;
        }
        #endregion


        #region Question 9
        /*
         * Q9. Write a method called ConvertFahrenheitToCelsius that takes a double argument.
         * The method will calculate and return the Celsius equivalent of the argument.
         * [C = (F – 32) * 5 / 9].
         * In your main call this method three times with arguments 0, 32 and 212 respectively and display the results.
         */
        
        public static double ConvertFahrenheitToCelsius(double f)
        {
            double c = (f - 32) * 5 / 9;

            return c;
        }
        #endregion


        #region Question 10
        /*
         * Q10.	Write a method called ConvertCelsiusToKelvin that takes a double argument.
         * The method will calculate and return the Kelvin equivalent of the argument.
         * [K = C + 273.15].
         * In your main call this method three times with arguments -196, 0 and 100 respectively and display the results.
         */
        
        public static double ConvertCelsiusToKelvin(double c)
        {
            double k = c + 273.15;

            return k;
        }
        #endregion


        #region Question 11
        /*
         * Q11.	Write a method call ConvertFahrenheitToKelvin that takes a double argument.
         * The method will calculate and return the Kelvin equivalent of the argument.
         * [Use the two previous methods to assist in your computation].
         * In your main call this method three times and display the results.
         */

        public static double ConvertFahrenheitToKelvin(double fahrenheit)
        {
            double celsius = ConvertFahrenheitToCelsius(fahrenheit);

            double kelvin = ConvertCelsiusToKelvin(celsius);

            return kelvin;
        }
        #endregion


        #region Question 12
        /*
         * Q12.	Write two methods: Square(int) and Cube(int), these methods return the square and the cube of its argument.
         * In your main method prompt the user for an integer, then pass this integer to the Square method and then pass the results to the Cube method.
         * In the main method print out the final results.
         */
        
        public static int Square(int input)
        {
            int square = input * input;

            return square;
        }

        public static int Cube(int input)
        {
            int cube = input * input * input;

            return cube;
        }
        #endregion


        #region Question 13
        /*
         * Q13.	Write two methods that will be called from main.
         * The first method should prompt the user for his daily sales amount.
         * The method should accept and return this amount.
         * The second method should calculate and return his commission based on the following: 0-999 3%, 1000-2999 4% and over 3000 5%.
         * In your main call the two methods and display the results in a readable manner.
         */
        
        public static double DailySales()
        {
            Console.Write("Enter the daily sales amount: ");
            double dailySales = Convert.ToDouble(Console.ReadLine());

            return dailySales;
        }

        public static double CommissionOfSales(double dailySalesAmount)
        {
            double commission;

            if(dailySalesAmount >= 0 && dailySalesAmount < 1000)
            {
                commission = dailySalesAmount * 0.03;
            }
            else if(dailySalesAmount >= 1000 && dailySalesAmount < 3000)
            {
                commission = dailySalesAmount * 0.04;
            }
            else if(dailySalesAmount >= 3000)
            {
                commission = dailySalesAmount * 0.05;
            }
            else
            {
                commission = dailySalesAmount;
            }

            return commission;
        }
        #endregion



        static void Main(string[] args)
        {
            Console.WriteLine("\n[Part III - Question 1]");
            Console.WriteLine(CaculateDifference(10, 1));
            Console.WriteLine(CaculateDifference(9, 9));
            Console.WriteLine(CaculateDifference(1, 10));
            Console.WriteLine(CaculateDifference(5, -4));

            Console.WriteLine("\n[Part III - Question 2]");
            Console.WriteLine(CalculatePower(10, 10) + " (P)");
            Console.WriteLine(CalculatePower(5, 4) + " (P)");

            Console.WriteLine("\n[Part III - Question 3]");
            Console.WriteLine("{0:C1}", CaculateTuitionFee(7)); // The second argument is not needed because it was already assigned as 449.99.
            Console.WriteLine("{0:C1}", CaculateTuitionFee(10, 500)); // The second argument can be assigned as different value.
            Console.WriteLine("{0:C1}", CaculateTuitionFee(5));
            Console.WriteLine("{0:C1}", CaculateTuitionFee(3, 400));

            Console.WriteLine("\n[Part III - Question 4]");
            Console.WriteLine("{0:C1}", CalculateCommission(900));
            Console.WriteLine("{0:C1}", CalculateCommission(1000));
            Console.WriteLine("{0:C1}", CalculateCommission(2000));

            Console.WriteLine("\n[Part III - Question 5]");
            Console.WriteLine("{0:C2}", CostOfBurgers());
            Console.WriteLine("{0:C2}", CostOfBurgers());


            Console.WriteLine("\n[Part III - Question 6]");
            double earth = 5.972 * 1024;
            double moon = 7.348 * 1022;
            double distance = 384400000;
            Console.WriteLine("{0:E2}N", CalculateGravitationalAttraction(earth, moon, distance));

            Console.WriteLine("\n[Part III - Question 7]");
            Console.WriteLine("{0:F1}", HeronFormula(5.83, 4.24, 8.00));

            Console.WriteLine("\n[Part III - Question 8]");
            Console.WriteLine("0 Celsius = {0:F1} Fahrenheit", ConvertCelsiusToFahrenheit(0));
            Console.WriteLine("50 Celsius = {0:F1} Fahrenheit", ConvertCelsiusToFahrenheit(50));
            Console.WriteLine("100 Celsius = {0:F1} Fahrenheit", ConvertCelsiusToFahrenheit(100));

            Console.WriteLine("\n[Part III - Question 9]");
            Console.WriteLine("0 Fahrenheit = {0:F1} Celsius", ConvertFahrenheitToCelsius(0));
            Console.WriteLine("32 Fahrenheit = {0:F1} Celsius", ConvertFahrenheitToCelsius(32));
            Console.WriteLine("212 Fahrenheit = {0:F1} Celsius", ConvertFahrenheitToCelsius(212));


            Console.WriteLine("\n[Part III - Question 10]");
            Console.WriteLine("-196 Celsius = {0:F1} Kelvin", ConvertCelsiusToKelvin(-196));
            Console.WriteLine("0 Celsius = {0:F1} Kelvin", ConvertCelsiusToKelvin(0));
            Console.WriteLine("100 Celsius = {0:F1} Kelvin", ConvertCelsiusToKelvin(100));

            Console.WriteLine("\n[Part III - Question 11]");
            Console.WriteLine("0 Fahrenheit = {0:F1} Kelvin", ConvertFahrenheitToKelvin(0));
            Console.WriteLine("32 Fahrenheit = {0:F1} Kelvin", ConvertFahrenheitToKelvin(32));
            Console.WriteLine("100 Fahrenheit = {0:F1} Kelvin", ConvertFahrenheitToKelvin(100));

            Console.WriteLine("\n[Part III - Question 12]");
            Console.Write("Enter the integer: ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The square of {0} is {1}", input, Square(input));
            Console.WriteLine("The cube of {0} is {1}", input, Cube(input));

            Console.WriteLine("\n[Part III - Question 13]");
            Console.WriteLine("The commission is {0:C2}", CommissionOfSales(DailySales()));
        }
    }
}
