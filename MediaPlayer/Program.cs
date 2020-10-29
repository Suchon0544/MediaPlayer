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
            Track t1 = new Track();
            Album album1 = new Album();
            Bottom bottom1 = new Bottom();

            Console.WriteLine("Input: 1 for play your music");
            Console.WriteLine("       2 for play next music");
            Console.WriteLine("       3 for play previous music");
            Console.WriteLine("       4 for stop playing");
            Console.WriteLine("       0 for add music");
            Console.WriteLine("     ");
            Console.WriteLine("Now Playing   :  "+ album1.PlayCD(1).name);
            Console.WriteLine("Artist   :  "+ album1.PlayCD(1).artist);
            Console.WriteLine(" 00.00 ------------------------- " + album1.PlayCD(1).time);
            Console.WriteLine("<               [play]               >");
            for (int i = 0; i < 10; i++)
            {
                Bottom.ask();
            }
        }
    }
}    
