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

namespace clinic_management_system
{
    public partial class N_appointments : Form
    {
        public N_appointments()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            NursePanel np = new NursePanel();
            np.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            N_appointments appointments = new N_appointments();
            appointments.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            N_view_app n_View = new N_view_app();
            n_View.Show();
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            NursePanel np = new NursePanel();
            np.Show();
            this.Hide();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            N_appointments appointments = new N_appointments();
            appointments.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            N_view_app n_View = new N_view_app();
            n_View.Show();
            this.Close();
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            N_sure n_sure = new N_sure();
            n_sure.Show();
            this.Close();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            N_viewmedHistory n_Write_ = new N_viewmedHistory();
            n_Write_.Show();
            this.Close();
        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            N_viewpatient viewpatient = new N_viewpatient();
            viewpatient.Show();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void N_appointments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psyclinicDataSet15.patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter1.Fill(this.psyclinicDataSet15.patient);
            // TODO: This line of code loads data into the 'psyclinicDataSet4.patient' table. You can move, or remove it, as needed.
            //this.patientTableAdapter.Fill(this.psyclinicDataSet4.patient);

        }

        private void Login_Click(object sender, EventArgs e)
        {
            appfun();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nDashboard nd = new nDashboard();
            nd.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void appfun()
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                try
                {
                SqlCommand commandcheck = new SqlCommand("select patient_name from appointment where patient_name='" + comboBox1.Text + "'", sqlcon);
                string check = (string)commandcheck.ExecuteScalar();
                if (check == comboBox1.Text)
                {
                    MessageBox.Show("appoinment already exist");
                }
                else
                {
                    string q = "INSERT INTO appointment(patient_name,appdate,apptime) values (@patient_name, @appdate,@apptime)"; ;

                    SqlCommand cmd = new SqlCommand(q, sqlcon);
                    cmd.Parameters.AddWithValue("@patient_name", comboBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@appdate", dateTimePicker1.Text.Trim());
                    cmd.Parameters.AddWithValue("@apptime", dateTimePicker2.Text.Trim());


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment reserved successfully !");


                }

                }
                catch (Exception ex)
                { 
                    MessageBox.Show(ex.ToString());

                }
                sqlcon.Close();

            }
        }
    }
}
