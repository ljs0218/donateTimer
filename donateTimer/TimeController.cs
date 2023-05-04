using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace donateTimer
{
    public class TimeController
    {
        public TimeSpan nowTime = new TimeSpan(1000, 0, 0);
        public int minFromWon = 100;

        private long previousTick;
        private bool isRunning;
        private Stopwatch sw = new Stopwatch();

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
            previousTick = sw.ElapsedMilliseconds;
            isRunning = true;
            sw.Start();
            RefreshTime();
        }

        public void StopTimer()
        {
            isRunning = false;
            sw.Stop();
        }

        async void RefreshTime()
        {
            while (isRunning)
            {
                long currentTime = sw.ElapsedMilliseconds;
                long deltaTick = currentTime - previousTick;

                nowTime -= TimeSpan.FromMilliseconds(deltaTick);
                previousTick = currentTime;
                await Task.Delay(10);
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

        public void AddDonate(Donate donate)
        {
            long mills = ((donate.amount / minFromWon) * 60) * 1000;
            AddTimeFromMilliseconds(mills);
        }

        public void SubDonate(Donate donate)
        {
            long mills = ((donate.amount / minFromWon) * 60) * 1000;
            SubTimeFromMilliseconds(mills);
        }
    }
}
