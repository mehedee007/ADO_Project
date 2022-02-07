
namespace Mehedee_ADO_Project.AppData.forms
{
    partial class TraineeInfo
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
            this.lblTraineeName = new System.Windows.Forms.Label();
            this.lblTraineeTitle = new System.Windows.Forms.Label();
            this.lblTraineeGender = new System.Windows.Forms.Label();
            this.lblTraineeDOB = new System.Windows.Forms.Label();
            this.lblTraineeContact = new System.Windows.Forms.Label();
            this.lblTraineeEmail = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnImageBrowse = new System.Windows.Forms.Button();
            this.txtTraineeImagePath = new System.Windows.Forms.TextBox();
            this.txtTraineeName = new System.Windows.Forms.TextBox();
            this.txtTraineeContact = new System.Windows.Forms.TextBox();
            this.dtpTrainee = new System.Windows.Forms.DateTimePicker();
            this.radioTraineeFemale = new System.Windows.Forms.RadioButton();
            this.radioTraineeMale = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.comTraineeCourse = new System.Windows.Forms.ComboBox();
            this.dgTrainee = new System.Windows.Forms.DataGridView();
            this.lbImagePath = new System.Windows.Forms.Label();
            this.btnTraineeLogout = new System.Windows.Forms.Button();
            this.picBoxTraineeImage = new System.Windows.Forms.PictureBox();
            this.btnTraineeSubmit = new System.Windows.Forms.Button();
            this.btnFormGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrainee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTraineeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTraineeName
            // 
            this.lblTraineeName.AutoSize = true;
            this.lblTraineeName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraineeName.Location = new System.Drawing.Point(63, 94);
            this.lblTraineeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTraineeName.Name = "lblTraineeName";
            this.lblTraineeName.Size = new System.Drawing.Size(146, 23);
            this.lblTraineeName.TabIndex = 0;
            this.lblTraineeName.Text = "Trainee Name : ";
            // 
            // lblTraineeTitle
            // 
            this.lblTraineeTitle.AutoSize = true;
            this.lblTraineeTitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblTraineeTitle.Font = new System.Drawing.Font("MV Boli", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraineeTitle.Location = new System.Drawing.Point(544, 26);
            this.lblTraineeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTraineeTitle.Name = "lblTraineeTitle";
            this.lblTraineeTitle.Size = new System.Drawing.Size(340, 44);
            this.lblTraineeTitle.TabIndex = 0;
            this.lblTraineeTitle.Text = "Trainee Information";
            // 
            // lblTraineeGender
            // 
            this.lblTraineeGender.AutoSize = true;
            this.lblTraineeGender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraineeGender.Location = new System.Drawing.Point(108, 268);
            this.lblTraineeGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTraineeGender.Name = "lblTraineeGender";
            this.lblTraineeGender.Size = new System.Drawing.Size(91, 23);
            this.lblTraineeGender.TabIndex = 0;
            this.lblTraineeGender.Text = "Gender : ";
            // 
            // lblTraineeDOB
            // 
            this.lblTraineeDOB.AutoSize = true;
            this.lblTraineeDOB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraineeDOB.Location = new System.Drawing.Point(75, 186);
            this.lblTraineeDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTraineeDOB.Name = "lblTraineeDOB";
            this.lblTraineeDOB.Size = new System.Drawing.Size(138, 23);
            this.lblTraineeDOB.TabIndex = 0;
            this.lblTraineeDOB.Text = "Date of Birth : ";
            this.lblTraineeDOB.Click += new System.EventHandler(this.lblTraineeDOB_Click);
            // 
            // lblTraineeContact
            // 
            this.lblTraineeContact.AutoSize = true;
            this.lblTraineeContact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraineeContact.Location = new System.Drawing.Point(105, 336);
            this.lblTraineeContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTraineeContact.Name = "lblTraineeContact";
            this.lblTraineeContact.Size = new System.Drawing.Size(94, 23);
            this.lblTraineeContact.TabIndex = 0;
            this.lblTraineeContact.Text = "Contact : ";
            // 
            // lblTraineeEmail
            // 
            this.lblTraineeEmail.AutoSize = true;
            this.lblTraineeEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraineeEmail.Location = new System.Drawing.Point(120, 444);
            this.lblTraineeEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTraineeEmail.Name = "lblTraineeEmail";
            this.lblTraineeEmail.Size = new System.Drawing.Size(75, 23);
            this.lblTraineeEmail.TabIndex = 0;
            this.lblTraineeEmail.Text = "Email : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 513);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Assigned Course : ";
            // 
            // btnImageBrowse
            // 
            this.btnImageBrowse.Location = new System.Drawing.Point(25, 662);
            this.btnImageBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnImageBrowse.Name = "btnImageBrowse";
            this.btnImageBrowse.Size = new System.Drawing.Size(121, 33);
            this.btnImageBrowse.TabIndex = 1;
            this.btnImageBrowse.Text = "Browse Image";
            this.btnImageBrowse.UseVisualStyleBackColor = true;
            this.btnImageBrowse.Click += new System.EventHandler(this.btnImageBrowse_Click);
            // 
            // txtTraineeImagePath
            // 
            this.txtTraineeImagePath.Location = new System.Drawing.Point(39, 773);
            this.txtTraineeImagePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtTraineeImagePath.Name = "txtTraineeImagePath";
            this.txtTraineeImagePath.ReadOnly = true;
            this.txtTraineeImagePath.Size = new System.Drawing.Size(612, 30);
            this.txtTraineeImagePath.TabIndex = 2;
            // 
            // txtTraineeName
            // 
            this.txtTraineeName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraineeName.Location = new System.Drawing.Point(232, 94);
            this.txtTraineeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTraineeName.Multiline = true;
            this.txtTraineeName.Name = "txtTraineeName";
            this.txtTraineeName.Size = new System.Drawing.Size(258, 44);
            this.txtTraineeName.TabIndex = 3;
            // 
            // txtTraineeContact
            // 
            this.txtTraineeContact.Font = new System.Drawing.Font("Nirmala UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraineeContact.Location = new System.Drawing.Point(228, 336);
            this.txtTraineeContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtTraineeContact.Multiline = true;
            this.txtTraineeContact.Name = "txtTraineeContact";
            this.txtTraineeContact.Size = new System.Drawing.Size(258, 44);
            this.txtTraineeContact.TabIndex = 3;
            // 
            // dtpTrainee
            // 
            this.dtpTrainee.Location = new System.Drawing.Point(232, 191);
            this.dtpTrainee.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTrainee.Name = "dtpTrainee";
            this.dtpTrainee.Size = new System.Drawing.Size(258, 30);
            this.dtpTrainee.TabIndex = 4;
            // 
            // radioTraineeFemale
            // 
            this.radioTraineeFemale.AutoSize = true;
            this.radioTraineeFemale.Location = new System.Drawing.Point(328, 264);
            this.radioTraineeFemale.Margin = new System.Windows.Forms.Padding(4);
            this.radioTraineeFemale.Name = "radioTraineeFemale";
            this.radioTraineeFemale.Size = new System.Drawing.Size(85, 27);
            this.radioTraineeFemale.TabIndex = 5;
            this.radioTraineeFemale.TabStop = true;
            this.radioTraineeFemale.Text = "Female";
            this.radioTraineeFemale.UseVisualStyleBackColor = true;
            this.radioTraineeFemale.CheckedChanged += new System.EventHandler(this.radioTraineeFemale_CheckedChanged);
            // 
            // radioTraineeMale
            // 
            this.radioTraineeMale.AutoSize = true;
            this.radioTraineeMale.Location = new System.Drawing.Point(232, 264);
            this.radioTraineeMale.Margin = new System.Windows.Forms.Padding(4);
            this.radioTraineeMale.Name = "radioTraineeMale";
            this.radioTraineeMale.Size = new System.Drawing.Size(68, 27);
            this.radioTraineeMale.TabIndex = 5;
            this.radioTraineeMale.TabStop = true;
            this.radioTraineeMale.Text = "Male";
            this.radioTraineeMale.UseVisualStyleBackColor = true;
            this.radioTraineeMale.CheckedChanged += new System.EventHandler(this.radioTraineeMale_CheckedChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Nirmala UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(228, 439);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(258, 44);
            this.txtEmail.TabIndex = 3;
            // 
            // comTraineeCourse
            // 
            this.comTraineeCourse.Font = new System.Drawing.Font("Nirmala UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comTraineeCourse.FormattingEnabled = true;
            this.comTraineeCourse.Location = new System.Drawing.Point(228, 513);
            this.comTraineeCourse.Margin = new System.Windows.Forms.Padding(4);
            this.comTraineeCourse.Name = "comTraineeCourse";
            this.comTraineeCourse.Size = new System.Drawing.Size(258, 31);
            this.comTraineeCourse.TabIndex = 6;
            // 
            // dgTrainee
            // 
            this.dgTrainee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgTrainee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgTrainee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTrainee.GridColor = System.Drawing.Color.Snow;
            this.dgTrainee.Location = new System.Drawing.Point(587, 94);
            this.dgTrainee.Margin = new System.Windows.Forms.Padding(4);
            this.dgTrainee.Name = "dgTrainee";
            this.dgTrainee.ReadOnly = true;
            this.dgTrainee.RowHeadersWidth = 51;
            this.dgTrainee.RowTemplate.Height = 24;
            this.dgTrainee.Size = new System.Drawing.Size(687, 581);
            this.dgTrainee.TabIndex = 7;
            // 
            // lbImagePath
            // 
            this.lbImagePath.AutoSize = true;
            this.lbImagePath.Location = new System.Drawing.Point(35, 744);
            this.lbImagePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbImagePath.Name = "lbImagePath";
            this.lbImagePath.Size = new System.Drawing.Size(111, 23);
            this.lbImagePath.TabIndex = 0;
            this.lbImagePath.Text = "Image Path : ";
            // 
            // btnTraineeLogout
            // 
            this.btnTraineeLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraineeLogout.ForeColor = System.Drawing.Color.Red;
            this.btnTraineeLogout.Location = new System.Drawing.Point(684, 744);
            this.btnTraineeLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnTraineeLogout.Name = "btnTraineeLogout";
            this.btnTraineeLogout.Size = new System.Drawing.Size(121, 58);
            this.btnTraineeLogout.TabIndex = 1;
            this.btnTraineeLogout.Text = "LOGOUT";
            this.btnTraineeLogout.UseVisualStyleBackColor = true;
            this.btnTraineeLogout.Click += new System.EventHandler(this.btnTraineeLogout_Click);
            // 
            // picBoxTraineeImage
            // 
            this.picBoxTraineeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxTraineeImage.Location = new System.Drawing.Point(232, 552);
            this.picBoxTraineeImage.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxTraineeImage.Name = "picBoxTraineeImage";
            this.picBoxTraineeImage.Size = new System.Drawing.Size(181, 194);
            this.picBoxTraineeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTraineeImage.TabIndex = 8;
            this.picBoxTraineeImage.TabStop = false;
            // 
            // btnTraineeSubmit
            // 
            this.btnTraineeSubmit.BackColor = System.Drawing.Color.Lime;
            this.btnTraineeSubmit.Font = new System.Drawing.Font("Nirmala UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraineeSubmit.Location = new System.Drawing.Point(463, 686);
            this.btnTraineeSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnTraineeSubmit.Name = "btnTraineeSubmit";
            this.btnTraineeSubmit.Size = new System.Drawing.Size(121, 60);
            this.btnTraineeSubmit.TabIndex = 1;
            this.btnTraineeSubmit.Text = "Submit";
            this.btnTraineeSubmit.UseVisualStyleBackColor = false;
            this.btnTraineeSubmit.Click += new System.EventHandler(this.btnTraineeSubmit_Click);
            // 
            // btnFormGenerate
            // 
            this.btnFormGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormGenerate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFormGenerate.Location = new System.Drawing.Point(957, 686);
            this.btnFormGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnFormGenerate.Name = "btnFormGenerate";
            this.btnFormGenerate.Size = new System.Drawing.Size(151, 58);
            this.btnFormGenerate.TabIndex = 1;
            this.btnFormGenerate.Text = "Form Generate";
            this.btnFormGenerate.UseVisualStyleBackColor = true;
            this.btnFormGenerate.Click += new System.EventHandler(this.btnFormGenerate_Click);
            // 
            // TraineeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1290, 933);
            this.Controls.Add(this.picBoxTraineeImage);
            this.Controls.Add(this.dgTrainee);
            this.Controls.Add(this.comTraineeCourse);
            this.Controls.Add(this.radioTraineeMale);
            this.Controls.Add(this.radioTraineeFemale);
            this.Controls.Add(this.dtpTrainee);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTraineeContact);
            this.Controls.Add(this.txtTraineeName);
            this.Controls.Add(this.txtTraineeImagePath);
            this.Controls.Add(this.btnTraineeSubmit);
            this.Controls.Add(this.btnFormGenerate);
            this.Controls.Add(this.btnTraineeLogout);
            this.Controls.Add(this.btnImageBrowse);
            this.Controls.Add(this.lbImagePath);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTraineeEmail);
            this.Controls.Add(this.lblTraineeDOB);
            this.Controls.Add(this.lblTraineeGender);
            this.Controls.Add(this.lblTraineeContact);
            this.Controls.Add(this.lblTraineeTitle);
            this.Controls.Add(this.lblTraineeName);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TraineeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trainee List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TraineeInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTrainee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTraineeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTraineeName;
        private System.Windows.Forms.Label lblTraineeTitle;
        private System.Windows.Forms.Label lblTraineeGender;
        private System.Windows.Forms.Label lblTraineeDOB;
        private System.Windows.Forms.Label lblTraineeContact;
        private System.Windows.Forms.Label lblTraineeEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnImageBrowse;
        private System.Windows.Forms.TextBox txtTraineeImagePath;
        private System.Windows.Forms.TextBox txtTraineeName;
        private System.Windows.Forms.TextBox txtTraineeContact;
        private System.Windows.Forms.DateTimePicker dtpTrainee;
        private System.Windows.Forms.RadioButton radioTraineeFemale;
        private System.Windows.Forms.RadioButton radioTraineeMale;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox comTraineeCourse;
        private System.Windows.Forms.DataGridView dgTrainee;
        private System.Windows.Forms.Label lbImagePath;
        private System.Windows.Forms.Button btnTraineeLogout;
        private System.Windows.Forms.PictureBox picBoxTraineeImage;
        private System.Windows.Forms.Button btnTraineeSubmit;
        private System.Windows.Forms.Button btnFormGenerate;
    }
}