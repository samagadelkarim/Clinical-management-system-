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
using System.Windows.Controls;
using System.Windows.Forms;

namespace clinic_management_system
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void History_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'psyclinicDataSet6.patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter1.Fill(this.psyclinicDataSet6.patient);
            // TODO: This line of code loads data into the 'psyclinicDataSet5.patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.psyclinicDataSet5.patient);

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NursePanel np = new NursePanel();
            np.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("writeHistory", sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@patientName", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@patientID", comboBox2.Text);

                    if (radioButton1.Checked) cmd.Parameters.AddWithValue("@problems", radioButton1.Text);
                    else cmd.Parameters.AddWithValue("@problems", radioButton2.Text);

                    if(radioButton3.Checked) cmd.Parameters.AddWithValue("@diagnosed", radioButton3.Text);
                    else cmd.Parameters.AddWithValue("@diagnosed", radioButton4.Text);

                    if (radioButton5.Checked) cmd.Parameters.AddWithValue("@med_conditions", radioButton5.Text);
                    else cmd.Parameters.AddWithValue("@med_conditions", radioButton6.Text);

                    if (radioButton7.Checked) cmd.Parameters.AddWithValue("@visting", radioButton7.Text);
                    else cmd.Parameters.AddWithValue("@visting", radioButton8.Text);

                    if (radioButton9.Checked)
                    {
                        cmd.Parameters.AddWithValue("@medics", radioButton9.Text);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        cmd.Parameters.AddWithValue("@mname", "No");
                        cmd.Parameters.AddWithValue("@mdose", "No");
                        cmd.Parameters.AddWithValue("@mfreq", "No");
                    }
                    else if (radioButton10.Checked)
                    {
                        cmd.Parameters.AddWithValue("@medics", radioButton9.Text);
                        cmd.Parameters.AddWithValue("@mname", textBox1.Text);
                        cmd.Parameters.AddWithValue("@mdose", textBox2.Text);
                        cmd.Parameters.AddWithValue("@mfreq", textBox3.Text);
                    }

                    if (radioButton11.Checked) cmd.Parameters.AddWithValue("@side_effect", radioButton11.Text);
                    else cmd.Parameters.AddWithValue("@side_effect", radioButton12.Text);

                    if (radioButton13.Checked) cmd.Parameters.AddWithValue("@hospitalized", radioButton13.Text);
                    else cmd.Parameters.AddWithValue("@hospitalized", radioButton14.Text);

                    if (radioButton15.Checked)
                    {
                        cmd.Parameters.AddWithValue("@siblings", radioButton15.Text);
                        textBox4.Text = "";
                        cmd.Parameters.AddWithValue("@type", "No");
                    }
                    else if (radioButton16.Checked)
                    {
                        cmd.Parameters.AddWithValue("@siblings", radioButton15.Text);
                        cmd.Parameters.AddWithValue("@type", textBox4.Text);
                    }

                    if(radioButton17.Checked) cmd.Parameters.AddWithValue("@mood", radioButton17.Text);
                    else cmd.Parameters.AddWithValue("@mood", radioButton18.Text);

                    if(radioButton19.Checked) cmd.Parameters.AddWithValue("@relationship", radioButton19.Text);
                    else cmd.Parameters.AddWithValue("@relationship", radioButton20.Text);

                    if (radioButton21.Checked) cmd.Parameters.AddWithValue("@mood_work", radioButton21.Text);
                    else cmd.Parameters.AddWithValue("@mood_work", radioButton22.Text);

                    if(radioButton23.Checked) cmd.Parameters.AddWithValue("@concentrate", radioButton23.Text);
                    else cmd.Parameters.AddWithValue("@concentrate", radioButton24.Text);

                    if (radioButton25.Checked) cmd.Parameters.AddWithValue("@stopwork", radioButton25.Text);
                    else cmd.Parameters.AddWithValue("@stopwork", radioButton26.Text);

                    if(checkBox1.Checked) cmd.Parameters.AddWithValue("@smoking", "Yes");
                    else if (!checkBox1.Checked) cmd.Parameters.AddWithValue("@smoking", "No");

                    if (checkBox2.Checked) cmd.Parameters.AddWithValue("@addict", "Yes");
                    else if (!checkBox2.Checked) cmd.Parameters.AddWithValue("@addict", "No");

                    if (checkBox3.Checked) cmd.Parameters.AddWithValue("@alcohol", "Yes");
                    else if (!checkBox3.Checked) cmd.Parameters.AddWithValue("@alcohol", "No");

                    if (checkBox4.Checked) cmd.Parameters.AddWithValue("@gamble", "Yes");
                    else if (!checkBox4.Checked) cmd.Parameters.AddWithValue("@gamble", "No");

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("History added successfully !");
                    
                   




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nDashboard nd = new nDashboard();
            nd.Show();
            this.Hide();
        }
    }
}
