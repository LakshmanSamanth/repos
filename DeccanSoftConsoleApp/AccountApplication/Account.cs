using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountApplication
{
    class Account
    {

        public int Id;
        public String Name;
        public Decimal Balance;
        public Account()
        {
            MessageBox.Show("Object Created");
        }
        ~Account()
        {
            MessageBox.Show("Object Destroyed");
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (this.Balance - amount < 500)
                throw new ApplicationException("Insufficient Balance");
            else
                this.Balance -= amount;
        }

    }
}
