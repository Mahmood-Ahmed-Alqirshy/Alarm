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
    public partial class AlarmDataForm : Form
    {
        string role = "Update";
        AlarmsListForm alarmsListForm;
        DataGridViewRow row;
        public AlarmDataForm(AlarmsListForm alarmsListForm)
        {
            InitializeComponent();
            this.role = "Add";
            this.alarmsListForm = alarmsListForm;
        }

        public AlarmDataForm(AlarmsListForm alarmsListForm, DataGridViewRow row)
        {
            InitializeComponent();
            this.alarmsListForm = alarmsListForm;
            this.row = row;
        }

        private void AlarmDataForm_Load(object sender, EventArgs e)
        {
            //add row data to the field if the role is update
            if (role == "Update")
            {
                alarmNameTextBox.Text = row.Cells[1].Value.ToString();
                alarmDateTimePicker.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                alarmDescreptionTextBox.Text = row.Cells[3].Value.ToString();

                //find the alarm in the list that has the same id as the one in the row
                //the return value will be INotifier so i cast it to Alarm type
                Alarm alarm = (Alarm)alarmsListForm.csv.list.Find((x) => x.GetID().ToString() == row.Cells[0].Value.ToString());

                //check the days ckeckboxes
                foreach (CheckBox item in daysGroupBox.Controls)
                {
                    if(alarm.days.Contains(item.Text))
                        item.Checked = true;
                }
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (alarmNameTextBox.Text == "" || alarmDescreptionTextBox.Text == "")
                return;

            //get the days names in daysList List and convert it to string array later
            List<string> daysList = new List<string>();
            foreach (CheckBox item in daysGroupBox.Controls)
            {
                if(item.Checked)
                    daysList.Add(item.Text);
            }

            if (role == "Add")
            {
                alarmsListForm.AddAlarm(alarmNameTextBox.Text, alarmDateTimePicker.Value.ToString("tt hh:mm"), daysList.ToArray(), alarmDescreptionTextBox.Text);
                alarmsListForm.Enabled = true;
                Close();
            }
            else
            {
                alarmsListForm.UpdateAlarm(row.Cells[0].Value.ToString(), alarmNameTextBox.Text, alarmDateTimePicker.Value.ToString("tt hh:mm"), daysList.ToArray(), alarmDescreptionTextBox.Text);
                alarmsListForm.Enabled = true;
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            alarmsListForm.Enabled = true;
            Close();
        }

        private void descreptionBorder_Click(object sender, EventArgs e)
        {
            alarmDescreptionTextBox.Focus();
        }

        private void nameBorder_Click(object sender, EventArgs e)
        {
            alarmNameTextBox.Focus();
        }
    }
}
