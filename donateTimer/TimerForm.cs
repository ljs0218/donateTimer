using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace donateTimer
{
    public partial class TimerForm : Form
    {
        private const string TIME_FORMAT = "{0}:{1:D2}:{2:D2}.{3:D3}";

        public TimerForm()
        {
            InitializeComponent();
        }

        private void TimerForm_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan time = TimeController.GetInstance().nowTime;
            timeLabel.Text = string.Format(TIME_FORMAT, (int)time.TotalHours, time.Minutes, time.Seconds, time.Milliseconds);
        }
    }
}
