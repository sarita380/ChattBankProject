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
    public partial class adminAddDeleteAcct : Form
    {
        public Customers c1;
        public adminAddDeleteAcct()
        {
            InitializeComponent();
        }

        public adminAddDeleteAcct(Customers c)
        {
            c1 = c;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //Display Customers 
        private void viewB_Click(object sender, EventArgs e)
        {
            int i;
            i = Int32.Parse(textBox1.Text);
            Customers c1 = new Customers();
            c1.Select(i);
            c1.displayCust();
            
            textBox2.Text = c1.Custid + "";
            textBox3.Text = c1.Cname+"";
            textBox4.Text = c1.ClastN + "";
            textBox5.Text = c1.Address + "";
            textBox6.Text = c1.Email + "";



        }
        //addaccount
        private void addButton_Click(object sender, EventArgs e)
        {
            createNewCustomer nca = new createNewCustomer();
            nca.Show();
        }
    //delete account
        private void deleteButton_Click(object sender, EventArgs e)
        {
            Customers dcust = new Customers();
            int ci = Int32.Parse(deleteTBox.Text);
            dcust.Select(ci);
            dcust.CustDeleteDB();
            MessageBox.Show("deleted successfull");

        }
        //clear text Box
        private void clearB_Click(object sender, EventArgs e)
        {
            deleteTBox.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

          
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
