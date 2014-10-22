using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicAlarm.SystemTray
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
            notifyIcon.MouseClick += notifyIcon_MouseClick;
            notifyIcon.Icon = Icon.FromHandle( Resources.alarm_icon.GetHicon());
            notifyIcon.Visible = true;
            notifyIcon.ContextMenuStrip = new ContextMenus().Create();
        }

        void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MusicAlarm.GUI.MainForm form = new GUI.MainForm();
                form.Show();
            }
        }

        public void Dispose()
        {
            notifyIcon.Dispose();
        }
    }
}
