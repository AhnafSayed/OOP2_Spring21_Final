using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account1
{
    class Transactions
    {
        private Account sender;
        private Account receiver;
        internal Account acc;

        public double Amount { get; set; }
        public string Additional { get; set; }
        public Account Acc { get; internal set; }

        public Transactions() { }

        public Transactions(Account sender, Account receiver, double amount, string additional)
        {
            this.sender = sender;
            this.receiver = receiver;
            Additional = additional;
            Amount = amount;
        }

        public void showAllTransactions()
        {
            Console.WriteLine("Transaction type: " + Additional);
            if (Additional.ToLower().Equals("transfer"))
            {
                Console.WriteLine("Sender: " + sender);
                Console.WriteLine("Receiver: " + receiver);
            }
            Console.WriteLine("Amount: " + Amount);
        }

        public void ShowInfo()
        {
            ShowInfo();
            acc.ShowInfo();
        }
    }
}
