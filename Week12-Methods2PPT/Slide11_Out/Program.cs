using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Week 12 : METHODs PPT
/// </summary>
namespace Slide11_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 1, area, volumn;

            CalculateAreaAndVolumn(radius, out area, out volumn);

            Console.WriteLine("Radius: {0:F2}, area: {1:F2}, volumn: {2:F2}", radius, area, volumn);
        }

        public static void CalculateAreaAndVolumn(double rad, out double area, out double vol)
        {
            area = 4 * Math.PI * rad * rad;
            vol = 4 * Math.PI * rad * rad * rad / 3;
        }
    }
}
