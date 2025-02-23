using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Notify_me;

namespace notify_me
{
    public partial class HomeForm : Form
    {

        //list contain all Notifier : Bells, Alarms and Calendars
        List<INotifier> notifiers = new List<INotifier>();

        //maintain the logic of saving and retriving the data from and to file
        public CSV csv;

        //lock and unlock the ablity of showing the form
        public bool appearUnlock = true;

        //control the showing and hiding of the form by simple boolean variable
        bool appear;
        public bool Appear
        {
            get { return appear; }
            set
            {
                if (value && appearUnlock)
                {
                    Show();
                    ShowInTaskbar = true;
                }
                else
                {
                    ShowInTaskbar = false;
                    Hide();
                }
                appear = (value && appearUnlock);
            }
        }

        public HomeForm()
        {
            InitializeComponent();
            csv = new CSV(notifiers, Application.StartupPath + "Notifiers.txt");
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            new Login(this).Show();
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            this.Appear = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            foreach (INotifier item in notifiers)
            {
                if (item.isOnTime())
                {
                    item.notify(notifyIcon);
                }
            }
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dialogResult = MessageBox.Show("No will only hide the app and it will keep it running for you", "Do you want to close the app", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        break;
                    case DialogResult.No:
                        e.Cancel = true;
                        this.Appear = false;
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void bells_MouseHover(object sender, EventArgs e)
        {
            logoImage.Image = Image.FromFile("C:\\Users\\Mahmod Ahmed\\source\\repos\\proj\\Notify me-1\\Notify me\\Notify me\\Image\\alarm.png");
            infoLabel.Text = "ring in time";
        }

        private void alarms_MouseHover(object sender, EventArgs e)
        {
            logoImage.Image = Image.FromFile("C:\\Users\\Mahmod Ahmed\\source\\repos\\proj\\Notify me-1\\Notify me\\Notify me\\Image\\bell.png");
            infoLabel.Text = "ring every some mins";
        }

        private void calendar_MouseHover(object sender, EventArgs e)
        {
            logoImage.Image = Image.FromFile("C:\\Users\\Mahmod Ahmed\\source\\repos\\proj\\Notify me-1\\Notify me\\Notify me\\Image\\calendar.png");
            infoLabel.Text = "ring in date";
        }

        private void setting_click(object sender, EventArgs e)
        {
            Enabled = false;
            new SettingForm(this).Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bells_Click(object sender, EventArgs e)
        {

            BellsListForm list = new BellsListForm(this);
            list.Show();
            list.Location = this.Location;
            Appear = false;
        }

        private void alarms_Click(object sender, EventArgs e)
        {
            AlarmsListForm list = new AlarmsListForm(this);
            list.Show();
            list.Location = this.Location;
            Appear = false;
        }

        private void calenders_Click(object sender, EventArgs e)
        {
            CalendarListForm list = new CalendarListForm(this);
            list.Show();
            list.Location = this.Location;
            Appear = false;
        }
    }
}
