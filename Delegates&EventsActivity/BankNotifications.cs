using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_EventsActivity
{
    class BankNotifications
    {

        public void Sendsms (double amount)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Alert: a large withdrawl of R{amount} has been made");
            Console.ResetColor();
        }

        public void NotifyFruad(double amount)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Warning: Potential fruad detected on withdrawl of R{amount}.");
            Console.ResetColor();
        }

        public void LogTranscript(double amount)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Large withdrawl of R{amount} has been logged");
            Console.ResetColor();
        }
    }
}
