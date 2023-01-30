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
    public partial class D_viewpatient : Form
    {
        public D_viewpatient()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Filldata();
      

            }

        private void D_viewpatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psyclinicDataSet9.patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter2.Fill(this.psyclinicDataSet9.patient);
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
            dDashboard dd = new dDashboard();
            dd.Show();
            this.Hide();
        }
    }

}
