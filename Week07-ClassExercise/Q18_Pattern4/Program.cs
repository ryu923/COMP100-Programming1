using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 7 - Class Exercise : DO WHILE, WHILE, FOR Loop
/// </summary>
namespace Q18_Pattern4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region A
            /*
             * Q18-A.
                         *
                        ***
                       *****
                      *******
                     *********
                    ***********
                     *********
                      *******
                       *****
                        ***
                         *
             */

            Console.WriteLine("[Question 18 - A : 1. DO-WHILE Loop]");

            int rowA = 0;

            do
            {
                int columnA = 0;

                do
                {
                    if((rowA + columnA <= 4) || (columnA - rowA >= 6) || (rowA - columnA >= 6) || (rowA + columnA >= 16))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }

                    columnA++;
                } while (columnA < 11);

                Console.WriteLine();

                rowA++;
            } while (rowA < 11);


            Console.WriteLine("\n\n[Question 18 - A : 2. WHILE Loop]");

            int rowAWhile = 0;

            while(rowAWhile < 11)
            {
                int columnAWhile = 0;

                while(columnAWhile < 11)
                {
                    if ((rowAWhile + columnAWhile <= 4) || (columnAWhile - rowAWhile >= 6) || (rowAWhile - columnAWhile >= 6) || (rowAWhile + columnAWhile >= 16))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }

                    columnAWhile++;
                }

                Console.WriteLine();

                rowAWhile++;
            }

            Console.WriteLine("\n\n[Question 18 - A : 3. FOR Loop]");

            for(int rowAFor = 0; rowAFor < 11; rowAFor++)
            {
                for(int columnAFor = 0; columnAFor < 11; columnAFor++)
                {
                    if ((rowAFor + columnAFor <= 4) || (columnAFor - rowAFor >= 6) || (rowAFor - columnAFor >= 6) || (rowAFor + columnAFor >= 16))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }

                Console.WriteLine();
            }

            #endregion


            #region B
            /*
             * Q18-B.
                         *
                        * *
                       *   *
                      *     *
                     *       *
                    ***********
             */

            Console.WriteLine("\n\n\n\n[Question 18 - B : 1. DO-WHILE Loop]");

            int rowB = 0;

            do
            {
                int columnB = 0;

                do
                {
                    if((rowB + columnB == 5) || (columnB - rowB == 5) || (rowB == 5))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                    columnB++;
                } while (columnB < 11);

                Console.WriteLine();

                rowB++;
            } while (rowB < 6);


            Console.WriteLine("\n\n[Question 18 - B : 2. WHILE Loop]");

            int rowBWhile = 0;

            while(rowBWhile < 6)
            {
                int columnBWhile = 0;

                while(columnBWhile < 11)
                {
                    if ((rowBWhile + columnBWhile == 5) || (columnBWhile - rowBWhile == 5) || (rowBWhile == 5))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                    columnBWhile++;
                }

                Console.WriteLine();

                rowBWhile++;
            }


            Console.WriteLine("\n\n[Question 18 - B : 3. FOR Loop]");

            for(int rowBFor = 0; rowBFor < 6; rowBFor++)
            {
                for(int columnBFor = 0; columnBFor < 11; columnBFor++)
                {
                    if ((rowBFor + columnBFor == 5) || (columnBFor - rowBFor == 5) || (rowBFor == 5))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
            #endregion
        }
    }
}
