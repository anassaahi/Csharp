using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStreaming.BL
{
    internal class Playlist
    {
        private string Playlistname;
        private List<Music> MusicList;
        public Playlist(string Plalistname, List<Music> musicList)
        {
            Playlistname = Plalistname;
            MusicList = musicList;
        }
        public void AddSongIntoList(Music s)
        {
            MusicList.Add(s);
        }

        public void SetNameOfPlaylist(string name)
        {
            Playlistname = name;
        }

        public string GetNameOfPlaylist()
        {
            return Playlistname;
        }
    }
}
