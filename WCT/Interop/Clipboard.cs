using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCT.Interop
{
    /// <summary>
    ///     A class that sets information to the clipboard.
    /// </summary>
    public static class Clipboard
    {
        /// <summary>
        ///     Copies provided string to the clipboard.
        /// </summary>
        /// <param name="value"></param>
        public static void Copy(string value)
        {
            Process clipboardExecutable = new()
            {
                StartInfo = new ProcessStartInfo // Creates the process
                {
                    RedirectStandardInput = true,
                    FileName = @"clip",
                }
            };
            clipboardExecutable.Start();

            clipboardExecutable.StandardInput.Write(value);
            clipboardExecutable.StandardInput.Close();
        }
    }
}
