using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notify_me
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            backgroundPanel = new Panel();
            logo = new PictureBox();
            createAccount = new LinkLabel();
            userName = new TextBox();
            confirm = new Button();
            password = new TextBox();
            exitButton = new PictureBox();
            backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitButton).BeginInit();
            SuspendLayout();
            // 
            // backgroundPanel
            // 
            backgroundPanel.BackColor = Color.FromArgb(33, 73, 142);
            backgroundPanel.Controls.Add(exitButton);
            backgroundPanel.Controls.Add(logo);
            backgroundPanel.Controls.Add(createAccount);
            backgroundPanel.Controls.Add(userName);
            backgroundPanel.Controls.Add(confirm);
            backgroundPanel.Controls.Add(password);
            backgroundPanel.Dock = DockStyle.Fill;
            backgroundPanel.Location = new Point(0, 0);
            backgroundPanel.Name = "backgroundPanel";
            backgroundPanel.Size = new Size(433, 615);
            backgroundPanel.TabIndex = 1;
            // 
            // logo
            // 
            logo.BackColor = Color.FromArgb(33, 73, 142);
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(100, 95);
            logo.Name = "logo";
            logo.Size = new Size(217, 104);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 13;
            logo.TabStop = false;
            // 
            // createAccount
            // 
            createAccount.AutoSize = true;
            createAccount.BackColor = Color.FromArgb(33, 73, 142);
            createAccount.Font = new Font("Bahnschrift Light", 10F, FontStyle.Regular, GraphicsUnit.Point);
            createAccount.ForeColor = Color.FromArgb(205, 211, 209);
            createAccount.LinkColor = Color.FromArgb(205, 211, 209);
            createAccount.Location = new Point(247, 397);
            createAccount.Name = "createAccount";
            createAccount.Size = new Size(124, 21);
            createAccount.TabIndex = 11;
            createAccount.TabStop = true;
            createAccount.Text = "Create account";
            // 
            // userName
            // 
            userName.BackColor = Color.FromArgb(238, 224, 201);
            userName.Font = new Font("Bahnschrift", 17F, FontStyle.Bold, GraphicsUnit.Point);
            userName.Location = new Point(56, 262);
            userName.Name = "userName";
            userName.PlaceholderText = "User Name";
            userName.RightToLeft = RightToLeft.Yes;
            userName.Size = new Size(315, 42);
            userName.TabIndex = 4;
            userName.TextAlign = HorizontalAlignment.Right;
            // 
            // confirm
            // 
            confirm.BackColor = Color.FromArgb(205, 211, 209);
            confirm.FlatStyle = FlatStyle.Flat;
            confirm.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            confirm.ForeColor = Color.Black;
            confirm.Location = new Point(137, 467);
            confirm.Name = "confirm";
            confirm.Size = new Size(151, 57);
            confirm.TabIndex = 8;
            confirm.Text = "Sign in";
            confirm.UseVisualStyleBackColor = false;
            confirm.Click += confirm_Click;
            // 
            // password
            // 
            password.BackColor = Color.FromArgb(238, 224, 201);
            password.Font = new Font("Bahnschrift", 17F, FontStyle.Bold, GraphicsUnit.Point);
            password.Location = new Point(56, 337);
            password.Name = "password";
            password.PlaceholderText = "Password";
            password.RightToLeft = RightToLeft.Yes;
            password.Size = new Size(315, 42);
            password.TabIndex = 5;
            password.TextAlign = HorizontalAlignment.Right;
            // 
            // exitButton
            // 
            exitButton.Image = Notify_me.Properties.Resources.logout;
            exitButton.Location = new Point(365, 19);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(56, 54);
            exitButton.SizeMode = PictureBoxSizeMode.StretchImage;
            exitButton.TabIndex = 14;
            exitButton.TabStop = false;
            exitButton.Click += exitButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 73, 142);
            ClientSize = new Size(433, 615);
            Controls.Add(backgroundPanel);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            backgroundPanel.ResumeLayout(false);
            backgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitButton).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel backgroundPanel;
        private LinkLabel createAccount;
        private TextBox userName;
        private Button confirm;
        private TextBox password;
        private PictureBox logo;
        private PictureBox exitButton;
    }
}