using System;


namespace TestInterface1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_____Calculator Interfaces_____");
            Console.WriteLine();
            Console.WriteLine("**********Basic Calculator Interface**********");
            Console.WriteLine();
            BasicCalculator b = new BasicCalculator();
            Console.WriteLine("_____The summation result is_____");
            b.sum(100, 50);
            b.printStates();


            Console.WriteLine();
            Console.WriteLine("_____The subtraction result is_____");
            b.sub(25, 10);
            b.printStates();


            Console.WriteLine();
            Console.WriteLine("_____The multiplication result is_____");
            b.multiplication(200, 2);
            b.printStates();


            Console.WriteLine();
            Console.WriteLine("_____The division result is_____");
            b.division(500, 2);
            b.printStates();



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**********Scientific Calculator Interface**********");
            Console.WriteLine();
            ScientificCalculator s = new ScientificCalculator();
            
            
            Console.WriteLine();
            Console.WriteLine("_____The division result is_____");
            Console.WriteLine();
            s.division(27, 7);


            Console.WriteLine();
            Console.WriteLine("_____The factorial result is_____");
            Console.WriteLine();
            s.factorial(10);

           
            Console.WriteLine();
            Console.WriteLine("_____The X to Y result is_____");
            Console.WriteLine();
            s.XtoY(300, 700);

        }
    }
}
