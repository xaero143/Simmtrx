using OpenTK;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGLGame
{
    internal class GameScreen: GameWindow
    {

        float[] vertices = 
        {
            0f, 0.5f, 0f, 
            -0.5f, -0.5f, 0f,
            0.5f, -0.5f, 0f
        };

        int vao;
        int shaderProgram;

        private int ScreenWidth; 
        private int ScreenHeight;
        public GameScreen(int width, int height) : base(GameWindowSettings.Default, NativeWindowSettings.Default)
        {

            Console.WriteLine(GL.GetString(StringName.Version) + " -> Version");
            Console.WriteLine(GL.GetString(StringName.Vendor) + " -> Vendor");
            Console.WriteLine(GL.GetString(StringName.ShadingLanguageVersion) + " -> ShadingLanguageVersion");
            Console.WriteLine(GL.GetString(StringName.Renderer) + " -> Renderer");
            Console.WriteLine(GL.GetString(StringName.Extensions) + " -> Extensions");

            ScreenWidth = width;
            ScreenHeight = height;

            this.CenterWindow(new Vector2i(width, height));
        }

        protected override void OnResize(ResizeEventArgs e)
        {
            base.OnResize(e);
            GL.Viewport(0, 0, e.Width, e.Height);
            this.ScreenWidth = e.Width;
            this.ScreenHeight = e.Height;
        }

        protected override void OnLoad()
        {
            base.OnLoad();
            vao = GL.GenVertexArray();

            int vbo = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);
            GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length*sizeof(float), vertices, BufferUsageHint.StaticDraw);

            GL.BindVertexArray(vbo);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 0, 0);
            GL.EnableVertexArrayAttrib(vao, 0);

            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            GL.BindVertexArray(0);

        }

        protected override void OnUnload()
        {
            base.OnUnload();
        }

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            GL.ClearColor(0.6f, 0.3f, 1f, 1f);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            Context.SwapBuffers();
            base.OnRenderFrame(args);
        }

        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);
        }
    }
}
