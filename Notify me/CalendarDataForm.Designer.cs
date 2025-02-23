namespace Notify_me
{
    partial class CalendarDataForm
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
            calendarDescreptionTextBox = new TextBox();
            calendarNameTextBox = new TextBox();
            calendarDateTimePicker = new DateTimePicker();
            CancelButton = new Button();
            OKButton = new Button();
            nameBorder = new PictureBox();
            descreptionBorder = new PictureBox();
            formBorder = new PictureBox();
            MonthlyCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)nameBorder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)descreptionBorder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)formBorder).BeginInit();
            SuspendLayout();
            // 
            // calendarDescreptionTextBox
            // 
            calendarDescreptionTextBox.BorderStyle = BorderStyle.None;
            calendarDescreptionTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            calendarDescreptionTextBox.Location = new Point(131, 164);
            calendarDescreptionTextBox.Multiline = true;
            calendarDescreptionTextBox.Name = "calendarDescreptionTextBox";
            calendarDescreptionTextBox.PlaceholderText = "Descreption";
            calendarDescreptionTextBox.Size = new Size(303, 109);
            calendarDescreptionTextBox.TabIndex = 31;
            // 
            // calendarNameTextBox
            // 
            calendarNameTextBox.BorderStyle = BorderStyle.None;
            calendarNameTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            calendarNameTextBox.Location = new Point(131, 88);
            calendarNameTextBox.Name = "calendarNameTextBox";
            calendarNameTextBox.PlaceholderText = "Name";
            calendarNameTextBox.Size = new Size(317, 31);
            calendarNameTextBox.TabIndex = 30;
            // 
            // calendarDateTimePicker
            // 
            calendarDateTimePicker.CalendarFont = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            calendarDateTimePicker.CustomFormat = "dd/MM tt hh:mm";
            calendarDateTimePicker.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            calendarDateTimePicker.Format = DateTimePickerFormat.Custom;
            calendarDateTimePicker.Location = new Point(75, 309);
            calendarDateTimePicker.Name = "calendarDateTimePicker";
            calendarDateTimePicker.RightToLeft = RightToLeft.Yes;
            calendarDateTimePicker.Size = new Size(375, 43);
            calendarDateTimePicker.TabIndex = 29;
            // 
            // CancelButton
            // 
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            CancelButton.ForeColor = Color.White;
            CancelButton.Image = Properties.Resources.small_pink_putton;
            CancelButton.Location = new Point(272, 442);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(162, 57);
            CancelButton.TabIndex = 28;
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
            OKButton.Image = Properties.Resources.small_putton;
            OKButton.Location = new Point(104, 442);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(162, 57);
            OKButton.TabIndex = 27;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // nameBorder
            // 
            nameBorder.Image = Properties.Resources.alarmName;
            nameBorder.Location = new Point(73, 79);
            nameBorder.Name = "nameBorder";
            nameBorder.Size = new Size(379, 54);
            nameBorder.SizeMode = PictureBoxSizeMode.Zoom;
            nameBorder.TabIndex = 32;
            nameBorder.TabStop = false;
            nameBorder.Click += nameBorder_Click;
            // 
            // descreptionBorder
            // 
            descreptionBorder.Image = Properties.Resources.descreption;
            descreptionBorder.Location = new Point(73, 148);
            descreptionBorder.Name = "descreptionBorder";
            descreptionBorder.Size = new Size(375, 145);
            descreptionBorder.SizeMode = PictureBoxSizeMode.Zoom;
            descreptionBorder.TabIndex = 33;
            descreptionBorder.TabStop = false;
            descreptionBorder.Click += descreptionBorder_Click;
            // 
            // formBorder
            // 
            formBorder.Dock = DockStyle.Fill;
            formBorder.Image = Properties.Resources.border;
            formBorder.Location = new Point(0, 0);
            formBorder.Name = "formBorder";
            formBorder.Size = new Size(534, 559);
            formBorder.SizeMode = PictureBoxSizeMode.Zoom;
            formBorder.TabIndex = 34;
            formBorder.TabStop = false;
            // 
            // MonthlyCheckBox
            // 
            MonthlyCheckBox.AutoSize = true;
            MonthlyCheckBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            MonthlyCheckBox.ForeColor = SystemColors.ControlLight;
            MonthlyCheckBox.Location = new Point(75, 377);
            MonthlyCheckBox.Name = "MonthlyCheckBox";
            MonthlyCheckBox.Size = new Size(143, 40);
            MonthlyCheckBox.TabIndex = 35;
            MonthlyCheckBox.Text = "Monthly";
            MonthlyCheckBox.UseVisualStyleBackColor = true;
            MonthlyCheckBox.CheckedChanged += MonthlyCheckBox_CheckedChanged;
            // 
            // CalendarDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 25, 61);
            ClientSize = new Size(534, 559);
            Controls.Add(MonthlyCheckBox);
            Controls.Add(calendarDescreptionTextBox);
            Controls.Add(calendarNameTextBox);
            Controls.Add(calendarDateTimePicker);
            Controls.Add(CancelButton);
            Controls.Add(OKButton);
            Controls.Add(nameBorder);
            Controls.Add(descreptionBorder);
            Controls.Add(formBorder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CalendarDataForm";
            Text = "CalendarDataForm";
            Load += CalendarDataForm_Load;
            ((System.ComponentModel.ISupportInitialize)nameBorder).EndInit();
            ((System.ComponentModel.ISupportInitialize)descreptionBorder).EndInit();
            ((System.ComponentModel.ISupportInitialize)formBorder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox calendarDescreptionTextBox;
        private TextBox calendarNameTextBox;
        private DateTimePicker calendarDateTimePicker;
        private Button CancelButton;
        private Button OKButton;
        private PictureBox nameBorder;
        private PictureBox descreptionBorder;
        private PictureBox formBorder;
        private CheckBox MonthlyCheckBox;
    }
}