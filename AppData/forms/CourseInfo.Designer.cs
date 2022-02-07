
namespace Mehedee_ADO_Project.AppData.forms
{
    partial class CourseInfo
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
            this.tabCourse = new System.Windows.Forms.TabControl();
            this.tabCourseInfo = new System.Windows.Forms.TabPage();
            this.comCourseTsp = new System.Windows.Forms.ComboBox();
            this.txtSeatAvailability = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.btnCourseDelete = new System.Windows.Forms.Button();
            this.btnCourseUpdate = new System.Windows.Forms.Button();
            this.btnCourseLogout = new System.Windows.Forms.Button();
            this.btnCourseSave = new System.Windows.Forms.Button();
            this.lblAssignedTsp = new System.Windows.Forms.Label();
            this.lblCourseDuration = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseTitle = new System.Windows.Forms.Label();
            this.dgCourseInfo = new System.Windows.Forms.DataGridView();
            this.tabTraineeInfo = new System.Windows.Forms.TabPage();
            this.comBoxTraineeStatus = new System.Windows.Forms.ComboBox();
            this.btnDeleteTrainee = new System.Windows.Forms.Button();
            this.btnUpdateTraineeStatus = new System.Windows.Forms.Button();
            this.dgCourseTrainee = new System.Windows.Forms.DataGridView();
            this.tabTrainerInfo = new System.Windows.Forms.TabPage();
            this.lblAssignCourse = new System.Windows.Forms.Label();
            this.comBoxAssignCourse = new System.Windows.Forms.ComboBox();
            this.btnAssignCourse = new System.Windows.Forms.Button();
            this.dgCourseTrainer = new System.Windows.Forms.DataGridView();
            this.tabEnrollmentInfo = new System.Windows.Forms.TabPage();
            this.lblSeatAvailabitlity = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtUpdateTrainerId = new System.Windows.Forms.TextBox();
            this.lblUpdateTrainer = new System.Windows.Forms.Label();
            this.txtCourseUpdateId = new System.Windows.Forms.TextBox();
            this.lblCourseUpdate = new System.Windows.Forms.Label();
            this.txtUpdateTraineeId = new System.Windows.Forms.TextBox();
            this.lblUpdateTrainee = new System.Windows.Forms.Label();
            this.tabCourse.SuspendLayout();
            this.tabCourseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourseInfo)).BeginInit();
            this.tabTraineeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourseTrainee)).BeginInit();
            this.tabTrainerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourseTrainer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCourse
            // 
            this.tabCourse.Controls.Add(this.tabCourseInfo);
            this.tabCourse.Controls.Add(this.tabTraineeInfo);
            this.tabCourse.Controls.Add(this.tabTrainerInfo);
            this.tabCourse.Controls.Add(this.tabEnrollmentInfo);
            this.tabCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCourse.Location = new System.Drawing.Point(0, 0);
            this.tabCourse.Name = "tabCourse";
            this.tabCourse.SelectedIndex = 0;
            this.tabCourse.Size = new System.Drawing.Size(1262, 671);
            this.tabCourse.TabIndex = 0;
            this.tabCourse.SelectedIndexChanged += new System.EventHandler(this.tabCourse_SelectedIndexChanged);
            // 
            // tabCourseInfo
            // 
            this.tabCourseInfo.Controls.Add(this.lblCourseUpdate);
            this.tabCourseInfo.Controls.Add(this.txtCourseUpdateId);
            this.tabCourseInfo.Controls.Add(this.comCourseTsp);
            this.tabCourseInfo.Controls.Add(this.txtDuration);
            this.tabCourseInfo.Controls.Add(this.txtSeatAvailability);
            this.tabCourseInfo.Controls.Add(this.txtCourseName);
            this.tabCourseInfo.Controls.Add(this.btnCourseDelete);
            this.tabCourseInfo.Controls.Add(this.btnCourseUpdate);
            this.tabCourseInfo.Controls.Add(this.btnCourseLogout);
            this.tabCourseInfo.Controls.Add(this.lblSeatAvailabitlity);
            this.tabCourseInfo.Controls.Add(this.btnCourseSave);
            this.tabCourseInfo.Controls.Add(this.lblAssignedTsp);
            this.tabCourseInfo.Controls.Add(this.lblCourseDuration);
            this.tabCourseInfo.Controls.Add(this.lblCourseName);
            this.tabCourseInfo.Controls.Add(this.lblCourseTitle);
            this.tabCourseInfo.Controls.Add(this.dgCourseInfo);
            this.tabCourseInfo.Location = new System.Drawing.Point(4, 25);
            this.tabCourseInfo.Name = "tabCourseInfo";
            this.tabCourseInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCourseInfo.Size = new System.Drawing.Size(1254, 642);
            this.tabCourseInfo.TabIndex = 0;
            this.tabCourseInfo.Text = "Course Information";
            this.tabCourseInfo.UseVisualStyleBackColor = true;
            // 
            // comCourseTsp
            // 
            this.comCourseTsp.FormattingEnabled = true;
            this.comCourseTsp.Location = new System.Drawing.Point(166, 377);
            this.comCourseTsp.Name = "comCourseTsp";
            this.comCourseTsp.Size = new System.Drawing.Size(215, 24);
            this.comCourseTsp.TabIndex = 8;
            // 
            // txtSeatAvailability
            // 
            this.txtSeatAvailability.Location = new System.Drawing.Point(166, 268);
            this.txtSeatAvailability.Multiline = true;
            this.txtSeatAvailability.Name = "txtSeatAvailability";
            this.txtSeatAvailability.Size = new System.Drawing.Size(215, 32);
            this.txtSeatAvailability.TabIndex = 6;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(179, 114);
            this.txtCourseName.Multiline = true;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(215, 32);
            this.txtCourseName.TabIndex = 6;
            // 
            // btnCourseDelete
            // 
            this.btnCourseDelete.Location = new System.Drawing.Point(294, 442);
            this.btnCourseDelete.Name = "btnCourseDelete";
            this.btnCourseDelete.Size = new System.Drawing.Size(100, 40);
            this.btnCourseDelete.TabIndex = 5;
            this.btnCourseDelete.Text = "DELETE";
            this.btnCourseDelete.UseVisualStyleBackColor = true;
            this.btnCourseDelete.Visible = false;
            this.btnCourseDelete.Click += new System.EventHandler(this.btnCourseDelete_Click);
            // 
            // btnCourseUpdate
            // 
            this.btnCourseUpdate.Location = new System.Drawing.Point(166, 442);
            this.btnCourseUpdate.Name = "btnCourseUpdate";
            this.btnCourseUpdate.Size = new System.Drawing.Size(100, 40);
            this.btnCourseUpdate.TabIndex = 5;
            this.btnCourseUpdate.Text = "UPDATE";
            this.btnCourseUpdate.UseVisualStyleBackColor = true;
            this.btnCourseUpdate.Visible = false;
            this.btnCourseUpdate.Click += new System.EventHandler(this.btnCourseUpdate_Click);
            // 
            // btnCourseLogout
            // 
            this.btnCourseLogout.Location = new System.Drawing.Point(925, 30);
            this.btnCourseLogout.Name = "btnCourseLogout";
            this.btnCourseLogout.Size = new System.Drawing.Size(100, 40);
            this.btnCourseLogout.TabIndex = 5;
            this.btnCourseLogout.Text = "LOGOUT";
            this.btnCourseLogout.UseVisualStyleBackColor = true;
            this.btnCourseLogout.Click += new System.EventHandler(this.btnCourseLogout_Click);
            // 
            // btnCourseSave
            // 
            this.btnCourseSave.Location = new System.Drawing.Point(31, 442);
            this.btnCourseSave.Name = "btnCourseSave";
            this.btnCourseSave.Size = new System.Drawing.Size(100, 40);
            this.btnCourseSave.TabIndex = 5;
            this.btnCourseSave.Text = "SAVE";
            this.btnCourseSave.UseVisualStyleBackColor = true;
            this.btnCourseSave.Click += new System.EventHandler(this.btnCourseSave_Click);
            // 
            // lblAssignedTsp
            // 
            this.lblAssignedTsp.AutoSize = true;
            this.lblAssignedTsp.Location = new System.Drawing.Point(36, 377);
            this.lblAssignedTsp.Name = "lblAssignedTsp";
            this.lblAssignedTsp.Size = new System.Drawing.Size(109, 17);
            this.lblAssignedTsp.TabIndex = 4;
            this.lblAssignedTsp.Text = "Assigned TSP : ";
            // 
            // lblCourseDuration
            // 
            this.lblCourseDuration.AutoSize = true;
            this.lblCourseDuration.Location = new System.Drawing.Point(63, 176);
            this.lblCourseDuration.Name = "lblCourseDuration";
            this.lblCourseDuration.Size = new System.Drawing.Size(74, 17);
            this.lblCourseDuration.TabIndex = 4;
            this.lblCourseDuration.Text = "Duration : ";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(31, 129);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(106, 17);
            this.lblCourseName.TabIndex = 3;
            this.lblCourseName.Text = "Course Name : ";
            // 
            // lblCourseTitle
            // 
            this.lblCourseTitle.AutoSize = true;
            this.lblCourseTitle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCourseTitle.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseTitle.Location = new System.Drawing.Point(394, 33);
            this.lblCourseTitle.Name = "lblCourseTitle";
            this.lblCourseTitle.Size = new System.Drawing.Size(155, 35);
            this.lblCourseTitle.TabIndex = 2;
            this.lblCourseTitle.Text = "Course Details";
            this.lblCourseTitle.Click += new System.EventHandler(this.lblCourseTitle_Click);
            // 
            // dgCourseInfo
            // 
            this.dgCourseInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCourseInfo.Location = new System.Drawing.Point(448, 107);
            this.dgCourseInfo.Name = "dgCourseInfo";
            this.dgCourseInfo.RowHeadersWidth = 51;
            this.dgCourseInfo.RowTemplate.Height = 24;
            this.dgCourseInfo.Size = new System.Drawing.Size(803, 527);
            this.dgCourseInfo.TabIndex = 1;
            this.dgCourseInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCourseInfo_CellClick);
            // 
            // tabTraineeInfo
            // 
            this.tabTraineeInfo.Controls.Add(this.lblUpdateTrainee);
            this.tabTraineeInfo.Controls.Add(this.txtUpdateTraineeId);
            this.tabTraineeInfo.Controls.Add(this.comBoxTraineeStatus);
            this.tabTraineeInfo.Controls.Add(this.btnDeleteTrainee);
            this.tabTraineeInfo.Controls.Add(this.btnUpdateTraineeStatus);
            this.tabTraineeInfo.Controls.Add(this.dgCourseTrainee);
            this.tabTraineeInfo.Location = new System.Drawing.Point(4, 25);
            this.tabTraineeInfo.Name = "tabTraineeInfo";
            this.tabTraineeInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTraineeInfo.Size = new System.Drawing.Size(1254, 642);
            this.tabTraineeInfo.TabIndex = 2;
            this.tabTraineeInfo.Text = "Trainee Information";
            this.tabTraineeInfo.UseVisualStyleBackColor = true;
            // 
            // comBoxTraineeStatus
            // 
            this.comBoxTraineeStatus.FormattingEnabled = true;
            this.comBoxTraineeStatus.Items.AddRange(new object[] {
            "Active",
            "Withdrawn"});
            this.comBoxTraineeStatus.Location = new System.Drawing.Point(85, 52);
            this.comBoxTraineeStatus.Name = "comBoxTraineeStatus";
            this.comBoxTraineeStatus.Size = new System.Drawing.Size(247, 24);
            this.comBoxTraineeStatus.TabIndex = 2;
            // 
            // btnDeleteTrainee
            // 
            this.btnDeleteTrainee.Location = new System.Drawing.Point(395, 82);
            this.btnDeleteTrainee.Name = "btnDeleteTrainee";
            this.btnDeleteTrainee.Size = new System.Drawing.Size(135, 39);
            this.btnDeleteTrainee.TabIndex = 1;
            this.btnDeleteTrainee.Text = "Delete Trainee";
            this.btnDeleteTrainee.UseVisualStyleBackColor = true;
            this.btnDeleteTrainee.Click += new System.EventHandler(this.btnDeleteTrainee_Click);
            // 
            // btnUpdateTraineeStatus
            // 
            this.btnUpdateTraineeStatus.Location = new System.Drawing.Point(85, 82);
            this.btnUpdateTraineeStatus.Name = "btnUpdateTraineeStatus";
            this.btnUpdateTraineeStatus.Size = new System.Drawing.Size(247, 39);
            this.btnUpdateTraineeStatus.TabIndex = 1;
            this.btnUpdateTraineeStatus.Text = "Update Trainee Status";
            this.btnUpdateTraineeStatus.UseVisualStyleBackColor = true;
            this.btnUpdateTraineeStatus.Click += new System.EventHandler(this.btnUpdateTraineeStatus_Click);
            // 
            // dgCourseTrainee
            // 
            this.dgCourseTrainee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCourseTrainee.Location = new System.Drawing.Point(85, 140);
            this.dgCourseTrainee.Name = "dgCourseTrainee";
            this.dgCourseTrainee.RowHeadersWidth = 51;
            this.dgCourseTrainee.RowTemplate.Height = 24;
            this.dgCourseTrainee.Size = new System.Drawing.Size(958, 442);
            this.dgCourseTrainee.TabIndex = 0;
            this.dgCourseTrainee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCourseTrainee_CellClick);
            // 
            // tabTrainerInfo
            // 
            this.tabTrainerInfo.Controls.Add(this.lblUpdateTrainer);
            this.tabTrainerInfo.Controls.Add(this.txtUpdateTrainerId);
            this.tabTrainerInfo.Controls.Add(this.lblAssignCourse);
            this.tabTrainerInfo.Controls.Add(this.comBoxAssignCourse);
            this.tabTrainerInfo.Controls.Add(this.btnAssignCourse);
            this.tabTrainerInfo.Controls.Add(this.dgCourseTrainer);
            this.tabTrainerInfo.Location = new System.Drawing.Point(4, 25);
            this.tabTrainerInfo.Name = "tabTrainerInfo";
            this.tabTrainerInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrainerInfo.Size = new System.Drawing.Size(1254, 642);
            this.tabTrainerInfo.TabIndex = 3;
            this.tabTrainerInfo.Text = "Trainer Information";
            this.tabTrainerInfo.UseVisualStyleBackColor = true;
            // 
            // lblAssignCourse
            // 
            this.lblAssignCourse.AutoSize = true;
            this.lblAssignCourse.Location = new System.Drawing.Point(247, 55);
            this.lblAssignCourse.Name = "lblAssignCourse";
            this.lblAssignCourse.Size = new System.Drawing.Size(72, 17);
            this.lblAssignCourse.TabIndex = 4;
            this.lblAssignCourse.Text = "Courses : ";
            // 
            // comBoxAssignCourse
            // 
            this.comBoxAssignCourse.FormattingEnabled = true;
            this.comBoxAssignCourse.Location = new System.Drawing.Point(345, 52);
            this.comBoxAssignCourse.Name = "comBoxAssignCourse";
            this.comBoxAssignCourse.Size = new System.Drawing.Size(199, 24);
            this.comBoxAssignCourse.TabIndex = 3;
            // 
            // btnAssignCourse
            // 
            this.btnAssignCourse.Location = new System.Drawing.Point(632, 52);
            this.btnAssignCourse.Name = "btnAssignCourse";
            this.btnAssignCourse.Size = new System.Drawing.Size(253, 42);
            this.btnAssignCourse.TabIndex = 2;
            this.btnAssignCourse.Text = "Assign Course";
            this.btnAssignCourse.UseVisualStyleBackColor = true;
            this.btnAssignCourse.Click += new System.EventHandler(this.btnAssignCourse_Click);
            // 
            // dgCourseTrainer
            // 
            this.dgCourseTrainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCourseTrainer.Location = new System.Drawing.Point(148, 100);
            this.dgCourseTrainer.Name = "dgCourseTrainer";
            this.dgCourseTrainer.RowHeadersWidth = 51;
            this.dgCourseTrainer.RowTemplate.Height = 24;
            this.dgCourseTrainer.Size = new System.Drawing.Size(958, 442);
            this.dgCourseTrainer.TabIndex = 1;
            this.dgCourseTrainer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCourseTrainer_CellClick);
            // 
            // tabEnrollmentInfo
            // 
            this.tabEnrollmentInfo.Location = new System.Drawing.Point(4, 25);
            this.tabEnrollmentInfo.Name = "tabEnrollmentInfo";
            this.tabEnrollmentInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabEnrollmentInfo.Size = new System.Drawing.Size(1254, 642);
            this.tabEnrollmentInfo.TabIndex = 5;
            this.tabEnrollmentInfo.Text = "Enrollment Information";
            this.tabEnrollmentInfo.UseVisualStyleBackColor = true;
            // 
            // lblSeatAvailabitlity
            // 
            this.lblSeatAvailabitlity.AutoSize = true;
            this.lblSeatAvailabitlity.Location = new System.Drawing.Point(20, 268);
            this.lblSeatAvailabitlity.Name = "lblSeatAvailabitlity";
            this.lblSeatAvailabitlity.Size = new System.Drawing.Size(117, 17);
            this.lblSeatAvailabitlity.TabIndex = 4;
            this.lblSeatAvailabitlity.Text = "Available Seats : ";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(179, 173);
            this.txtDuration.Multiline = true;
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(215, 32);
            this.txtDuration.TabIndex = 6;
            // 
            // txtUpdateTrainerId
            // 
            this.txtUpdateTrainerId.Location = new System.Drawing.Point(345, 6);
            this.txtUpdateTrainerId.Name = "txtUpdateTrainerId";
            this.txtUpdateTrainerId.ReadOnly = true;
            this.txtUpdateTrainerId.Size = new System.Drawing.Size(57, 22);
            this.txtUpdateTrainerId.TabIndex = 5;
            this.txtUpdateTrainerId.Visible = false;
            // 
            // lblUpdateTrainer
            // 
            this.lblUpdateTrainer.AutoSize = true;
            this.lblUpdateTrainer.Location = new System.Drawing.Point(192, 6);
            this.lblUpdateTrainer.Name = "lblUpdateTrainer";
            this.lblUpdateTrainer.Size = new System.Drawing.Size(127, 17);
            this.lblUpdateTrainer.TabIndex = 6;
            this.lblUpdateTrainer.Text = "Updating Trainer : ";
            this.lblUpdateTrainer.Visible = false;
            // 
            // txtCourseUpdateId
            // 
            this.txtCourseUpdateId.Location = new System.Drawing.Point(166, 528);
            this.txtCourseUpdateId.Name = "txtCourseUpdateId";
            this.txtCourseUpdateId.Size = new System.Drawing.Size(62, 22);
            this.txtCourseUpdateId.TabIndex = 9;
            this.txtCourseUpdateId.Visible = false;
            // 
            // lblCourseUpdate
            // 
            this.lblCourseUpdate.AutoSize = true;
            this.lblCourseUpdate.Location = new System.Drawing.Point(84, 528);
            this.lblCourseUpdate.Name = "lblCourseUpdate";
            this.lblCourseUpdate.Size = new System.Drawing.Size(65, 17);
            this.lblCourseUpdate.TabIndex = 10;
            this.lblCourseUpdate.Text = "Updating";
            this.lblCourseUpdate.Visible = false;
            // 
            // txtUpdateTraineeId
            // 
            this.txtUpdateTraineeId.Location = new System.Drawing.Point(494, 38);
            this.txtUpdateTraineeId.Multiline = true;
            this.txtUpdateTraineeId.Name = "txtUpdateTraineeId";
            this.txtUpdateTraineeId.Size = new System.Drawing.Size(119, 36);
            this.txtUpdateTraineeId.TabIndex = 3;
            // 
            // lblUpdateTrainee
            // 
            this.lblUpdateTrainee.AutoSize = true;
            this.lblUpdateTrainee.Location = new System.Drawing.Point(362, 41);
            this.lblUpdateTrainee.Name = "lblUpdateTrainee";
            this.lblUpdateTrainee.Size = new System.Drawing.Size(126, 17);
            this.lblUpdateTrainee.TabIndex = 4;
            this.lblUpdateTrainee.Text = "Updating Trainee: ";
            // 
            // CourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 671);
            this.Controls.Add(this.tabCourse);
            this.Name = "CourseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CourseInfo";
            this.Load += new System.EventHandler(this.CourseInfo_Load);
            this.tabCourse.ResumeLayout(false);
            this.tabCourseInfo.ResumeLayout(false);
            this.tabCourseInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourseInfo)).EndInit();
            this.tabTraineeInfo.ResumeLayout(false);
            this.tabTraineeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourseTrainee)).EndInit();
            this.tabTrainerInfo.ResumeLayout(false);
            this.tabTrainerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourseTrainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCourse;
        private System.Windows.Forms.TabPage tabCourseInfo;
        private System.Windows.Forms.TabPage tabTraineeInfo;
        private System.Windows.Forms.TabPage tabTrainerInfo;
        private System.Windows.Forms.TabPage tabEnrollmentInfo;
        private System.Windows.Forms.DataGridView dgCourseInfo;
        private System.Windows.Forms.Label lblCourseTitle;
        private System.Windows.Forms.Button btnCourseDelete;
        private System.Windows.Forms.Button btnCourseUpdate;
        private System.Windows.Forms.Button btnCourseSave;
        private System.Windows.Forms.Label lblAssignedTsp;
        private System.Windows.Forms.Label lblCourseDuration;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.ComboBox comCourseTsp;
        private System.Windows.Forms.TextBox txtSeatAvailability;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Button btnCourseLogout;
        private System.Windows.Forms.ComboBox comBoxTraineeStatus;
        private System.Windows.Forms.Button btnDeleteTrainee;
        private System.Windows.Forms.Button btnUpdateTraineeStatus;
        private System.Windows.Forms.DataGridView dgCourseTrainee;
        private System.Windows.Forms.ComboBox comBoxAssignCourse;
        private System.Windows.Forms.Button btnAssignCourse;
        private System.Windows.Forms.Label lblAssignCourse;
        public System.Windows.Forms.DataGridView dgCourseTrainer;
        private System.Windows.Forms.Label lblSeatAvailabitlity;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblUpdateTrainer;
        private System.Windows.Forms.TextBox txtUpdateTrainerId;
        private System.Windows.Forms.Label lblCourseUpdate;
        private System.Windows.Forms.TextBox txtCourseUpdateId;
        private System.Windows.Forms.Label lblUpdateTrainee;
        private System.Windows.Forms.TextBox txtUpdateTraineeId;
    }
}