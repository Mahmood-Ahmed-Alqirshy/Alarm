using Notify_me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace notify_me
{
    class Calendar : INotifier
    {
        int id;
        public string name;
        public string datetime;
        public string descreption;
        private bool ringed = false;
        //wather the calendar will alart monthly of yearly
        public bool monthly = false;

        public Calendar(string csv)
        {
            this.id = INotifier.IDCounter++;
            string[] data = csv.Split(',');
            this.name = data[1];
            this.datetime = data[2];
            this.monthly = bool.Parse(data[3]);
            this.descreption = data[4];
        }

        public Calendar(string name, string datetime, bool monthly, string descreption)
        {
            this.id = INotifier.IDCounter++;
            this.name = name;
            this.datetime = datetime;
            this.monthly = monthly;
            this.descreption = descreption;
        }

        public int GetID()
        {
            return id;
        }

        public bool isOnTime()
        {
            if (ringed)
                return false;

            if(monthly)
            {
                if (DateTime.Now.ToString("dd tt hh:mm") == datetime)
                    return true;
            } 
            else
            {
                if (DateTime.Now.ToString("dd/MM tt hh:mm") == datetime)
                    return true;
            }
            
            return false;
        }

        public void notify(NotifyIcon notifyIcon)
        {
            ringed = true;
            notifyIcon.ShowBalloonTip(5000, name, descreption, ToolTipIcon.Info);
            new AlartForm(name, datetime, descreption).Show();
        }

        public string ToCSV()
        {
            return string.Join(',', new string[] { "Calendar", name, datetime, monthly.ToString(), descreption });
        }
    }
}
