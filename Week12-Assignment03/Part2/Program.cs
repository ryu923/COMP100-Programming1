using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 12 : Assignment 3 - Part 2 : Methods that do not return a value but takes an argument or possibly multiple arguments
/// </summary>
namespace Part2
{
    class Program
    {
        #region Question 1
        /*
         * Q1. Write a method called DisplayHorizontalStars(int numberOfStars).
         * This method will output the number of stars horizontally specified by its argument.
         * Call the DisplayHorizontalStars() method three times from your program Main() method,
           supplying 0, 5 and 10 respectively for the number of stars
         */

        public static void DisplayHorizontalStars(int numberOfStars)
        {
            for(int counter = 1; counter <= numberOfStars; counter++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }
        #endregion


        #region Question 2
        /*
         * Q2. Write a method similar to the one above that displays a vertical line of stars.
         * Call this method three times with arguments 0, 5 and 10 respectively.
         */

        public static void DisplayVerticalStars(int numberOfStars)
        {
            for (int counter = 1; counter <= numberOfStars; counter++)
            {
                Console.WriteLine("* ");
            }

            Console.WriteLine();
        }
        #endregion


        #region Question 3
        /*
         * Q3. Write a method that accepts an argument of type double.
         * The method will calculate and display the volume of a sphere with radius specified by its argument.
         * [V= 4/3 * πr^3].
         * Call this method from your main three times, with arguments 1, 2, and 10 respectively.
         * Use Math.PI for the value of π
         */

        public static void DisplayVolumnOfShpere(double radius)
        {
            double volumnOfShpere = (4 / 3) * Math.PI * Math.Pow(radius, 3);

            Console.WriteLine("Valume of shpere that has {0} radius is {1:F4}", radius, volumnOfShpere);
        }
        #endregion


        #region Question 4
        /*
         * Q4. Write a method that takes two arguments: a cost price and a two letter province code.
         * It will calculate and display the selling price.
         * (If province is Ontario a tax of 13% is added to the price,
            if the province is Quebec a tax of 17% is added to the cost price.
            There is no tax for the rest of the provinces and territories).
         * In your main, call this method enough times to fully test it
         */

        public static void DisplayProvinceTax(double price, string provinceCode)
        {
            double tax;

            if(provinceCode == "ON")
            {
                tax = price * 0.13;

                Console.WriteLine("The tax of {0:C2} item is {1:C2} in {2}.", price, tax, provinceCode);
            }
            else if(provinceCode == "QC")
            {
                tax = price * 0.17;

                Console.WriteLine("The tax of {0:C2} item is {1:C2} in {2}.", price, tax, provinceCode);
            }
            else
            {
                Console.WriteLine("There is no tax of {0:C2} item in {1}.", price, provinceCode);
            }
        }
        #endregion


        #region Question 5
        /*
         * Q5. Write a method that takes a single argument of type double.
         * The will display a Celsius to Fahrenheit conversion table.
         * The starting temperature is indicated by the argument and it will display 10 lines in increments of 1.
         * [Farenheit = 9/5 Celsius + 32].
         * In your main call this method two times, each time with a different value.
         */

        public static void DisplayCelsiusToFahrenheit(double celsius)
        {
            int counter = 0;

            Console.WriteLine("Celsius | Fahrenheit");
            Console.WriteLine("====================");

            do
            {
                double fahrenheit = (9 / 5 * celsius) + 32;

                Console.WriteLine("{0,5}   | {1,8:F0}", celsius, fahrenheit);

                celsius++;
                counter++;
            } while (counter < 10);

            Console.WriteLine();
        }
        #endregion


        #region Question 6
        /*
         * Q6. Write a method that takes the following arguments:
           a starting km value of type double, an increment size of type double and the number of lines of type int.
         * The display a kilometer to miles conversion table.
         * [miles = km * 0.621371].
         * In your main call this method three times, each time with different values.
         */

        public static void DisplayKilometerToMiles(double kilometer, double increment, int numberOfLines)
        {
            double counter = 0;

            Console.WriteLine("Kilometer | Miles");
            Console.WriteLine("=================");

            while (counter < numberOfLines)
            {
                double miles = kilometer * 0.621371;

                Console.WriteLine("{0,6:F1}    | {1,4:F1}", kilometer, miles);

                kilometer += increment;

                counter ++;
            }

            Console.WriteLine();
        }
        #endregion


        #region Question 7
        /*
         * Q7. Modify the DisplaySineTable() method in the previous section to accept the start value,
         * the step size and number of rows as argument to the method.
         */

        public static void DisplaySineTable(double startValue, double stepSize, int numberOfRows)
        {
            int counter = 0;

            Console.WriteLine("Value | Sine");
            Console.WriteLine("============");

            do
            {
                double sine = Math.Sin(startValue);

                Console.WriteLine("{0,4:F1}  | {1,4:F1}", startValue, sine);

                startValue += stepSize;

                counter++;
            } while (counter < numberOfRows);

            Console.WriteLine();
        }
        #endregion


        #region Question 8
        /*
         * Q8. Write a method that converts a person’s height from centimeter to meters
           and centimeters and display the result on the console.
         * In your main method, you should prompt the user for his height in cm and then call the method with this value. 
         
            Input   Result
            90cm	0m 90cm
            120cm	1m 20cm
            275cm	2m 75cm

         */

        public static void DisplayHeight(int height)
        {
            int meter = height / 100;
            int centimeter = height % 100;

            Console.WriteLine("\nInput	Result");
            Console.WriteLine("{0,2}cm{1,4}m{2,2}cm", height, meter, centimeter);
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("\n[Part II - Question 1]");
            DisplayHorizontalStars(0);
            DisplayHorizontalStars(5);
            DisplayHorizontalStars(10);
        
            Console.WriteLine("\n[Part II - Question 2]");
            DisplayVerticalStars(0);
            DisplayVerticalStars(5);
            DisplayVerticalStars(10);
        
            Console.WriteLine("\n[Part II - Question 3]");
            DisplayVolumnOfShpere(1);
            DisplayVolumnOfShpere(2);
            DisplayVolumnOfShpere(10);
        
            Console.WriteLine("\n[Part II - Question 4]");
            DisplayProvinceTax(100, "ON");
            DisplayProvinceTax(100, "QC");
            DisplayProvinceTax(100, "BC");
        
            Console.WriteLine("\n[Part II - Question 5]");
            DisplayCelsiusToFahrenheit(0);
            DisplayCelsiusToFahrenheit(10);
        
            Console.WriteLine("\n[Part II - Question 6]");
            DisplayKilometerToMiles(0, 10, 10);
            DisplayKilometerToMiles(100, 10, 10);
            DisplayKilometerToMiles(200, 10, 10);

            Console.WriteLine("\n[Part II - Question 7]");
            DisplaySineTable(0.0, 1.0, 10);
            DisplaySineTable(10.0, 1.0, 10);
            DisplaySineTable(20.0, 1.0, 10);

            Console.WriteLine("\n[Part II - Question 8]");
            Console.Write("Enter the height: ");
            int heightInput = Convert.ToInt32(Console.ReadLine());

            DisplayHeight(heightInput);
        }
    }
}
