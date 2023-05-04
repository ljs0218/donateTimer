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
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Option data = FileController.LoadOptionData();
            data.minFromWon = int.Parse(comboBox1.Text);
            data.selectedIndex = comboBox1.SelectedIndex;
            FileController.SaveOptionData(data);
            TimeController.GetInstance().option.minFromWon = int.Parse(comboBox1.Text);
        }

        private void addChecked_CheckedChanged(object sender, EventArgs e)
        {
            Option data = FileController.LoadOptionData();
            data.addChecked = addChecked.Checked;
            FileController.SaveOptionData(data);
        }

        private void subChecked_CheckedChanged(object sender, EventArgs e)
        {
            Option data = FileController.LoadOptionData();
            data.subChecked = subChecked.Checked;
            FileController.SaveOptionData(data);
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            Option data = FileController.LoadOptionData();
            comboBox1.SelectedIndex = data.selectedIndex;
            addChecked.Checked = data.addChecked;
            subChecked.Checked = data.subChecked;
        }
    }
}
