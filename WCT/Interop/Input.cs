using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WCT.Interop
{
    /// <summary>
    ///     A class that wraps user32 input information discovery.
    /// </summary>
    public static partial class Input
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        [LibraryImport("user32.dll", SetLastError = true)]
        public static partial short GetAsyncKeyState(int VirtualKeyPressed);

        public static bool Matches(VirtualKey key)
        {
            if (GetAsyncKeyState((int)key) == 0)
                return false;
            return true;
        }

        public static bool Matches(params VirtualKey[] keys)
        {
            if (keys.All(Matches))
                return true;
            return false;
        }
    }

    /// <summary>
    ///     Represents a virtual key. Refer to <see href="https://learn.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes"/> for more information.
    /// </summary>
    public enum VirtualKey : byte
    {
        LeftMouse = 0x01,

        RightMouse = 0x02,

        MiddleMouse = 0x04,

        Backspace = 0x08,

        Tab = 0x09,

        Clear = 0x0C,

        Enter = 0x0D,

        Alt = 0x12,

        C = 0x43,

        D = 0x44,

        E = 0x45,

        F = 0x46,
    }
}
