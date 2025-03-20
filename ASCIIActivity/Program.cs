using Figgle;

namespace ASCIIActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WelcomeScreen.ShowWelcomeScreen();
            WelcomeScreen.DrawBorder("AUTHENTICATION");

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine().Trim();

            Console.WriteLine("Enter your account number:");
            string accountNumber = Console.ReadLine().Trim();

            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(accountNumber))
            {
                //Console.ForegroundColor


            }

            User user = new User(name, accountNumber);
            BankAccount account = new BankAccount(300);

           
            ATMService.ProcessATM(user,account);

        }

        

       

        
    }
}
