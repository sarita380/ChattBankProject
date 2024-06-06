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
    public partial class createNewCustomer : Form
    {
        public Customers c1;
        public createNewCustomer()
        {
            InitializeComponent();
        }
        public createNewCustomer(Customers c)
        {
            c1 = c;
            InitializeComponent();
        }
        // insert a new customer 
        private void submitB_Click(object sender, EventArgs e)
        {
            Customers cut = new Customers();
            
            int ci = Int32.Parse(idTBox.Text);
            int ps = Int32.Parse(pTBox.Text);
            string nm = ntBox.Text;
            string ln = lntBox.Text;
            string ad = adTBox.Text;
            string em = emTBox.Text;
            cut.InsertCustDB(ci, ps, nm, ln, ad, em);

            MessageBox.Show("New customer inserted!!");
        }
        // clear text Boxes
        private void clearB_Click(object sender, EventArgs e)
        {
            idTBox.Text = "";
            pTBox.Text = "";
            ntBox.Text = "";
            lntBox.Text = "";
            adTBox.Text = "";
            emTBox.Text = "";

        }
        // Close window
        private void exitB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
