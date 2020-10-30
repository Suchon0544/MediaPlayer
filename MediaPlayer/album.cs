using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    public class Album
    {
        public List<Track> tracks = new List<Track>();
        int Tracklist;
        public Album()
        {

            tracks.Add(new Track("Camelia", "MILI", "04.43"));
            tracks.Add(new Track("Can't You See Me?", "TOMORROW X TOGETHER", "03:21"));
            tracks.Add(new Track("Eternally", "TOMORROW X TOGETHER", "03:37"));
            tracks.Add(new Track("Spark", "JBJ95", "03.36"));
            tracks.Add(new Track("TO BE OR NOT TO BE", "Oneus", "03.48"));
            tracks.Add(new Track("Yakusoku", "GARNiDELiA", "04.16"));
            tracks.Add(new Track("Touch off", "UVERworld", "04.12"));

            Tracklist = tracks.Count;
        }
        public Track PlayCD(int order)
        {
            Tracklist--;
            return tracks[order];
        }
        public void Addmusic(string name, string artist, string time)
        {
            tracks.Add(new Track(name, artist, time));
        }
        public void Show()
        {
            foreach (var t in tracks)
            {
                Console.Write("         " + t.name);
                Console.Write(" --- " + t.artist);
                Console.WriteLine(" --- " + t.time);
            }
        }
    }
}
