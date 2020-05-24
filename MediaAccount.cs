using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNDunit20
{
    class MediaAccount
    {
        public BankAccount bankAccount { get; set; }

        public MediaService mediaService { get; set; }

        public LinkedList<string> UserSongs { get; set; }

        public MediaAccount()
        {
            bankAccount = new BankAccount(); //do whatever setup for the account here
            mediaService = new MediaService();
        }
    }
}
