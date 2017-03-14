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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
        }

        public static int poeng = 0;
        ferdigboks form2 = new ferdigboks(); 

        /*public void Sjekk_Svar()
        {
            if ()
            Hei 
        }*/

        private void Spill_Ferdig()
        {
            if (poeng == 5)
            {
                form2.Show(); 
            }
            else if (poeng == 3 || poeng == 4)
            {
                form2.Show(); 
            }
            else if (poeng <= 2)
            {
                form2.Show(); 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSjekk_Click(object sender, EventArgs e)
        {
            
        }
    }
}
