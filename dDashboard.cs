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
    public partial class dDashboard : Form
    {
        public dDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorPane dp = new DoctorPane();
            dp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            D_view_app view = new D_view_app();
            view.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            D_viewpatient viewp = new D_viewpatient();
            viewp.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            write_diagnosis wd = new write_diagnosis();
            wd.Show();
            this.Hide();
            
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ocr ocr = new ocr();
            ocr.Show();
            this.Close();
        }
    }
}
