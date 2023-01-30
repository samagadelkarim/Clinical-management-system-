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
    public partial class appointments : Form
    {
        public appointments()
        {
            InitializeComponent();
        }

        private void online_app_Load(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {
            appointments appointments = new appointments();
            appointments.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            sure sure = new sure();
            sure.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            MessageBox.Show("your appointment has been reserved");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NursePanel np = new NursePanel();
            np.Show();
            this.Hide(); 
        }
    }
}
