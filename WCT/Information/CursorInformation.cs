using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

namespace WCT.Information
{
    /// <summary>
    ///     A class that wraps user32 cursor information discovery.
    /// </summary>
    public static partial class CursorInformation
    {
        [LibraryImport("user32.dll"), EditorBrowsable(EditorBrowsableState.Never)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool GetCursorPos(out PT point);

        [StructLayout(LayoutKind.Sequential), EditorBrowsable(EditorBrowsableState.Never)]
        public struct PT
        {
            public int X;

            public int Y;

            public static implicit operator Point(PT point)
                => new(point.X, point.Y);
        }

        /// <summary>
        ///     Tries to get the cursor information from the provided 
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public static bool TryGetCursorPosition(out Point point)
        {
            point = default!;
            if (GetCursorPos(out var pt))
            {
                point = pt;
                return true;
            }
            return false;
        }
    }
}
