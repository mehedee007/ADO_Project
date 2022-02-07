using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mehedee_ADO_Project.AppData.forms
{
    public partial class TraineeInfo : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["tspDB"].ConnectionString;
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataTable dt;
        string gender;

        public TraineeInfo()
        {
            InitializeComponent();
            GetCourseFromCoursesForTrainee();
        }

        private void lblTraineeDOB_Click(object sender, EventArgs e)
        {

        }

        private void btnTraineeLogout_Click(object sender, EventArgs e)
        {
            formProject home = new formProject();
            this.Hide();
            home.Show();
        }

        private void btnTraineeSubmit_Click(object sender, EventArgs e)
        {
            File.Copy(txtTraineeImagePath.Text, Path.Combine(@"C:\Users\dream\OneDrive\Desktop\1260927\Mehedee_ADO_Project\AppData\traineeImages", Path.GetFileName(txtTraineeImagePath.Text)), true);
            using (con = new SqlConnection(cs))
            {
                cmd = new SqlCommand("EXEC sp_TraineeSaveCourseUpdate '"+txtTraineeName.Text+"', @dob, '"+gender+"', '"+txtTraineeContact.Text+"', '"+txtEmail.Text+"', '"+comTraineeCourse.Text+"', '"+comTraineeCourse.SelectedValue+"', '"+txtTraineeImagePath.Text+"'", con);
                cmd.Parameters.AddWithValue("@dob", dtpTrainee.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Trainee Registered.");
                TraineeDisplay();
            }
        }

        public void GetCourseFromCoursesForTrainee()
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

                comTraineeCourse.ValueMember = "CourseID";
                comTraineeCourse.DisplayMember = "CourseName";

                comTraineeCourse.DataSource = dt;

                con.Close();
            }
        }

        private void TraineeInfo_Load(object sender, EventArgs e)
        {
            TraineeDisplay();
        }

        public void TraineeDisplay()
        {
            con = new SqlConnection(cs);
            adapter = new SqlDataAdapter("SELECT * FROM Trainees", con);
            dt = new DataTable();
            adapter.Fill(dt);
            dgTrainee.DataSource = dt;
        }

        private void btnImageBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*jpg; *jpeg; *gif; *bmp;)|*jpg; *jpeg; *gif; *bmp;";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtTraineeImagePath.Text = openFile.FileName;
                picBoxTraineeImage.Image = new Bitmap(openFile.FileName);
            }
        }

        private void radioTraineeMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioTraineeFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void btnFormGenerate_Click(object sender, EventArgs e)
        {
            ReportForm rf = new ReportForm();
            rf.ShowDialog();
        }
    }
}
