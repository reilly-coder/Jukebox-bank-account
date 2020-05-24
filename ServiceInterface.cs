using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNDunit20
{
    interface ServiceInterface
    {
        double SongPrice { get; }

        IList<string> Songs { get; }

        void ListAll();

        string Purchase(MediaAccount account, string songToPurchase);
    }
}
