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
    public partial class viewmedhistory : Form
    {
        public viewmedhistory()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            DoctorPane dp = new DoctorPane();
            dp.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            D_view_app view = new D_view_app();
            view.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            D_viewpatient viewp = new D_viewpatient();
            viewp.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            viewmedhistory viewh = new viewmedhistory();
            viewh.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dDashboard dd = new dDashboard();
            dd.Show();
            this.Hide();
        }

        private void viewmedhistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psyclinicDataSet11.medHistory' table. You can move, or remove it, as needed.
            this.medHistoryTableAdapter1.Fill(this.psyclinicDataSet11.medHistory);
            // TODO: This line of code loads data into the 'psyclinicDataSet10.medHistory' table. You can move, or remove it, as needed.
            this.medHistoryTableAdapter.Fill(this.psyclinicDataSet10.medHistory);

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
                    sqlcon.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = showhistory();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
