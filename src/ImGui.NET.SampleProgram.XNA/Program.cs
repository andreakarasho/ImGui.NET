using Microsoft.Xna.Framework;

namespace ImGuiNET.SampleProgram.XNA
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CoreDllMap.Register(typeof(Color).Assembly);

            using (var game = new SampleGame()) game.Run();
        }
    }
}