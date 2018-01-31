using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 7 - Class Exercise : DO WHILE, WHILE, FOR Loop
/// </summary>
namespace Q15_Pattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region A
            /*
             * Q15-A.
                        *
                         *
                          *
                           *
                            *
                             *
                              *
                               *
             */

            Console.WriteLine("[Question 15 - A : 1. DO-WHILE Loop]");

            int row = 0;

            do
            {
                int column = 0;

                do
                {
                    if(row == column)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                    column++;
                } while (column < 8);

                Console.WriteLine();

                row++;
            } while (row < 8);


            Console.WriteLine("\n[Question 15 - A : 2. WHILE Loop]");

            int rowAWhile = 0;

            while(rowAWhile < 8)
            {
                int columnAWhile = 0;

                while(columnAWhile < 8)
                {
                    if(rowAWhile == columnAWhile)
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


            Console.WriteLine("\n[Question 15 - A : 3. FOR Loop]");

            for(int rowAFor = 0; rowAFor <= 8; rowAFor++)
            {
                for(int columnAFor = 0; columnAFor < 8; columnAFor++)
                {
                    if (rowAFor == columnAFor)
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
             * Q15-B.
                               *
                              *
                             *
                            *
                           *
                          *
                         *
                        *
             */

            Console.WriteLine("\n\n\n\n[Question 15 - B : 1. DO-WHILE Loop]");

            int rowB = 0;

            do
            {
                int columnB = 0;

                do
                {
                    if(rowB + columnB == 7)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                    columnB++;
                } while (columnB < 8);

                Console.WriteLine();

                rowB++;
            } while (rowB < 8);


            Console.WriteLine("\n\n[Question 15 - B : 2. WHILE Loop]");

            int rowBWhile = 0;

            while(rowBWhile < 8)
            {
                int columnBWhile = 0;

                while(columnBWhile < 8)
                {
                    if (rowBWhile + columnBWhile == 7)
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

            Console.WriteLine("\n\n[Question 15 - B : 3. FOR Loop]");

            for(int rowBFor = 0; rowBFor < 8; rowBFor++)
            {
                for(int columnBFor = 0; columnBFor < 8; columnBFor++)
                {
                    if (rowBFor + columnBFor == 7)
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

            #region C
            /*
             * Q15-C.
                        *     *
                         *   *
                          * *
                           *
                          * *
                         *   *
                        *     *
             */

            Console.WriteLine("\n\n\n\n[Question 15 - C : 1. DO-WHILE Loop]");

            int rowC = 0;

            do
            {
                int columnC = 0;

                do
                {
                    if(rowC == columnC || rowC + columnC == 7)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                    columnC++;
                } while (columnC < 8);

                Console.WriteLine();

                rowC++;
            } while (rowC < 8);


            Console.WriteLine("\n\n[Question 15 - C : 2. WHILE Loop]");

            int rowCWhile = 0;

            while(rowCWhile < 8)
            {
                int columnCWhile = 0;

                while(columnCWhile < 8)
                {
                    if (rowCWhile == columnCWhile || rowCWhile + columnCWhile == 7)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                    columnCWhile++;
                }

                Console.WriteLine();

                rowCWhile++;
            }


            Console.WriteLine("\n\n[Question 15 - C : 3. For Loop]");

            for(int rowCFor = 0; rowCFor < 8; rowCFor++)
            {
                for(int columnCFor = 0; columnCFor < 8; columnCFor++)
                {
                    if (rowCFor == columnCFor || rowCFor + columnCFor == 7)
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

            #region D
            /*
             * Q15-D.
                        *******
                        *
                        *
                        *
                        *
                        *
                        *
             */

            Console.WriteLine("\n\n\n\n[Question 15 - D : 1. DO-WHILE Loop]");

            int rowD = 0;

            do
            {
                int columnD = 0;

                do
                {
                    if(rowD == 0 || columnD == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                    columnD++;
                } while (columnD < 7);

                Console.WriteLine();

                rowD++;
            } while (rowD < 7);


            Console.WriteLine("\n\n[Question 15 - D : 2. WHILE Loop]");
            int rowDWhile = 0;

            while(rowDWhile < 7)
            {
                int columnDWhile = 0;

                while(columnDWhile < 7)
                {
                    if (rowDWhile == 0 || columnDWhile == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                    columnDWhile++;
                }

                Console.WriteLine();

                rowDWhile++;
            }


            Console.WriteLine("\n\n[Question 15 - D : 3. FOR Loop]");

            for(int rowDFor = 0; rowDFor < 7; rowDFor++)
            {
                for(int columnDFor = 0; columnDFor < 7; columnDFor++)
                {
                    if (rowDFor == 0 || columnDFor == 0)
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


            #region E
            /*
             * Q15-E.
                        *******
                        *     *
                        *     *
                        *     *
                        *     *
                        *     *
                        *     *
                        *******
             */

            Console.WriteLine("\n\n\n[Question 15 - E: 1. DO-WHILE Loop]");

            int rowE = 0;
            
            do
            {
                int columnE = 0;
            
                do
                {
                    if(rowE == 0 || columnE == 0 || rowE == 7 || columnE == 6)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
            
                    columnE++;
                } while (columnE < 7);
            
                Console.WriteLine();
            
                rowE++;
            } while (rowE < 8);


            Console.WriteLine("\n\n[Question 15 - E: 2. WHILE Loop]");

            int rowEWhile = 0;

            while(rowEWhile < 8)
            {
                int columnEWhile = 0;

                while(columnEWhile < 7)
                {
                    if (rowEWhile == 0 || columnEWhile == 0 || rowEWhile == 7 || columnEWhile == 6)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                    columnEWhile++;
                }

                Console.WriteLine();

                rowEWhile++;
            }


            Console.WriteLine("\n\n[Question 15 - E: 3. FOR Loop]");

            for (int rowEFor = 0; rowEFor < 8; rowEFor++)
            {
                for (int columnEFor = 0; columnEFor < 7; columnEFor++)
                {
                    if (rowEFor == 0 || columnEFor == 0 || rowEFor == 7 || columnEFor == 6)
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