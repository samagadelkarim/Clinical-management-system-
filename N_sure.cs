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
    public partial class N_sure : Form
    {
        public N_sure()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nDashboard np = new nDashboard();
            np.Show();
            this.Hide();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            delete_fun();
        }
        private void delete_fun()
        {
            if (MessageBox.Show("Are you sure to delete ?", "delete record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
                using (SqlConnection sqlcon = new SqlConnection(conStr))

                {
                    sqlcon.Open();
                    string patient = comboBox1.Text;
                    SqlCommand cmd = new SqlCommand("exec Deleteapp '" + patient + "'", sqlcon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully deleted");


                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void N_sure_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psyclinicDataSet16.appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter1.Fill(this.psyclinicDataSet16.appointment);
            Filldata();
            // TODO: This line of code loads data into the 'psyclinicDataSet14.appointment' table. You can move, or remove it, as needed.

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            nDashboard nd = new nDashboard();
            nd.Show();
            this.Hide();
        }
        private void Filldata()
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                String q = "select * from appointment";
                SqlDataAdapter da = new SqlDataAdapter(q, sqlcon);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                sqlcon.Close();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

