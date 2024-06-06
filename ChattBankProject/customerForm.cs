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
    public partial class customerForm : Form
    {
       public  Customers c1;
       public Accounts act;
       
        public customerForm()
        {
            InitializeComponent();
        }
        //create a constructor with args
        public customerForm(Customers c)
        {
            c1 = c;
            InitializeComponent();
        }

       

        private void customerForm_Load(object sender, EventArgs e)
        {
            /*c1.displayCust();
            nameTbox.Text = c1.Cname + "";
            lastTbox.Text = c1.ClastN + "";
            addrTbox.Text = c1.Address + "";
            emailTbox.Text = c1.Email + "";*/
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            c1.displayCust();
            nameTbox.Text = c1.Cname + "";
            lastTbox.Text = c1.ClastN + "";
            addrTbox.Text = c1.Address + "";
            emailTbox.Text = c1.Email + "";
           
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string name = nameTbox.Text;
            c1.Cname = name;
            c1.UpdateCustDB();

            string last = lastTbox.Text;
            c1.ClastN = last;
            c1.UpdateCustDB();

            string address = addrTbox.Text;
            c1.Address = address;
            c1.UpdateCustDB();

            string email = emailTbox.Text;
            c1.Email = email;
            c1.UpdateCustDB();


        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            ChattBankForm chattB = new ChattBankForm();
            chattB.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accButton_Click(object sender, EventArgs e)
        {
            c1.displayCust();
            //string cust;
            Accounts act;
            int count;
            count = c1.alist.index;

            act = c1.alist.acclist.ElementAt(0);

            if (count >= 1)
            {
                    int cuact;
                    cuact = act.ActN;
                    label6.Text = cuact + "";

                    int cid;
                    cid = act.Cusid;
                    label8.Text = cid + "";

                    string tpe;
                    tpe = act.Typ;
                    label9.Text = tpe;

                    double blc;
                    blc = act.Balance;
                    label10.Text = blc + "";

            }
            if (count >= 2)
            {
                act = c1.alist.acclist.ElementAt(1);
                int cuact;
                cuact = act.ActN;
                label11.Text = cuact + "";

                int cid;
                cid = act.Cusid;
                label12.Text = cid + "";

                string tpe;
                tpe = act.Typ;
                label16.Text = tpe;

                double blc;
                blc = act.Balance;
                label17.Text = blc + "";

            }

            if (count >= 3)
            {
                act = c1.alist.acclist.ElementAt(2);
                int cuact;
                cuact = act.ActN;
                label18.Text = cuact + "";

                int cid;
                cid = act.Cusid;
                label19.Text = cid + "";

                string tpe;
                tpe = act.Typ;
                label20.Text = tpe;

                double blc;
                blc = act.Balance;
                label21.Text = blc + "";
            }

            if (count >= 4)
            {
                act = c1.alist.acclist.ElementAt(3);
                int cuact;
                cuact = act.ActN;
                label22.Text = cuact + "";

                int cid;
                cid = act.Cusid;
                label23.Text = cid + "";

                string tpe;
                tpe = act.Typ;
                label24.Text = tpe;

                double blc;
                blc = act.Balance;
                label25.Text = blc + "";
            }

            if (count >= 5)
            {
                act = c1.alist.acclist.ElementAt(4);
                int cuact;
                cuact = act.ActN;
                label26.Text = cuact + "";

                int cid;
                cid = act.Cusid;
                label27.Text = cid + "";

                string tpe;
                tpe = act.Typ;
                label28.Text = tpe;

                double blc;
                blc = act.Balance;
                label29.Text = blc + "";
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            createCustAccount custAct = new createCustAccount();
            custAct.Show();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            depositWithdraw depw = new depositWithdraw();
            depw.Show();
        }
    }
}
