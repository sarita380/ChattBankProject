/*********************************************************************
 *                  Sara Aliaga 
 *                 CIST 2342 C# II
 *                  Programming
 *                Teacher Ronal Enz  
 *                  Final Project
 ***********************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattBankProject
{
    public class Customers
    {
        //Declare properties
        private int _cusId;
        private int _cpssw;
        private string _cname;
        private string  _clastn;
        private string _addr;
        private string _email;
        public AccountList alist = new AccountList();

        //create a default constructor
        public Customers()
        {
          _cusId = 0;
          _cpssw = 0;
          _cname = "";
          _clastn = "";
          _addr = "";
          _email = "";
        }
        //Create a constructor with arguments
        public Customers(int cid, int cpsw, string name, string lname, string add, string em )
        {
            _cusId = cid;
            _cpssw = cpsw;
            _cname = name;
            _clastn = lname;
            _addr = add;
            _email = em;
        }

        //Build Setters and getters 

        public int Custid
        {
            get { return _cusId; }
            set { _cusId = value; }
        }

        public int Cpassw
        {
            get { return _cpssw; }
            set { _cpssw = value; }
        }

        public string Cname
        {
            get { return _cname; }
            set { _cname = value; }
        }

        public string ClastN
        {
            get { return _clastn; }
            set { _clastn = value; }
        }

        public string Address
        {
            get { return _addr; }
            set { _addr = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        //===============Behaviors==========================
        //************Data base Elements********************

        public System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter2;
		public System.Data.OleDb.OleDbCommand OleDbSelectCommand2;
		public System.Data.OleDb.OleDbCommand OleDbInsertCommand2;
		public System.Data.OleDb.OleDbCommand OleDbUpdateCommand2;
		public System.Data.OleDb.OleDbCommand OleDbDeleteCommand2;
		public System.Data.OleDb.OleDbConnection OleDbConnection2;
		public string cmd;
	 
		public void DBSetup(){
		// +++++++++++++++++++++++++++  DBSetup function +++++++++++++++++++++++++++
		// This DBSetup() method instantiates all the DB objects needed to access a DB, 
		// including OleDbDataAdapter, which contains 4 other objects(OlsDbSelectCommand, 
		// oleDbInsertCommand, oleDbUpdateCommand, oleDbDeleteCommand.) And each
		// Command object contains a Connection object and an SQL string object.
			OleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
			OleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			OleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
			OleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
			OleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
			OleDbConnection2 = new System.Data.OleDb.OleDbConnection();
																									
			
			OleDbDataAdapter2.DeleteCommand = OleDbDeleteCommand2;
			OleDbDataAdapter2.InsertCommand = OleDbInsertCommand2;
			OleDbDataAdapter2.SelectCommand = OleDbSelectCommand2;
			OleDbDataAdapter2.UpdateCommand = OleDbUpdateCommand2;

// The highlighted text below should be changed to the location of your own database
            
            OleDbConnection2.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Reg"+
            "istry Path=;Jet OLEDB:Database L" + 
            "ocking Mode=1;Data Source=c:\\Users\\Sara\\Documents\\ChattBankMDB.mdb;J" + 
            "et OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System datab" + 
            "ase=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=S" + 
            "hare Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet " + 
            "OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repai" + 
            "r=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1";

		}  //end DBSetup

        //****************************Select******************************************************
        public void Select(int id)
        {
            DBSetup();
            cmd = "Select * from Customers where CustID = '" + id +"'";
            Custid = id;
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();
                dr.Read();

                Custid = Int32.Parse(dr.GetValue(0) + "");
                Cpassw = Int32.Parse(dr.GetValue(1) + "");
                Cname = dr.GetValue(2) + "";
                ClastN = dr.GetValue(3) + "";
                Address = dr.GetValue(4) + "";
                Email = dr.GetValue(5) + "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection2.Close();
            }

            fillaccount();
        } //end Select

        //*******************Insert*************

        public void InsertCustDB(int id, int psw, string name, string lastn, string addrs, string ema)
        {
            Custid = id;
            Cpassw = psw;
            Cname = name;
            ClastN = lastn;
            Address = addrs;
            Email = ema;
            DBSetup();
            cmd = "Insert into Customers values (" + id + "," +
                                                  "" + psw + "," +
                                                  "'" + name + "'," +
                                                  "'" + lastn + "'," +
                                                  "'" + addrs + "'," +
                                                  "'" + ema + "')";

            OleDbDataAdapter2.InsertCommand.CommandText = cmd;
            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
				int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();
				if (n==1)
					Console.WriteLine("Data Inserted");
				else
					Console.WriteLine("ERROR: Inserting Data");
			}
			catch (Exception ex) 
			{
				Console.WriteLine(ex);
			}
			finally 
			{
				OleDbConnection2.Close();
			}
        } //end Insert

        //*********************Update*************************

        public void UpdateCustDB()
        {

            cmd = "Update Customers set CustPassword = '" + Cpassw + "'," +
                "CustFirstName = '" + Cname + "'," +
                "CustLastName = '" + ClastN + "'," +
                "CustAddress = '" + Address + "'," +
                "CustEmail = '" + Email + "'" +
                " where CustID = '" + Custid + "'";

            OleDbDataAdapter2.UpdateCommand.CommandText = cmd;
			OleDbDataAdapter2.UpdateCommand.Connection = OleDbConnection2;
			Console.WriteLine(cmd);
			try  
			{
				OleDbConnection2.Open();
				int n = OleDbDataAdapter2.UpdateCommand.ExecuteNonQuery();
				if (n==1)
					Console.WriteLine("Data Updated");
				else
					Console.WriteLine("ERROR: Updating Data");
			}
			catch (Exception ex) 
			{
				Console.WriteLine(ex);
			}
			finally 
			{
				OleDbConnection2.Close();
			}				 	 
		} //end UpdateDB()

        //*******************************Delete**********************

        public void CustDeleteDB()
        {
            cmd = "Delete from Customers where CustID = '" + Custid+"'";

            OleDbDataAdapter2.DeleteCommand.CommandText = cmd;
            OleDbDataAdapter2.DeleteCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.DeleteCommand.ExecuteNonQuery();
                if (n == 1)
                    Console.WriteLine("Data Deleted");
                else
                    Console.WriteLine("ERROR: Deleting Data");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection2.Close();
            }

        }//End delete  


        //**********************fill account***********************************************

        public void fillaccount()
        {
            Console.WriteLine(" FillAccount:entering fillAccount ");
            cmd = "Select AcctNo from Accounts where Cid =  '" + Custid + "'";

            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
            Console.WriteLine(" FillAccount:SQL in FillAccount = ");
            Console.WriteLine(cmd);

            try
            {
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();
                //dr.Read();
                int act;
                Accounts al1;
                Console.WriteLine(" FillAccount:before while loop ");
                while (dr.Read())
                {
                    Console.WriteLine("FillAccount:testing account");
                    //dr.GetValue(0);
                    act = Int32.Parse(dr.GetValue(0) + ""); 
                    Console.WriteLine(" FillAccounts: act = "+act);

                    al1 = new Accounts();
                    al1.SelectAcctDB(act);
                    alist.AddAct(al1);

                    
                    
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection2.Close();
            }


        }

        //************************* addAcount*********************************** 

        public void AddAct(Accounts ac)
        {
            alist.AddAct(ac);
          /*  cmd = "Insert into Accounts values ("+ Custid+ ", '"+ ac.ActN +"', '"+ ac.Cusid +"',"+ ac.Typ +",'"+ ac.Balance +"')";
            OleDbDataAdapter2.InsertCommand.CommandText = cmd;
            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);

            try
               {
                   OleDbConnection2.Open();
                   int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();
                   if (n == 1)
                       Console.WriteLine("adding account successfully");
                   else
                       Console.WriteLine("ERROR ");
               }
               catch (Exception ex)
               {
                   Console.WriteLine(ex);
               }
               finally
               {
                   OleDbConnection2.Close();
               }*/
           } //end add Account method

        
           
         //**************************Display Customer********************

        public void displayCust()
        {
            Console.WriteLine(Custid);
            Console.WriteLine(Cpassw);
            Console.WriteLine(Cname);
            Console.WriteLine(ClastN);
            Console.WriteLine(Address);
            Console.WriteLine(Email);
            alist.displayAcctList();

        }

    }
}
