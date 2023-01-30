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
    public partial class nDashboard : Form
    {
        public nDashboard()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nDashboard np = new nDashboard();
            np.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            N_appointments appointments = new N_appointments();
            appointments.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            N_sure n_sure = new N_sure();
            n_sure.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addpatient ap = new addpatient();
            this.Hide();
            ap.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            History h = new History();
            h.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            N_viewpatient viewpatient = new N_viewpatient();
            viewpatient.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            N_viewmedHistory vmh = new N_viewmedHistory();
            vmh.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }
    }
}
