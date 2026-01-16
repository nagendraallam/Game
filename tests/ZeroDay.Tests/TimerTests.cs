using Xunit;
using ZeroDay.Core;

namespace ZeroDay.Tests.Core;

public class TimerTests
{
    [Fact]
    public void Tick_IncrementsTotalTime()
    {
        // Arrange
        var timer = new Time();

        // Act
        timer.Tick(0.5f);
        timer.Tick(0.5f);

        // Assert
        Assert.Equal(1.0f, timer.TotalTime);
    }

    [Theory]
    [InlineData(0, "00:00")]
    [InlineData(59, "00:59")]
    [InlineData(60, "01:00")]
    [InlineData(3599, "59:59")] // Just under an hour
    public void GetDisplayTime_FormatsCorrectly(float seconds, string expected)
    {
        // Arrange
        var timer = new Time();

        // Act
        timer.Tick(seconds);

        // Assert
        Assert.Equal(expected, timer.GetDisplayTime());
    }

    [Fact]
    public void Tick_HandlesNegativeTime_ByDoingNothing()
    {
        // Safety test: What if Raylib gives a weird negative number?
        var timer = new Time();
        timer.Tick(-1.0f);
        Assert.Equal(0, timer.TotalTime);
    }
}
