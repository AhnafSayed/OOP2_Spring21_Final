using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account1
{
    class Program
    {
        static void Main(string[]args)
        {
            Account sender01 = new Account("Rafat Ahsan", "678987654", 6455.89f);
            Account receiver01 = new Account("Ashraf Uddin", "778976542", 4656.78f);
            Account receiver02 = new Account("Arafat Arif", "867543218", 5678.56f);

            Transactions t1 = new Transactions(sender01, receiver01, 250, "Mobile Recharge");
            Transactions t2 = new Transactions(sender01, receiver02, 500, "Bill Pay");
            Transactions t3 = new Transactions(sender01, receiver02, 700, "Recharge Balance");

            sender01.AddTransaction(t1, t2, t3);
            sender01.showAllTransaction();
            sender01.ShowInfo();
            sender01.Withdraw(550);
            sender01.Transfer(receiver02, 850);

        
        }
    }
}
