using OpenTK.Windowing.Desktop;

namespace OGLGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.ReadKey();

            using (Game game = new Game(500, 500))
            {
                Game.Run();
            }
        }
    }
}