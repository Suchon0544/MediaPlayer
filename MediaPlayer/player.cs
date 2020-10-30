using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    class Player
    {
        public void player_display()
        {

            Console.WriteLine("Input: p for play your music");
            Console.WriteLine("       n for play next music");
            Console.WriteLine("       r for play previous music");
            Console.WriteLine("       s for stop playing");
            Console.WriteLine("       a for add music");
            Console.WriteLine("       q for show tracklist");
            Console.WriteLine("       e for close");
            Console.WriteLine("     ");
            Console.WriteLine("Now Playing   :  --");
            Console.WriteLine("Artist   :  --");
            Console.WriteLine(" --.-- ------------------------- --.--");
            Console.WriteLine("<               [play]               >");
        }
    }
}
