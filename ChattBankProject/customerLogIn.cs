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
    public partial class customerLogIn : Form
    {
        public customerLogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Customers c1;
        private void logInCButton_Click(object sender, EventArgs e)
        {
            string id = custIdTextBox.Text;
            string passw = passwTextbox.Text;
            c1 = new Customers();
            c1.Select(Int32.Parse(id));
            int dbc = c1.Cpassw;
            string dbcp = dbc + "";

            if (dbcp == passw)
            {
                customerForm cf = new customerForm(c1);
                cf.Show();
            }
            if (!(dbcp == passw))
            {
                MessageBox.Show("enter a valid id and password");
            }

           
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            custIdTextBox.Text = "";
            passwTextbox.Text = "";
;

        }
    }
}
