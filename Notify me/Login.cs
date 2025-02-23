using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace notify_me
{
    public partial class Login : Form
    {
        HomeForm homeForm;
        public Login(HomeForm homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;
            homeForm.appearUnlock = false;
            homeForm.Appear = false;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            homeForm.appearUnlock = true;
            homeForm.Appear = true;
            homeForm.Focus();
            homeForm.csv.Read();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            homeForm.appearUnlock = false;
            homeForm.Appear = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}