using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNDunit20
{
    class Savings : BankAccount
    {
        private double interestRate;

        public Savings(double rate, string accNum, string name) : base(accNum, name)
        {
            interestRate = rate;
        }

        public Savings(double rate, string name)
        {
            interestRate = rate;
            Name = name;
        }

        public double Rate
        {
            get
            {
                return interestRate;
            }
            set
            {
                interestRate = value;
            }
        }

        public override string identify()
        {
            return "Savings Account";
        }

        public new string displayStatement()
        {
            return "Savings Account for "  + Name + 
                "\nbalance: £" + String.Format("{0:0.##}", balance);
        }

    }
}
