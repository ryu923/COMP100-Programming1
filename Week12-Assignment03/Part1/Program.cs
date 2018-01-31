using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 12 : Assignment 3 - Part 1 : Methods with an empty parameter list and do not return a value
/// </summary>
namespace Part1
{
    class Program
    {
        #region Question 1
        /*
         * Q1. Write a method called DisplayPersonalInfo().
         * This method will display your name, school, program and your favorite course.
         * Call the DisplayPersonalInfo() method from your program Main() method
         */

        public static void DisplayPersonalInfo()
        {
            Console.WriteLine(" Name: David Ryu");
            Console.WriteLine(" School: Centennial College");
            Console.WriteLine(" Program: Software Engineering");
            Console.WriteLine(" Favorite Course : C# Programming");
        }
        #endregion


        #region Question 2
        /*
         * Q2. Write a method called CalculateTuition().
         * This method will prompt the user for the number of courses that he/she is currently taking and then calculate and display the tuition cost.
         * (cost = number of course * 569.99).
         * Call the CalculateTuition() method two times from the same Main() method as in question 1.
         */

        public static void CalculateTuition()
        {
            Console.Write("Enter the number of courses that you currently taking: ");
            int numberOfCourses = Convert.ToInt32(Console.ReadLine());

            double cost = numberOfCourses * 569.99;

            Console.WriteLine("Cost for {0} is {1:C2}", numberOfCourses, cost);
        }
        #endregion


        #region Question 3
        /*
         * Q3. Write a method call CalculateAreaOfCircle().
         * This method will prompt the user for the radius of a circle and then calculate and display the area.
         * [A = πr2]
         * Call the CalculateAreaOfCircle() method twice from the same Main() method as in question 1.
         * Use Math.Pi for the value of π
         */

        public static void CalculateAreaOfCircle()
        {
            Console.Write("Enter the radius of a circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.Pow(radius, 2) * Math.PI;

            Console.WriteLine("The area of circle that has {0} is {1:F2}", radius, area);
        }
        #endregion


        #region Question 4
        /*
         * Q4. Write a method call CalculateAreaOfTriangle(),
           that prompts the user for the base and height of a triangle and then calculate and display the area.
         * [ A=bt/2 ]
         * Call the CalculateAreaOfTriangle() method twice from the same Main() method as in question 1.
         */

        public static void CalculateAreaOfTriangle()
        {
            Console.Write("Enter the length of base: ");
            double lengthOfBase = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of height: ");
            double lengthOfHeight = Convert.ToDouble(Console.ReadLine());

            double area = lengthOfBase * lengthOfHeight / 2;

            Console.WriteLine("The area of triangle that has {0} length of base and {1} length of height is {2:F2}", lengthOfBase, lengthOfHeight, area);
        }
        #endregion


        #region Question 5
        /*
         * Q5. Write a method call CalculateSaleCommission(),
           that prompts the user for his sales figure, and then calculate and display his commission.
         * (commission = 25% of sales in excess of 1000. If sales is equal to or below $1000.00 there is no commission)
         * Call the CalculateSaleCommission() method three times from the same Main() method as in question 1.
         */

        public static void CalculateSaleCommission()
        {
            Console.Write("Enter the sales figure: ");
            double sales = Convert.ToDouble(Console.ReadLine());

            double commission;

            if(sales > 1000)
            {
                commission = sales * 0.25;
            }
            else
            {
                commission = 0;
            }

            Console.WriteLine("The commission for {0:C2} sales is {1:C2}", sales, commission);
        }
        #endregion


        #region Question 6
        /*
         * Q6. Write a method call DisplaySineTable(), that prompts the user for a starting value and an step size.
         * The method will calculate and display a table (10 rows) of sine values based on the user input.
         * Use the built-in method Math.Sin() to obtain the sine of an angle.
         * e.g. if the starting value is 0.5 and the step size is 0.03 the method will display the following table:

            0.50    0.4794
            0.53	0.5055
            0.56	0.5311
            …
            0.77	0.6961

         * The numbers in both columns MUST be right aligned.
         * Call the DisplaySineTable() method from the same Main() method as in question 1.
         */

        public static void DisplaySineTable()
        {
            Console.Write("Enter the starting value: ");
            double value = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the step size: ");
            double stepSize = Convert.ToDouble(Console.ReadLine());

            int counter = 0;

            do
            {
                double sine = Math.Sin(value);

                Console.WriteLine("{0,4:F2}{1,10:F4}", value, sine);

                value += stepSize;

                counter++;
            } while (counter < 10);
        }
        #endregion


        #region Question 7
        /*
         * Q7. In a write a method called DisplayMenu() to display the following text on screen:
         
            =============Narendra’s Computer Systems==================
            |         1. Display Personal Information                |
            |         2. Calculate Tuition                           |
            |         3. Calculate Area Of A Circle                  |
            |         4. Calculate The Area Of A Triangle            |
            |         5. Calculate Sales Commission                  |
            |         6. Display Sine Table                          |
            |         0. End program                                 |
            |                                                        |
            ==========================================================
              Enter the number of your choice ->

         * You may replace the instructor’s name with your name.
         */

        public static void DisplayMenu()
        {
            Console.WriteLine("================David's Computer Systems=================");
            Console.WriteLine("|         1. Display Personal Information               |");
            Console.WriteLine("|         2. Calculate Tuition                          |");
            Console.WriteLine("|         3. Calculate Area Of A Circle                 |");
            Console.WriteLine("|         4. Calculate The Area Of A Triangle           |");
            Console.WriteLine("|         5. Calculate Sales Commission                 |");
            Console.WriteLine("|         6. Display Sine Table                         |");
            Console.WriteLine("|         0. End program                                |");
            Console.WriteLine("|                                                       |");
            Console.WriteLine("=========================================================");
            Console.Write("  Enter the number of your choice -> ");
        }
        #endregion


        #region Question 8
        /*
         * Q8. Add another method called ShowMenu() to your project.
         * This method will call the method in question 7 continuously until the user presses 0.
         * (You will have to invoke the method in a loop body, read in the user input as well as check the input).
         * You will need to hook up all the methods that you wrote previously
         * i.e. questions 1 to 6. Remove all the code from your Main() method and add a single call to the ShowMenu() method.
         */
        
        public static void ShowMenu()
        {
            DisplayMenu();
            int numberChoice = Convert.ToInt32(Console.ReadLine());

            while (numberChoice != 0)
            {
                Console.WriteLine("\n\n");
                DisplayMenu();
                numberChoice = Convert.ToInt32(Console.ReadLine());

                switch (numberChoice)
                {
                    case 1:
                        DisplayPersonalInfo();
                        break;

                    case 2:
                        CalculateTuition();
                        break;

                    case 3:
                        CalculateAreaOfCircle();
                        break;

                    case 4:
                        CalculateAreaOfTriangle();
                        break;

                    case 5:
                        CalculateSaleCommission();
                        break;

                    case 6:
                        DisplaySineTable();
                        break;

                    default:
                        break;
                }
            }
        }
        #endregion


        static void Main(string[] args)
        {
            //Console.WriteLine("\n[Part I - Question 1]");
            //DisplayPersonalInfo();

            //Console.WriteLine("\n[Part I - Question 2]");
            //CalculateTuition();
            //CalculateTuition();

            //Console.WriteLine("\n[Part I - Question 3]");
            //CalculateAreaOfCircle();
            //CalculateAreaOfCircle();

            //Console.WriteLine("\n[Part I - Question 4]");
            //CalculateAreaOfTriangle();
            //CalculateAreaOfTriangle();

            //Console.WriteLine("\n[Part I - Question 5]");
            //CalculateSaleCommission();
            //CalculateSaleCommission();
            //CalculateSaleCommission();

            //Console.WriteLine("\n[Part I - Question 6]");
            //DisplaySineTable();

            //Console.WriteLine("\n[Part I - Question 7]");
            //DisplayMenu();

            Console.WriteLine("\n[Part I - Question 8]");
            ShowMenu();
        }
    }
}
