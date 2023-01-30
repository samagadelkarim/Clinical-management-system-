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
    public partial class D_view_app : Form
    {
        public D_view_app()
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

        private void label3_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dDashboard dd = new dDashboard();
            dd.Show();
            this.Hide();

        }
    }
}
