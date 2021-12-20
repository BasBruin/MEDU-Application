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
    public partial class Hamburger_Agenda : Form
    {
        public Hamburger_Agenda()
        {
            InitializeComponent();
        }

        private void Hamburger_Agenda_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agenda f3 = new Agenda();
            f3.ShowDialog();
        }

        private void navigatiebar_Paint(object sender, PaintEventArgs e)
        {
            navigatiebar.BackColor = Color.FromArgb(16, 92, 124);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(16, 92, 124);
        }
        private void Vandaag_Ham_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vandaag f1 = new Vandaag();
            f1.ShowDialog();
        }

        private void Agenda_Ham_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agenda f3 = new Agenda();
            f3.ShowDialog();
        }

        private void Medicijnen_Ham_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medicijnenlijst f4 = new Medicijnenlijst();
            f4.ShowDialog();
        }

        private void Instellingen_Ham_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instellingen f5 = new Instellingen();
            f5.ShowDialog();
        }

        private void Help_Ham_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help f6 = new Help();
            f6.ShowDialog();
        }

        private void Inloggen_Ham_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inloggen f10 = new Inloggen();
            f10.ShowDialog();
        }
    }
}
