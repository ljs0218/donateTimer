using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace donateTimer
{
    public class TimeController
    {
        public TimeSpan nowTime = new TimeSpan(24, 0, 0);
        public Option option = new Option();
        public Label label;

        private Stopwatch stopwatch = new Stopwatch();

        private const string ADD_MESSAGE = "추가";
        private const string SUB_MESSAGE = "삭감";

        private static TimeController instance;
        public static TimeController GetInstance()
        {
            if (instance == null)
            {
                instance = new TimeController();
            }
            return instance;
        }

        public void StartTimer()
        {
            stopwatch.Start();
        }

        public void StopTimer()
        {
            stopwatch.Stop();
        }

        long lastTick = 0;
        public void Update()
        {
            long currentTick = stopwatch.ElapsedMilliseconds;
            int elapsedTick = (int)(currentTick - this.lastTick);
            this.lastTick = currentTick;
            nowTime = nowTime.Subtract(new TimeSpan(0, 0, 0, 0, elapsedTick));
            if (nowTime.Milliseconds < 0)
            {
                nowTime = new TimeSpan(0, 0, 0, 0, 0);
                stopwatch.Stop();
            }
        }

        public void AddTimeFromMilliseconds(long milliseconds)
        {
            nowTime = nowTime.Add(TimeSpan.FromMilliseconds(milliseconds));
        }

        public void SubTimeFromMilliseconds(long milliseconds)
        {
            nowTime = nowTime.Subtract(TimeSpan.FromMilliseconds(milliseconds));
        }

        public void Donate(Donate donate)
        {
            if (donate.nickname.Contains(ADD_MESSAGE) || donate.comment.Contains(ADD_MESSAGE))
            {
                donate.type = Type.Add;
            }
            else if (donate.nickname.Contains(SUB_MESSAGE) || donate.comment.Contains(SUB_MESSAGE))
            {
                donate.type = Type.Sub;
            }
            else
            {
                return;
            }

            long mills = ((donate.amount / option.minFromWon) * 60) * 1000;
            switch (donate.type)
            {
                case Type.Add:
                    if (option.addChecked || donate.platform == Platform.Admin)
                        AddTimeFromMilliseconds(mills);
                    break;

                case Type.Sub:
                    if (option.subChecked || donate.platform == Platform.Admin)
                        SubTimeFromMilliseconds(mills);
                    break;

                default: break;

            }
            ChangeLabelColor(donate.type);
        }

        CancellationTokenSource cts = null;
        Task myTask2;

        void ChangeLabelColor(Type type)
        {
            if (myTask2 != null && cts != null)
            {
                cts.Cancel();
            }

            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;
            myTask2 = Task<int>.Run(() =>
            {
                token.ThrowIfCancellationRequested();
                Color color = new Color();
                switch (type)
                {
                    case Type.Add:
                        color = Color.Green;
                        break;

                    case Type.Sub:
                        color = Color.Red;
                        break;

                    default: break;
                }
                label.ForeColor = color;
                Thread.Sleep(2000);
                token.ThrowIfCancellationRequested();
                label.ForeColor = Color.Black;
            }, token);


        }

        public void SubDonate(Donate donate)
        {
            long mills = ((donate.amount / option.minFromWon) * 60) * 1000;
            SubTimeFromMilliseconds(mills);
        }
    }
}
