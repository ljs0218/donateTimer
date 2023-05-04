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
    public partial class MainForm : Form
    {
        //private const string TWIP_KEY = "4bYpPmP5zXp";
        //private const string TOONATION_KEY = "5ea3ea50ab1a9fb06e990a0a2d84ac4f";

        //private const string TWIP_KEY = "PBvNXmw5qp";
        //private const string TOONATION_KEY = "f07544f8835c57c908763ae409bb2bb2";

        private bool isConnectTwip = false;
        private bool isConnectToonation = false;

        Twip twip;
        Toonation toonation;

        public MainForm()
        {
            InitializeComponent();
        }

        private async void twipConnectBtn_Click(object sender, EventArgs e)
        {
            twip = new Twip();
            twip.onConnectSuccess += new EventHandler(OnConnectSuccessTwip);
            twip.onConnectFailed += new EventHandler(OnConnectFailedTwip);
            await twip.Init(twipBox.Text);
        }

        private async void toonationConnectBtn_Click(object sender, EventArgs e)
        {
            toonation = new Toonation();
            toonation.onConnectSuccess += new EventHandler(OnConnectSuccessToonation);
            toonation.onConnectFailed += new EventHandler(OnConnectFailedToonation);
            await toonation.Init(toonationBox.Text);

        }

        void OnConnectSuccessTwip(object sender, EventArgs e)
        {
            isConnectTwip = true;
            twipConnectBtn.Enabled = false;
            twip.onDonate += new EventHandler<Donate>(OnDonate);

            string[] accounts = FileController.LoadAccountData();
            accounts[0] = twipBox.Text;
            FileController.SaveAccountData(accounts);

            CheckConnect();
        }

        void OnConnectSuccessToonation(object sender, EventArgs e)
        {
            isConnectToonation = true;
            toonationConnectBtn.Enabled = false;
            toonation.onDonate += new EventHandler<Donate>(OnDonate);

            string[] accounts = FileController.LoadAccountData();
            accounts[1] = toonationBox.Text;
            FileController.SaveAccountData(accounts);

            CheckConnect();
        }

        void OnConnectFailedTwip(object sender, EventArgs e)
        {
            Console.WriteLine("Error");
        }

        void OnConnectFailedToonation(object sender, EventArgs e)
        {
            Console.WriteLine("Error");
        }

        void CheckConnect()
        {
            if (isConnectTwip && isConnectToonation)
            {
                new ManagerForm().Show();
                new TimerForm().Show();
                Close();
                return;
            }
        }

        void OnDonate(object sender, Donate e)
        {
            TimeController.GetInstance().Donate(e);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TimeController.GetInstance().option = FileController.LoadOptionData();
            string[] accounts = FileController.LoadAccountData();
            if (accounts.Length > 1)
            {
                twipBox.Text = accounts[0];
                toonationBox.Text = accounts[1];
            }
        }
    }
}
