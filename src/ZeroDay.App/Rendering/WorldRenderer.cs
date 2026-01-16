using Raylib_cs;
using ZeroDay.Core;

namespace ZeroDay.App.Rendering;

public class WorldRenderer
{
    private readonly Color _themeColor = Color.Green;

    public void DrawHUD(Time timer)
    {
        string timeText = timer.GetDisplayTime();
        int fontSize = 30;

        int textWidth = Raylib.MeasureText(timeText, fontSize);
        int posX = (Raylib.GetScreenWidth() / 2) - (textWidth / 2);

        Raylib.DrawText(timeText, posX, 20, fontSize, _themeColor);
    }

    public void DrawBackground()
    {
        Raylib.ClearBackground(Color.Black);
    }
}
