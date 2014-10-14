using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SpotifyAPI.SpotifyLocalAPI;

namespace MusicAlarm
{
    public class SpotifyMusicPlayer : IMusicProvider
    {
        private SpotifyLocalAPIClass spotify;
        private SpotifyMusicHandler musicHandler;
        public SpotifyMusicPlayer()
        {
            this.spotify = new SpotifyLocalAPIClass();
            if (!spotify.Connect())
            {
                Console.WriteLine("Spotify is not running");
                Thread.Sleep(3000);
                return;
            }
            this.musicHandler = spotify.GetMusicHandler();
        }

        public void Play()
        {
            musicHandler.Play();
        }

        public void Play(string song)
        {
            if (SpotifyLocalAPIClass.IsValidSpotifyURI(song))
            {
                musicHandler.PlayURL(song);
            }
            else
            {
                Console.WriteLine("Wrong format: " + song + " is not a spotify URI");
            }
        }

        public void Pause()
        {
            musicHandler.Pause();
        }

        public void AddToQueue(string song)
        {
            musicHandler.AddToQueue(song);
        }
    }
}
