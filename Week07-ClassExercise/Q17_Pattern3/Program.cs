using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 7 - Class Exercise : DO WHILE, WHILE, FOR Loop
/// </summary>
namespace Q17_Pattern3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region A
            /*
             * Q17-A.
                         ******
                        ******
                       ******
                      ******
                     ******
                    ******
             */

            Console.WriteLine("[Question 17 - A : 1. DO-WHILE Loop]");

            int rowA = 0;

            do
            {
                int columnA = 0;

                do
                {
                    if((rowA + columnA <= 4) || (rowA + columnA >= 11))
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
            } while (rowA < 6);



            Console.WriteLine("\n\n[Question 17 - A : 2. WHILE Loop]");

            int rowAWhile = 0;

            while(rowAWhile < 6)
            {
                int columnAWhile = 0;

                while(columnAWhile < 11)
                {
                    if ((rowAWhile + columnAWhile <= 4) || (rowAWhile + columnAWhile >= 11))
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


            Console.WriteLine("\n\n[Question 17 - A : 3. FOR Loop]");

            for (int rowAFor = 0; rowAFor < 6; rowAFor++)
            {
                for(int columnAFor = 0; columnAFor < 11; columnAFor++)
                {
                    if ((rowAFor + columnAFor <= 4) || (rowAFor + columnAFor >= 11))
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
             * Q17-B.
                    ******
                     ******
                      ******
                       ******
                        ******
                         ******
             */

            Console.WriteLine("\n\n\n\n[Question 17 - B : 1. DO-WHILE Loop]");

            int rowB = 0;

            do
            {
                int columnB = 0;

                do
                {
                    if((rowB - columnB >= 1) || (columnB - rowB >= 6))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }

                    columnB++;
                } while (columnB < 11);

                Console.WriteLine();

                rowB++;
            } while (rowB < 6);


            Console.WriteLine("\n\n[Question 17 - B : 2. WHILE Loop]");

            int rowBWhile = 0;

            while(rowBWhile < 6)
            {
                int columnBWhile = 0;

                while(columnBWhile < 11)
                {
                    if ((rowBWhile - columnBWhile >= 1) || (columnBWhile - rowBWhile >= 6))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }

                    columnBWhile++;
                }

                Console.WriteLine();

                rowBWhile++;
            }


            Console.WriteLine("\n\n[Question 17 - B : 3. FOR Loop]");

            for(int rowBFor = 0; rowBFor < 6; rowBFor++)
            {
                for(int columnBFor = 0; columnBFor < 11; columnBFor++)
                {
                    if ((rowBFor - columnBFor >= 1) || (columnBFor - rowBFor >= 6))
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


            #region C
            /*
             * Q17-C.
                    -----*
                        ***
                       *****
                      *******
                     *********
                    ***********
             */

            Console.WriteLine("\n\n\n\n[Question 17 - C : 1. DO-WHILE Loop]");

            int rowC = 0;
            
            do
            {
                int columnC = 0;
            
                do
                {
                    if((rowC + columnC <= 4) || (columnC - rowC >= 6))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
            
                    columnC++;
                } while (columnC < 11);
            
                Console.WriteLine();
            
                rowC++;
            } while (rowC < 6);


            Console.WriteLine("\n\n[Question 17 - C : 2. WHILE Loop]");

            int rowCWhile = 0;

            while(rowCWhile < 6)
            {
                int columnCWhile = 0;

                while(columnCWhile < 11)
                {
                    if ((rowCWhile + columnCWhile <= 4) || (columnCWhile - rowCWhile >= 6))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }

                    columnCWhile++;
                }

                Console.WriteLine();

                rowCWhile++;
            }


            Console.WriteLine("\n\n[Question 17 - C : 3. FOR Loop]");

            for(int rowCFor = 0; rowCFor < 6; rowCFor++)
            {
                for(int columnCFor = 0; columnCFor < 11; columnCFor++)
                {
                    if ((rowCFor + columnCFor <= 4) || (columnCFor - rowCFor >= 6))
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
        }
    }
}
