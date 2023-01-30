using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic_management_system
{
    public partial class N_view_app : Form
    {
        public N_view_app()
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void label13_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }
    }
}
