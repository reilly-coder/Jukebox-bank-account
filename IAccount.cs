using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNDunit20
{
    interface IAccount
    {
        bool withdraw(double money);
        void deposit(double money);
        string ID { get; set; }
    }
}
