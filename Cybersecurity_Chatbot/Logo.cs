using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace Cybersecurity_Chatbot
{
    class Logo
    {
        public static void showLogo()
        {
            /*
             * variable ascii will hold the format of the text: "Cybersecurity Awareness Bot"
             */
            Console.ForegroundColor = ConsoleColor.Yellow;//sets the console color to cyan
            string ascii = FiggleFonts.Big.Render("Cybersecurity Awareness Bot");
            Console.WriteLine(ascii);
            Console.ResetColor();//resets the  console color
        }
    }
}
