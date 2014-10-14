using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private void loadSystemTraySettings()
        {
            
        }
    }
}
