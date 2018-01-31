using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 12 : METHODs PPT
/// </summary>
namespace Slide10_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int var_a = 5;

            Console.WriteLine("Before method call {0}", var_a); // 5

            Twice(ref var_a); // 10

            Console.WriteLine("After method call {0}", var_a); // 10
        }

        public static void Twice(ref int a)
        {
            a *= 2;

            Console.WriteLine("In method call {0}", a);
        }
    }
}
