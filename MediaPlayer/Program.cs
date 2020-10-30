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
            Player player = new Player();
            player.player_display();
            Bottom.ask();
        }
    }
}    
