using Notify_me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notify_me
{
    public class Alarm : INotifier
    {
        public int id;
        public string name;
        public string time;
        public string descreption;
        //to make shor the alarm ring once in a second
        private bool ringed = false;
        public string[] days;

        private const int MIN = 1;
        public int timer;

        //create object by parsing csv line
        public Alarm(string CSV)
        {
            this.id = INotifier.IDCounter++;
            string[] data = CSV.Split(',');
            this.name = data[1];
            this.time = data[2];
            this.days = data[3].Split("|");
            this.descreption = data[4];
        }

        public Alarm(string name, string time, string[] days, string descreption)
        {
            this.id = INotifier.IDCounter++;
            this.name = name;
            this.time = time;
            this.days = days;
            this.descreption = descreption;
        }

        public int GetID()
        {
            return id;
        }

        
        public bool isOnTime()
        {
            if(ringed)
                return false;

            if (days.Contains(DateTime.Now.ToString("dddd")) && DateTime.Now.ToString("tt hh:mm") == time)
                return true;
            else
                return false;
        }

        public void notify(NotifyIcon notifyIcon)
        {
            ringed = true;
            notifyIcon.ShowBalloonTip(5000, name, descreption, ToolTipIcon.Info);
            new AlartForm(name, time, descreption).Show();
        }

        public string ToCSV()
        {
            return string.Join(',', new string[] { "Alarm", name, time, string.Join('|', days), descreption });
        }
    }
}
