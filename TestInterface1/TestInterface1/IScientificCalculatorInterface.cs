using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterface1
{
    public interface IScientificCalculatorInterface
    {
        int XtoY(int x, int y);
        double division(double x, double y);
        int factorial(int x);
    }
    class ScientificCalculator : IScientificCalculatorInterface
    {
        double result;
        public double division(double number1, double number2)
        {
            Console.WriteLine("The dividend is : " + number1 + " and the divisor is: " + number2);
            if (number1 % number2 == 0)
            {
                result = number1 / number2;
                Console.WriteLine("The result is : " + result);
                return 0;
            }
            else
            {
                int a = Convert.ToInt32(number1 / number2);
                double b = number1 % number2;
                result = number1 / number2;
                Console.WriteLine("The result is: " + result);
                Console.WriteLine("The quotient is = " + a + "  and the remainder is = " + b);
                return 0;

            }
        }
        public int factorial(int number)
        {
            Console.WriteLine("The factorial number is: " + number);
            int fact = 1;
            for (int x = 1; x <= number; x++)
            {
                fact *= x;
            }
            int r = fact;
            Console.WriteLine("The result is: " + r);
            return 0;

        }
        public void SwapNum(ref int x, ref int y)
        {

            int tempswap = x;
            x = y;
            y = tempswap;
        }
        public int XtoY(int a, int b)
        {
            Console.WriteLine("The value of X and Y before swapping");
            

            Console.WriteLine("X=" + " " + a);
            Console.WriteLine("Y=" + " " + b);
            SwapNum(ref a, ref b);
            Console.WriteLine();
            Console.WriteLine("The value of X and Y after swapping");
            

            Console.WriteLine("X=" + " " + a);
            Console.WriteLine("Y=" + " " + b);
            Console.ReadLine();
            return 0;
        }
        public void printStates()
        {
            Console.WriteLine("The result is: " + result);
        }
    }
}
