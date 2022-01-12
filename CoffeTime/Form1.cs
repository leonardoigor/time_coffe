using CoffeTime.Progress;
using CoffeTime.Time;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeTime
{
    public partial class Hora : Form
    {
        public Hora()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private Task Progressdata(List<string> list, IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalProgress = list.Count;
            var progressReport = new ProgressReport();

            return Task.Run(() =>
            {

                for (int i = 0; i < totalProgress; i++)
                {
                    progressReport.PerentComplete = index++ * 100 / totalProgress;
                    // index++;
                    progress.Report(progressReport);
                    Thread.Sleep(10);
                }
            });
        }

        private void button1_ClickAsync(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < 100; i++)
            {
                list.Add(i.ToString());
                // Console.WriteLine(i);
            }
            var progress = new Progress<ProgressReport>();
            var timeCountOut = new TimeCountOut(15, 30, 0);
            var _hour = new Label();
            timeCountOut.Start(() =>
            {
                setTxt(timeCountOut);

                return 0;
            });


            progress.ProgressChanged += (o, report) =>
            {
                progressBar1.Value = report.PerentComplete;
                // Console.WriteLine(string.Format("{0}%", report.PerentComplete));
                // label1.Text = report.PerentComplete.ToString();
                progressBar1.Update();

            };
            // await Progressdata(list, progress);
            var progressReport = new ProgressReport();

            var th1 = new Thread(() => c(progress, timeCountOut));
            th1.Start();
            Console.WriteLine("Done");

        }

        private void c(IProgress<ProgressReport> report, TimeCountOut timeCountOut)
        {
            var progressReport = new ProgressReport();
            while (true)
            {
                progressReport.PerentComplete = timeCountOut.percentComplete;
                report.Report(progressReport);
                Console.WriteLine(timeCountOut.percentComplete);
                Thread.Sleep(10);
            }
        }
        private void setTxt(TimeCountOut timeCountOut)
        {

            if (hour.InvokeRequired)
            {
                hour.Invoke((MethodInvoker)delegate
                {
                    hour.Text = string.Format("Hora: {0}", timeCountOut.diffHours);
                    hour.Refresh();
                });
            }
            else
            {
                hour.Text = string.Format("Hora: {0}", timeCountOut.diffHours);
                hour.Refresh();
            }
            if (minute.InvokeRequired)
            {
                minute.Invoke((MethodInvoker)delegate
                {
                    minute.Text = string.Format("Minutos: {0}", timeCountOut.diffMinutes);
                    minute.Refresh();
                });
            }
            else
            {
                minute.Text = string.Format("Minutos: {0}", timeCountOut.diffMinutes);
                minute.Refresh();
            }

            if (second.InvokeRequired)
            {
                second.Invoke((MethodInvoker)delegate
                {
                    second.Text = string.Format("Segundos: {0}", timeCountOut.diffSeconds);
                    second.Refresh();
                });
            }
            else
            {
                second.Text = string.Format("Segundos: {0}", timeCountOut.diffSeconds);
                second.Refresh();
            }
            if (mili.InvokeRequired)
            {
                mili.Invoke((MethodInvoker)delegate
                {
                    mili.Text = string.Format("Milisegundos: {0}", timeCountOut.diffMilliseconds);
                    mili.Refresh();
                });
            }
            else
            {
                mili.Text = string.Format("Milisegundos: {0}", timeCountOut.diffMilliseconds);
                mili.Refresh();
            }
            if (percentLabel.InvokeRequired)
            {
                percentLabel.Invoke((MethodInvoker)delegate
                {
                    percentLabel.Text = string.Format("{0}%", timeCountOut.percentComplete);
                    percentLabel.Refresh();
                });
            }
            else
            {
                percentLabel.Text = string.Format("{0}%", timeCountOut.percentComplete);
                percentLabel.Refresh();
            }

        }

        private void Hora_Load(object sender, EventArgs e)
        {
            hour.Text = string.Format("Hora: {0}", DateTime.Now.ToString("HH"));
            hour.Refresh();
            minute.Text = string.Format("Minuto: {0}", DateTime.Now.ToString("mm"));
            minute.Refresh();
            second.Text = string.Format("Secondo: {0}", DateTime.Now.ToString("ss"));
            second.Refresh();
            mili.Text = string.Format("MiliSegundo: {0}", DateTime.Now.ToString("ss"));
            mili.Refresh();
        }
    }
}
