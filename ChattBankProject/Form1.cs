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
    public partial class ChattBankForm : Form
    {
        public ChattBankForm()
        {
            InitializeComponent();
        }

        private void testCustButton_Click(object sender, EventArgs e)
        {
            Customers c1 = new Customers();
            c1.Select(3007);
            c1.displayCust();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customers ins = new Customers();
            ins.InsertCustDB(3007, 1478, "Loren", "Aliaga", "Per", "lore@gmail.com");
            ins.displayCust();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customers upd = new Customers();
            upd.Select(3007);
            upd.Address = "Texas";
            upd.UpdateCustDB();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Customers del = new Customers();
            del.Select(3007);
            del.CustDeleteDB();
                
        }

        private void testAcctbButton_Click(object sender, EventArgs e)
        {
            Accounts ac = new Accounts();
            ac.SelectAcctDB(90009);
            ac.displayAccount();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Accounts ac = new Accounts();
            ac.Insert(90012, 3007, "PSY", 70000);
            ac.displayAccount();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Accounts act = new Accounts();
            act.SelectAcctDB(90012);
            act.Typ = "MMA";
            act.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //show the customer log in oage
            customerLogIn clog = new customerLogIn();
            clog.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //show the admin log in page
            adminLogIn alog = new adminLogIn();
            alog.Show();

            
        }

        private void ExButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //delete account
            Accounts del = new Accounts();
            del.SelectAcctDB(90012);
            del.DeleteAcctDB();
        }
    }
}
 