using Raylib_cs;
using ZeroDay.Core;
using ZeroDay.App.Rendering;


// Window Setup
const int screenWidth = 800;
const int screenHeight = 450;
Raylib.InitWindow(screenWidth, screenHeight, "ZeroDay");

Time gameTimer = new();
WorldRenderer renderer = new();

while (!Raylib.WindowShouldClose())
{
    // --- UPDATE ---
    gameTimer.Tick(Raylib.GetFrameTime());

    // --- DRAW ---
    Raylib.BeginDrawing();

    renderer.DrawBackground();
    renderer.DrawHUD(gameTimer); // Pass the timer to the renderer

    Raylib.EndDrawing();
}

Raylib.CloseWindow();
