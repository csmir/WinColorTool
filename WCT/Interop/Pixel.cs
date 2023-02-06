using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace WCT.Interop
{
    /// <summary>
    ///     A class that wraps gdi32 pixel information discovery.
    /// </summary>
    public static partial class Pixel
    {
        private static readonly Bitmap _screenPixel = new(1, 1, PixelFormat.Format32bppArgb);

        [LibraryImport("gdi32.dll", SetLastError = true), EditorBrowsable(EditorBrowsableState.Never)]
        public static partial int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        /// <summary>
        ///     Gets the color from a specific position on the screen.
        /// </summary>
        /// <param name="location">The pixel location on the screen to fetch a color for.</param>
        /// <returns>A color created from the information on the screen pixel.</returns>
        public static Color GetColor(Point location)
        {
            lock (_screenPixel)
            {
                using (Graphics gdest = Graphics.FromImage(_screenPixel))
                {
                    using Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero);

                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }

                return _screenPixel.GetPixel(0, 0);
            }
        }
    }
}
