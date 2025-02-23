
namespace notify_me
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            alarms = new Button();
            bells = new Button();
            timer = new System.Windows.Forms.Timer(components);
            notifyIcon = new NotifyIcon(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            calenders = new Button();
            logo = new PictureBox();
            exitButton = new PictureBox();
            settingButton = new PictureBox();
            logoImage = new PictureBox();
            infoLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)settingButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoImage).BeginInit();
            SuspendLayout();
            // 
            // alarms
            // 
            alarms.BackColor = Color.FromArgb(147, 132, 189);
            alarms.FlatAppearance.BorderSize = 0;
            alarms.FlatStyle = FlatStyle.Flat;
            alarms.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            alarms.ForeColor = Color.FromArgb(205, 211, 209);
            alarms.Image = Notify_me.Properties.Resources.alarm;
            alarms.ImageAlign = ContentAlignment.TopRight;
            alarms.Location = new Point(308, 119);
            alarms.Name = "alarms";
            alarms.Padding = new Padding(0, 20, 20, 0);
            alarms.Size = new Size(278, 219);
            alarms.TabIndex = 0;
            alarms.Text = "Alarm";
            alarms.TextAlign = ContentAlignment.BottomLeft;
            alarms.UseVisualStyleBackColor = false;
            alarms.Click += alarms_Click;
            alarms.MouseEnter += alarms_MouseHover;
            // 
            // bells
            // 
            bells.BackColor = Color.FromArgb(242, 115, 126);
            bells.FlatAppearance.BorderSize = 0;
            bells.FlatStyle = FlatStyle.Flat;
            bells.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            bells.ForeColor = Color.FromArgb(205, 211, 209);
            bells.Image = Notify_me.Properties.Resources.bell;
            bells.ImageAlign = ContentAlignment.TopRight;
            bells.Location = new Point(28, 119);
            bells.Name = "bells";
            bells.Padding = new Padding(0, 20, 20, 0);
            bells.Size = new Size(274, 219);
            bells.TabIndex = 1;
            bells.Text = "Bell";
            bells.TextAlign = ContentAlignment.BottomLeft;
            bells.UseVisualStyleBackColor = false;
            bells.Click += bells_Click;
            bells.MouseEnter += bells_MouseHover;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // notifyIcon
            // 
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "Notify me";
            notifyIcon.Visible = true;
            notifyIcon.Click += notifyIcon_Click;
            // 
            // calenders
            // 
            calenders.BackColor = Color.FromArgb(99, 189, 223);
            calenders.FlatAppearance.BorderSize = 0;
            calenders.FlatStyle = FlatStyle.Flat;
            calenders.Font = new Font("Microsoft Sans Serif", 40F, FontStyle.Bold, GraphicsUnit.Point);
            calenders.ForeColor = Color.FromArgb(205, 211, 209);
            calenders.Image = Notify_me.Properties.Resources.calendar;
            calenders.ImageAlign = ContentAlignment.TopRight;
            calenders.Location = new Point(28, 344);
            calenders.Name = "calenders";
            calenders.Padding = new Padding(0, 20, 30, 0);
            calenders.Size = new Size(558, 227);
            calenders.TabIndex = 4;
            calenders.Text = "Calendar";
            calenders.TextAlign = ContentAlignment.BottomLeft;
            calenders.UseVisualStyleBackColor = false;
            calenders.Click += calenders_Click;
            calenders.MouseEnter += calendar_MouseHover;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(462, 28);
            logo.Name = "logo";
            logo.Size = new Size(184, 62);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // exitButton
            // 
            exitButton.Image = (Image)resources.GetObject("exitButton.Image");
            exitButton.Location = new Point(971, 28);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(99, 49);
            exitButton.SizeMode = PictureBoxSizeMode.Zoom;
            exitButton.TabIndex = 1;
            exitButton.TabStop = false;
            exitButton.Click += exitButton_Click;
            // 
            // settingButton
            // 
            settingButton.Image = (Image)resources.GetObject("settingButton.Image");
            settingButton.Location = new Point(38, 28);
            settingButton.Name = "settingButton";
            settingButton.Size = new Size(99, 49);
            settingButton.SizeMode = PictureBoxSizeMode.Zoom;
            settingButton.TabIndex = 2;
            settingButton.TabStop = false;
            settingButton.Click += setting_click;
            // 
            // logoImage
            // 
            logoImage.Image = Notify_me.Properties.Resources.alarm;
            logoImage.Location = new Point(688, 119);
            logoImage.Name = "logoImage";
            logoImage.Size = new Size(320, 320);
            logoImage.SizeMode = PictureBoxSizeMode.StretchImage;
            logoImage.TabIndex = 5;
            logoImage.TabStop = false;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point);
            infoLabel.ForeColor = SystemColors.ControlLight;
            infoLabel.Location = new Point(669, 489);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(367, 42);
            infoLabel.TabIndex = 6;
            infoLabel.Text = "show in spicific time";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 25, 61);
            ClientSize = new Size(1104, 609);
            Controls.Add(infoLabel);
            Controls.Add(logoImage);
            Controls.Add(settingButton);
            Controls.Add(exitButton);
            Controls.Add(calenders);
            Controls.Add(logo);
            Controls.Add(bells);
            Controls.Add(alarms);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeForm";
            FormClosing += HomeForm_FormClosing;
            Load += HomeForm_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)settingButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button alarms;
        private Button bells;
        private System.Windows.Forms.Timer timer;
        private NotifyIcon notifyIcon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button calenders;
        private PictureBox logo;
        private PictureBox exitButton;
        private PictureBox settingButton;
        private PictureBox logoImage;
        private Label infoLabel;
    }
}