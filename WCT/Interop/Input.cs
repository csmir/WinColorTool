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
        public static partial short GetAsyncKeyState(int VirtualKeyPressed);

        public static bool Is(VirtualKey key)
        {
            if (GetAsyncKeyState((int)key) == 0)
                return false;
            return true;
        }
    }

    /// <summary>
    ///     Represents a virtual key. Refer to https://learn.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes for more information.
    /// </summary>
    public enum VirtualKey : byte
    {
        LeftMouseButton = 0x01,

        RightMouseButton = 0x02,
    }
}
