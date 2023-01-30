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
    public partial class N_viewpatient : Form
    {
        public N_viewpatient()
        {
            InitializeComponent();
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

        private void label8_Click(object sender, EventArgs e)
        {
            N_view_app n_View = new N_view_app();
            n_View.Show();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
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

        private void label10_Click(object sender, EventArgs e)
        {
            N_viewpatient viewpatient = new N_viewpatient();
            viewpatient.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void N_viewpatient_Load(object sender, EventArgs e)
        {
            Filldata();
        }
        private void Filldata()
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                String q = "select * from patient";
                SqlDataAdapter da = new SqlDataAdapter(q, sqlcon);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                sqlcon.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nDashboard nd = new nDashboard();
            nd.Show();
            this.Hide();
        }
    }
}
