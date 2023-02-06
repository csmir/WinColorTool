
using WCT.Information;

var frameCount = 1000 / 15;

var timer = new System.Timers.Timer(frameCount)
{
    Enabled = true,
    AutoReset = true
};

timer.Elapsed += (_, x) =>
{
    if (CursorInformation.TryGetCursorPosition(out var point))
        Console.WriteLine($"{point.X}, {point.Y} {PixelInformation.GetColor(point).ToArgb()}");
};

timer.Start();

await Task.Delay(Timeout.Infinite);