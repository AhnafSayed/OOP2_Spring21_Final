using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface1
{
    class Calculator
    {
        private string companyname;

        public string getcompanyName()
        {
            return companyname;
        }

        public string SetcompanyName()
        {
            this.companyname = companyname;
        }


        private string name;

        public string getName()
        {
            return name;
        }

        public string SetName()
        {
            this.name = name;
        }
    }
}
