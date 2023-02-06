
using WCT.Extensions;
using WCT.Interop;

var frameCount = 1000 / 15;

var timer = new System.Timers.Timer(frameCount)
{
    Enabled = true,
    AutoReset = true
};

timer.Elapsed += (_, x) =>
{
    if (Cursor.TryGetCursorPosition(out var point))
    {
        var color = Pixel.GetColor(point).ToHex();

        Console.WriteLine($"{point.X}, {point.Y}: {color}");

        //if (Input.Matches(VirtualKey.LeftMouseButton))

        if (Input.Matches(VirtualKey.Alt, VirtualKey.C))
            Clipboard.Copy(color);
    }
};

timer.Start();

await Task.Delay(Timeout.Infinite);