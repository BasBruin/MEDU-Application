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
    public partial class Medicijnenlijst : Form
    {
        Patient patient;

        public Medicijnenlijst(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
        }

        private void navigatiebar_Paint(object sender, PaintEventArgs e)
        {
            navigatiebar.BackColor = Color.FromArgb(16, 92, 124);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HamburgerMenu f2 = new HamburgerMenu(patient);
            f2.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
