using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNDunit20
{
    class Mobile
    {
        private string name, mobNum;
        private double balance;

        public Mobile(string name, string number)
        {
            this.name = name;
            this.mobNum = number;
            balance = 0;
        }

        public void makeCall()
        {
            balance = balance + 0.20;
        }

        public void sendText()
        {
            balance = balance + 0.10;
        }

        public void deposit(double money)
        {
            balance -= money;
        }

        public string statement()
        {
            return name + " with number " + mobNum + "\n"
                + "Balance £" + string.Format("{0:0.00}", balance); 
        }


    }
}
