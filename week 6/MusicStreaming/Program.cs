using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicStreaming.BL;

namespace MusicStreaming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Music> Songs = new List<Music>();

            Music s = new Music("Song1", "Jak", 12);
            Music s2 = new Music("Song", "Jke", 11);
            Songs.Add(s);
            Songs.Add(s2);
            Playlist p = new Playlist("Best Songs", Songs);
            Console.ReadKey();

        }
    }
}
