namespace Notify_me
{
    partial class AlartForm
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
            time = new Label();
            descreption = new Label();
            name = new Label();
            OKButton = new Button();
            formBorder = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)formBorder).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.BackColor = Color.FromArgb(15, 25, 61);
            logo.Image = Properties.Resources.alarm;
            logo.Location = new Point(185, 44);
            logo.Name = "logo";
            logo.Size = new Size(157, 143);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 44;
            logo.TabStop = false;
            // 
            // time
            // 
            time.BackColor = Color.FromArgb(15, 25, 61);
            time.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            time.ForeColor = SystemColors.ControlLight;
            time.Location = new Point(30, 215);
            time.Name = "time";
            time.Size = new Size(479, 45);
            time.TabIndex = 43;
            time.Text = "time";
            time.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // descreption
            // 
            descreption.BackColor = Color.FromArgb(15, 25, 61);
            descreption.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            descreption.ForeColor = SystemColors.ControlLight;
            descreption.Location = new Point(30, 336);
            descreption.Name = "descreption";
            descreption.Size = new Size(479, 122);
            descreption.TabIndex = 42;
            descreption.Text = "descreption";
            descreption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            name.BackColor = Color.FromArgb(15, 25, 61);
            name.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            name.ForeColor = SystemColors.ControlLight;
            name.Location = new Point(30, 287);
            name.Name = "name";
            name.Size = new Size(479, 49);
            name.TabIndex = 41;
            name.Text = "name";
            name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OKButton
            // 
            OKButton.BackColor = Color.FromArgb(15, 25, 61);
            OKButton.FlatAppearance.BorderSize = 0;
            OKButton.FlatStyle = FlatStyle.Flat;
            OKButton.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            OKButton.ForeColor = Color.White;
            OKButton.Image = Properties.Resources.small_putton;
            OKButton.Location = new Point(191, 461);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(151, 57);
            OKButton.TabIndex = 39;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = false;
            OKButton.Click += OKButton_Click;
            // 
            // formBorder
            // 
            formBorder.BackColor = Color.FromArgb(15, 25, 61);
            formBorder.Dock = DockStyle.Fill;
            formBorder.Image = Properties.Resources.border;
            formBorder.Location = new Point(0, 0);
            formBorder.Name = "formBorder";
            formBorder.Size = new Size(534, 559);
            formBorder.SizeMode = PictureBoxSizeMode.Zoom;
            formBorder.TabIndex = 40;
            formBorder.TabStop = false;
            // 
            // AlartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 559);
            Controls.Add(logo);
            Controls.Add(time);
            Controls.Add(descreption);
            Controls.Add(name);
            Controls.Add(OKButton);
            Controls.Add(formBorder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlartForm";
            Load += AlartForm_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)formBorder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox logo;
        private Label time;
        private Label descreption;
        private Label name;
        private Button OKButton;
        private PictureBox formBorder;
    }
}