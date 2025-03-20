

using System.Media;

namespace SoundPlayerDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add the .WAV file to your app
            //right click the name on solution explorer
            //go to Add>Existing item and look for the file in file explorer
            //System.Media Library to access the SoundPlayer Class
            //We will create a program that will allow us to hear a chime soundwhen we type play
            //when we type exit the program will exit
            string sound = "C:\\Users\\nseng\\Downloads\\SPLAAAASH.wav";
            SoundPlayer splash = new SoundPlayer(sound);
            SoundPlayer player = new SoundPlayer();
            Console.WriteLine("Type 'play' and press enter to hear a sound");
            Console.WriteLine("Type 'exit' to quit");

            while(true)
            {
                Console.WriteLine("Enter command");
                string input = Console.ReadLine()?.Trim().ToLower();

                if(input == "play")
                {
                    Console.WriteLine("Playing sound....");
                    player.Play();
                }
                else if (input == "splash")
                {
                    Console.WriteLine("SPLAAAAASH");
                    splash.Play();
                }
                else if (input == "exit")
                {
                    Console.WriteLine("Exiting the program....");
                    break;
                }
                
            }
            //Thread.Sleep gives the code some time before it breaks
            Thread.Sleep(1000);

        }
    }
}
