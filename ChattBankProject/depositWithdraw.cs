using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChattBankProject
{
    public partial class depositWithdraw : Form
    {
        Customers c1;


        public depositWithdraw()
        {
            InitializeComponent();
        }

        public depositWithdraw(Customers c)
        {
            c1 = c;
            InitializeComponent();
        }
        
    //deposit money to account
       private void depositButton_Click(object sender, EventArgs e)
        {
            Accounts ac = new Accounts();
            int tb = Int32.Parse(actTextBox.Text);
            ac.SelectAcctDB(tb);
            double amt;
            amt = double.Parse(depTextB.Text);
            ac.deposit(amt);
            ac.Update();
            labelBalance.Text = "Deposit successfull";


        }
    //withdraw  money from account
        private void withdrawButton_Click(object sender, EventArgs e)
        {
            Accounts ac = new Accounts();
            int tb = Int32.Parse(actTextBox.Text);
           // int tb = Int32.Parse(depTextB.Text);
            ac.SelectAcctDB(tb);
            double amt;
            amt = double.Parse(withdTextB.Text);
            ac.withdraw(amt);
            ac.Update();
            labelBalance.Text = "withdraw successfull";
        }
      
        private void viewButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            actTextBox.Text = "";
            labelBalance.Text = "";
            depTextB.Text = "";
            withdTextB.Text = "";

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // display account balace 
        private void button1_Click(object sender, EventArgs e)
        {
            
           
           
            
        }



    }


}
