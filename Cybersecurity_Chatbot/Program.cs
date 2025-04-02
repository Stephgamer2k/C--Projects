using System.Media;

namespace Cybersecurity_Chatbot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Logo.showLogo();//Shows the logo in ascii format
            //pass the name of the .wav file so that the sound I want to be played from the object is palyed
            SoundPlayer player = new SoundPlayer("Welcome.wav");
            player.PlaySync();  //The built in method PlaySync plays the .wav file
        }
    }
}
