using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface2.Interface
{
    interface IBasicBankingInterface
    {
        void Deposit(int amount);
        void Withdraw(int amount);
    }
}
