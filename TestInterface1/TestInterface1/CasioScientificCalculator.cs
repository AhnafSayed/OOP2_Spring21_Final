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

        public int absolute(int x)
        {
            int a = Math.Abs(x);
            Console.WriteLine("The Absolute value of {0} is {1}", x, a);
            return a;
        }

        public double sin_value(double angle)
        {
            double s = Math.Sin(angle);
            Console.WriteLine("The sin value of angle  {0} is {1}", angle, s);
            return s;
        }

        public double X_Power_Y(double x, double y)
        {
            double pow = Math.Pow(x, y);
            Console.WriteLine("The result of {0}^{1} is {2}", x, y, pow);
            return pow;
        }
    }
}
