using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public class ProcessIcon : IDisposable
    {
        private NotifyIcon notifyIcon;
        public ProcessIcon()
        {
            this.notifyIcon = new NotifyIcon();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
