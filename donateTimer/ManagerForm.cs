using System;
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

        private void addWonBtn_Click(object sender, EventArgs e)
        {
            if (IsNumeric(addWonBox.Text)) {
                int value = int.Parse(addWonBox.Text);

                Donate donate = new Donate();
                donate.id = "admin";
                donate.nickname = "admin";
                donate.comment = "테스트입니다. 추가";
                donate.amount = value;
                donate.platform = Platform.Admin;

                TimeController.GetInstance().Donate(donate);
            }
        }

        private void subWonBtn_Click(object sender, EventArgs e)
        {
            if (IsNumeric(subWonBox.Text))
            {
                int value = int.Parse(subWonBox.Text);

                Donate donate = new Donate();
                donate.id = "admin";
                donate.nickname = "admin";
                donate.comment = "테스트입니다. 삭감";
                donate.amount = value;
                donate.platform = Platform.Admin;

                TimeController.GetInstance().Donate(donate);
            }
        }

        bool IsNumeric(string value)
        {
            if (value == string.Empty) return false;
            return value.All(char.IsNumber);
        }

        private void addMinutesBtn_Click(object sender, EventArgs e)
        {
            if (IsNumeric(addMinutesBox.Text))
            {
                int value = int.Parse(addMinutesBox.Text);

                Donate donate = new Donate();
                donate.id = "admin";
                donate.nickname = "admin";
                donate.comment = "테스트입니다. 추가";
                donate.amount = MinutesToWon(value);
                donate.platform = Platform.Admin;

                TimeController.GetInstance().Donate(donate);
            }
        }

        private void subMinutesBtn_Click(object sender, EventArgs e)
        {
            if (IsNumeric(subMinutesBox.Text))
            {
                int value = int.Parse(subMinutesBox.Text);

                Donate donate = new Donate();
                donate.id = "admin";
                donate.nickname = "admin";
                donate.comment = "테스트입니다. 삭감";
                donate.amount = MinutesToWon(value);
                donate.platform = Platform.Admin;

                TimeController.GetInstance().Donate(donate);
            }
        }

        int MinutesToWon(int minutes)
        {
            return minutes * TimeController.GetInstance().option.minFromWon;
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            new SettingForm().ShowDialog();
        }

        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
