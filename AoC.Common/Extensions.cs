using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AoC.Common
{
    public static class Extensions
    {
        public static T[] SplitByNewline<T>(this string input)
        {
            return input.SplitBy<T>(new[] { "\r", "\n", "\r\n" });
        }

        public static string[] SplitByBlankLine(this string input)
        {
            return input.SplitBy<string>(new[] { "\r\r", "\n\n", "\r\n\r\n" });
        }

        public static T[] SplitBy<T>(this string value, params string[] separators)
        {
            return value
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => (T)Convert.ChangeType(x, typeof(T)))
                .ToArray();
        }
    }
}
