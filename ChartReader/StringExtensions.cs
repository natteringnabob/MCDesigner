using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public static ObservableCollection<string> LineToStringObservable(this string line)
        {
            var array =  line.Split(' ');
            var obs = new ObservableCollection<string>();
            foreach (var word in array)
            {
                obs.Add(word);
            }
            return obs;
        }
    }
}
