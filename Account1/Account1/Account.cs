using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account1
{
    class Account
    {
        private string accId;
        private string accName;
        private int balance;

        public Account()
        {
        }

        public Account(string accId, string accName, int balance)
        {
            this.accId = accId;
            this.accName = accName;
            this.balance = balance;
        }
        public string AccId
        {
            get
            {
                return accId;
            }
            set
            {
                accId = value;
            }
        }
        public string AccName
        {
            get
            {
                return accName;
            }
            set
            {
                accName = value;
            }
        }
        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

    }

}