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
        
        private const string TWIP_KEY = "PBvNXmw5qp";
        private const string TOONATION_KEY = "f07544f8835c57c908763ae409bb2bb2";

        public TimerForm()
        {
            InitializeComponent();
        }

        private async void TimerForm_Load(object sender, EventArgs e)
        {
            Twip twip = new Twip();
            Toonation toonation = new Toonation();

            twip.onDonate += new EventHandler<Donate>(OnDonate);
            toonation.onDonate += new EventHandler<Donate>(OnDonate);

            await twip.Init(TWIP_KEY);
            await toonation.Init(TOONATION_KEY);
        }

        void OnDonate(object sender, Donate e)
        {
            Console.WriteLine(e.id);
            Console.WriteLine(e.nickname);
            Console.WriteLine(e.comment);
            Console.WriteLine(e.amount);
            Console.WriteLine(e.platform);
        }
    }
}
