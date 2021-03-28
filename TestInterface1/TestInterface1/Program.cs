using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface1
{
    class Program
    {
        static void Main(string[] args)
        {
            CasioBasicCalculator b = new CasioBasicCalculator ();
            Console.WriteLine();
            Console.WriteLine("**********Casio Basic Calculator**********");
            b.sum(10, 20);
            b.sub(25, 10);
            b.multiplication(25, 4);
            b.division(100, 50);

            CasioScientificCalculator s = new CasioScientificCalculator();
            Console.WriteLine();
            Console.WriteLine("**********Casio Scientific Calculator**********");
            s.sin_value(526.34f);
            s.absolute(-500);
            s.X_Power_Y(4, 2);
        }
    }
}
