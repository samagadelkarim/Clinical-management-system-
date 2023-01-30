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

namespace clinic_management_system
{
    public partial class N_viewmedHistory : Form
    {
        public N_viewmedHistory()
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void N_write_med_history_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psyclinicDataSet8.medHistory' table. You can move, or remove it, as needed.
            this.medHistoryTableAdapter1.Fill(this.psyclinicDataSet8.medHistory);
            // TODO: This line of code loads data into the 'psyclinicDataSet7.medHistory' table. You can move, or remove it, as needed.
            this.medHistoryTableAdapter.Fill(this.psyclinicDataSet7.medHistory);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private DataTable showhistory()
        {
            DataTable dt = new DataTable();
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                try
                {
                    string cmmd = "SELECT * FROM medHistory WHERE patientID =" + comboBox2.Text.Trim();
                    SqlCommand cmd = new SqlCommand(cmmd, sqlcon);
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }
            return dt;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = showhistory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nDashboard nd = new nDashboard();
            nd.Show();
            this.Hide();
        }
    }
}
