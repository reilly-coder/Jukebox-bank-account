using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HNDunit20
{
    public partial class frmBehavioural : Form
    {
        SpindleStack myst = new SpindleStack();
        public frmBehavioural()
        {
            InitializeComponent();
        }

        private void btnCollection_Click(object sender, EventArgs e)
        {
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add(2);
            al.Add(3);
            al.Add(4);
            al.Add(5);

            string[] names = { "Fred", "Ted", "Zed", "Shed" };
            lblOutput.Text = "";

            IEnumerator ie = names.GetEnumerator();

            while(ie.MoveNext())
            {
                lblOutput.Text += ie.Current.ToString();
            }

        }

        private void btnPush_Click(object sender, EventArgs e)
        { 
            CDNode cd = new CDNode();
            cd.Artist = txtData.Text;
            cd.Duration = Convert.ToInt32(nudMinutes.Value);

            myst.push(cd);
        }

        private void btnIterate_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            //lblOutput.Text = myst.list();
            Iterator it = myst.createIterator();

            while(it.hasMore())
            {
                lblOutput.Text += it.getNext() + "\n";
            }

        }
    }
}
