using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCT.Interop
{
    /// <summary>
    ///     Represents a virtual key. Refer to <see href="https://learn.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes"/> for more information.
    /// </summary>
    public enum Key : byte
    {
        LeftMouse = 0x01,

        RightMouse = 0x02,

        MiddleMouse = 0x04,

        Backspace = 0x08,

        Tab = 0x09,

        Clear = 0x0C,

        Enter = 0x0D,

        Alt = 0x12,

        No0 = 0x30,

        No1 = 0x31,

        No2 = 0x32,

        No3 = 0x33,

        No4 = 0x34,

        No5 = 0x35,

        No6 = 0x36,

        No7 = 0x37,

        No8 = 0x38,

        No9 = 0x39,

        A = 0x41,

        B = 0x42,

        C = 0x43,

        D = 0x44,

        E = 0x45,

        F = 0x46,

        G = 0x47,

        H = 0x48,

        I = 0x49,

        J = 0x4A,

        K = 0x4B,

        L = 0x4C,

        M = 0x4D,

        N = 0x4E,

        O = 0x4F,

        P = 0x50,

        Q = 0x51,

        R = 0x52,

        S = 0x53,

        T = 0x54,

        U = 0x55,

        V = 0x56,

        W = 0x57,

        X = 0x58,

        Y = 0x59,

        Z = 0x5A,
    }
}
