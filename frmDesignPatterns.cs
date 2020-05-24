using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HNDunit20
{
    public partial class frmDesignPatterns : Form
    {
        public frmDesignPatterns()
        {
            InitializeComponent();
        }

        private void btnSingleton_Click(object sender, EventArgs e)
        {
            Singleton s1 = new Singleton();
            lblOutput.Text = s1.PrintDetails("Hello HND 201");
            lblOutput.Text += s1.PrintDetails("Nearly home time");
            Singleton s2 = new Singleton();
            lblOutput.Text += s2.PrintDetails("Hello from s2");
            
        }
    }
}
