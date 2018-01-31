using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 7 - Class Exercise : DO WHILE, WHILE, FOR Loop
/// </summary>
namespace Q16_Pattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region A
            /*
             * Q16-A.
                              *
                             **
                            ***
                           ****
                          *****
                         ******
                        *******
                       ********
             */

            Console.WriteLine("[Question 16 - A : 1. DO-WHILE Loop]");

            int rowA = 0;

            do
            {
                int columnA = 0;

                do
                {
                    if (rowA + columnA > 6)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                    columnA++;
                } while (columnA < 8);

                Console.WriteLine();

                rowA++;
            } while (rowA < 8);


            Console.WriteLine("\n\n[Question 16 - A : 2. WHILE Loop]");

            int rowAWhile = 0;

            while (rowAWhile < 8)
            {
                int columnAWhile = 0;

                while (columnAWhile < 8)
                {
                    if (rowAWhile + columnAWhile > 6)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                    columnAWhile++;
                }

                Console.WriteLine();

                rowAWhile++;
            }

            Console.WriteLine("\n\n[Question 16 - A : 3. FOR Loop]");

            for (int rowAFor = 0; rowAFor < 8; rowAFor++)
            {
                for (int columnAFor = 0; columnAFor < 8; columnAFor++)
                {
                    if (rowAFor + columnAFor > 6)
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


            #region B
            /*
             * Q16-B.
                        *
                        **
                        ***
                        ****
                        *****
                        ******
             */

            Console.WriteLine("\n\n\n\n[Question 16 - B : 1. DO-WHILE Loop]");

            int rowB = 0;

            do
            {
                int columnB = 0;

                do
                {
                    if (rowB - columnB >= 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                    columnB++;
                } while (columnB < 6);

                Console.WriteLine();

                rowB++;
            } while (rowB < 6);


            Console.WriteLine("\n\n[Question 16 - B : 2. WHILE Loop]");

            int rowBWhile = 0;

            while (rowBWhile < 6)
            {
                int columnBWhile = 0;

                while(columnBWhile < 6)
                {
                    if (rowBWhile - columnBWhile >= 0)
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


            Console.WriteLine("\n\n[Question 16 - B : 3. FOR Loop]");

            for(int rowBFor = 0; rowBFor < 6; rowBFor++)
            {
                for(int columnBFor = 0; columnBFor < 6; columnBFor++)
                {
                    if (rowBFor - columnBFor >= 0)
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
