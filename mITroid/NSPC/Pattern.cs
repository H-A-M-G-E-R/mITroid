﻿using System.Collections.Generic;

namespace mITroid.NSPC
{
    class Pattern
    {
        public int Pointer { get; set; }
        public int Rows { get; set; }
        public List<Track> Tracks { get; set; }
        public int PatternIndex { get; set; }

        public Pattern(IT.Pattern itPattern)
        {
            PatternIndex = itPattern.PatternIndex;
            Tracks = new List<Track>();
            Rows = itPattern.Rows;
            foreach(var channel in itPattern.Channels)
            {
                var track = new Track(channel.Rows, channel.ChannelNum)
                {
                    Rows = itPattern.Rows
                };
                Tracks.Add(track);
            }
        }
    }
}
