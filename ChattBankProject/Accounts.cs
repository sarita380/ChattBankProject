using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattBankProject
{
   public class Accounts
    {
        //*************Declare Properties******************
        private int _acctN;
        private int  _ctId;
        private string _type;
        private double _balance;
        public AccountList alist = new AccountList();

        //************* Default constructor****************

        public Accounts()
        {
            _acctN = 0;
            _ctId = 0;
            _type = "";
            _balance = 0.0;
        }
        public Accounts(int actn, int cid, string ty, int blc)
        {
            _acctN = actn;
            _ctId = cid;
            _type = ty;
            _balance = blc;
        }

        //*********************Setters and getters*******************

        public int ActN
        {
            get { return _acctN; }
            set { _acctN = value; }
        }

        public int Cusid {
            get{ return _ctId; }
            set { _ctId = value; }
        }
        public string Typ
        {
            get { return _type; }
            set { _type = value; }
        }

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        //************************Behaviors**************

        //************Data base Elements********************

        public System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter2;
        public System.Data.OleDb.OleDbCommand OleDbSelectCommand2;
        public System.Data.OleDb.OleDbCommand OleDbInsertCommand2;
        public System.Data.OleDb.OleDbCommand OleDbUpdateCommand2;
        public System.Data.OleDb.OleDbCommand OleDbDeleteCommand2;
        public System.Data.OleDb.OleDbConnection OleDbConnection2;
        public string cmd;

        public void DBSetup()
        {
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

            OleDbConnection2.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Reg" +
            "istry Path=;Jet OLEDB:Database L" +
            "ocking Mode=1;Data Source=c:\\Users\\Sara\\Documents\\ChattBankMDB.mdb;J" +
            "et OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System datab" +
            "ase=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=S" +
            "hare Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet " +
            "OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repai" +
            "r=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1";

        }  //end DBSetup

        //***************************Select account**************************

        public void SelectAcctDB(int acn)
        {
            DBSetup();
            cmd = "Select * from Accounts where AcctNo = '" + acn + "'";
            ActN = acn;
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                dr.Read();
                ActN = Int32.Parse(dr.GetValue(0) + "");
                Cusid = Int32.Parse(dr.GetValue(1) + "");
                Typ = dr.GetValue(2) + "";
                Balance = Double.Parse(dr.GetValue(3) + "");
    
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection2.Close();
            }
            
        } //end SelectDB()

        //***************************Create Insert************************

        public void Insert(int acn, int cd, string tp, double bl)
        {
            ActN = acn;
            Cusid = cd;
            Typ = tp;
            Balance = bl;
            DBSetup();
            cmd = "Insert into Accounts values (" + acn + "," +
                                                "" + cd + "," +
                                                "'" + tp + "'," +
                                                "" + bl + ")";
            OleDbDataAdapter2.InsertCommand.CommandText = cmd;
            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();
                if (n == 1)
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
        } //end InsertDB()

        //*******************************Update***********************

        public void Update()
        {
            DBSetup();
           /* cmd = "Update Accounts set Cid = '" + Cusid + "'," +
                                       " Type = '" + Typ + "'," +
                                       " Balance = " + Balance + " " +
                                       " Where AcctNo = '" + ActN + "'";*/

            cmd = "Update Accounts set AcctNo = '" + ActN + "',"+
                                       "Cid = '" + Cusid + "'," +
                                       " Type = '" + Typ + "'," +
                                       " Balance = " + Balance + " " +
                                       " Where AcctNo = '" + ActN + "'";

           

            OleDbDataAdapter2.UpdateCommand.CommandText = cmd;
            OleDbDataAdapter2.UpdateCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.UpdateCommand.ExecuteNonQuery();
                if (n == 1)
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


        }// End Update

        //***************Create Delete*******************
        public void DeleteAcctDB()
        {
            DBSetup();
            cmd = "Delete from Accounts where AcctNo = '" + ActN + "'";

            OleDbDataAdapter2.DeleteCommand.CommandText = cmd;
			OleDbDataAdapter2.DeleteCommand.Connection = OleDbConnection2;
			Console.WriteLine(cmd);
			try  
			{
				OleDbConnection2.Open();
				int n = OleDbDataAdapter2.DeleteCommand.ExecuteNonQuery();
				if (n==1)
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
		} //end DelectDB()

       //Deposit amount

        public void deposit(double am)
        {
            _balance = _balance + am;
        }
       //withdraw amount
        public void withdraw(double am)
        {
            _balance = _balance - am;
        }

        public Accounts(int acn)
        {
            SelectAcctDB(acn);
        }

        //********************Display Accounts**************

        public void displayAccount()
        {
            Console.WriteLine(ActN);
            Console.WriteLine(Cusid);
            Console.WriteLine(Typ);
            Console.WriteLine(Balance);
            alist.displayAcctList(); 

        }
    }
}
