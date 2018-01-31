using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week04 - Class Exercise - Selection
/// </summary>
namespace Q9_LawnMowing2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q9. To the Lawn application you created in the above question,
             * add a prompt that asks the user whether the customer wants to pay (1) once, (2) twice, or (3) 20 times per season.
             * If the user enters 1 for once, the fee for the season is simply the seasonal total.
             * If the customer requests two payments, each payment is half the seasonal fee plus a $5 service charge.
             * If the user requests 20 separate payments, add a $3 service charge per week.
             * Display the number of payments the customer must make, each payment amount, and the total for the season.
             */

            Console.WriteLine("[Question 9 : Lawn Mowing 2]");

            Console.Write("Enter the length of lawn: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the width of lawn: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nChoose a option for payment per season.");
            Console.WriteLine("(1) once, (2) twice, or (3) 20 times");
            Console.Write(">> Enter the number of option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            double area = length * width;
            double cost;

            if (area < 400 && option == 1)
            {
                cost = 25 * 20;

                Console.WriteLine("\nTotal fee of option 1 for {0} square feet is {1:C}", area, cost);
            }
            else if(area < 400 && option == 2)
            {
                cost = 25 * 20 + (5 * 2);

                Console.WriteLine("\nTotal fee of option 2 for {0} square feet is {1:C}", area, cost);
            }
            else if(area < 400 && option == 3)
            {
                cost = (25 * 20) + (20 * 3);

                Console.WriteLine("\nTotal fee of option 3 for {0} square feet is {1:C}", area, cost);
            }

            else if((area >= 400 && area < 600) && option == 1)
            {
                cost = 35 * 20;

                Console.WriteLine("\nTotal fee of option 1 for {0} square feet is {1:C}", area, cost);
            }
            else if ((area >= 400 && area < 600) && option == 2)
            {
                cost = 35 * 20 + (5 * 2);

                Console.WriteLine("\nTotal fee of option 2 for {0} square feet is {1:C}", area, cost);
            }
            else if ((area >= 400 && area < 600) && option == 3)
            {
                cost = (25 * 20) + (20 * 3);

                Console.WriteLine("\nTotal fee of option 3 for {0} square feet is {1:C}", area, cost);
            }

            else if(area >= 600 && option == 1)
            {
                cost = 50 * 20;

                Console.WriteLine("\nTotal fee of option 1 for {0} square feet is {1:C}", area, cost);
            }
            else if (area >= 600 && option == 2)
            {
                cost = 50 * 20 + (5 * 2);

                Console.WriteLine("\nTotal fee of option 2 for {0} square feet is {1:C}", area, cost);
            }
            else if (area >= 600 && option == 3)
            {
                cost = 50 * 20 + (20 * 3);

                Console.WriteLine("\nTotal fee of option 3 for {0} square feet is {1:C}", area, cost);
            }
            else
            {
                Console.WriteLine("Error! Please, enter correct value.");
            }
        }
    }
}
