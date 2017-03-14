using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Læringsaplikasjon
{
    public partial class ferdigboks : Form
    {
        public ferdigboks()
        {
            InitializeComponent();
        }

        private void ferdigboks_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;

            if (Form1.poeng == 5)
            {
                label1.Text = "Gratulerer! Du fikk full score. Kos deg med en bra boi.";
                pictureBox1.Image = Properties.Resources.braDatBoi; 
            }
            else if (Form1.poeng == 3 || Form1.poeng == 4)
            {
                label1.Text = "Dette var ok. Ha deg en middels boi."; 
            }
            else if (Form1.poeng == 1 || Form1.poeng == 2)
            {
                label1.Text = "Dette var dritt. Her har du en dårlig boi."; 
            }
        }

        private void btnIgjen_Click(object sender, EventArgs e)
        {

        }

        private void btnFerdig_Click(object sender, EventArgs e)
        {

        }
    }
}
