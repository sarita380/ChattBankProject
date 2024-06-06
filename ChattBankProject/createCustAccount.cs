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
    public partial class createCustAccount : Form
    {
        public Customers c1;
        public Accounts act;
        public AccountList al;
       

        public createCustAccount()
        {
            InitializeComponent();
        }

        public createCustAccount(Accounts c)
        {
            act = c;
            InitializeComponent();
        }
       // method to create a new account
        private void button1_Click(object sender, EventArgs e)
        {
            Accounts ac1 = new Accounts();
            
            int act;
            //insert Account no
            act = Int32.Parse(acctTextB.Text);
            //insert cid
            int cd = Int32.Parse(idTextB.Text);
            //insert type
            string tp = typeTextbox.Text; 
            //insert balance
            double b = double.Parse(amtTextB.Text);
            ac1.Insert(act,cd,tp,b);
            //c1.alist.AddAct(ac1);

            //Display Account
            ac1.displayAccount();
            outlabel.Text = "new account is created";        
    }

        private void button2_Click(object sender, EventArgs e)
        {
            acctTextB.Text = "";
            idTextB.Text = "";
            typeTextbox.Text = "";
            amtTextB.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
