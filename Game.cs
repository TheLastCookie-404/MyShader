using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;

class Game : GameWindow
{
    private float r,g,b;
    public Game(int width, int height, string title) : base(GameWindowSettings.Default, new NativeWindowSettings() { Size = (width, height), Title = title }) 
    { 
        Console.WriteLine();
    }

    protected override void OnUpdateFrame(FrameEventArgs e)
    {
        base.OnUpdateFrame(e);

        if(KeyboardState.IsKeyDown(Keys.R)) 
        {
            r = 1f;
            g = 0f;
            b = 0f;
        }
        if(KeyboardState.IsKeyDown(Keys.G)) 
        {
            r = 0f;
            g = 1f;
            b = 0f;
        }
        if(KeyboardState.IsKeyDown(Keys.B)) 
        {
            r = 0f;
            g = 0f;
            b = 1f;
        }

        if (KeyboardState.IsKeyDown(Keys.Escape))
        {
            Close();
        }
    }
    protected override void OnLoad()
    {
        base.OnLoad();

        GL.ClearColor(0.0f, 0.0f, 0.0f, 1.0f);

        //Code goes here
    }

    protected override void OnRenderFrame(FrameEventArgs e)
    {
        base.OnRenderFrame(e);

        GL.Clear(ClearBufferMask.ColorBufferBit);

        GL.ClearColor(r, g, b, 1.0f);

        //Code goes here.

        SwapBuffers();
    }
}