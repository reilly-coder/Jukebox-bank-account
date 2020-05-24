using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNDunit20
{
    class Gas : IAccount
    {
        private string name, addr;
        private double cost;

        public string ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Gas(string name)
        {
            this.name = name;
            cost = 0;
            addr = "Millfield campus";
        }

        public string statement()
        {
            return name + " gas account \n"
                + "Cost owed £" + string.Format("{0:0.00}", cost);
        }

        public void cookDinner()
        {
            cost = cost + 1;
        }

        public bool withdraw(double money)
        {
            throw new NotImplementedException();
        }

        public void deposit(double money)
        {
            cost = cost - money;
        }
    }
}
