using OpenTK;
using OpenTK.Windowing.Desktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGLGame
{
    internal class Game: GameWindow
    {
        private static int ScreenWidth; private static int ScreenHeight;
        public Game(int width, int height) : base(GameWindowSettings.Default, NativeWindowSettings.Default)
        {
            this.CenterWindow(new OpenTK.Mathematics.Vector2i(width, height));
            ScreenWidth = width;
            ScreenHeight = height;

        }
    }
}
