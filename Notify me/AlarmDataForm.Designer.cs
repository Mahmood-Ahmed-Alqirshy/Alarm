
namespace notify_me
{
    partial class AlarmDataForm
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
            CancelButton = new Button();
            OKButton = new Button();
            alarmDescreptionTextBox = new TextBox();
            alarmNameTextBox = new TextBox();
            alarmDateTimePicker = new DateTimePicker();
            nameBorder = new PictureBox();
            formBorder = new PictureBox();
            descreptionBorder = new PictureBox();
            daysGroupBox = new GroupBox();
            friday = new CheckBox();
            saturday = new CheckBox();
            sunday = new CheckBox();
            thursday = new CheckBox();
            tuesday = new CheckBox();
            monday = new CheckBox();
            wednesday = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)nameBorder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)formBorder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)descreptionBorder).BeginInit();
            daysGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            CancelButton.ForeColor = Color.White;
            CancelButton.Image = Notify_me.Properties.Resources.small_pink_putton;
            CancelButton.Location = new Point(272, 468);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(162, 57);
            CancelButton.TabIndex = 19;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // OKButton
            // 
            OKButton.FlatAppearance.BorderSize = 0;
            OKButton.FlatStyle = FlatStyle.Flat;
            OKButton.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            OKButton.ForeColor = Color.White;
            OKButton.Image = Notify_me.Properties.Resources.small_putton;
            OKButton.Location = new Point(104, 468);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(162, 57);
            OKButton.TabIndex = 18;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // alarmDescreptionTextBox
            // 
            alarmDescreptionTextBox.BorderStyle = BorderStyle.None;
            alarmDescreptionTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            alarmDescreptionTextBox.Location = new Point(134, 127);
            alarmDescreptionTextBox.Multiline = true;
            alarmDescreptionTextBox.Name = "alarmDescreptionTextBox";
            alarmDescreptionTextBox.PlaceholderText = "Descreption";
            alarmDescreptionTextBox.Size = new Size(303, 109);
            alarmDescreptionTextBox.TabIndex = 22;
            // 
            // alarmNameTextBox
            // 
            alarmNameTextBox.BorderStyle = BorderStyle.None;
            alarmNameTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            alarmNameTextBox.Location = new Point(134, 51);
            alarmNameTextBox.Name = "alarmNameTextBox";
            alarmNameTextBox.PlaceholderText = "Name";
            alarmNameTextBox.Size = new Size(317, 31);
            alarmNameTextBox.TabIndex = 21;
            // 
            // alarmDateTimePicker
            // 
            alarmDateTimePicker.CalendarFont = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            alarmDateTimePicker.CustomFormat = "tt hh:mm";
            alarmDateTimePicker.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            alarmDateTimePicker.Format = DateTimePickerFormat.Custom;
            alarmDateTimePicker.Location = new Point(78, 272);
            alarmDateTimePicker.Name = "alarmDateTimePicker";
            alarmDateTimePicker.RightToLeft = RightToLeft.Yes;
            alarmDateTimePicker.ShowUpDown = true;
            alarmDateTimePicker.Size = new Size(375, 43);
            alarmDateTimePicker.TabIndex = 20;
            // 
            // nameBorder
            // 
            nameBorder.Image = Notify_me.Properties.Resources.alarmName;
            nameBorder.Location = new Point(76, 42);
            nameBorder.Name = "nameBorder";
            nameBorder.Size = new Size(379, 54);
            nameBorder.SizeMode = PictureBoxSizeMode.Zoom;
            nameBorder.TabIndex = 23;
            nameBorder.TabStop = false;
            nameBorder.Click += nameBorder_Click;
            // 
            // formBorder
            // 
            formBorder.Dock = DockStyle.Fill;
            formBorder.Image = Notify_me.Properties.Resources.border;
            formBorder.Location = new Point(0, 0);
            formBorder.Name = "formBorder";
            formBorder.Size = new Size(534, 559);
            formBorder.SizeMode = PictureBoxSizeMode.Zoom;
            formBorder.TabIndex = 26;
            formBorder.TabStop = false;
            // 
            // descreptionBorder
            // 
            descreptionBorder.Image = Notify_me.Properties.Resources.descreption;
            descreptionBorder.Location = new Point(76, 111);
            descreptionBorder.Name = "descreptionBorder";
            descreptionBorder.Size = new Size(375, 145);
            descreptionBorder.SizeMode = PictureBoxSizeMode.Zoom;
            descreptionBorder.TabIndex = 24;
            descreptionBorder.TabStop = false;
            descreptionBorder.Click += descreptionBorder_Click;
            // 
            // daysGroupBox
            // 
            daysGroupBox.Controls.Add(wednesday);
            daysGroupBox.Controls.Add(thursday);
            daysGroupBox.Controls.Add(tuesday);
            daysGroupBox.Controls.Add(monday);
            daysGroupBox.Controls.Add(sunday);
            daysGroupBox.Controls.Add(saturday);
            daysGroupBox.Controls.Add(friday);
            daysGroupBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            daysGroupBox.ForeColor = SystemColors.ControlLight;
            daysGroupBox.Location = new Point(44, 321);
            daysGroupBox.Name = "daysGroupBox";
            daysGroupBox.Size = new Size(451, 141);
            daysGroupBox.TabIndex = 27;
            daysGroupBox.TabStop = false;
            daysGroupBox.Text = "days";
            // 
            // friday
            // 
            friday.AutoSize = true;
            friday.Location = new Point(6, 26);
            friday.Name = "friday";
            friday.Size = new Size(94, 29);
            friday.TabIndex = 0;
            friday.Text = "Friday";
            friday.UseVisualStyleBackColor = true;
            // 
            // saturday
            // 
            saturday.AutoSize = true;
            saturday.Location = new Point(6, 61);
            saturday.Name = "saturday";
            saturday.Size = new Size(121, 29);
            saturday.TabIndex = 1;
            saturday.Text = "Saturday";
            saturday.UseVisualStyleBackColor = true;
            // 
            // sunday
            // 
            sunday.AutoSize = true;
            sunday.Location = new Point(6, 96);
            sunday.Name = "sunday";
            sunday.Size = new Size(108, 29);
            sunday.TabIndex = 2;
            sunday.Text = "Sunday";
            sunday.UseVisualStyleBackColor = true;
            // 
            // thursday
            // 
            thursday.AutoSize = true;
            thursday.Location = new Point(289, 61);
            thursday.Name = "thursday";
            thursday.Size = new Size(125, 29);
            thursday.TabIndex = 5;
            thursday.Text = "Thursday";
            thursday.UseVisualStyleBackColor = true;
            // 
            // tuesday
            // 
            tuesday.AutoSize = true;
            tuesday.Location = new Point(143, 61);
            tuesday.Name = "tuesday";
            tuesday.Size = new Size(118, 29);
            tuesday.TabIndex = 4;
            tuesday.Text = "Tuesday";
            tuesday.UseVisualStyleBackColor = true;
            // 
            // monday
            // 
            monday.AutoSize = true;
            monday.Location = new Point(143, 26);
            monday.Name = "monday";
            monday.Size = new Size(111, 29);
            monday.TabIndex = 3;
            monday.Text = "Monday";
            monday.UseVisualStyleBackColor = true;
            // 
            // wednesday
            // 
            wednesday.AutoSize = true;
            wednesday.Location = new Point(289, 29);
            wednesday.Name = "wednesday";
            wednesday.Size = new Size(149, 29);
            wednesday.TabIndex = 6;
            wednesday.Text = "Wednesday";
            wednesday.UseVisualStyleBackColor = true;
            // 
            // AlarmDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 25, 61);
            ClientSize = new Size(534, 559);
            Controls.Add(daysGroupBox);
            Controls.Add(alarmDescreptionTextBox);
            Controls.Add(alarmNameTextBox);
            Controls.Add(alarmDateTimePicker);
            Controls.Add(CancelButton);
            Controls.Add(OKButton);
            Controls.Add(nameBorder);
            Controls.Add(descreptionBorder);
            Controls.Add(formBorder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlarmDataForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlarmDataForm";
            Load += AlarmDataForm_Load;
            ((System.ComponentModel.ISupportInitialize)nameBorder).EndInit();
            ((System.ComponentModel.ISupportInitialize)formBorder).EndInit();
            ((System.ComponentModel.ISupportInitialize)descreptionBorder).EndInit();
            daysGroupBox.ResumeLayout(false);
            daysGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelButton;
        private Button OKButton;
        private TextBox alarmDescreptionTextBox;
        private TextBox alarmNameTextBox;
        private DateTimePicker alarmDateTimePicker;
        private PictureBox nameBorder;
        private PictureBox formBorder;
        private PictureBox descreptionBorder;
        private GroupBox daysGroupBox;
        private CheckBox friday;
        private CheckBox wednesday;
        private CheckBox thursday;
        private CheckBox tuesday;
        private CheckBox monday;
        private CheckBox sunday;
        private CheckBox saturday;
    }
}