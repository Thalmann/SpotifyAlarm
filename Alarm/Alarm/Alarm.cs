﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm
{
    public class Alarm
    {
        private DateTime alarmTime;
        private IMusicProvider musicProvider;
        public Alarm(IMusicProvider musicProvider, DateTime alarmTime)
        {
            this.musicProvider = musicProvider;
            this.alarmTime = alarmTime;
        }

        //Event til at styre hvornår den er færdig

    }
}
