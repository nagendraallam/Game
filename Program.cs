using Raylib_cs;

namespace ZeroDay.Base
{
    class Program
    {
        [System.STAThread]
        public static void Main()
        {
            Raylib.InitWindow(640, 400, "Fun Game");
            Console.WriteLine("Building world...");

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);

                Raylib.DrawText("Starting...", 12, 12, 20, Color.Black);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
