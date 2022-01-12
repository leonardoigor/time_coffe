using System;
using System.Threading;
using System.Threading.Tasks;

namespace CoffeTime.Time
{
    class TimeCountOut
    {
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public int diffDays { get; set; }
        public int diffHours { get; set; }
        public int diffMinutes { get; set; }
        public int diffSeconds { get; set; }
        public int diffMilliseconds { get; set; }

        public TimeSpan tsStart { get; set; }
        public TimeSpan tsEnd { get; set; }
        public int percentComplete { get; set; }
        public int TotalPercent { get; set; }

        public TimeCountOut(int hour, int min, int sec)
        {
            this.startTime = DateTime.Now;
            this.endTime = DateTime.Now;
            this.endTime = ChangeTime(this.endTime, hour, min, sec);



        }

        private DateTime ChangeTime(DateTime t, int hour, int min, int sec)
        {

            return new DateTime(t.Year, t.Month, t.Day, hour, min, sec);
        }
        public void Start(Func<int> lambda)
        {
            var thread1 = new Thread(() => Check(lambda));
            thread1.Start();
        }
        private void Check(Func<int> lambda)
        {
            while (true)
            {
                //             Console.WriteLine(string.Format("Dias {0} horas {1} minutos {2}, segundos {3} miliSegundos {4} ",
                // diffDays, diffHours, diffMinutes, diffSeconds, diffMilliseconds));
                GetTimeDiff();
                lambda();
                Thread.Sleep(100);
            }
        }

        private void GetTimeDiff()
        {
            this.startTime = DateTime.Now;
            TimeSpan ts = this.endTime - this.startTime;
            diffDays = ts.Days;
            diffHours = ts.Hours;
            diffMinutes = ts.Minutes + 1;
            diffSeconds = ts.Seconds;
            diffMilliseconds = ts.Milliseconds;


            tsStart = this.startTime.TimeOfDay;
            tsEnd = this.endTime.TimeOfDay;
            percentComplete = (int)(tsStart.TotalMilliseconds / tsEnd.TotalMilliseconds * 100);
            TotalPercent = 100;
        }
    }
}