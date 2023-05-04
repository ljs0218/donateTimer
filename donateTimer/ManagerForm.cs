﻿using System;
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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            TimeController.GetInstance().StartTimer();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            TimeController.GetInstance().StopTimer();
        }
    }
}
