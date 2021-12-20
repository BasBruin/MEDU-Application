using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDU_Application
{
    public partial class Vandaag : Form
    {

        public Vandaag()
        {
            InitializeComponent();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hamburger_Vandaag f2 = new Hamburger_Vandaag();
            f2.ShowDialog();
        }

        private void navigatiebar_Paint(object sender, PaintEventArgs e)
        {
            navigatiebar.BackColor = Color.FromArgb(16, 92, 124);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
