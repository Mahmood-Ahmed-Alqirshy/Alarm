using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notify_me
{
    public partial class AlartForm : Form
    {
        SoundPlayer soundPlayer;
        string alartName;
        string alartTime;
        string alartDescreption;
        public AlartForm(string name, string time, string descreption)
        {
            InitializeComponent();
            this.alartName = name;
            this.alartTime = time;
            this.alartDescreption = descreption;
            if (File.Exists(Application.StartupPath + "sound.txt"))
            {
                StreamReader streamReader = new StreamReader(Application.StartupPath + "sound.txt");
                soundPlayer = new SoundPlayer(streamReader.ReadToEnd().Trim());
                streamReader.Close();
            }
            else 
            { 
                soundPlayer = new SoundPlayer(Application.StartupPath + "sound.wav"); 
            }
            soundPlayer.Play();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            Close();
        }

        private void AlartForm_Load(object sender, EventArgs e)
        {
            name.Text = alartName;
            time.Text = alartTime;
            descreption.Text = alartDescreption;
        }
    }
}
