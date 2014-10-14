using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MusicAlarm.SystemTray;
using System.Windows.Forms;

namespace MusicAlarm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            using (ProcessIcon processIcon = new ProcessIcon())
            {
                processIcon.Display();
                UI ui = new UI();
                Application.Run();
            }
        }
    }
}
