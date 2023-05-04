using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace donateTimer
{
    public partial class TimerForm : Form
    {
        private const string TIME_FORMAT = "{0:D3}:{1:mm\\:ss\\.ff}";

        public TimerForm()
        {
            InitializeComponent();
        }

        private void TimerForm_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeController.GetInstance().Update();
            TimeSpan ts = TimeController.GetInstance().nowTime;
            this.timeLabel.Text = string.Format(TIME_FORMAT, (int)ts.TotalHours, ts);
        }
    }
}
