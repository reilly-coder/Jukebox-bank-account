using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNDunit20
{
    class BankAccount : IAccount
    {
        //fields
        private string accNum, name;
        protected double balance;
        private static string bankname = "ABC";

        //constructor
        public BankAccount(string accNum, string accName)
        {
            this.accNum = accNum;
            name = accName;
            balance = 0;
        }
        public BankAccount(string name)
        {
            this.name = name;
            balance = 0;
        }
        public BankAccount()
        {
            this.name = "No name assigned";
            balance = 0;
        }
        public static string Bankname
        {
            get
            {
                return bankname;
            }
            set
            {
                bankname = value;
            }
        }
        //auto-implemented property
        public string Addr { get; set; }

        //public read-only property
        public double Balance
        {
            get
            {
                return balance;
            }
        }

        //public property
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 0)
                {
                    name = value;
                }
            }
        }

        public string ID {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        //other methods
        public void deposit(double money)
        {
            balance = balance + money;
        }
        public bool withdraw(double money)
        {
            if (balance >= money)
            {
                balance = balance - money;
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual string displayStatement()
        {
            return "Acc: " + accNum + " "
            + name + "\nbalance: £" + balance.ToString();
        }
        //communicate with another object
        public void transfer(double money, BankAccount other)
        {
            if(this.withdraw(money))
            {
                other.deposit(money);
            }   
        }

        public void transfer(double money, Mobile mob1)
        {
            if (this.withdraw(money))
            {
                mob1.deposit(money);
            }
        }

        public void transfer(double money, IAccount acc)
        {
            if(withdraw(money))
            {
                acc.deposit(money);
            }
        }

        public override string ToString()
        {
            return String.Format("Name: {0} has balance £{1}", name, balance);
        }
        public virtual string identify()
        {
            return "Bank Account";
        }

    }
}
