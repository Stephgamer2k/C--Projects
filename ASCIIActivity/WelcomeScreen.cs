using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace ASCIIActivity
{
    internal class WelcomeScreen
    {
        public static void ShowWelcomeScreen()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════╗");
            Console.WriteLine("║       ATM SYSTEM       ║");
            Console.WriteLine("╚════════════════════════╝");

            Console.ResetColor();
        }


        public static void DrawBorder(string title)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string('=', 70));
            Console.WriteLine(new string($"= {title.PadRight(26)} ="));
            Console.WriteLine(new string('=', 70));
            Console.ResetColor();
        }

    }

}
