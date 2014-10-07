using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm
{
    public interface IMusicProvider
    {
        void Play();
        void Play(string song);
        void Pause();
        void AddToQueue(string song);
    }
}
