using System.Media;

namespace SlashSound
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string splaash = "C:\\Users\\nseng\\Downloads\\SPLAAAASH.wav";

            SoundPlayer player = new SoundPlayer(splaash);
            player.PlayLooping();

            Console.WriteLine("SPLAAAAASHH");
            Console.ReadLine();
            
        }
    }
}
