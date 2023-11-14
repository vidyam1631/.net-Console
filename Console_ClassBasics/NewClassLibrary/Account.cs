using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewClassLibrary
{
    public class Account
    {
        private int accNo;
        private string holderName;
        private int balance;

        public int AccNo
        {
            get { return accNo; }
            set { accNo = value; }
        }
        public string HolderName
        {
            get { return holderName; }
            set { holderName = value; }
        }
        public int Balance
        {
            get { return balance; }
            set
            {
                if (value >= 5000)
                    balance = value;
                else balance = 0;
            }
        }

    }
}
