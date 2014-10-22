using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MusicAlarm
{
    public class Alarm
    {
        private DateTime alarmTime;
        private IMusicProvider musicProvider;
        private Timer timer;
        public Alarm(IMusicProvider musicProvider, DateTime alarmTime)
        {
            this.musicProvider = musicProvider;
            this.alarmTime = alarmTime;
            timer = new Timer((alarmTime - DateTime.Now).Milliseconds);
            timer.Start();
            timer.Elapsed += timer_Elapsed;
        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.musicProvider.Play();
        }

    }
}
