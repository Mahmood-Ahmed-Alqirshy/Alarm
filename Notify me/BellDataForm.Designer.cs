
namespace notify_me
{
    partial class BellDataForm
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
            ringMinsLabel = new Label();
            bellMinsNumericUpDown = new NumericUpDown();
            bellDescreptionTextBox = new TextBox();
            bellNameTextBox = new TextBox();
            OKButton = new Button();
            CancelButton = new Button();
            descreptionBorder = new PictureBox();
            nameBorder = new PictureBox();
            formBorder = new PictureBox();
            cooldownNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)bellMinsNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)descreptionBorder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nameBorder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)formBorder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cooldownNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // ringMinsLabel
            // 
            ringMinsLabel.AutoSize = true;
            ringMinsLabel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            ringMinsLabel.ForeColor = Color.FromArgb(205, 211, 209);
            ringMinsLabel.Location = new Point(36, 368);
            ringMinsLabel.Name = "ringMinsLabel";
            ringMinsLabel.Size = new Size(452, 31);
            ringMinsLabel.TabIndex = 15;
            ringMinsLabel.Text = "Ring every 1 Min and 0 cooldown.";
            // 
            // bellMinsNumericUpDown
            // 
            bellMinsNumericUpDown.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            bellMinsNumericUpDown.Location = new Point(72, 307);
            bellMinsNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            bellMinsNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            bellMinsNumericUpDown.Name = "bellMinsNumericUpDown";
            bellMinsNumericUpDown.Size = new Size(183, 43);
            bellMinsNumericUpDown.TabIndex = 14;
            bellMinsNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            bellMinsNumericUpDown.ValueChanged += bellMinsNumericUpDown_ValueChanged;
            // 
            // bellDescreptionTextBox
            // 
            bellDescreptionTextBox.BorderStyle = BorderStyle.None;
            bellDescreptionTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            bellDescreptionTextBox.Location = new Point(131, 164);
            bellDescreptionTextBox.Multiline = true;
            bellDescreptionTextBox.Name = "bellDescreptionTextBox";
            bellDescreptionTextBox.PlaceholderText = "Descreption";
            bellDescreptionTextBox.Size = new Size(307, 111);
            bellDescreptionTextBox.TabIndex = 13;
            // 
            // bellNameTextBox
            // 
            bellNameTextBox.BorderStyle = BorderStyle.None;
            bellNameTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            bellNameTextBox.Location = new Point(131, 88);
            bellNameTextBox.Name = "bellNameTextBox";
            bellNameTextBox.PlaceholderText = "Name";
            bellNameTextBox.Size = new Size(321, 31);
            bellNameTextBox.TabIndex = 12;
            // 
            // OKButton
            // 
            OKButton.BackColor = Color.FromArgb(15, 25, 61);
            OKButton.FlatAppearance.BorderSize = 0;
            OKButton.FlatStyle = FlatStyle.Flat;
            OKButton.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            OKButton.ForeColor = Color.White;
            OKButton.Image = Notify_me.Properties.Resources.small_putton;
            OKButton.Location = new Point(93, 413);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(162, 57);
            OKButton.TabIndex = 16;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = false;
            OKButton.Click += OKButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(15, 25, 61);
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            CancelButton.ForeColor = Color.White;
            CancelButton.Image = Notify_me.Properties.Resources.small_pink_putton;
            CancelButton.Location = new Point(276, 413);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(162, 57);
            CancelButton.TabIndex = 17;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // descreptionBorder
            // 
            descreptionBorder.Image = Notify_me.Properties.Resources.descreption;
            descreptionBorder.Location = new Point(73, 148);
            descreptionBorder.Name = "descreptionBorder";
            descreptionBorder.Size = new Size(375, 145);
            descreptionBorder.SizeMode = PictureBoxSizeMode.Zoom;
            descreptionBorder.TabIndex = 25;
            descreptionBorder.TabStop = false;
            descreptionBorder.Click += descreptionBorder_Click;
            // 
            // nameBorder
            // 
            nameBorder.Image = Notify_me.Properties.Resources.bellName;
            nameBorder.Location = new Point(73, 79);
            nameBorder.Name = "nameBorder";
            nameBorder.Size = new Size(379, 54);
            nameBorder.SizeMode = PictureBoxSizeMode.Zoom;
            nameBorder.TabIndex = 26;
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
            formBorder.TabIndex = 27;
            formBorder.TabStop = false;
            // 
            // cooldownNumericUpDown
            // 
            cooldownNumericUpDown.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            cooldownNumericUpDown.Location = new Point(265, 307);
            cooldownNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            cooldownNumericUpDown.Name = "cooldownNumericUpDown";
            cooldownNumericUpDown.Size = new Size(183, 43);
            cooldownNumericUpDown.TabIndex = 28;
            cooldownNumericUpDown.ValueChanged += bellMinsNumericUpDown_ValueChanged;
            // 
            // BellDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 25, 61);
            ClientSize = new Size(534, 559);
            Controls.Add(cooldownNumericUpDown);
            Controls.Add(CancelButton);
            Controls.Add(OKButton);
            Controls.Add(ringMinsLabel);
            Controls.Add(bellMinsNumericUpDown);
            Controls.Add(bellDescreptionTextBox);
            Controls.Add(bellNameTextBox);
            Controls.Add(descreptionBorder);
            Controls.Add(nameBorder);
            Controls.Add(formBorder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BellDataForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BellDataForm";
            Load += BellDataForm_Load;
            ((System.ComponentModel.ISupportInitialize)bellMinsNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)descreptionBorder).EndInit();
            ((System.ComponentModel.ISupportInitialize)nameBorder).EndInit();
            ((System.ComponentModel.ISupportInitialize)formBorder).EndInit();
            ((System.ComponentModel.ISupportInitialize)cooldownNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ringMinsLabel;
        private NumericUpDown bellMinsNumericUpDown;
        private TextBox bellDescreptionTextBox;
        private TextBox bellNameTextBox;
        private Button OKButton;
        private Button CancelButton;
        private PictureBox descreptionBorder;
        private PictureBox nameBorder;
        private PictureBox formBorder;
        private NumericUpDown cooldownNumericUpDown;
    }
}