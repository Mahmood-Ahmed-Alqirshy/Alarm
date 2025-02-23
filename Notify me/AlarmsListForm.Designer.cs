
namespace notify_me
{
    partial class AlarmsListForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            UpdateAlarmButton = new Button();
            deleteAlarmButton = new Button();
            addAlarmButton = new Button();
            alarmsDataGridView = new DataGridView();
            alarmIDColumn = new DataGridViewTextBoxColumn();
            alarmNameColumn = new DataGridViewTextBoxColumn();
            alarmTimeColumn = new DataGridViewTextBoxColumn();
            alarmDescreptionColumn = new DataGridViewTextBoxColumn();
            backButton = new PictureBox();
            logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)alarmsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // UpdateAlarmButton
            // 
            UpdateAlarmButton.BackgroundImageLayout = ImageLayout.Zoom;
            UpdateAlarmButton.CausesValidation = false;
            UpdateAlarmButton.FlatAppearance.BorderSize = 0;
            UpdateAlarmButton.FlatStyle = FlatStyle.Flat;
            UpdateAlarmButton.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateAlarmButton.ForeColor = SystemColors.ButtonHighlight;
            UpdateAlarmButton.Image = Notify_me.Properties.Resources.putton;
            UpdateAlarmButton.Location = new Point(95, 373);
            UpdateAlarmButton.Name = "UpdateAlarmButton";
            UpdateAlarmButton.Size = new Size(225, 70);
            UpdateAlarmButton.TabIndex = 15;
            UpdateAlarmButton.Text = "Update";
            UpdateAlarmButton.UseVisualStyleBackColor = true;
            UpdateAlarmButton.Click += UpdateAlarmButton_Click;
            // 
            // deleteAlarmButton
            // 
            deleteAlarmButton.FlatAppearance.BorderSize = 0;
            deleteAlarmButton.FlatStyle = FlatStyle.Flat;
            deleteAlarmButton.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            deleteAlarmButton.ForeColor = SystemColors.ButtonHighlight;
            deleteAlarmButton.Image = Notify_me.Properties.Resources.pink_putton;
            deleteAlarmButton.Location = new Point(95, 473);
            deleteAlarmButton.Name = "deleteAlarmButton";
            deleteAlarmButton.Size = new Size(225, 70);
            deleteAlarmButton.TabIndex = 14;
            deleteAlarmButton.Text = "Delete";
            deleteAlarmButton.UseVisualStyleBackColor = true;
            deleteAlarmButton.Click += deleteAlarmButton_Click;
            // 
            // addAlarmButton
            // 
            addAlarmButton.BackgroundImageLayout = ImageLayout.None;
            addAlarmButton.FlatAppearance.BorderSize = 0;
            addAlarmButton.FlatStyle = FlatStyle.Flat;
            addAlarmButton.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            addAlarmButton.ForeColor = SystemColors.ButtonHighlight;
            addAlarmButton.Image = Notify_me.Properties.Resources.putton;
            addAlarmButton.Location = new Point(95, 278);
            addAlarmButton.Margin = new Padding(0);
            addAlarmButton.Name = "addAlarmButton";
            addAlarmButton.Size = new Size(225, 70);
            addAlarmButton.TabIndex = 9;
            addAlarmButton.Text = "Add";
            addAlarmButton.UseVisualStyleBackColor = true;
            addAlarmButton.Click += addAlarmButton_Click;
            // 
            // alarmsDataGridView
            // 
            alarmsDataGridView.AllowUserToAddRows = false;
            alarmsDataGridView.AllowUserToDeleteRows = false;
            alarmsDataGridView.AllowUserToResizeColumns = false;
            alarmsDataGridView.AllowUserToResizeRows = false;
            alarmsDataGridView.BackgroundColor = Color.FromArgb(13, 75, 101);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            alarmsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            alarmsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            alarmsDataGridView.Columns.AddRange(new DataGridViewColumn[] { alarmIDColumn, alarmNameColumn, alarmTimeColumn, alarmDescreptionColumn });
            alarmsDataGridView.Dock = DockStyle.Right;
            alarmsDataGridView.Location = new Point(426, 0);
            alarmsDataGridView.Name = "alarmsDataGridView";
            alarmsDataGridView.RowHeadersWidth = 51;
            alarmsDataGridView.RowTemplate.Height = 29;
            alarmsDataGridView.Size = new Size(678, 609);
            alarmsDataGridView.TabIndex = 8;
            // 
            // alarmIDColumn
            // 
            alarmIDColumn.Frozen = true;
            alarmIDColumn.HeaderText = "id";
            alarmIDColumn.MinimumWidth = 6;
            alarmIDColumn.Name = "alarmIDColumn";
            alarmIDColumn.Visible = false;
            alarmIDColumn.Width = 50;
            // 
            // alarmNameColumn
            // 
            alarmNameColumn.FillWeight = 200F;
            alarmNameColumn.Frozen = true;
            alarmNameColumn.HeaderText = "Name";
            alarmNameColumn.MinimumWidth = 6;
            alarmNameColumn.Name = "alarmNameColumn";
            alarmNameColumn.ReadOnly = true;
            alarmNameColumn.Width = 200;
            // 
            // alarmTimeColumn
            // 
            alarmTimeColumn.Frozen = true;
            alarmTimeColumn.HeaderText = "Time";
            alarmTimeColumn.MinimumWidth = 6;
            alarmTimeColumn.Name = "alarmTimeColumn";
            alarmTimeColumn.ReadOnly = true;
            alarmTimeColumn.Width = 70;
            // 
            // alarmDescreptionColumn
            // 
            alarmDescreptionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            alarmDescreptionColumn.Frozen = true;
            alarmDescreptionColumn.HeaderText = "Descreption";
            alarmDescreptionColumn.MinimumWidth = 6;
            alarmDescreptionColumn.Name = "alarmDescreptionColumn";
            alarmDescreptionColumn.ReadOnly = true;
            alarmDescreptionColumn.Width = 510;
            // 
            // backButton
            // 
            backButton.Image = Notify_me.Properties.Resources.back_arrow;
            backButton.Location = new Point(-14, 23);
            backButton.Name = "backButton";
            backButton.Size = new Size(119, 62);
            backButton.SizeMode = PictureBoxSizeMode.Zoom;
            backButton.TabIndex = 18;
            backButton.TabStop = false;
            backButton.Click += backButton_Click;
            // 
            // logo
            // 
            logo.Image = Notify_me.Properties.Resources.alarmLogo;
            logo.Location = new Point(67, 101);
            logo.Name = "logo";
            logo.Size = new Size(301, 120);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 19;
            logo.TabStop = false;
            // 
            // AlarmsListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 25, 61);
            ClientSize = new Size(1104, 609);
            Controls.Add(logo);
            Controls.Add(backButton);
            Controls.Add(UpdateAlarmButton);
            Controls.Add(deleteAlarmButton);
            Controls.Add(addAlarmButton);
            Controls.Add(alarmsDataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlarmsListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlarmsListForm";
            Load += AlarmsListForm_Load;
            ((System.ComponentModel.ISupportInitialize)alarmsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button UpdateAlarmButton;
        private Button deleteAlarmButton;
        private Button addAlarmButton;
        private DataGridView alarmsDataGridView;
        private DataGridViewTextBoxColumn alarmIDColumn;
        private DataGridViewTextBoxColumn alarmNameColumn;
        private DataGridViewTextBoxColumn alarmTimeColumn;
        private DataGridViewTextBoxColumn alarmDescreptionColumn;
        private PictureBox backButton;
        private PictureBox logo;
    }
}