namespace ATM_Welcome_screen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawUpperBorder();
            DrawLowerBorder();
        }

        static void DrawUpperBorder()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("╔════════════════════════╗");
        }
        static void DrawLowerBorder()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n╚════════════════════════╝");
        }
    }
}
