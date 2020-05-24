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
    public partial class frmBank : Form
    {
        BankAccount ba1 = new BankAccount("Fred", "fr123");
        BankAccount ba2 = new BankAccount("Rose", "ro456");
        Savings sa1 = new Savings(2.5, "Sally");
        Mobile mo1 = new Mobile("Moby", "234567");
        Gas ga1 = new Gas("Fred");

        public frmBank()
        {
            InitializeComponent();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            lblAcc1.Text = ba1.displayStatement();
            //lblAcc2.Text = ba2.displayStatement();
            lblAcc2.Text = sa1.displayStatement();
            lblMobile.Text = mo1.statement();
            lblGas.Text = ga1.statement();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Double money = Convert.ToDouble(txtMoney.Text);
            ba1.deposit(money);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Double money = Convert.ToDouble(txtMoney.Text);
            ba1.withdraw(money);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Double money = Convert.ToDouble(txtMoney.Text);
            //ba1.transfer(money, ba2);
            //ba1.transfer(money, sa1);
            ba1.transfer(money, mo1);
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            mo1.makeCall();
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            mo1.sendText();
        }

        private void btnCook_Click(object sender, EventArgs e)
        {
            ga1.cookDinner();
            lblGas.Text = "Just cooked tasty nosh";
        }

        private void btnTopUp_Click(object sender, EventArgs e)
        {
            Double money = Convert.ToDouble(txtMoney.Text);
            ba1.transfer(money, ga1);
        }
    }
}
