using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterface1
{
    public interface IBasicCalculatorInterface
    {
        int sum(int x, int y);
        int sub(int x, int y);
        int multiplication(int x, int y);
        int division(int x, int y);
    }
    class BasicCalculator : IBasicCalculatorInterface
    {
        int result;
        public int sum(int number1, int number2)
        {
            Console.WriteLine("The summation : " + number1 + " with : " + number2);
            result = number1 + number2;
            return result;
        }
        public int sub(int number1, int number2)
        {
            Console.WriteLine("The subtraction : " + number1 + " by : " + number2);
            result = number1 - number2;
            return result;
        }
        public int multiplication(int number1, int number2)
        {
            Console.WriteLine("The multiplication : " + number1 + " with : " + number2);
            result = number1 * number2;
            return result;
        }
        public int division(int number1, int number2)
        {
            Console.WriteLine("The dividend is: " + number1 + " and the divisor is: " + number2);
            result = number1 / number2;
            return result;
        }
        public void printStates()
        {
            Console.WriteLine("The result is : " + result);
        }
    }
}
