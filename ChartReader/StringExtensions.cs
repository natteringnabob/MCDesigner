using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChartReader
{
    public static class StringExtensions
    {
        public static string LinesToRawString(this IEnumerable<string> str)
        {
            var sb = new StringBuilder();
            foreach (var line in str)
            {
                sb.AppendLine(line);
            }
            return sb.ToString();
        }


        public static IEnumerable<string> LineToStringEnumerable(this string line)
        {
            return line.Split(' ');
        }
    }
}
