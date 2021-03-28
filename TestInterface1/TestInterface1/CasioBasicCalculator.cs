using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface1
{
    class CasioBasicCalculator : IBasicCalculatorInterface
    {

        public CasioBasicCalculator()
        {

        }
        public int sum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("The addition of {0} and {1} is :{2}", x, y, sum);
            return sum;
        }

        public int sub(int x, int y)
        {
            int sub = x - y;
            Console.WriteLine("The subtraction of {0} and {1} is :{2}", x, y, sub);
            return sub;
        }

        public int multiplication(int x, int y)
        {
            int mul = x * y;
            Console.WriteLine("The multiplication of {0} and {1} is :{2}", x, y, mul);
            return mul;
        }

        public double division(int x, int y)
        {
            double div = x / y;
            Console.WriteLine("The division of {0} and {1} is :{2}", x, y, div);
            return div;
        }
    }
}
