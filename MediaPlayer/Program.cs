using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MediaPlayer;

namespace MediaPlayer
{

    class Program
    {
        
        static void Main(string[] args)
        {
            Album album1 = new Album();
            Bottom bottom1 = new Bottom();

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

            Bottom.ask();
        }
    }
}    
