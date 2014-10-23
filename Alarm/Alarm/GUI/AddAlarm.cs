using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicAlarm.GUI
{
    public partial class AddAlarm : UserControl
    {
        private List<Alarm> alarms;
        public AddAlarm()
        {
            this.alarms = new List<Alarm>();
            InitializeComponent();
            listBox.DataSource = alarms;
        }

        private void addAlarmButton_Click(object sender, EventArgs e)
        {
            DateTime alarmTime = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, Int32.Parse(textBoxHour.Text), Int32.Parse(textBoxMinute.Text),0,0);
            if (alarmTime > DateTime.Now)
            {
                alarms.Add(new Alarm(new SpotifyMusicPlayer(), alarmTime));
                listBox.DataSource = alarms;
            }
            else
                MessageBox.Show("Chosen alarm time is in the past!");
        }
    }
}
