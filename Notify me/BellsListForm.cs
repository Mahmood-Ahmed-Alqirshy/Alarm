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
    public partial class BellsListForm : Form
    {
        CSV csv;
        HomeForm homeForm;
        public BellsListForm(HomeForm homeForm)
        {
            InitializeComponent();
            this.csv = homeForm.csv;
            this.homeForm = homeForm;
        }

        private void BellsListForm_Load(object sender, EventArgs e)
        {
            //add Bells from the Notifier List to the Bell dataGridView
            foreach (INotifier item in csv.list)
            {
                if (item is Bell)
                {

                    Bell bell = (Bell)item;
                    bellsDataGridView.Rows.Add(
                        bell.GetID(),
                        bell.name,
                        bell.interval,
                        bell.cooldown,
                        bell.descreption
                    );

                }
            }
        }

        private void UpdateBellButton_Click(object sender, EventArgs e)
        {
            if (bellsDataGridView.SelectedRows.Count != 1)
                return;

            DataGridViewRow item = bellsDataGridView.SelectedRows[0];

            new BellDataForm(this, item).Show();
            Enabled = false;
        }

        public void UpdateBell(string id, string name, int interval, int cooldown, string descreption)
        {
            foreach (DataGridViewRow item in bellsDataGridView.Rows)
            {
                if (item.Cells[0].Value.ToString() == id)
                {
                    item.Cells[1].Value = name;
                    item.Cells[2].Value = interval.ToString();
                    item.Cells[3].Value = cooldown.ToString();
                    item.Cells[4].Value = descreption;
                }
            }
            //find the bell in the list that has the same id as the one passed in the params
            //the return value will be INotifier so i cast it to Bell type
            Bell bell = ((Bell)csv.list.Find(x => x.GetID().ToString() == id));
            bell.name = name;
            bell.interval = interval;
            bell.cooldown = cooldown;
            bell.descreption = descreption;
            bell.timer = interval * Bell.MIN;

            csv.Save();
        }

        public void AddBell(string name, int interval, int cooldown, string descreption)
        {
            //make new bell object
            Bell bell = new Bell(
                name,
                interval,
                cooldown,
                descreption
            );

            //add bell to the grid view
            bellsDataGridView.Rows.Add(
                bell.GetID(),
                name,
                interval,
                cooldown,
                descreption
            );

            //add it to the list
            csv.list.Add(bell);
            //save the new list in CSV format in file
            csv.Save();
        }

        private void addBellButton_Click(object sender, EventArgs e)
        {
            new BellDataForm(this).Show();
            this.Enabled = false;
        }

        private void deleteBellButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in bellsDataGridView.SelectedRows)
            {
                //find the selected item in the Notifier List using the Find() function in the nested call
                //and then remove it from the list using the Remove() functuon
                //both function accept callback function (callback function here in arrow syntax)
                csv.list.Remove(csv.list.Find((x) => x.GetID() == int.Parse(item.Cells[0].Value.ToString())));
                bellsDataGridView.Rows.Remove(item);
            }
            csv.Save();
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

