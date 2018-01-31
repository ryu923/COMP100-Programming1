using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/// <summary>
/// Week 6 - Class Exercise : DO WHILE Loop - CONTINUE Practice
/// </summary>
namespace Practice_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            Random random = new Random();

            do
            {
                int value = random.Next(1,100);

                if((value % 2) == 0)
                {
                    Console.WriteLine("Divisible by 2: {0}", value);
                    continue;
                }
                
                if((value % 3) == 0)
                {
                    Console.WriteLine("Divisible by 3: {0}", value);
                    continue;
                }

                Console.WriteLine("Not divisible by 2 or 3: {0}", value);

                i++;
            } while (i < 10);
        }
    }
}
