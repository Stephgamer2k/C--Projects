using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_EventsActivity
{
    class BankAccount
    {
        //Declare the delegate
        public delegate void WithdrawHandler(double amount);

        public event WithdrawHandler Withdraws;

        public string Account { get; set; }
        public double Balance { get; private set; }//Only allows the user to view Balance

        public BankAccount(string account,double initialBalance)
        {
            Account = account;
            Balance = initialBalance;
        }


        public void Withdraw (double amount)
        {
            if(amount > Balance)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Insufficient funds");
                Console.ResetColor();
            }

            Balance -= amount;
            Console.WriteLine($"Amount withdrawn: {amount}.\nNew Balance: {Balance}");

            if(amount > 5000 && Withdraws != null)
            {
                Withdraws(amount);
            }
        }
    }
}
