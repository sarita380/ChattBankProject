using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattBankProject
{
   public class AccountList
    {
        // create account list
        public List<Accounts> acclist = new List<Accounts>();
        public int index = 0;
        //default constructor 
        
        public AccountList()
        {

        }

        public void AddAct(Accounts a1)
        {
            acclist.Add(a1);
            index++;
        }

        public void deleteAct(Accounts a1)
        {
            acclist.Add(a1);
            index--;
        }
        public void displayAcctList()
        {
            for (int x = 0; x < index; x++)
            {
                acclist[x].displayAccount();
            }
        }
           
    }
}
