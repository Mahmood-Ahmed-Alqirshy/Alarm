using notify_me;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notify_me
{
    public partial class CalendarDataForm : Form
    {
        string role = "Update";
        CalendarListForm calendarDataForm;
        DataGridViewRow row;
        public CalendarDataForm(CalendarListForm calendarDataForm)
        {
            InitializeComponent();
            this.role = "Add";
            this.calendarDataForm = calendarDataForm;
        }

        public CalendarDataForm(CalendarListForm calendarDataForm, DataGridViewRow row)
        {
            InitializeComponent();
            this.calendarDataForm = calendarDataForm;
            this.row = row;
        }

        private void CalendarDataForm_Load(object sender, EventArgs e)
        {
            //add row data to the field if the role is update
            if (role == "Update")
            {
                //decide the correct format base on user choice
                string datetimeFormat = ((bool.Parse(row.Cells[3].Value.ToString())) ? "dd tt hh:mm" : "dd/MM tt hh:mm");

                calendarNameTextBox.Text = row.Cells[1].Value.ToString();
                calendarDateTimePicker.Value = DateTime.ParseExact(row.Cells[2].Value.ToString(), datetimeFormat, null);
                MonthlyCheckBox.Checked = bool.Parse(row.Cells[3].Value.ToString());
                calendarDescreptionTextBox.Text = row.Cells[4].Value.ToString();
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (calendarNameTextBox.Text == "" || calendarDescreptionTextBox.Text == "")
                return;

            string datetimeFormat = ((MonthlyCheckBox.Checked) ? "dd tt hh:mm" : "dd/MM tt hh:mm");
            if (role == "Add")
            {
                calendarDataForm.AddCalendar(calendarNameTextBox.Text, calendarDateTimePicker.Value.ToString(datetimeFormat), MonthlyCheckBox.Checked, calendarDescreptionTextBox.Text);
                calendarDataForm.Enabled = true;
                Close();
            }
            else
            {
                calendarDataForm.UpdateCalendar(row.Cells[0].Value.ToString(), calendarNameTextBox.Text, calendarDateTimePicker.Value.ToString(datetimeFormat), MonthlyCheckBox.Checked, calendarDescreptionTextBox.Text);
                calendarDataForm.Enabled = true;
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            calendarDataForm.Enabled = true;
            Close();
        }

        private void descreptionBorder_Click(object sender, EventArgs e)
        {
            calendarDescreptionTextBox.Focus();
        }

        private void nameBorder_Click(object sender, EventArgs e)
        {
            calendarNameTextBox.Focus();
        }

        private void MonthlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //decide the correct format base on user choice
            if (MonthlyCheckBox.Checked) 
            {
                calendarDateTimePicker.CustomFormat = "dd tt hh:mm";
            }
            else 
            {
                calendarDateTimePicker.CustomFormat = "dd/MM tt hh:mm";
            }
        }
    }
}
