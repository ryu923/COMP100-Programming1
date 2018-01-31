using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///  Week 13 - Class Exercise: FOREACH
/// </summary>
namespace FOREACH
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 1, 3, 4, 0, 9 };

            // FOR Loop
            Console.WriteLine("[FOR Loop]");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0}, ", numbers[i]);
            }


            // FOREACH
            Console.WriteLine("\n\n[FOREACH]");

            foreach (int x in numbers)
            {
                Console.Write("{0}, ", x);
            }

            // FORLoop output & FOREACH output is Same !!!
        }
    }
}
