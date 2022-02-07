
namespace Mehedee_ADO_Project
{
    partial class formProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formProject));
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.comBoxUser = new System.Windows.Forms.ComboBox();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.SpringGreen;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(453, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(496, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Project Management System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.comBoxUser);
            this.panelLogin.Controls.Add(this.txtBoxPass);
            this.panelLogin.Controls.Add(this.lblPass);
            this.panelLogin.Controls.Add(this.lblUser);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Location = new System.Drawing.Point(357, 150);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(649, 428);
            this.panelLogin.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(249, 271);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(104, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // comBoxUser
            // 
            this.comBoxUser.FormattingEnabled = true;
            this.comBoxUser.Items.AddRange(new object[] {
            "---",
            "TSP Admin",
            "Trainee Admin",
            "Trainer Admin",
            "Course Authority"});
            this.comBoxUser.Location = new System.Drawing.Point(324, 164);
            this.comBoxUser.Name = "comBoxUser";
            this.comBoxUser.Size = new System.Drawing.Size(165, 36);
            this.comBoxUser.TabIndex = 2;
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Location = new System.Drawing.Point(324, 218);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(165, 35);
            this.txtBoxPass.TabIndex = 2;
            this.txtBoxPass.UseSystemPasswordChar = true;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPass.Location = new System.Drawing.Point(200, 221);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(106, 28);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUser.Location = new System.Drawing.Point(97, 167);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(209, 28);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Who is logging in :-";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(192)))), ((int)(((byte)(30)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(222, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME";
            // 
            // formProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1404, 671);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "formProject";
            this.Text = "Project Management Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBoxUser;
        private System.Windows.Forms.Button btnLogin;
    }
}

