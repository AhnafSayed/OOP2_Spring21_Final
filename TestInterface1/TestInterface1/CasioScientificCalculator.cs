using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface1
{
    class CasioScientificCalculator : CasioBasicCalculator, IScientificCalculatorInterface
    {
        public CasioScientificCalculator()
        {

        }
        public double X_Power_Y(double x, double y)
        {
            double pow = Math.Pow(x, y);
            Console.WriteLine("The power of {0} and {1} is {2}", x, y, pow);
            return pow;
        }
        public double sin(double intersection)
        {
            double s = Math.Sin(intersection);
            Console.WriteLine("The intersection of sin value {0} is {1}", intersection, s);
            return s;
        }


    }
}
