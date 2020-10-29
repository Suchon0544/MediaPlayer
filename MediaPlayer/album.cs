using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    public class Album
    {
        public Track[] tracks;
        //public int TrackList { get; }
        public int Tracklist = 0;
        public Album()
        {
            tracks = new Track[10];
            for (int i = 0; i < tracks.Length; i++)
            {
                tracks[i] = new Track();
            }


            tracks[0].name = "Drama";
            tracks[0].artist = "TOMORROW X TOGETHER";
            tracks[0].time = "3:29";
            tracks[1].name = "Can't You See Me?";
            tracks[1].artist = "TOMORROW X TOGETHER";
            tracks[1].time = "3:21";
            tracks[2].name = "Fairy of Shampoo";
            tracks[2].artist = "TOMORROW X TOGETHER";
            tracks[2].time = "4:27";
            tracks[3].name = "Maze in the Mirror";
            tracks[3].artist = "TOMORROW X TOGETHER";
            tracks[3].time = "3:46";
            tracks[4].name = "PUMA";
            tracks[4].artist = "TOMORROW X TOGETHER";
            tracks[4].time = "3:25";
            tracks[5].name = "Eternally";
            tracks[5].artist = "TOMORROW X TOGETHER";
            tracks[5].time = "3:37";
            Tracklist = tracks.Length;
        }
        public Track PlayCD(int order)
        {
            Tracklist--;
            return tracks[order];
        }
    }
}
