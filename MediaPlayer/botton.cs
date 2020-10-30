using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace MediaPlayer
{
    public class Botton
    {
        Album album1 = new Album();
        int ordering = 0;

        private void Display()
        {
            Console.WriteLine("Now Playing   :  " + album1.PlayCD(ordering).name);
            Console.WriteLine("Artist   :  " + album1.PlayCD(ordering).artist);
            Console.WriteLine(" 00.00 ------------------------- " + album1.PlayCD(ordering).time);
        }
        private void play()
        {
            Display();
            Console.WriteLine("<              [pause]              >");
        }

        private void next()
        {
            ordering = ordering + 1;
            Display();
            Console.WriteLine("<              [pause]              >");
        }
        private void previous()
        {
            ordering = ordering - 1;
            Display();
            Console.WriteLine("<              [pause]              >");
        }
        private void Stop()
        {
            ordering = 0;
            Display();
            Console.WriteLine("<               [play]               >");
        }

        private void add()
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
            Botton botton = new Botton();
            Album album = new Album();
        UP:
            Console.WriteLine("     ");
            Console.Write(" Input for press botton : ");
            string Answer = Console.ReadLine();
            Console.WriteLine("        ");
            //Console.WriteLine("     " + Answer);

            switch (Answer)
            {
                case "p":
                    botton.play();
                    goto UP;
                    break;
                case "n":
                    botton.next();
                    goto UP;
                    break;
                case "r":
                    botton.previous();
                    goto UP;
                    break;
                case "s":
                    botton.Stop();
                    goto UP;
                    break;
                case "a":
                    botton.add();
                    goto UP;
                    break;
                case "q":
                    album.show();
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
