using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Alarm.SystemTray;

namespace Alarm
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ProcessIcon processIcon = new ProcessIcon())
            {
                processIcon.Display();
                UI ui = new UI();
                Console.ReadKey();
            }
        }
    }
}
