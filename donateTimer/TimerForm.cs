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
        //private const string TWIP_KEY = "4bYpPmP5zXp";
        //private const string TOONATION_KEY = "5ea3ea50ab1a9fb06e990a0a2d84ac4f";
        
        private const string TWIP_KEY = "4bYpPmP5zXp";
        private const string TOONATION_KEY = "5ea3ea50ab1a9fb06e990a0a2d84ac4f";

        public TimerForm()
        {
            InitializeComponent();
        }

        private async void TimerForm_Load(object sender, EventArgs e)
        {
            Twip catcher = new Twip();


            catcher.onDonate += new EventHandler<Donate>(btn_Click);
            await catcher.Begin(TWIP_KEY);
        }

        void btn_Click(object sender, Donate e)
        {
            MessageBox.Show("Button 클릭");
        }
    }
}
