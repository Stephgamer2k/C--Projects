namespace Delegates_EventsActivity
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Steph",100000);
            BankNotifications notification = new BankNotifications();

            //call the delegate then subscribe ( += )  it to the action

            account.Withdraws += notification.Sendsms;
            account.Withdraws += notification.NotifyFruad;
            account.Withdraws += notification.LogTranscript;

            account.Withdraw(2000);
            account.Withdraw(20000);
        }
    }
}
