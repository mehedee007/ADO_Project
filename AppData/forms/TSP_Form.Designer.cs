
namespace Mehedee_ADO_Project.AppData.forms
{
    partial class Form_TSP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TSP));
            this.lblTspTitle = new System.Windows.Forms.Label();
            this.lblTspId = new System.Windows.Forms.Label();
            this.tlTipTspName = new System.Windows.Forms.ToolTip(this.components);
            this.txtBoxTspName = new System.Windows.Forms.TextBox();
            this.btnTspLogout = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.dgOutputTsp = new System.Windows.Forms.DataGridView();
            this.lblTspLocation = new System.Windows.Forms.Label();
            this.lblTspManager = new System.Windows.Forms.Label();
            this.lblTspContact = new System.Windows.Forms.Label();
            this.lblTspEmail = new System.Windows.Forms.Label();
            this.btnTspUpdate = new System.Windows.Forms.Button();
            this.txtTspManager = new System.Windows.Forms.TextBox();
            this.comBoxTspLocation = new System.Windows.Forms.ComboBox();
            this.txtTspContact = new System.Windows.Forms.TextBox();
            this.txtTspEmail = new System.Windows.Forms.TextBox();
            this.lblUpdateTsp = new System.Windows.Forms.Label();
            this.txtUpdateTspId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgOutputTsp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTspTitle
            // 
            this.lblTspTitle.AutoSize = true;
            this.lblTspTitle.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTspTitle.Location = new System.Drawing.Point(576, 13);
            this.lblTspTitle.Name = "lblTspTitle";
            this.lblTspTitle.Size = new System.Drawing.Size(185, 26);
            this.lblTspTitle.TabIndex = 1;
            this.lblTspTitle.Text = "TSP Information";
            this.lblTspTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTspId
            // 
            this.lblTspId.AutoSize = true;
            this.lblTspId.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTspId.Location = new System.Drawing.Point(23, 87);
            this.lblTspId.Name = "lblTspId";
            this.lblTspId.Size = new System.Drawing.Size(107, 23);
            this.lblTspId.TabIndex = 2;
            this.lblTspId.Text = "TSP Name : ";
            // 
            // tlTipTspName
            // 
            this.tlTipTspName.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tlTipTspName.ToolTipTitle = "Insert the TSP Name Here";
            // 
            // txtBoxTspName
            // 
            this.txtBoxTspName.Location = new System.Drawing.Point(150, 87);
            this.txtBoxTspName.Multiline = true;
            this.txtBoxTspName.Name = "txtBoxTspName";
            this.txtBoxTspName.Size = new System.Drawing.Size(439, 35);
            this.txtBoxTspName.TabIndex = 3;
            // 
            // btnTspLogout
            // 
            this.btnTspLogout.Location = new System.Drawing.Point(954, 16);
            this.btnTspLogout.Name = "btnTspLogout";
            this.btnTspLogout.Size = new System.Drawing.Size(84, 44);
            this.btnTspLogout.TabIndex = 4;
            this.btnTspLogout.Text = "Logout";
            this.btnTspLogout.UseVisualStyleBackColor = true;
            this.btnTspLogout.Click += new System.EventHandler(this.btnTspLogout_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(335, 446);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 52);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // dgOutputTsp
            // 
            this.dgOutputTsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOutputTsp.Location = new System.Drawing.Point(624, 87);
            this.dgOutputTsp.Name = "dgOutputTsp";
            this.dgOutputTsp.RowHeadersWidth = 51;
            this.dgOutputTsp.RowTemplate.Height = 24;
            this.dgOutputTsp.Size = new System.Drawing.Size(635, 581);
            this.dgOutputTsp.TabIndex = 5;
            this.dgOutputTsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOutputTsp_CellClick);
            // 
            // lblTspLocation
            // 
            this.lblTspLocation.AutoSize = true;
            this.lblTspLocation.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTspLocation.Location = new System.Drawing.Point(12, 160);
            this.lblTspLocation.Name = "lblTspLocation";
            this.lblTspLocation.Size = new System.Drawing.Size(128, 23);
            this.lblTspLocation.TabIndex = 2;
            this.lblTspLocation.Text = "TSP Location : ";
            // 
            // lblTspManager
            // 
            this.lblTspManager.AutoSize = true;
            this.lblTspManager.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTspManager.Location = new System.Drawing.Point(44, 212);
            this.lblTspManager.Name = "lblTspManager";
            this.lblTspManager.Size = new System.Drawing.Size(96, 23);
            this.lblTspManager.TabIndex = 2;
            this.lblTspManager.Text = "Manager : ";
            // 
            // lblTspContact
            // 
            this.lblTspContact.AutoSize = true;
            this.lblTspContact.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTspContact.Location = new System.Drawing.Point(53, 290);
            this.lblTspContact.Name = "lblTspContact";
            this.lblTspContact.Size = new System.Drawing.Size(87, 23);
            this.lblTspContact.TabIndex = 2;
            this.lblTspContact.Text = "Contact : ";
            // 
            // lblTspEmail
            // 
            this.lblTspEmail.AutoSize = true;
            this.lblTspEmail.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTspEmail.Location = new System.Drawing.Point(71, 349);
            this.lblTspEmail.Name = "lblTspEmail";
            this.lblTspEmail.Size = new System.Drawing.Size(69, 23);
            this.lblTspEmail.TabIndex = 2;
            this.lblTspEmail.Text = "Email : ";
            // 
            // btnTspUpdate
            // 
            this.btnTspUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTspUpdate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTspUpdate.Location = new System.Drawing.Point(435, 445);
            this.btnTspUpdate.Name = "btnTspUpdate";
            this.btnTspUpdate.Size = new System.Drawing.Size(92, 53);
            this.btnTspUpdate.TabIndex = 0;
            this.btnTspUpdate.Text = "UPDATE";
            this.btnTspUpdate.UseVisualStyleBackColor = true;
            this.btnTspUpdate.Visible = false;
            this.btnTspUpdate.Click += new System.EventHandler(this.btnTspUpdate_Click);
            // 
            // txtTspManager
            // 
            this.txtTspManager.Location = new System.Drawing.Point(150, 214);
            this.txtTspManager.Multiline = true;
            this.txtTspManager.Name = "txtTspManager";
            this.txtTspManager.Size = new System.Drawing.Size(439, 35);
            this.txtTspManager.TabIndex = 3;
            // 
            // comBoxTspLocation
            // 
            this.comBoxTspLocation.FormattingEnabled = true;
            this.comBoxTspLocation.Items.AddRange(new object[] {
            "Dhaka",
            "Chittagong"});
            this.comBoxTspLocation.Location = new System.Drawing.Point(150, 160);
            this.comBoxTspLocation.Name = "comBoxTspLocation";
            this.comBoxTspLocation.Size = new System.Drawing.Size(439, 24);
            this.comBoxTspLocation.TabIndex = 6;
            // 
            // txtTspContact
            // 
            this.txtTspContact.Location = new System.Drawing.Point(150, 278);
            this.txtTspContact.Multiline = true;
            this.txtTspContact.Name = "txtTspContact";
            this.txtTspContact.Size = new System.Drawing.Size(439, 35);
            this.txtTspContact.TabIndex = 3;
            // 
            // txtTspEmail
            // 
            this.txtTspEmail.Location = new System.Drawing.Point(150, 337);
            this.txtTspEmail.Multiline = true;
            this.txtTspEmail.Name = "txtTspEmail";
            this.txtTspEmail.Size = new System.Drawing.Size(439, 35);
            this.txtTspEmail.TabIndex = 3;
            // 
            // lblUpdateTsp
            // 
            this.lblUpdateTsp.AutoSize = true;
            this.lblUpdateTsp.Location = new System.Drawing.Point(332, 543);
            this.lblUpdateTsp.Name = "lblUpdateTsp";
            this.lblUpdateTsp.Size = new System.Drawing.Size(125, 17);
            this.lblUpdateTsp.TabIndex = 7;
            this.lblUpdateTsp.Text = "Updating TSP ID =";
            this.lblUpdateTsp.Visible = false;
            // 
            // txtUpdateTspId
            // 
            this.txtUpdateTspId.Location = new System.Drawing.Point(472, 540);
            this.txtUpdateTspId.Multiline = true;
            this.txtUpdateTspId.Name = "txtUpdateTspId";
            this.txtUpdateTspId.Size = new System.Drawing.Size(33, 36);
            this.txtUpdateTspId.TabIndex = 8;
            this.txtUpdateTspId.Visible = false;
            // 
            // Form_TSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 671);
            this.Controls.Add(this.txtUpdateTspId);
            this.Controls.Add(this.lblUpdateTsp);
            this.Controls.Add(this.comBoxTspLocation);
            this.Controls.Add(this.dgOutputTsp);
            this.Controls.Add(this.btnTspLogout);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtTspEmail);
            this.Controls.Add(this.txtTspContact);
            this.Controls.Add(this.txtTspManager);
            this.Controls.Add(this.txtBoxTspName);
            this.Controls.Add(this.lblTspEmail);
            this.Controls.Add(this.lblTspManager);
            this.Controls.Add(this.lblTspContact);
            this.Controls.Add(this.lblTspLocation);
            this.Controls.Add(this.lblTspId);
            this.Controls.Add(this.lblTspTitle);
            this.Controls.Add(this.btnTspUpdate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form_TSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Project Management Application";
            this.Load += new System.EventHandler(this.Form_TSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOutputTsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTspTitle;
        private System.Windows.Forms.Label lblTspId;
        private System.Windows.Forms.ToolTip tlTipTspName;
        private System.Windows.Forms.TextBox txtBoxTspName;
        private System.Windows.Forms.Button btnTspLogout;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DataGridView dgOutputTsp;
        private System.Windows.Forms.Label lblTspLocation;
        private System.Windows.Forms.Label lblTspManager;
        private System.Windows.Forms.Label lblTspContact;
        private System.Windows.Forms.Label lblTspEmail;
        private System.Windows.Forms.Button btnTspUpdate;
        private System.Windows.Forms.TextBox txtTspManager;
        private System.Windows.Forms.ComboBox comBoxTspLocation;
        private System.Windows.Forms.TextBox txtTspContact;
        private System.Windows.Forms.TextBox txtTspEmail;
        private System.Windows.Forms.Label lblUpdateTsp;
        private System.Windows.Forms.TextBox txtUpdateTspId;
    }
}