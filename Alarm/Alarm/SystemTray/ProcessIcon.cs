using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm.SystemTray
{
    public class ProcessIcon : IDisposable
    {
        private NotifyIcon notifyIcon;
        public ProcessIcon()
        {
            this.notifyIcon = new NotifyIcon();
        }

        public void Display()
        {
            notifyIcon.Icon = Icon.FromHandle( Resources.alarm_icon.GetHicon());
            notifyIcon.Visible = true;
            notifyIcon.ContextMenuStrip = new ContextMenus().Create();
        }

        public void Dispose()
        {
            notifyIcon.Dispose();
        }
    }
}
