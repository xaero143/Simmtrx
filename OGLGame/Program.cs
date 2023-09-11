using OpenTK.Windowing.Desktop;
using OpenTK.Graphics.OpenGL4;

namespace OGLGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameScreen game =  new GameScreen(500, 500);
            game.Run();


        }
    }
}