using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notify_me
{
    public partial class BellDataForm : Form
    {
        string role = "Update";
        BellsListForm bellsListForm;
        DataGridViewRow row;
        public BellDataForm(BellsListForm BellsListForm)
        {
            InitializeComponent();
            this.role = "Add";
            this.bellsListForm = BellsListForm;
        }

        public BellDataForm(BellsListForm BellsListForm, DataGridViewRow row)
        {
            InitializeComponent();
            this.bellsListForm = BellsListForm;
            this.row = row;
        }

        private void BellDataForm_Load(object sender, EventArgs e)
        {
            //add row data to the field if the role is update
            if (role == "Update")
            {
                bellNameTextBox.Text = row.Cells[1].Value.ToString();
                bellMinsNumericUpDown.Value = int.Parse(row.Cells[2].Value.ToString());
                cooldownNumericUpDown.Value = int.Parse(row.Cells[3].Value.ToString());
                bellDescreptionTextBox.Text = row.Cells[4].Value.ToString();
                ringMinsLabel.Text = "Ring every " + row.Cells[2].Value.ToString() + " Min and " + row.Cells[2].Value.ToString() + " cooldown.";
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (bellNameTextBox.Text == "" || bellDescreptionTextBox.Text == "")
                return;

            if (role == "Add")
            {
                bellsListForm.AddBell(bellNameTextBox.Text, (int)bellMinsNumericUpDown.Value, (int)cooldownNumericUpDown.Value, bellDescreptionTextBox.Text);
                bellsListForm.Enabled = true;
                Close();
            }
            else
            {
                bellsListForm.UpdateBell(row.Cells[0].Value.ToString(), bellNameTextBox.Text, (int)bellMinsNumericUpDown.Value, (int)cooldownNumericUpDown.Value, bellDescreptionTextBox.Text);
                bellsListForm.Enabled = true;
                Close();
            }
        }

        private void bellMinsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ringMinsLabel.Text = "Ring every " + bellMinsNumericUpDown.Value.ToString() + " Min and " + cooldownNumericUpDown.Value.ToString() + " cooldown.";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            bellsListForm.Enabled = true;
            Close();
        }

        private void descreptionBorder_Click(object sender, EventArgs e)
        {
            bellDescreptionTextBox.Focus();
        }

        private void nameBorder_Click(object sender, EventArgs e)
        {
            bellNameTextBox.Focus();
        }
    }
}
