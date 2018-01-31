using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week05 - Class Exercise : SWITCH Statement Exercise
/// </summary>
namespace Q05_Textbook
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Q5. The average cost of a college textbook is $125.
             * There is a premium of 20% on hardcover text and a discount of 5% on sales of more than 4 textbooks.
             * Write a program to prompt the user for the appropriate inputs and compute and display the before-tax cost of the textbooks.

                Sample calculation
                price of 10 hardcover text = 10 * 125 + premium – discount
                price = 1250 + 20% of 1250 – 5% of 1250
                price = $1437.50

             */

            Console.WriteLine("[Question 5 : Textbook]");

            Console.Write("Enter the number of textbooks: ");
            int numberOfTextbook = Convert.ToInt32(Console.ReadLine());

            Console.Write("Do you want to choose premium HARDCOVER option (Y/N)? ");
            char hardcover = Convert.ToChar(Console.ReadLine().ToUpper());

            double priceOfTextbooks;

            if(numberOfTextbook <= 4)
            {
                switch(hardcover)
                {
                    case 'Y':
                        priceOfTextbooks = (numberOfTextbook * 125) + (numberOfTextbook * 125 * 0.2);

                        Console.WriteLine("Price: {0:C}", priceOfTextbooks);
                        break;
                    case 'N':
                        priceOfTextbooks = numberOfTextbook * 125;

                        Console.WriteLine("Price: {0:C}", priceOfTextbooks);
                        break;
                    default:
                        Console.WriteLine("Error! Please, enter the valid value.");
                        break;
                }
            }
            else
            {
                switch (hardcover)
                {
                    case 'Y':
                        priceOfTextbooks = (numberOfTextbook * 125) + (numberOfTextbook * 125 * 0.2) - (numberOfTextbook * 125 * 0.05);

                        Console.WriteLine("Price: {0:C}", priceOfTextbooks);
                        break;
                    case 'N':
                        priceOfTextbooks = (numberOfTextbook * 125) - (numberOfTextbook * 125 * 0.05);

                        Console.WriteLine("Price: {0:C}", priceOfTextbooks);
                        break;
                    default:
                        Console.WriteLine("Error! Please, enter the valid value.");
                        break;
                }
            }
        }
    }
}
