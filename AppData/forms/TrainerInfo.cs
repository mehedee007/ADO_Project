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
    public partial class TrainerInfo : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["tspDB"].ConnectionString;
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataTable dt;

        public TrainerInfo()
        {
            InitializeComponent();
            GetTspIdFromTsps();
           
        }

        private void btnTrainerLogout_Click(object sender, EventArgs e)
        {
            formProject home = new formProject();
            this.Hide();
            home.Show();
        }

        private void comBoxTspName_DropDown(object sender, EventArgs e)
        {
            
        }
        public void GetTspIdFromTsps()
        {
            using (con = new SqlConnection(cs))
            {
                //con.Open();
                //adapter = new SqlDataAdapter("SELECT TspName FROM TSPs", con);
                //dt = new DataTable();
                //adapter.Fill(dt);
                //comBoxTspName.DataSource = dt;
                //comBoxTspName.DisplayMember = "TspName";
                //comBoxTspName.ValueMember = "TSPID";
                //con.Close();

                con.Open();
                cmd = new SqlCommand("SELECT * FROM TSPs", con);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select TSP" };
                dt.Rows.InsertAt(dr, 0);

                comBoxTspName.ValueMember = "TSPID";
                comBoxTspName.DisplayMember = "TSPName";

                comBoxTspName.DataSource = dt;

                con.Close();
            }
        }

        private void btnTrainerAdd_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                cmd = new SqlCommand("INSERT INTO TrainerList(TrainerName, TrainerContact, TrainerEmail, TSPName, TSPID) VALUES ('" + txtTrainerName.Text + "', '" + txtTrainerContact.Text + "', '" + txtTraineeEmail.Text + "', '" + comBoxTspName.Text + "', '"+comBoxTspName.SelectedValue+"')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Trainer Added to the List.");
                TrainerDisplay();
            }
        }

        public void TrainerDisplay()
        {
            con = new SqlConnection(cs);
            adapter = new SqlDataAdapter("SELECT * FROM TrainerList", con);
            dt = new DataTable();
            adapter.Fill(dt);
            dgTrainer.DataSource = dt;
            //CourseInfo ci = new CourseInfo();
            //ci.dgCourseTrainer.DataSource = dt;
        }

        private void TrainerInfo_Load(object sender, EventArgs e)
        {
            TrainerDisplay();
        }
    }
}
