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
        [LibraryImport("user32.dll"), EditorBrowsable(EditorBrowsableState.Never)]
#pragma warning disable CA1401 // P/Invokes should not be visible
        public static partial short GetAsyncKeyState(int VirtualKeyPressed);
#pragma warning restore CA1401 // P/Invokes should not be visible

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
    ///     Represents a virtual key. Refer to https://learn.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes for more information.
    /// </summary>
    public enum VirtualKey : byte
    {
        LeftMouseButton = 0x01,

        RightMouseButton = 0x02,

        Alt = 0x12,

        C = 0x43,
    }
}
