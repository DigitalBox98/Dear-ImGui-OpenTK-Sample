using System;

namespace Dear_ImGui_Sample
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Window game = new Window();
            game.Run();
        }
    }
}