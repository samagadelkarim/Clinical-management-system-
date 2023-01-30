using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patagames.Ocr;

namespace clinic_management_system
{
    public partial class ocr : Form
    {
        public ocr()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            using (var objocr = OcrApi.Create())
            {
                objocr.Init(Patagames.Ocr.Enums.Languages.English);
                string plaintext = objocr.GetTextFromImage(pictureBox1.ImageLocation);
                textBox1.Text = plaintext;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dDashboard dd = new dDashboard();
            dd.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"E:\games\files\clinic management system sh8aaaal bgd\clinic management system sh8aaaal\photo.png";
        }
    }
}
