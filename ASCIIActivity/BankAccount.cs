using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIActivity
{
    class BankAccount
    {

        public double Balance { get; private set; }//Variable balance is only able to be read

        //COnstructor that initializes the account with an initial amount
        public BankAccount( double initialBalance)
        {
            Balance = initialBalance;
        }

        //Deposit method to add money into the account
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if(amount > Balance)
            {
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

    }
}
