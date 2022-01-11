using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace MEDU_Application
{
    public partial class Inloggen : Form
    {


        public Inloggen()
        {
            InitializeComponent();
            navigatiebar.BackColor = Color.FromArgb(16, 92, 124);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            username.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text != "" && password.Text != "")
            {
                Patient patient = new Patient(username.Text, password.Text);
                
                Boolean success = patient.inloggen();

                if (success)
                {
                    DataTable dt = DataTbl.GetValues(username.Text, password.Text);
                    patient = new Patient(Convert.ToInt32(dt.Rows[0][0]), Convert.ToString(dt.Rows[0][3]), Convert.ToString(dt.Rows[0][4]), Convert.ToInt32(dt.Rows[0][7]), Convert.ToString(dt.Rows[0][8]), Convert.ToString(dt.Rows[0][9]), Convert.ToString(dt.Rows[0][10]), Convert.ToString(dt.Rows[0][11]), Convert.ToInt32(dt.Rows[0][12]));
                    this.Hide();
                    Vandaag f1 = new Vandaag(patient);
                    f1.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Verkeerd wachtwoord en/of gebruikersnaam");
                }
            }
            else
            {
                MessageBox.Show("Vul bij beide textboxen iets in");
            }


        }

        private void navigatiebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
