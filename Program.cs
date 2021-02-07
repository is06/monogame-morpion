using System;

namespace Morpion
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new MorpionGame())
                game.Run();
        }
    }
}
