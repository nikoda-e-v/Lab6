using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
   public class Bank
    {
        public void Transfer(Account from, Account to, int ammount)
        {
           if(!from.isBlocked && !to.isBlocked)
            {
                from.isBlocked = true;
                to.isBlocked = true;
                if (from.money - ammount >= 0)
                {
                    from.money -= ammount;
                    to.money += ammount;
                }
                from.isBlocked = false;
                to.isBlocked = false;
            }
            
        }

        public async void doTransfer(Account from, Account to, int ammount)
        {
            await Task.Run(() => Transfer(from, to, ammount));
        }
    }
}
