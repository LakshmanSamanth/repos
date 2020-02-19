using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountApplication
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        Account a;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            a = new Account();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            txtId.Text = a.Id.ToString();
            txtName.Text = a.Name;
            txtBalance.Text = a.Balance.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtBalance.Text = "";
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            a.Id = int.Parse(txtId.Text);
            a.Name = txtName.Text;
            a.Balance = decimal.Parse(txtBalance.Text);
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            a = null;
        }

        private void btnGC_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            Account a1 = new Account();
            a = a1;
        }

        private void btnGetConection_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GC.GetGeneration(a).ToString());
        }

        
    }
}
