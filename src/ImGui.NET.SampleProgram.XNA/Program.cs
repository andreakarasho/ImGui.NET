using Microsoft.Xna.Framework;
using System;

namespace ImGuiNET.SampleProgram.XNA
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CoreDllMap.Register(typeof(Color).Assembly);

            FNALoggerEXT.LogError += (e) =>
            {
                Console.WriteLine("[ERROR]: {0}", e);
            };

            FNALoggerEXT.LogWarn += (e) =>
            {
                Console.WriteLine("[WARN]: {0}", e);
            };

            FNALoggerEXT.LogInfo += (e) =>
            {
                Console.WriteLine("[INFO]: {0}", e);
            };

            //System.Environment.SetEnvironmentVariable("FNA3D_OPENGL_FORCE_ES3", "1");
            //System.Environment.SetEnvironmentVariable("FNA3D_FORCE_DRIVER", "Vulkan");

            using (var game = new SampleGame()) game.Run();
        }
    }
}