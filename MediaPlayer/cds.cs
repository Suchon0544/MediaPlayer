﻿using System;

namespace MediaPlayer
{
    public class Track
    {
        public string name;
        public string artist;
        public string time;

        public void SetTrack(string name, string artist, string time)
        {
            this.name = name;
            this.artist = artist;
            this.time = time;
        }
    }
}