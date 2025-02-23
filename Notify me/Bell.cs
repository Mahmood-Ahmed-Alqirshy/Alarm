using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notify_me
{
    public class Bell : INotifier
    {
        public int id;
        public string name;
        public int interval;
        //the amount of cooldwon
        public int cooldown = 1;
        public string descreption;
        //after the bell ring it will enter cooldown state before it start count time again
        bool isInCooldown = false;

        public const int MIN = 60;
        public int timer;

        public Bell(string CSV)
        {
            this.id = INotifier.IDCounter++;
            string[] data = CSV.Split(',');
            this.name = data[1];
            this.interval = int.Parse(data[2]);
            this.cooldown = int.Parse(data[3]);
            this.descreption = data[4];
            timer = this.interval * MIN;
        }

        public Bell(string name, int interval, int cooldown, string descreption)
        {
            this.id = INotifier.IDCounter++;
            this.name = name;
            this.interval = interval;
            this.cooldown = cooldown;
            this.descreption = descreption;
            timer = this.interval * MIN;
        }

        public int GetID()
        {
            return id;
        }

        public bool isOnTime()
        {
            if(--timer <= 0)
            {
                if(isInCooldown)
                {
                    isInCooldown = false;
                    timer = interval * MIN;
                }
                else
                {
                    isInCooldown = true;
                    timer = cooldown * MIN;
                }
                return true;
            }
            return false;
        }

        public void notify(NotifyIcon notifyIcon)
        {
            //will be here after isOnTime() so the isInCooldown will be switched
            if (isInCooldown)
                notifyIcon.ShowBalloonTip(5000, name, descreption, ToolTipIcon.Info);
            else
                notifyIcon.ShowBalloonTip(5000, name, "cooldown is finshed", ToolTipIcon.Info);

        }

        public string ToCSV()
        {
            return string.Join(',',  new string[] { "Bell", name, interval.ToString(), cooldown.ToString(), descreption });
        }


    }
}
