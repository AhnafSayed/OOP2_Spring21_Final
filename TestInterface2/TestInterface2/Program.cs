using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Current("Rifat", "5678", 7860);
            Account acc2 = new Current("Abdul", "6654", 6890);
            Account acc3 = new Current("Jubaer", "6789", 5650);
            acc1.showInfo();
            acc3.showInfo();
            acc1.Deposit(6000);
            acc3.Deposit(5000);
            acc1.showInfo();
            acc3.showInfo();

        }
    }
}
