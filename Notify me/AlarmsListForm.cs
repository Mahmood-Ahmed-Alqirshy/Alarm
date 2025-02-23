using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notify_me
{
    public partial class AlarmsListForm : Form
    {
        public CSV csv;
        HomeForm homeForm;
        public AlarmsListForm(HomeForm homeForm)
        {
            InitializeComponent();
            this.csv = homeForm.csv;
            this.homeForm = homeForm;
        }

        private void AlarmsListForm_Load(object sender, EventArgs e)
        {
            //add Alarms from the Notifier List to the Alarm dataGridView
            foreach (INotifier item in csv.list)
            {
                if (item is Alarm)
                {
                    Alarm alarm = (Alarm)item;
                    alarmsDataGridView.Rows.Add(
                        alarm.GetID(),
                        alarm.name,
                        alarm.time,
                        alarm.descreption
                    );
                }
            }
        }

        private void addAlarmButton_Click(object sender, EventArgs e)
        {
            new AlarmDataForm(this).Show();
            this.Enabled = false;

        }

        private void deleteAlarmButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in alarmsDataGridView.SelectedRows)
            {
                //find the selected item in the Notifier List using the Find() function in the nested call
                //and then remove it from the list using the Remove() functuon
                //both function accept callback function (callback function here in arrow syntax)
                csv.list.Remove(csv.list.Find((x) => x.GetID() == int.Parse(item.Cells[0].Value.ToString())));
                alarmsDataGridView.Rows.Remove(item);
            }
            csv.Save();
        }

        public void AddAlarm(string name, string time, string[] days, string descreption)
        {
            Alarm alarm = new Alarm(
                name,
                time,
                days,
                descreption
            );

            alarmsDataGridView.Rows.Add(
                alarm.GetID(),
                name,
                time,
                descreption
            );

            csv.list.Add(alarm);

            csv.Save();
        }

        public void UpdateAlarm(string id, string name, string time, string[] days, string descreption)
        {
            foreach (DataGridViewRow item in alarmsDataGridView.Rows)
            {
                if (item.Cells[0].Value.ToString() == id)
                {
                    item.Cells[1].Value = name;
                    item.Cells[2].Value = time;
                    item.Cells[3].Value = descreption;
                }
            }

            //find the alarm in the list that has the same id as the one passed in the params
            //the return value will be INotifier so i cast it to Alarm type
            Alarm alarm = (Alarm)csv.list.Find(x => x.GetID().ToString() == id);
            alarm.name = name;
            alarm.time = time;
            alarm.days = days;
            alarm.descreption = descreption;

            csv.Save();
        }

        private void UpdateAlarmButton_Click(object sender, EventArgs e)
        {
            if (alarmsDataGridView.SelectedRows.Count != 1)
                return;

            DataGridViewRow item = alarmsDataGridView.SelectedRows[0];

            new AlarmDataForm(this, item).Show();
            Enabled = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            homeForm.Appear = true;
            homeForm.Location = this.Location;
            homeForm.Focus();
            Close();
        }
    }
}
