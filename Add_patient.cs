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
    public partial class addpatient : Form
    {
        public addpatient()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nDashboard nd = new nDashboard();
            nd.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ToString();
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                sqlcon.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("register1", sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NATIONAL_ID", textBox6.Text.Trim());
                    cmd.Parameters.AddWithValue("@ID", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@FullName", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address", textBox5.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", textBox7.Text.Trim());
                    cmd.Parameters.AddWithValue("@PNO", textBox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@GENDER", comboBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@WEIGHT", textBox8.Text.Trim());
                    cmd.Parameters.AddWithValue("@HEIGHT", textBox9.Text.Trim());

                    if (radioButton3.Checked) cmd.Parameters.AddWithValue("@M_STATE", radioButton3.Text);
                    else if (radioButton4.Checked) cmd.Parameters.AddWithValue("@M_STATE", radioButton4.Text);
                    else if (radioButton5.Checked) cmd.Parameters.AddWithValue("@M_STATE", radioButton5.Text);
                    else if (radioButton6.Checked) cmd.Parameters.AddWithValue("@M_STATE", radioButton6.Text);
                    
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "" || textBox5.Text == ""
                        || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == ""
                        || (radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false && radioButton6.Checked == false))
                        MessageBox.Show("Enter the required information!!");

                    else if (!int.TryParse(textBox2.Text.Trim(), out int i) || !float.TryParse(textBox8.Text.Trim(), out float w) || !float.TryParse(textBox9.Text.Trim(), out float h))
                        MessageBox.Show("Only numbers are valid !");

                    else if (textBox6.Text.Length != textBox6.MaxLength)
                        MessageBox.Show("Enter the full National ID");

                    else if (textBox4.Text.Length != textBox4.MaxLength)
                        MessageBox.Show("Enter the full phone number");

                    else
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Patient added successfully !");
                        Clear();
                    }




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
                void Clear()
                {
                    textBox1.Text = textBox2.Text = textBox4.Text = textBox5.Text = textBox6.Text
                    = textBox7.Text = textBox8.Text = textBox9.Text = "";
                    radioButton3.Checked = false; radioButton4.Checked = false; radioButton5.Checked = false; radioButton6.Checked = false;
                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void CreateMedicalHistory_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
