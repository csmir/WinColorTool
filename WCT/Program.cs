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
        var color = Pixel.GetColor(point);

        Console.WriteLine($"{point.X}, {point.Y}: {color.ToHex()}");

        Input.Matches(Key.Alt, Key.C)
            .ContinueMatching(Key.H, () =>
            {
                Clipboard.Copy(color.ToHex());
            })
            .ContinueMatching(Key.R, () =>
            {
                Clipboard.Copy(color.ToArgb());
            })
            .ContinueMatching(Key.S, () =>
            {
                Clipboard.Copy(color.ToHsl());
            });
    }
};

timer.Start();

await Task.Delay(Timeout.Infinite);