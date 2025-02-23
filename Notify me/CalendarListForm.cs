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
    public partial class CalendarListForm : Form
    {
        CSV csv;
        HomeForm homeForm;
        public CalendarListForm(HomeForm homeForm)
        {
            InitializeComponent();
            this.csv = homeForm.csv;
            this.homeForm = homeForm;
        }

        private void CalendarsListForm_Load(object sender, EventArgs e)
        {
            //add Calendars from the Notifier List to the Bell dataGridView
            foreach (INotifier item in csv.list)
            {
                if (item is Calendar)
                {
                    Calendar calendar = (Calendar)item;
                    calendarDataGridView.Rows.Add(
                        calendar.GetID(),
                        calendar.name,
                        calendar.datetime,
                        calendar.monthly.ToString(),
                        calendar.descreption
                    );

                }
            }
        }

        public void UpdateCalendar(string id, string name, string date, bool monthly, string descreption)
        {
            foreach (DataGridViewRow item in calendarDataGridView.Rows)
            {
                if (item.Cells[0].Value.ToString() == id)
                {
                    item.Cells[1].Value = name;
                    item.Cells[2].Value = date;
                    item.Cells[3].Value = monthly.ToString();
                    item.Cells[4].Value = descreption;
                }
            }
            //find the calendar in the list that has the same id as the one passed in the params
            //the return value will be INotifier so i cast it to Calendar type
            Calendar calendar = ((Calendar)csv.list.Find(x => x.GetID().ToString() == id));
            calendar.name = name;
            calendar.datetime = date;
            calendar.monthly = monthly;
            calendar.descreption = descreption;

            csv.Save();
        }

        public void AddCalendar(string name, string datetime, bool monthly, string descreption)
        {

            Calendar calendar = new Calendar(
                name,
                datetime,
                monthly,
                descreption
            );


            calendarDataGridView.Rows.Add(
                calendar.GetID(),
                name,
                datetime,
                monthly,
                descreption
            );


            csv.list.Add(calendar);

            csv.Save();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            homeForm.Appear = true;
            homeForm.Location = this.Location;
            homeForm.Focus();
            Close();
        }

        private void updateCalendarButton_Click(object sender, EventArgs e)
        {
            if (calendarDataGridView.SelectedRows.Count != 1)
                return;

            DataGridViewRow item = calendarDataGridView.SelectedRows[0];

            new CalendarDataForm(this, item).Show();
            Enabled = false;
        }

        private void addCalendarButton_Click(object sender, EventArgs e)
        {
            new CalendarDataForm(this).Show();
            this.Enabled = false;
        }

        private void deleteCalendarButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in calendarDataGridView.SelectedRows)
            {
                //find the selected item in the Notifier List using the Find() function in the nested call
                //and then remove it from the list using the Remove() functuon
                //both function accept callback function (callback function here in arrow syntax)
                csv.list.Remove(csv.list.Find((x) => x.GetID() == int.Parse(item.Cells[0].Value.ToString())));
                calendarDataGridView.Rows.Remove(item);
            }
            csv.Save();
        }
    }
}

