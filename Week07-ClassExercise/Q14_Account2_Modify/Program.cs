using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 7 - Class Exercise : DO WHILE, WHILE, FOR Loop
/// </summary>
namespace Q14_Account2_Modify
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * a. Modify the program written for Question 13 to initially prompt the user for the amount of money initially deposited in the account. 
             * b. Modify the program written for Question 13 to initially prompt the user for both the amount of money initially deposited
                  and the number of years that should be displayed.
             * c. Modify the program written for Question 13 to initially prompt for the amount of money initially deposited,
                  the interest rate to be used, and the number of years to be displayed. 
             */

            #region Question A
            Console.WriteLine("[Question 14 - A : 1. DO-WHILE Loop]");
            
            Console.Write("Enter the amount of money initially deposited: ");
            double money = Convert.ToDouble(Console.ReadLine());
            
            double rate = 6;
            
            do
            {
                Console.WriteLine("[{0}% INTEREST]", rate);
                Console.WriteLine();
                Console.WriteLine(" Year | Balance");
                Console.WriteLine("================");
            
                int year = 1;
            
                double balance = money; // Reset the balance in account.
            
                do
                {
                    balance += (balance * rate / 100);
            
                    Console.WriteLine("{0,4}  | {1,7:C1}", year, balance);
            
                    year++;
                } while (year <= 10);
            
                Console.WriteLine("\n");
                rate++;
            } while (rate <= 12);
            
            
            Console.WriteLine("\n\n[Question 14 - A : 2. WHILE Loop]");
            
            Console.Write("Enter the amount of money initially deposited: ");
            double moneyWhile = Convert.ToDouble(Console.ReadLine());
            
            double rateWhile = 6;
            
            while (rateWhile <= 12)
            {
                Console.WriteLine("\n[{0}% INTEREST]", rateWhile);
                Console.WriteLine();
                Console.WriteLine(" Year | Balance");
                Console.WriteLine("================");
            
                int yearWhile = 1;
                double balanceWhile = moneyWhile;
            
                while (yearWhile <= 10)
                {
                    balanceWhile += (balanceWhile * rateWhile / 100);
            
                    Console.WriteLine("{0,4}  | {1,7:C1}", yearWhile, balanceWhile);
            
                    yearWhile++;
                }
            
                rateWhile++;
            }
            
            
            Console.WriteLine("\n\n[Question 14 - A : 3. FOR Loop]");
            
            Console.Write("Enter the amount of money initially deposited: ");
            double moneyFor = Convert.ToDouble(Console.ReadLine());
            
            for (double rateFor = 6; rateFor <= 12; rateFor++)
            {
                Console.WriteLine("\n[{0}% INTEREST]", rateFor);
                Console.WriteLine();
                Console.WriteLine(" Year | Balance");
                Console.WriteLine("================");
            
                for (double yearFor = 1, balanceFor = moneyFor; yearFor <= 10; yearFor++)
                {
                    balanceFor += (balanceFor * rateFor / 100);
            
                    Console.WriteLine("{0,4}  | {1,7:C1}", yearFor, balanceFor);
                }
            }
            #endregion
            
            
            #region Question B
            Console.WriteLine("\n\n\n\n[Question 14 - B : 1. DO-WHILE Loop]");
            
            Console.Write("Enter the amount of money initially deposited: ");
            double moneyB = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the number of year that you want to display: ");
            int numberOfyearB = Convert.ToInt32(Console.ReadLine());
            
            double rateB = 6;
            
            do
            {
                Console.WriteLine("\n[{0}% INTEREST]", rateB);
                Console.WriteLine();
                Console.WriteLine(" Year | Balance");
                Console.WriteLine("================");
            
                int yearB = 1;
            
                double balanceB = moneyB; // Reset the balance in account.
            
                do
                {
                    balanceB += (balanceB * rateB / 100);
            
                    Console.WriteLine("{0,4}  | {1,7:C1}", yearB, balanceB);
            
                    yearB++;
                } while (yearB <= numberOfyearB);
            
                Console.WriteLine("\n");
                rateB++;
            } while (rateB <= 12);
            
            
            Console.WriteLine("\n\n[Question 14 - B : 2. WHILE Loop]");
            
            Console.Write("Enter the amount of money initially deposited: ");
            double moneyBWhile = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the number of year that you want to display: ");
            int numberOfyearBWhile = Convert.ToInt32(Console.ReadLine());
            
            double rateBWhile = 6;
            
            while (rateBWhile <= 12)
            {
                Console.WriteLine("\n[{0}% INTEREST]", rateBWhile);
                Console.WriteLine();
                Console.WriteLine(" Year | Balance");
                Console.WriteLine("================");
            
                int yearBWhile = 1;
            
                double balanceBWhile = moneyBWhile; // Reset the balance in account. *
            
                while (yearBWhile <= numberOfyearBWhile)
                {
                    balanceBWhile += (balanceBWhile * rateBWhile / 100);
            
                    Console.WriteLine("{0,4}  | {1,7:C1}", yearBWhile, balanceBWhile);
            
                    yearBWhile++;
                }
            
                rateBWhile++;
            }
            
            
            Console.WriteLine("\n\n[Question 14 - B : 3. FOR Loop]");
            
            Console.Write("Enter the amount of money initially deposited: ");
            double moneyBFor = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the number of year that you want to display: ");
            int numberOfyearBFor = Convert.ToInt32(Console.ReadLine());
            
            for (double rateBFor = 6; rateBFor <= 12; rateBFor++)
            {
                Console.WriteLine("\n[{0}% INTEREST]", rateBFor);
                Console.WriteLine();
                Console.WriteLine(" Year | Balance");
                Console.WriteLine("================");
            
                for (double yearBFor = 1, balanceBFor = moneyBFor; yearBFor <= numberOfyearBFor; yearBFor++)
                {
                    balanceBFor += (balanceBFor * rateBFor / 100);
            
                    Console.WriteLine("{0,4}  | {1,7:C1}", yearBFor, balanceBFor);
                }
            }
            #endregion
            
            
            #region Question C
            Console.WriteLine("[Question 14 - C : 1. DO-WHILE Loop]");
            
            Console.Write("Enter the amount of money initially deposited: ");
            double moneyC = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the number of year that you want to display: ");
            int numberOfyearC = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the starting interest rate that you want to display: ");
            double startingRateC = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the ending interest rate that you want to display: ");
            double endingRateC = Convert.ToInt32(Console.ReadLine());
            
            do
            {
                Console.WriteLine("\n[{0}% INTEREST]", startingRateC);
                Console.WriteLine();
                Console.WriteLine(" Year | Balance");
                Console.WriteLine("================");
            
                int yearC = 1;
            
                double balanceC = moneyC; // Reset the balance in account.
            
                do
                {
                    balanceC += (balanceC * startingRateC / 100);
            
                    Console.WriteLine("{0,4}  | {1,7:C1}", yearC, balanceC);
            
                    yearC++;
                } while (yearC <= numberOfyearC);
            
                Console.WriteLine("\n");
                startingRateC++;
            } while (startingRateC <= endingRateC);
            
            
            Console.WriteLine("[Question 14 - C : 2. WHILE Loop]");
            
            Console.Write("Enter the amount of money initially deposited: ");
            double moneyCWhile = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the number of year that you want to display: ");
            int numberOfyearCWhile = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the starting interest rate that you want to display: ");
            double startingRateCWhile = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the ending interest rate that you want to display: ");
            double endingRateCWhile = Convert.ToInt32(Console.ReadLine());
            
            while(startingRateCWhile <= endingRateCWhile)
            {
                Console.WriteLine("\n[{0}% INTEREST]", startingRateCWhile);
                Console.WriteLine();
                Console.WriteLine(" Year | Balance");
                Console.WriteLine("================");
            
                double yearCWhile = 1, balanceCWhile = moneyCWhile;
            
                while (yearCWhile <= numberOfyearCWhile)
                {
                    balanceCWhile += (balanceCWhile * startingRateCWhile / 100);
            
                    Console.WriteLine("{0,4}  | {1,7:C1}", yearCWhile, balanceCWhile);
            
                    yearCWhile++;
                }
            
                startingRateCWhile++;
            }
            
            
            Console.WriteLine("\n\n[Question 14 - C : 3. FOR Loop]");
            
            Console.Write("Enter the amount of money initially deposited: ");
            double moneyCFor = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the number of year that you want to display: ");
            int numberOfyearCFor = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the starting interest rate that you want to display: ");
            double startingRateCFor = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the ending interest rate that you want to display: ");
            double endingRateCFor = Convert.ToInt32(Console.ReadLine());
            
            for(; startingRateCFor <= endingRateCFor; startingRateCFor++)
            {
                Console.WriteLine("\n[{0}% INTEREST]", startingRateCFor);
                Console.WriteLine();
                Console.WriteLine(" Year | Balance");
                Console.WriteLine("================");
            
                for(double yearCFor = 1, balanceCFor = moneyCFor; yearCFor <= numberOfyearCFor; yearCFor++)
                {
                    balanceCFor += (balanceCFor * startingRateCFor / 100);
            
                    Console.WriteLine("{0,4}  | {1,7:C1}", yearCFor, balanceCFor);
                }
            }
            #endregion
        }
    }
}
