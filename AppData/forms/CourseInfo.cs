using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mehedee_ADO_Project.AppData.forms
{
    public partial class CourseInfo : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["tspDB"].ConnectionString;
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataTable dt;

        public CourseInfo()
        {
            InitializeComponent();
            GetTspForCourse();
            GetCourseFromCourses();
        }

        private void lblCourseTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnCourseLogout_Click(object sender, EventArgs e)
        {
            formProject home = new formProject();
            this.Hide();
            home.Show();
        }

        public void GetTspForCourse()
        {
            using (con = new SqlConnection(cs))
            {
               
                con.Open();
                cmd = new SqlCommand("SELECT * FROM TSPs", con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select TSP" };
                dt.Rows.InsertAt(dr, 0);

                comCourseTsp.ValueMember = "TSPID";
                comCourseTsp.DisplayMember = "TSPName";

                comCourseTsp.DataSource = dt;

                con.Close();
            }
        }

        public void GetCourseFromCourses()
        {
            using (con = new SqlConnection(cs))
            {

                con.Open();
                cmd = new SqlCommand("SELECT * FROM CourseDetails", con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select Course" };
                dt.Rows.InsertAt(dr, 0);

                comBoxAssignCourse.ValueMember = "CourseID";
                comBoxAssignCourse.DisplayMember = "CourseName";

                comBoxAssignCourse.DataSource = dt;

                con.Close();
            }
        }

        private void tabCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabCourse.SelectedIndex == 2)
            {
                CourseTrainerDisplay();
            }
            else if (tabCourse.SelectedIndex == 1)
            {
                CourseTraineeDisplay();
            }
        }

        public void CourseTrainerDisplay()
        {
            con = new SqlConnection(cs);
            adapter = new SqlDataAdapter("SELECT * FROM TrainerList", con);
            dt = new DataTable();
            adapter.Fill(dt);
            dgCourseTrainer.DataSource = dt;
        }

        private void dgCourseTrainer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUpdateTrainerId.Visible = true;
            lblUpdateTrainer.Visible = true;
            btnAssignCourse.BackColor = Color.Green;
            txtUpdateTrainerId.Text = this.dgCourseTrainer.CurrentRow.Cells["TrainerID"].Value.ToString();
        }

        private void btnAssignCourse_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();
                cmd = new SqlCommand("UPDATE TrainerList SET AssignedCourse = '" + comBoxAssignCourse.Text + "' WHERE TrainerID='"+txtUpdateTrainerId.Text+"'", con);
                MessageBox.Show("Course Assigned to : '"+txtUpdateTrainerId.Text+"'.");
                cmd.ExecuteNonQuery();
                con.Close();
                CourseTrainerDisplay();
            }
        }

        private void btnCourseSave_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                cmd = new SqlCommand("INSERT INTO CourseDetails VALUES ('" + txtCourseName.Text + "', '" + txtDuration.Text + "', '" + txtSeatAvailability.Text + "', '" + comCourseTsp.Text + "', '" + comCourseTsp.SelectedValue + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Course Assigned.");
                CourseDisplay();
            }
        }

        public void CourseDisplay()
        {
            con = new SqlConnection(cs);
            adapter = new SqlDataAdapter("SELECT * FROM CourseDetails", con);
            dt = new DataTable();
            adapter.Fill(dt);
            dgCourseInfo.DataSource = dt;
        }

        public void CourseTraineeDisplay()
        {
            con = new SqlConnection(cs);
            adapter = new SqlDataAdapter("SELECT * FROM Trainees", con);
            dt = new DataTable();
            adapter.Fill(dt);
            dgCourseTrainee.DataSource = dt;
        }

        private void CourseInfo_Load(object sender, EventArgs e)
        {
            CourseDisplay();
            CourseTraineeDisplay();
        }

        private void btnCourseUpdate_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();
                cmd = new SqlCommand("UPDATE CourseDetails SET CourseName = '" + txtCourseName.Text + "',Duration = '"+txtDuration.Text+ "',SeatAvailability = '"+txtSeatAvailability.Text+ "', AssignedTSP = '"+comCourseTsp.Text+ "',TSPID ='"+comCourseTsp.SelectedValue+"' WHERE CourseID='" + txtCourseUpdateId.Text + "'", con);
                MessageBox.Show("Course Updated : '" + txtCourseUpdateId.Text + "'.");
                cmd.ExecuteNonQuery();
                con.Close();
                CourseDisplay();
            }
        }

        private void dgCourseInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCourseUpdate.Visible = true;
            lblCourseUpdate.Visible = true;
            txtCourseUpdateId.Visible = true;
            btnCourseDelete.Visible = true;
            btnCourseSave.Visible = false;
            txtCourseName.Text = this.dgCourseInfo.CurrentRow.Cells["CourseName"].Value.ToString();
            txtDuration.Text = this.dgCourseInfo.CurrentRow.Cells["Duration"].Value.ToString();
            txtSeatAvailability.Text = this.dgCourseInfo.CurrentRow.Cells["SeatAvailability"].Value.ToString();
            txtCourseUpdateId.Text = this.dgCourseInfo.CurrentRow.Cells["CourseID"].Value.ToString();
        }

        private void btnCourseDelete_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                cmd = new SqlCommand("DELETE FROM CourseDetails WHERE CourseID = '" + txtCourseUpdateId.Text+"'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Course Deleted");
                CourseDisplay();
            }
        }

        private void dgCourseTrainee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUpdateTraineeId.Text = this.dgCourseTrainee.CurrentRow.Cells["TraineeID"].Value.ToString();
            txtUpdateTraineeId.ReadOnly = true;
        }

        private void btnUpdateTraineeStatus_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();
                cmd = new SqlCommand("UPDATE Trainees SET TraineeStatus = '" + comBoxTraineeStatus.Text + "' WHERE TraineeID='" + txtUpdateTraineeId.Text + "'", con);
                MessageBox.Show("Trainee Status Updated : '" + txtCourseUpdateId.Text + "'.");
                cmd.ExecuteNonQuery();
                con.Close();
                CourseTraineeDisplay();
            }
        }

        private void btnDeleteTrainee_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                cmd = new SqlCommand("DELETE FROM Trainees WHERE TraineeID = '" + txtUpdateTraineeId.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Trainee Removed");
                CourseTraineeDisplay();
            }
        }
    }
}
