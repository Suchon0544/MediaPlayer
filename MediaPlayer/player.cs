using System;
using System.Runtime.InteropServices;

namespace MediaPlayer
{
    public class Bottom
    {
        Album album = new Album();
        //public string Answer;

        public void Play(string Answer)
        {
            /*Console.WriteLine("         ", tracks[1].name, "         ");
            Console.WriteLine("         ", tracks[1].Artist, "         ");
            Console.WriteLine("00.00 -------------------------", tracks[1].time);*/
        }

        public void Next(string Answer)
        {

        }

        public void Previous(string Answer)
        {

        }

        public void Stop(string Answer)
        {

        }

        public void Ask(string Answer)
        {
            Console.WriteLine("p for play your music");
            Console.WriteLine("n for play next music");
            Console.WriteLine("r for play previous music");
            Console.WriteLine("s for stop playing");
            Console.WriteLine("Input for Press bottom : ");
            Answer = Console.ReadLine();
            //return Answer;
        }
    }
}