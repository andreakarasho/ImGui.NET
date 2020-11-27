using Microsoft.Xna.Framework;

namespace ImGuiNET.SampleProgram.XNA
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CoreDllMap.Register(typeof(Color).Assembly);
            
            System.Environment.SetEnvironmentVariable("FNA3D_OPENGL_FORCE_ES3", "1");
            //System.Environment.SetEnvironmentVariable("FNA3D_FORCE_DRIVER", "Vulkan");

            using (var game = new SampleGame()) game.Run();
        }
    }
}