using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace notify_me
{
    public interface INotifier
    {
        static int IDCounter = 1;

        int GetID();

        //return true if it is the time for the Notifier to ring
        bool isOnTime();

        //ring the Notifier
        void notify(NotifyIcon notifyIcon);

        //convert Notifier object to CSV format
        string ToCSV();

    }
}
