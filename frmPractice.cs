using System;
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
    public partial class frmPractice : Form
    {
        ArrayList al = new ArrayList();
        
        public frmPractice()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Student temp = new Student(txtName.Text);
            al.Add(temp);
            txtName.Text="";
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            lblOutput.Text = ""; //Student.getCount();

            foreach(object obj in al)
            {
                if(obj != null)
                {
                    Student temp = (Student)obj;
                    lblOutput.Text += temp.Name + "\n";
                }
                else
                {
                    lblOutput.Text += "null\n";
                }

            }

            lblOutput.Text += "Student objects:" +  Student.getCount() + "\n";
            lblOutput.Text += "ArrayList  objects:" + al.Count.ToString() + "\n";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(nudIndex.Value);
            al[index] = null;
        }
    }
}
