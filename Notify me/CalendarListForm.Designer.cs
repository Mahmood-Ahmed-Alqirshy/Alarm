namespace Notify_me
{
    partial class CalendarListForm
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
            logo = new PictureBox();
            backButton = new PictureBox();
            UpdateCalendarButton = new Button();
            deleteCalendarButton = new Button();
            addCalendarButton = new Button();
            calendarDataGridView = new DataGridView();
            calendarIDColumn = new DataGridViewTextBoxColumn();
            calendarNameColumn = new DataGridViewTextBoxColumn();
            calendarDateColumn = new DataGridViewTextBoxColumn();
            calendarMonthlyColumn = new DataGridViewTextBoxColumn();
            calendarDescreptionColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calendarDataGridView).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = Properties.Resources.BellLogo;
            logo.Location = new Point(74, 101);
            logo.Name = "logo";
            logo.Size = new Size(296, 120);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 30;
            logo.TabStop = false;
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(15, 25, 61);
            backButton.Image = Properties.Resources.back_arrow;
            backButton.Location = new Point(-7, 23);
            backButton.Name = "backButton";
            backButton.Size = new Size(119, 62);
            backButton.SizeMode = PictureBoxSizeMode.Zoom;
            backButton.TabIndex = 29;
            backButton.TabStop = false;
            backButton.Click += backButton_Click;
            // 
            // UpdateCalendarButton
            // 
            UpdateCalendarButton.BackColor = Color.FromArgb(15, 25, 61);
            UpdateCalendarButton.FlatAppearance.BorderSize = 0;
            UpdateCalendarButton.FlatStyle = FlatStyle.Flat;
            UpdateCalendarButton.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateCalendarButton.ForeColor = SystemColors.ButtonHighlight;
            UpdateCalendarButton.Image = Properties.Resources.putton;
            UpdateCalendarButton.Location = new Point(102, 373);
            UpdateCalendarButton.Name = "UpdateCalendarButton";
            UpdateCalendarButton.Size = new Size(225, 70);
            UpdateCalendarButton.TabIndex = 28;
            UpdateCalendarButton.Text = "Update";
            UpdateCalendarButton.UseVisualStyleBackColor = false;
            UpdateCalendarButton.Click += updateCalendarButton_Click;
            // 
            // deleteCalendarButton
            // 
            deleteCalendarButton.BackColor = Color.FromArgb(15, 25, 61);
            deleteCalendarButton.FlatAppearance.BorderSize = 0;
            deleteCalendarButton.FlatStyle = FlatStyle.Flat;
            deleteCalendarButton.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            deleteCalendarButton.ForeColor = SystemColors.ButtonHighlight;
            deleteCalendarButton.Image = Properties.Resources.pink_putton;
            deleteCalendarButton.Location = new Point(102, 473);
            deleteCalendarButton.Name = "deleteCalendarButton";
            deleteCalendarButton.Size = new Size(225, 70);
            deleteCalendarButton.TabIndex = 27;
            deleteCalendarButton.Text = "Delete";
            deleteCalendarButton.UseVisualStyleBackColor = false;
            deleteCalendarButton.Click += deleteCalendarButton_Click;
            // 
            // addCalendarButton
            // 
            addCalendarButton.BackColor = Color.FromArgb(15, 25, 61);
            addCalendarButton.FlatAppearance.BorderSize = 0;
            addCalendarButton.FlatStyle = FlatStyle.Flat;
            addCalendarButton.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            addCalendarButton.ForeColor = SystemColors.ButtonHighlight;
            addCalendarButton.Image = Properties.Resources.putton;
            addCalendarButton.Location = new Point(102, 278);
            addCalendarButton.Name = "addCalendarButton";
            addCalendarButton.Size = new Size(225, 70);
            addCalendarButton.TabIndex = 26;
            addCalendarButton.Text = "Add";
            addCalendarButton.UseVisualStyleBackColor = false;
            addCalendarButton.Click += addCalendarButton_Click;
            // 
            // calendarDataGridView
            // 
            calendarDataGridView.AllowUserToAddRows = false;
            calendarDataGridView.AllowUserToDeleteRows = false;
            calendarDataGridView.AllowUserToResizeColumns = false;
            calendarDataGridView.AllowUserToResizeRows = false;
            calendarDataGridView.BackgroundColor = Color.FromArgb(13, 75, 101);
            calendarDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            calendarDataGridView.Columns.AddRange(new DataGridViewColumn[] { calendarIDColumn, calendarNameColumn, calendarDateColumn, calendarMonthlyColumn, calendarDescreptionColumn });
            calendarDataGridView.Dock = DockStyle.Right;
            calendarDataGridView.Location = new Point(426, 0);
            calendarDataGridView.Name = "calendarDataGridView";
            calendarDataGridView.RowHeadersWidth = 51;
            calendarDataGridView.RowTemplate.Height = 29;
            calendarDataGridView.Size = new Size(678, 609);
            calendarDataGridView.TabIndex = 25;
            // 
            // calendarIDColumn
            // 
            calendarIDColumn.Frozen = true;
            calendarIDColumn.HeaderText = "id";
            calendarIDColumn.MinimumWidth = 6;
            calendarIDColumn.Name = "calendarIDColumn";
            calendarIDColumn.Visible = false;
            calendarIDColumn.Width = 50;
            // 
            // calendarNameColumn
            // 
            calendarNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            calendarNameColumn.Frozen = true;
            calendarNameColumn.HeaderText = "Name";
            calendarNameColumn.MinimumWidth = 6;
            calendarNameColumn.Name = "calendarNameColumn";
            calendarNameColumn.ReadOnly = true;
            calendarNameColumn.Width = 200;
            // 
            // calendarDateColumn
            // 
            calendarDateColumn.Frozen = true;
            calendarDateColumn.HeaderText = "Date";
            calendarDateColumn.MinimumWidth = 6;
            calendarDateColumn.Name = "calendarDateColumn";
            calendarDateColumn.ReadOnly = true;
            calendarDateColumn.Width = 200;
            // 
            // calendarMonthlyColumn
            // 
            calendarMonthlyColumn.Frozen = true;
            calendarMonthlyColumn.HeaderText = "Monthly";
            calendarMonthlyColumn.MinimumWidth = 6;
            calendarMonthlyColumn.Name = "calendarMonthlyColumn";
            calendarMonthlyColumn.Width = 70;
            // 
            // calendarDescreptionColumn
            // 
            calendarDescreptionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            calendarDescreptionColumn.Frozen = true;
            calendarDescreptionColumn.HeaderText = "Descreption";
            calendarDescreptionColumn.MinimumWidth = 6;
            calendarDescreptionColumn.Name = "calendarDescreptionColumn";
            calendarDescreptionColumn.ReadOnly = true;
            calendarDescreptionColumn.Width = 510;
            // 
            // CalendarListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 25, 61);
            ClientSize = new Size(1104, 609);
            Controls.Add(logo);
            Controls.Add(backButton);
            Controls.Add(UpdateCalendarButton);
            Controls.Add(deleteCalendarButton);
            Controls.Add(addCalendarButton);
            Controls.Add(calendarDataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CalendarListForm";
            Text = "CalendarListForm";
            Load += CalendarsListForm_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)calendarDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox logo;
        private PictureBox backButton;
        private Button UpdateCalendarButton;
        private Button deleteCalendarButton;
        private Button addCalendarButton;
        private DataGridView calendarDataGridView;
        private DataGridViewTextBoxColumn calendarIDColumn;
        private DataGridViewTextBoxColumn calendarNameColumn;
        private DataGridViewTextBoxColumn calendarDateColumn;
        private DataGridViewTextBoxColumn calendarMonthlyColumn;
        private DataGridViewTextBoxColumn calendarDescreptionColumn;
    }
}