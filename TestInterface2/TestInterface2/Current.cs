using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestInterface2.Interface;

namespace TestInterface2
{
    class Current : Account, IBasicBankingInterface
    {
        public int amount { get; set; }
        public Current(string AccName, string AccNo, int balance) : base(AccName, AccNo, balance)
        {
        }

        public override void Deposit(int amount)
        {
            balance += amount;
        }

        public override void Withdraw(int amount)
        {
            if (amount < balance)
            {
                balance -= amount;
            }
        }
    }
}
