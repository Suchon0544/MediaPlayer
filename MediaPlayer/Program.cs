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

            
            Console.WriteLine("Now Playing   :  "+ album1.PlayCD(5).name);
            Console.WriteLine("Artist   :  "+ album1.PlayCD(0).artist);
            Console.WriteLine("00.00 ------------------------- " + album1.PlayCD(5).time);
            Console.WriteLine("<                 ►                 >");

            Bottom.Ask();

            /*for (int i = 0; i < 6; i++)
            {
                //Console.WriteLine(album1.PlayCD().name);
                Console.WriteLine(album1.PlayCD().artist);
                //Console.WriteLine(album1.PlayCD().time);
            }

            for (int i = 0; i < 6; i++)
            {
                //Console.WriteLine(album1.PlayCD().name);
                //Console.WriteLine(album1.PlayCD().artist);
                Console.WriteLine(album1.PlayCD().time);
            }*/

            /*Console.WriteLine(tracks[0].name);
            Console.WriteLine(tracks[0].artist);
            Console.WriteLine(tracks[0].time);*/
        }
    }

}    
