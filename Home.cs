using Mehedee_ADO_Project.AppData.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mehedee_ADO_Project
{
    public partial class formProject : Form
    {
        public formProject()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (comBoxUser.Text=="TSP Admin" && txtBoxPass.Text =="1")
            {
                Form_TSP tsp = new Form_TSP();
                this.Hide();
                tsp.Show();
            }
            else if (comBoxUser.Text == "Trainee Admin" && txtBoxPass.Text == "1")
            {
                TraineeInfo traineeInfo = new TraineeInfo();
                this.Hide();
                traineeInfo.Show();
            }
            else if (comBoxUser.Text== "Trainer Admin" && txtBoxPass.Text == "1")
            {
                TrainerInfo trainerInfo = new TrainerInfo();
                this.Hide();
                trainerInfo.Show();
            }
            else if (comBoxUser.Text == "Course Authority" && txtBoxPass.Text == "1")
            {
                CourseInfo courseInfo = new CourseInfo();
                this.Hide();
                courseInfo.Show();
            }
        }
    }
}
