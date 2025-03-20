using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIActivity
{
    class ATMService
    {
        public static void DisplayMenu()
        {
            WelcomeScreen.DrawBorder("ATM MENU");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔════════════════════════╗");
            Console.WriteLine("║    1. Check Balance    ║");
            Console.WriteLine("║    2. Deposit money    ║");
            Console.WriteLine("║    3. Withdraw money   ║");
            Console.WriteLine("║    4. Exit             ║");
            Console.WriteLine("╚════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine("\nChoose an option");
        }

        public static void ProcessATM(User user, BankAccount bankAccount)
        {
            string choice;
            do
            {
                DisplayMenu();
                choice = Console.ReadLine().Trim();

                switch (choice)
                {
                    case "1":
                        WelcomeScreen.DrawBorder("CHECK BALANCE");
                        Console.Write($"Hello {user.Name}, Your current balance is {bankAccount.Balance}");
                        break;
                    case "2":
                        WelcomeScreen.DrawBorder("DEPOSIT MONEY");
                        Console.Write($"Enter the amount you want to enter: ");
                        if (double.TryParse(Console.ReadLine(), out double deposit) && deposit > 0)
                        {
                            bankAccount.Deposit(deposit);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Successfully deposited ${deposit}. New Balance: ${bankAccount.Balance}");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid deposit");
                            Console.ResetColor();
                        }
                        break;
                    case "3":
                        WelcomeScreen.DrawBorder("WITHDRAW MONEY");
                        Console.Write("Enter amount to withdraw: ");
                        if (double.TryParse(Console.ReadLine(), out double withdraw) && withdraw > 0)
                        {
                            if (bankAccount.Withdraw(withdraw))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Successfully withdrawn ${withdraw}. Remaining Balance: ${bankAccount.Balance}");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Insufficient Funds");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Insufficient withdrawl amount");
                            Console.ResetColor();
                        }
                        break;
                    case "4":
                        WelcomeScreen.DrawBorder(" THANK YOU FOR USING THE SYSTEM");
                        Console.WriteLine("ENjoy yyour day");
                        break;

                }
                Console.WriteLine("\nPress Enter to Continue");
                Console.ReadLine();


            }
            while (choice != "4");
        }
    }
}
