using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition2_Ref_Out
{
    class Program
    {
        public static void RefSample(double a, double b, ref double c)
        {
            c = a + b;

            Console.WriteLine("The sum of {0} and {1} is {2}", a, b, c);
        }

        public static void OutSample(double a, double b, out double c)
        {
            c = a + b;

            Console.WriteLine("The sum of {0} and {1} is {2}", a, b, c);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n[1. REF Sample]");
            // When the [ref] is used, variable c should be assigned!!! Value c will be changed after method.
            double c = 0;
            RefSample(1, 2, ref c);

            Console.WriteLine("\n[2. OUT Sample]");
            // When the [out] is used, do not need to assign to variable c!!! 
            double c2;
            OutSample(1, 2, out c2);
        }
    }
}
