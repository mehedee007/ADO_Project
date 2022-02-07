using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Mehedee_ADO_Project.AppData.forms
{
    public partial class Form_TSP : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["tspDB"].ConnectionString;
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataTable dt;

        public Form_TSP()
        {
            InitializeComponent();
        }

        private void Form_TSP_Load(object sender, EventArgs e)
        {
            TspDisplay();
        }

        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            cmd = new SqlCommand("INSERT INTO TSPs (TSPName, TSPLocation, Manager, ContactNumber, Email) VALUES (@tspName, @tspLocation, @manager, @contact, @email)", con);
            cmd.Parameters.AddWithValue("@tspName", txtBoxTspName.Text);
            cmd.Parameters.AddWithValue("@tspLocation", comBoxTspLocation.Text);
            cmd.Parameters.AddWithValue("@manager", txtTspManager.Text);
            cmd.Parameters.AddWithValue("@contact", txtTspContact.Text);
            cmd.Parameters.AddWithValue("@email", txtTspEmail.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your are a registerd TSP now.");
            con.Close();
            TspDisplay();
        }

        private void btnTspLogout_Click(object sender, EventArgs e)
        {
            formProject fHome = new formProject();
            this.Hide();
            fHome.Show();
        }

        public void TspDisplay()
        {
            con = new SqlConnection(cs);
            adapter = new SqlDataAdapter("SELECT * FROM TSPs", con);
            dt = new DataTable();
            adapter.Fill(dt);
            dgOutputTsp.DataSource = dt;
            
        }

        private void dgOutputTsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxTspName.Text = this.dgOutputTsp.CurrentRow.Cells["TSPName"].Value.ToString();
            txtTspManager.Text = this.dgOutputTsp.CurrentRow.Cells["Manager"].Value.ToString();
            txtTspContact.Text = this.dgOutputTsp.CurrentRow.Cells["ContactNumber"].Value.ToString();
            txtTspEmail.Text = this.dgOutputTsp.CurrentRow.Cells["Email"].Value.ToString();
            txtUpdateTspId.Text = this.dgOutputTsp.CurrentRow.Cells["TSPID"].Value.ToString();
            btnTspUpdate.Visible = true;
            txtUpdateTspId.Visible = true;
            lblUpdateTsp.Visible = true;
            btnRegister.Visible = false;
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnTspUpdate_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();
                cmd = new SqlCommand("UPDATE TSPs SET TSPName = '"+txtBoxTspName.Text+"', TSPLocation = '"+comBoxTspLocation.Text+"', Manager = '"+txtTspManager.Text+ "', ContactNumber = '"+txtTspContact.Text+"', Email = '"+txtTspEmail.Text+"' WHERE TSPID = '" + txtUpdateTspId.Text + "'", con);
                MessageBox.Show("TSP Data Updated.");
                cmd.ExecuteNonQuery();
                con.Close();
                TspDisplay();
            }
            
        }
    }
}
