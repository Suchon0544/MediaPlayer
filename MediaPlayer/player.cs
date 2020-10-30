using System;
using System.Runtime.InteropServices;

namespace MediaPlayer
{
    public class Bottom
    {
        Album album1 = new Album();
        int _next = 0;

        public void play()
        {
            Console.WriteLine("Now Playing   :  " + album1.PlayCD(_next).name);
            Console.WriteLine("Artist   :  " + album1.PlayCD(_next).artist);
            Console.WriteLine(" 00.00 ------------------------- " + album1.PlayCD(_next).time);
            Console.WriteLine("<              [pause]              >");
        }

        public void next()
        {
            _next = _next + 1;
            Console.WriteLine("Now Playing   :  " + album1.PlayCD(_next).name);
            Console.WriteLine("Artist   :  " + album1.PlayCD(_next).artist);
            Console.WriteLine(" 00.00 ------------------------- " + album1.PlayCD(_next).time);
            Console.WriteLine("<              [pause]              >");
        }
        public void previous()
        {
            _next = _next - 1;
            Console.WriteLine("Now Playing   :  " + album1.PlayCD(_next).name);
            Console.WriteLine("Artist   :  " + album1.PlayCD(_next).artist);
            Console.WriteLine(" 00.00 ------------------------- " + album1.PlayCD(_next).time);
            Console.WriteLine("<              [pause]              >");
        }
        public void Stop()
        {
            Console.WriteLine("Now Playing   :  " + album1.PlayCD(0).name);
            Console.WriteLine("Artist   :  " + album1.PlayCD(0).artist);
            Console.WriteLine(" 00.00 ------------------------- " + album1.PlayCD(0).time);
            Console.WriteLine("<               [play]               >");
        }

        public void add()
        {
            Console.Write("input name = ");
            string input_name = Console.ReadLine();
            Console.Write("input artist = ");
            string input_artist = Console.ReadLine();
            Console.Write("input time = ");
            string input_time = Console.ReadLine();
            album1.Addmusic(input_name, input_artist, input_time);
        }
        public static void ask()
        {
            Bottom bottom = new Bottom();
            Album album = new Album();
        UP:
            Console.WriteLine("     ");
            Console.Write(" Input for press bottom : ");
            string Answer = Console.ReadLine();
            Console.WriteLine("        ");
            //Console.WriteLine("     " + Answer);

            switch (Answer)
            {
                case "p":
                    bottom.play();
                    goto UP;
                    break;
                case "n":
                    bottom.next();
                    goto UP;
                    break;
                case "r":
                    bottom.previous();
                    goto UP;
                    break;
                case "s":
                    bottom.Stop();
                    goto UP;
                    break;
                case "a":
                    bottom.add();
                    goto UP;
                    break;
                case "q":
                    album.Show();
                    goto UP;
                    break;
                case "e":
                    break;
                default:
                    goto UP;
                    break;
            }
        }
    }
}
