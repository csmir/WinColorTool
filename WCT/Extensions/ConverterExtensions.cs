using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCT.Extensions
{
    public static class ConverterExtensions
    {
        /// <summary>
        ///     Converts the color value to HTML Hex format.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string ToHex(this Color color)
            => $"#{color.R:X2}{color.G:X2}{color.B:X2}";

        /// <summary>
        ///     Converts the color value to HSL(B) format.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string ToHsl(this Color color)
            => $"{color.GetHue()}, {color.GetSaturation}, {color.GetBrightness}";
    }
}
