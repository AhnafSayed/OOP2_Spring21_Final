using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestInterface2.Interface;

namespace TestInterface2
{
    abstract class Account : IBasicBankingInterface
    {
        public string AccName { get; set; }
        public string AccNo { get; set; }
        public int balance { get; set; }

        public Account(string accName, string accNo, int balance)
        {
            this.AccName = accName;
            this.AccNo = accNo;
            this.balance = balance;
        }

        public void showInfo()
        {
            Console.WriteLine("Account name: " + AccName);
            Console.WriteLine("Account no: " + AccNo);
            Console.WriteLine("Balance: " + balance);
        }

        public abstract void Deposit(int amount);
        public abstract void Withdraw(int amount);
    }
}
