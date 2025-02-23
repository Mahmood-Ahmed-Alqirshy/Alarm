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
using Microsoft.Win32;

namespace notify_me
{
    public partial class SettingForm : Form
    {
        //object used to registr the application to the startup Apps 
        RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        HomeForm homeForm;
        public SettingForm(HomeForm homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            //GetValue() return null if app does not exist in the startup list
            if (registryKey.GetValue("Notify me") != null)
                startUpCheckBox.Checked = true;
            //get sound path from file if exist elss use default path
            if (File.Exists(Application.StartupPath + "sound.txt"))
            {
                StreamReader streamReader = new StreamReader(Application.StartupPath + "sound.txt");
                filesSavePathTextBox.Text = streamReader.ReadToEnd().Trim();
                streamReader.Close();
            }
            else
            {
                filesSavePathTextBox.Text = Application.StartupPath + "sound.wav";
            }
        }

        private void startUpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //add or remove the app from the startup list in windows
            if (startUpCheckBox.Checked)
                registryKey.SetValue("Notify me", Application.ExecutablePath);
            else
                registryKey.DeleteValue("Notify me");
        }

        private void changeSoundPathButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = alartSoundFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string path = alartSoundFileDialog.FileName;
                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "sound.txt", false);
                streamWriter.WriteLine(path);
                streamWriter.Close();
                filesSavePathTextBox.Text = path;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            homeForm.Enabled = true;
            Close();
        }
    }
}
