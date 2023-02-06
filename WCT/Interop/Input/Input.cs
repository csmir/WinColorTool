using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public static bool Matches(Key key)
        {
            if (GetAsyncKeyState((int)key) == 0)
                return false;
            return true;
        }

        public static bool Matches(params Key[] keys)
        {
            if (keys.All(x => Matches(x)))
                return true;
            return false;
        }
    }
}
