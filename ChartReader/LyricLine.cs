using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChartReader
{
    public class LyricLine
    {
        private IEnumerable<string> Words { get; set; }
        private IEnumerable<string> Chords { get; set; }

        public LyricLine()
        {
            
        }

        public LyricLine(IEnumerable<string> words, IEnumerable<string> chords)
        {
            Words = words;
            Chords = chords;
        }
    }
}
