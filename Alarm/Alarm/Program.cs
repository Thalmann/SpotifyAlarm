using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SpotifyAPI.SpotifyLocalAPI;

namespace Alarm
{
    class Program
    {
        static void Main(string[] args)
        {
            SpotifyLocalAPIClass spotify = new SpotifyLocalAPIClass();
            if (!spotify.Connect())
            {
                Console.WriteLine("Spotify is not running");
                Thread.Sleep(3000);
                return;
            }

            SpotifyMusicHandler musichHandler = spotify.GetMusicHandler();

            
            musichHandler.Play();

        }
    }
}
