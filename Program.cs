using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;


GameWindowSettings gameWindowSettings = new();
NativeWindowSettings nativeWindowSettings = new();
Game game = new(500, 500, "Shader ESC-close");


game.Run();



