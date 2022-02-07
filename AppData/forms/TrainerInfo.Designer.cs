
namespace Mehedee_ADO_Project.AppData.forms
{
    partial class TrainerInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTrainerName = new System.Windows.Forms.Label();
            this.lblTrainerEmail = new System.Windows.Forms.Label();
            this.lblTrainerContact = new System.Windows.Forms.Label();
            this.lblTrainerTitle = new System.Windows.Forms.Label();
            this.txtTrainerName = new System.Windows.Forms.TextBox();
            this.txtTrainerContact = new System.Windows.Forms.TextBox();
            this.txtTraineeEmail = new System.Windows.Forms.TextBox();
            this.btnTrainerAdd = new System.Windows.Forms.Button();
            this.dgTrainer = new System.Windows.Forms.DataGridView();
            this.comBoxTSP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comBoxTspName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTrainerLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrainer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrainerName
            // 
            this.lblTrainerName.AutoSize = true;
            this.lblTrainerName.Location = new System.Drawing.Point(13, 99);
            this.lblTrainerName.Name = "lblTrainerName";
            this.lblTrainerName.Size = new System.Drawing.Size(107, 17);
            this.lblTrainerName.TabIndex = 0;
            this.lblTrainerName.Text = "Trainer Name : ";
            // 
            // lblTrainerEmail
            // 
            this.lblTrainerEmail.AutoSize = true;
            this.lblTrainerEmail.Location = new System.Drawing.Point(66, 232);
            this.lblTrainerEmail.Name = "lblTrainerEmail";
            this.lblTrainerEmail.Size = new System.Drawing.Size(54, 17);
            this.lblTrainerEmail.TabIndex = 0;
            this.lblTrainerEmail.Text = "Email : ";
            // 
            // lblTrainerContact
            // 
            this.lblTrainerContact.AutoSize = true;
            this.lblTrainerContact.Location = new System.Drawing.Point(52, 164);
            this.lblTrainerContact.Name = "lblTrainerContact";
            this.lblTrainerContact.Size = new System.Drawing.Size(68, 17);
            this.lblTrainerContact.TabIndex = 0;
            this.lblTrainerContact.Text = "Contact : ";
            // 
            // lblTrainerTitle
            // 
            this.lblTrainerTitle.AutoSize = true;
            this.lblTrainerTitle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTrainerTitle.Font = new System.Drawing.Font("Segoe Print", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainerTitle.Location = new System.Drawing.Point(424, 9);
            this.lblTrainerTitle.Name = "lblTrainerTitle";
            this.lblTrainerTitle.Size = new System.Drawing.Size(263, 43);
            this.lblTrainerTitle.TabIndex = 1;
            this.lblTrainerTitle.Text = "Trainer Information";
            // 
            // txtTrainerName
            // 
            this.txtTrainerName.Location = new System.Drawing.Point(126, 99);
            this.txtTrainerName.Multiline = true;
            this.txtTrainerName.Name = "txtTrainerName";
            this.txtTrainerName.Size = new System.Drawing.Size(234, 29);
            this.txtTrainerName.TabIndex = 2;
            // 
            // txtTrainerContact
            // 
            this.txtTrainerContact.Location = new System.Drawing.Point(126, 161);
            this.txtTrainerContact.Multiline = true;
            this.txtTrainerContact.Name = "txtTrainerContact";
            this.txtTrainerContact.Size = new System.Drawing.Size(234, 29);
            this.txtTrainerContact.TabIndex = 2;
            // 
            // txtTraineeEmail
            // 
            this.txtTraineeEmail.Location = new System.Drawing.Point(126, 229);
            this.txtTraineeEmail.Multiline = true;
            this.txtTraineeEmail.Name = "txtTraineeEmail";
            this.txtTraineeEmail.Size = new System.Drawing.Size(234, 29);
            this.txtTraineeEmail.TabIndex = 2;
            // 
            // btnTrainerAdd
            // 
            this.btnTrainerAdd.Location = new System.Drawing.Point(126, 321);
            this.btnTrainerAdd.Name = "btnTrainerAdd";
            this.btnTrainerAdd.Size = new System.Drawing.Size(104, 53);
            this.btnTrainerAdd.TabIndex = 3;
            this.btnTrainerAdd.Text = "Add Trainer";
            this.btnTrainerAdd.UseVisualStyleBackColor = true;
            this.btnTrainerAdd.Click += new System.EventHandler(this.btnTrainerAdd_Click);
            // 
            // dgTrainer
            // 
            this.dgTrainer.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTrainer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgTrainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTrainer.Location = new System.Drawing.Point(472, 99);
            this.dgTrainer.Name = "dgTrainer";
            this.dgTrainer.ReadOnly = true;
            this.dgTrainer.RowHeadersWidth = 51;
            this.dgTrainer.RowTemplate.Height = 24;
            this.dgTrainer.Size = new System.Drawing.Size(778, 504);
            this.dgTrainer.TabIndex = 4;
            // 
            // comBoxTSP
            // 
            this.comBoxTSP.FormattingEnabled = true;
            this.comBoxTSP.Location = new System.Drawing.Point(126, 280);
            this.comBoxTSP.Name = "comBoxTSP";
            this.comBoxTSP.Size = new System.Drawing.Size(234, 24);
            this.comBoxTSP.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email : ";
            // 
            // comBoxTspName
            // 
            this.comBoxTspName.FormattingEnabled = true;
            this.comBoxTspName.Location = new System.Drawing.Point(126, 280);
            this.comBoxTspName.Name = "comBoxTspName";
            this.comBoxTspName.Size = new System.Drawing.Size(234, 24);
            this.comBoxTspName.TabIndex = 5;
            this.comBoxTspName.DropDown += new System.EventHandler(this.comBoxTspName_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "TSP Name : ";
            // 
            // btnTrainerLogout
            // 
            this.btnTrainerLogout.Location = new System.Drawing.Point(844, 29);
            this.btnTrainerLogout.Name = "btnTrainerLogout";
            this.btnTrainerLogout.Size = new System.Drawing.Size(89, 34);
            this.btnTrainerLogout.TabIndex = 3;
            this.btnTrainerLogout.Text = "LOGOUT";
            this.btnTrainerLogout.UseVisualStyleBackColor = true;
            this.btnTrainerLogout.Click += new System.EventHandler(this.btnTrainerLogout_Click);
            // 
            // TrainerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 671);
            this.Controls.Add(this.comBoxTspName);
            this.Controls.Add(this.comBoxTSP);
            this.Controls.Add(this.dgTrainer);
            this.Controls.Add(this.btnTrainerLogout);
            this.Controls.Add(this.btnTrainerAdd);
            this.Controls.Add(this.txtTraineeEmail);
            this.Controls.Add(this.txtTrainerContact);
            this.Controls.Add(this.txtTrainerName);
            this.Controls.Add(this.lblTrainerTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTrainerContact);
            this.Controls.Add(this.lblTrainerEmail);
            this.Controls.Add(this.lblTrainerName);
            this.Name = "TrainerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TrainerList";
            this.Load += new System.EventHandler(this.TrainerInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTrainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrainerName;
        private System.Windows.Forms.Label lblTrainerEmail;
        private System.Windows.Forms.Label lblTrainerContact;
        private System.Windows.Forms.Label lblTrainerTitle;
        private System.Windows.Forms.TextBox txtTrainerName;
        private System.Windows.Forms.TextBox txtTrainerContact;
        private System.Windows.Forms.TextBox txtTraineeEmail;
        private System.Windows.Forms.Button btnTrainerAdd;
        private System.Windows.Forms.DataGridView dgTrainer;
        private System.Windows.Forms.ComboBox comBoxTSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBoxTspName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTrainerLogout;
    }
}