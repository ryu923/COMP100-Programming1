using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 12 : METHODs PPT
/// </summary>
namespace Addition1_Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            string value1 = "cat";

            SetString1(ref value1); // Is cat

            Console.WriteLine(value1); // dog


            string value2;

            SetString2(1, out value2);

            Console.WriteLine(value2); // dog
        }

        static void SetString1(ref string value)
        {
            if(value == "cat")
            {
                Console.WriteLine("Is cat");
            }
            value = "dog";
        }

        static void SetString2(int number, out string value)
        {
            if(number == 1)
            {
                value = "dog";
            }
            else
            {
                value = "carrot";
            }
        }
    }
}
