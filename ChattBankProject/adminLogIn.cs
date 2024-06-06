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
    public partial class adminLogIn : Form
    {
        public adminLogIn()
        {
            InitializeComponent();
        }

        //validate admin username and password
        private void button1_Click(object sender, EventArgs e)
        {
            
            string id = adIdTbox.Text;
            string pass = adPassTbox.Text;

            if (null == id || null == pass)
            {
                MessageBox.Show("Enter your username and password");
            }
            if (!(id == "admin" && pass == "123"))
            {
                MessageBox.Show("Invalid username and password");

            }

            if (id == "admin" && pass == "123")
            {
                adminAddDeleteAcct adsDel = new adminAddDeleteAcct();
                adsDel.Show();

            }
             
           
        }
        //clear text boxes
        private void clearB_Click(object sender, EventArgs e)
        {
            adIdTbox.Text = "";
            adPassTbox.Text = "";
        }

        //Close page
        private void exButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
