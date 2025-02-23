
namespace notify_me
{
    partial class SettingForm
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
            savedFilesPathLabel = new Label();
            changeSavePathButton = new Button();
            filesSavePathTextBox = new TextBox();
            startUpCheckBox = new CheckBox();
            settingIcon = new PictureBox();
            folderIcon = new PictureBox();
            alartSoundFileDialog = new OpenFileDialog();
            closeButton = new PictureBox();
            formBorder = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)settingIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)folderIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)formBorder).BeginInit();
            SuspendLayout();
            // 
            // savedFilesPathLabel
            // 
            savedFilesPathLabel.AutoSize = true;
            savedFilesPathLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            savedFilesPathLabel.ForeColor = Color.FromArgb(188, 187, 187);
            savedFilesPathLabel.Location = new Point(102, 197);
            savedFilesPathLabel.Name = "savedFilesPathLabel";
            savedFilesPathLabel.Size = new Size(168, 36);
            savedFilesPathLabel.TabIndex = 9;
            savedFilesPathLabel.Text = "Alart sound";
            // 
            // changeSavePathButton
            // 
            changeSavePathButton.Location = new Point(579, 244);
            changeSavePathButton.Name = "changeSavePathButton";
            changeSavePathButton.Size = new Size(97, 27);
            changeSavePathButton.TabIndex = 8;
            changeSavePathButton.Text = "Change";
            changeSavePathButton.UseVisualStyleBackColor = true;
            changeSavePathButton.Click += changeSoundPathButton_Click;
            // 
            // filesSavePathTextBox
            // 
            filesSavePathTextBox.Enabled = false;
            filesSavePathTextBox.Location = new Point(34, 244);
            filesSavePathTextBox.Name = "filesSavePathTextBox";
            filesSavePathTextBox.Size = new Size(539, 27);
            filesSavePathTextBox.TabIndex = 7;
            // 
            // startUpCheckBox
            // 
            startUpCheckBox.AutoSize = true;
            startUpCheckBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            startUpCheckBox.ForeColor = Color.FromArgb(188, 187, 187);
            startUpCheckBox.Location = new Point(49, 305);
            startUpCheckBox.Name = "startUpCheckBox";
            startUpCheckBox.Size = new Size(285, 40);
            startUpCheckBox.TabIndex = 6;
            startUpCheckBox.Text = "Launch on start up";
            startUpCheckBox.UseVisualStyleBackColor = true;
            startUpCheckBox.CheckedChanged += startUpCheckBox_CheckedChanged;
            // 
            // settingIcon
            // 
            settingIcon.Image = Notify_me.Properties.Resources.settingLogo;
            settingIcon.Location = new Point(34, 24);
            settingIcon.Name = "settingIcon";
            settingIcon.Size = new Size(254, 149);
            settingIcon.SizeMode = PictureBoxSizeMode.Zoom;
            settingIcon.TabIndex = 10;
            settingIcon.TabStop = false;
            // 
            // folderIcon
            // 
            folderIcon.Image = Notify_me.Properties.Resources.folder;
            folderIcon.Location = new Point(49, 197);
            folderIcon.Name = "folderIcon";
            folderIcon.Size = new Size(56, 37);
            folderIcon.SizeMode = PictureBoxSizeMode.Zoom;
            folderIcon.TabIndex = 11;
            folderIcon.TabStop = false;
            // 
            // alartSoundFileDialog
            // 
            alartSoundFileDialog.Filter = "Audio | *.wav";
            // 
            // closeButton
            // 
            closeButton.Image = Notify_me.Properties.Resources.logout;
            closeButton.Location = new Point(642, 24);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(67, 68);
            closeButton.SizeMode = PictureBoxSizeMode.StretchImage;
            closeButton.TabIndex = 12;
            closeButton.TabStop = false;
            closeButton.Click += closeButton_Click;
            // 
            // formBorder
            // 
            formBorder.BackColor = Color.Transparent;
            formBorder.Dock = DockStyle.Fill;
            formBorder.Image = Notify_me.Properties.Resources.border;
            formBorder.Location = new Point(0, 0);
            formBorder.Name = "formBorder";
            formBorder.Size = new Size(736, 385);
            formBorder.SizeMode = PictureBoxSizeMode.StretchImage;
            formBorder.TabIndex = 13;
            formBorder.TabStop = false;
            // 
            // SettingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 25, 61);
            ClientSize = new Size(736, 385);
            Controls.Add(closeButton);
            Controls.Add(folderIcon);
            Controls.Add(settingIcon);
            Controls.Add(savedFilesPathLabel);
            Controls.Add(changeSavePathButton);
            Controls.Add(filesSavePathTextBox);
            Controls.Add(startUpCheckBox);
            Controls.Add(formBorder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SettingForm";
            Load += SettingForm_Load;
            ((System.ComponentModel.ISupportInitialize)settingIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)folderIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)formBorder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label savedFilesPathLabel;
        private Button changeSavePathButton;
        private TextBox filesSavePathTextBox;
        private CheckBox startUpCheckBox;
        private PictureBox settingIcon;
        private PictureBox folderIcon;
        private PictureBox pictureBox3;
        private OpenFileDialog alartSoundFileDialog;
        private PictureBox closeButton;
        private PictureBox formBorder;
    }
}