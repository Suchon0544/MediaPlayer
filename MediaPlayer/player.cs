using System;
using System.Runtime.InteropServices;

namespace MediaPlayer
{
    public class Bottom
    {
        Album album1 = new Album();
        //string Answer = Console.ReadLine();

        public void play()
        {
            Console.WriteLine("Now Playing   :  " + album1.PlayCD(0).name);
            Console.WriteLine("Artist   :  " + album1.PlayCD(0).artist);
            Console.WriteLine(" 00.00 ------------------------- " + album1.PlayCD(0).time);
            Console.WriteLine("<              [pause]              >");
        }

        public void next()
        {

        }

        public void previous()
        {

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

        }

        public static void ask()
        {
            Bottom bottom = new Bottom() ;
            Console.WriteLine("     ");
            Console.Write(" Input for press bottom : ");
            string Answer = Console.ReadLine();
            Console.WriteLine("     " + Answer);

            switch (Answer)
             {
                 case "1":
                    bottom.play();
                     break;
                case "2":
                    bottom.next();
                    break;
                case "3":
                    bottom.previous();
                    break;
                case "4":
                    bottom.Stop();
                    break;
                case "0":
                    bottom.add();
                    break;
                default:
                    break;
            }
        }
    }
}
