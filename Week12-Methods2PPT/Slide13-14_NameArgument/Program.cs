using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 12 : METHODs PPT
/// </summary>
namespace Slide13_14_NameArgument
{
    class Program
    {
        public static double CalculateFees(int numberOfCourses, double cost = 549.99)
        {
            return numberOfCourses * cost;
        }

        static void Main(string[] args)
        {
            // All of ouput are same
            Console.WriteLine("Tuition fees {0:c} ", CalculateFees(5, 549.99));
            Console.WriteLine("Tuition fees {0:c} ", CalculateFees(numberOfCourses: 5, cost: 549.99));
            Console.WriteLine("Tuition fees {0:c} ", CalculateFees(cost: 549.99, numberOfCourses: 5));

            Console.WriteLine("Tuition fees {0:c} ", CalculateFees(5, 559.99)); // This output is different because of different input of cost
            Console.WriteLine("Tuition fees {0:c} ", CalculateFees(5));

        }
    }
}
