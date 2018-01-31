using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 8 : METHODS PPT
/// </summary>
namespace Slide17_Exercise4
{
    class Program
    {
        public static double CalculateVolumeOfCube(double length, double width, double height)
        {
            double volumn = length * width * height;

            return volumn;
        }

        public static double CalculateVolumeOfCube2()
        {
            Console.Write("\n\nEnter length of cube: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter width of cube: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height of cube: ");
            double height = Convert.ToDouble(Console.ReadLine());

            return length * width * height;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Volume of cube 1: {0}", CalculateVolumeOfCube(5.0, 3.0, 2));

            Console.WriteLine("Volume of cube 2: {0}", CalculateVolumeOfCube2());
        }
    }
}
