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


        Account receiver;
        private int amount;
        private string additionalInfo;

        public Transactions(Account sender01)
        {

        }

        public Transactions (int amount,string additionalInfo)
        {
            this.amount = amount;
            this.additionalInfo = additionalInfo;
        }

        public int Amount 
        { get; set; }

        public string AdditionalInfo
        { get; set; }

    }
}
