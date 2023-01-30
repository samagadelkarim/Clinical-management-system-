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
    public partial class write_diagnosis : Form
    {
        public write_diagnosis()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psyclinicDataSet13.patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter2.Fill(this.psyclinicDataSet13.patient);
            // TODO: This line of code loads data into the 'psyclinicDataSet3.Drugs' table. You can move, or remove it, as needed.
            this.drugsTableAdapter1.Fill(this.psyclinicDataSet3.Drugs);
            // TODO: This line of code loads data into the 'psyclinicDataSet2.patient' table. You can move, or remove it, as needed.
            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        //public class DataOperations 
        //{
            /*public DataTable ReadTable()
            {
                var selectStatement = "SELECT Fname + ' ' + Lname As FullName FROM patient";
                var dt = new DataTable();
                string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
                using (SqlConnection sqlcon = new SqlConnection(conStr))
                {
                    using (var cmd = new SqlCommand())
                    {
                        sqlcon.Open();
                        dt.Load(cmd.ExecuteReader());
                    }
                }

                return dt;
            }*/
        //}

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.patientTableAdapter.FillBy(this.psyclinicDataSet.patient);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.patientTableAdapter.FillBy1(this.psyclinicDataSet.patient);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.patientTableAdapter.FillBy1(this.psyclinicDataSet.patient);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("WriteDiagnosisForm", sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Pname", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@Age", textBox1.Text);
                    cmd.Parameters.AddWithValue("@PID", textBox2.Text);
                    cmd.Parameters.AddWithValue("@DOS", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@subinfo", richTextBox1.Text);
                    cmd.Parameters.AddWithValue("@obinfo", richTextBox4.Text);
                    cmd.Parameters.AddWithValue("@dig", richTextBox2.Text);
                    cmd.Parameters.AddWithValue("@digplan", richTextBox5.Text);
                    cmd.Parameters.AddWithValue("@addcomm", richTextBox3.Text);
                    cmd.Parameters.AddWithValue("@med", comboBox1.Text);

                    if (comboBox2.Text == "" || textBox1.Text == "" || textBox2.Text == "")
                        MessageBox.Show("Enter the required information!!");

                    else
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Done");
                        Clear();
                    }




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
                void Clear()
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dDashboard dd = new dDashboard();
            dd.Show();
            this.Hide();

        }
    }
}
