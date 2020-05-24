using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HNDunit20
{
    class ActualService : ServiceInterface
    {
        public void performOperation()
        {
            MessageBox.Show("Perform Actual Operation");
        }
    }
}
