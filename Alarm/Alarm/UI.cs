using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alarm.SystemTray;

namespace Alarm
{
    public class UI
    {
        public UI()
        {
            loadConsoleSettings();
        }

        private void loadConsoleSettings()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
        }
    }
}
