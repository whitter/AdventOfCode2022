using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC.Common
{
    public static class Extensions
    {
        public static T[] SplitByNewline<T>(this string input)
        {
            return input
                .Split(new[] { "\r", "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => (T)Convert.ChangeType(x, typeof(T)))
                .ToArray();
        }

        public static T[] SplitByBlankLine<T>(this string input)
        {
            return input
                .Split(new[] { "\r\r", "\n\n", "\r\n\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => (T)Convert.ChangeType(x, typeof(T)))
                .ToArray();
        }

    }
}
