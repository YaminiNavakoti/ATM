using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    public partial class Account
    {
        private string c_name, c_addr, atm_option;
        public int balance;

        public string CustomerName
        {
            get { return c_name; }
            set { c_name = value; }
        }

        public string CustomerAddr
        {
            get { return c_addr; }
            set { c_addr = value; }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public string HasATMOption
        {
            get { return atm_option; }
            set { atm_option = value; }
        }
    }
}
