namespace ZeroDay.Core;

public class Time
{
    public float TotalTime { get; private set; }

    public void Tick(float delta_time)
    {
        if (delta_time < 0)
        {
            return;
        }
        TotalTime += delta_time;
    }

    public string GetDisplayTime()
    {
        int minutes = (int)TotalTime / 60;
        int seconds = (int)TotalTime % 60;
        return $"{minutes:D2}:{seconds:D2}";
    }
}
