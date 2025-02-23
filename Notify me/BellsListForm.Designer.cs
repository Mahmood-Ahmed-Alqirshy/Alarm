
namespace notify_me
{
    partial class BellsListForm
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
            UpdateBellButton = new Button();
            deleteBellButton = new Button();
            addBellButton = new Button();
            bellsDataGridView = new DataGridView();
            backButton = new PictureBox();
            logo = new PictureBox();
            bellIDColumn = new DataGridViewTextBoxColumn();
            bellNameColumn = new DataGridViewTextBoxColumn();
            bellIntervalColumn = new DataGridViewTextBoxColumn();
            bellCooldownColumn = new DataGridViewTextBoxColumn();
            bellDescreptionColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bellsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // UpdateBellButton
            // 
            UpdateBellButton.BackColor = Color.FromArgb(15, 25, 61);
            UpdateBellButton.FlatAppearance.BorderSize = 0;
            UpdateBellButton.FlatStyle = FlatStyle.Flat;
            UpdateBellButton.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateBellButton.ForeColor = SystemColors.ButtonHighlight;
            UpdateBellButton.Image = Notify_me.Properties.Resources.putton;
            UpdateBellButton.Location = new Point(95, 373);
            UpdateBellButton.Name = "UpdateBellButton";
            UpdateBellButton.Size = new Size(225, 70);
            UpdateBellButton.TabIndex = 22;
            UpdateBellButton.Text = "Update";
            UpdateBellButton.UseVisualStyleBackColor = false;
            UpdateBellButton.Click += UpdateBellButton_Click;
            // 
            // deleteBellButton
            // 
            deleteBellButton.BackColor = Color.FromArgb(15, 25, 61);
            deleteBellButton.FlatAppearance.BorderSize = 0;
            deleteBellButton.FlatStyle = FlatStyle.Flat;
            deleteBellButton.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBellButton.ForeColor = SystemColors.ButtonHighlight;
            deleteBellButton.Image = Notify_me.Properties.Resources.pink_putton;
            deleteBellButton.Location = new Point(95, 473);
            deleteBellButton.Name = "deleteBellButton";
            deleteBellButton.Size = new Size(225, 70);
            deleteBellButton.TabIndex = 21;
            deleteBellButton.Text = "Delete";
            deleteBellButton.UseVisualStyleBackColor = false;
            deleteBellButton.Click += deleteBellButton_Click;
            // 
            // addBellButton
            // 
            addBellButton.BackColor = Color.FromArgb(15, 25, 61);
            addBellButton.FlatAppearance.BorderSize = 0;
            addBellButton.FlatStyle = FlatStyle.Flat;
            addBellButton.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            addBellButton.ForeColor = SystemColors.ButtonHighlight;
            addBellButton.Image = Notify_me.Properties.Resources.putton;
            addBellButton.Location = new Point(95, 278);
            addBellButton.Name = "addBellButton";
            addBellButton.Size = new Size(225, 70);
            addBellButton.TabIndex = 15;
            addBellButton.Text = "Add";
            addBellButton.UseVisualStyleBackColor = false;
            addBellButton.Click += addBellButton_Click;
            // 
            // bellsDataGridView
            // 
            bellsDataGridView.AllowUserToAddRows = false;
            bellsDataGridView.AllowUserToDeleteRows = false;
            bellsDataGridView.AllowUserToResizeColumns = false;
            bellsDataGridView.AllowUserToResizeRows = false;
            bellsDataGridView.BackgroundColor = Color.FromArgb(13, 75, 101);
            bellsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bellsDataGridView.Columns.AddRange(new DataGridViewColumn[] { bellIDColumn, bellNameColumn, bellIntervalColumn, bellCooldownColumn, bellDescreptionColumn });
            bellsDataGridView.Dock = DockStyle.Right;
            bellsDataGridView.Location = new Point(426, 0);
            bellsDataGridView.Name = "bellsDataGridView";
            bellsDataGridView.RowHeadersWidth = 51;
            bellsDataGridView.RowTemplate.Height = 29;
            bellsDataGridView.Size = new Size(678, 609);
            bellsDataGridView.TabIndex = 14;
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(15, 25, 61);
            backButton.Image = Notify_me.Properties.Resources.back_arrow;
            backButton.Location = new Point(-14, 23);
            backButton.Name = "backButton";
            backButton.Size = new Size(119, 62);
            backButton.SizeMode = PictureBoxSizeMode.Zoom;
            backButton.TabIndex = 23;
            backButton.TabStop = false;
            backButton.Click += backButton_Click;
            // 
            // logo
            // 
            logo.Image = Notify_me.Properties.Resources.BellLogo;
            logo.Location = new Point(67, 101);
            logo.Name = "logo";
            logo.Size = new Size(296, 120);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 24;
            logo.TabStop = false;
            // 
            // bellIDColumn
            // 
            bellIDColumn.Frozen = true;
            bellIDColumn.HeaderText = "id";
            bellIDColumn.MinimumWidth = 6;
            bellIDColumn.Name = "bellIDColumn";
            bellIDColumn.Visible = false;
            bellIDColumn.Width = 50;
            // 
            // bellNameColumn
            // 
            bellNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            bellNameColumn.Frozen = true;
            bellNameColumn.HeaderText = "Name";
            bellNameColumn.MinimumWidth = 6;
            bellNameColumn.Name = "bellNameColumn";
            bellNameColumn.ReadOnly = true;
            bellNameColumn.Width = 200;
            // 
            // bellIntervalColumn
            // 
            bellIntervalColumn.Frozen = true;
            bellIntervalColumn.HeaderText = "Interval";
            bellIntervalColumn.MinimumWidth = 6;
            bellIntervalColumn.Name = "bellIntervalColumn";
            bellIntervalColumn.ReadOnly = true;
            bellIntervalColumn.Width = 70;
            // 
            // bellCooldownColumn
            // 
            bellCooldownColumn.Frozen = true;
            bellCooldownColumn.HeaderText = "Cooldown";
            bellCooldownColumn.MinimumWidth = 6;
            bellCooldownColumn.Name = "bellCooldownColumn";
            bellCooldownColumn.Width = 80;
            // 
            // bellDescreptionColumn
            // 
            bellDescreptionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            bellDescreptionColumn.Frozen = true;
            bellDescreptionColumn.HeaderText = "Descreption";
            bellDescreptionColumn.MinimumWidth = 6;
            bellDescreptionColumn.Name = "bellDescreptionColumn";
            bellDescreptionColumn.ReadOnly = true;
            bellDescreptionColumn.Width = 510;
            // 
            // BellsListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 25, 61);
            ClientSize = new Size(1104, 609);
            Controls.Add(logo);
            Controls.Add(backButton);
            Controls.Add(UpdateBellButton);
            Controls.Add(deleteBellButton);
            Controls.Add(addBellButton);
            Controls.Add(bellsDataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BellsListForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BellsListForm";
            Load += BellsListForm_Load;
            ((System.ComponentModel.ISupportInitialize)bellsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button UpdateBellButton;
        private Button deleteBellButton;
        private Button addBellButton;
        private DataGridView bellsDataGridView;
        private PictureBox backButton;
        private PictureBox logo;
        private DataGridViewTextBoxColumn bellIDColumn;
        private DataGridViewTextBoxColumn bellNameColumn;
        private DataGridViewTextBoxColumn bellIntervalColumn;
        private DataGridViewTextBoxColumn bellCooldownColumn;
        private DataGridViewTextBoxColumn bellDescreptionColumn;
    }
}