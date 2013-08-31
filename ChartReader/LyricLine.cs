using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChartReader
{
    public class LyricLine
    {
        public IEnumerable<Lyric> Lyrics { get; set; }
        public bool HasChords { get; set; }

        public LyricLine()
        {
            
        }

        public LyricLine(IEnumerable<Lyric> lyrics,  bool hasChords)
        {
            Lyrics = lyrics;
            HasChords = hasChords;
        }
    }

    public class Lyric
    {
        public string Text { get; set; }
        public string Chord { get; set; }

        public Lyric()
        {
            
        }

        public Lyric(string chord, string text)
        {
            Text = text;
            Chord = chord;
        }
    }
}
