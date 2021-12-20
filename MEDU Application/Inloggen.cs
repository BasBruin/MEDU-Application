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

        private void Inloggen_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            username.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(username.Text == "")
            {

            }

            if (username.Text != "")
            {
                string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sql_database;";
                string query = string.Format("SELECT * FROM test_sql_server WHERE userName='{0}' AND passWord='{1}'", username.Text, password.Text);
                MySqlConnection databaseConnection = new MySqlConnection(connString);
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                databaseConnection.Open();

                DataTable dt = new DataTable(); //this is creating a virtual table  
                dt.Load(cmd.ExecuteReader());

                try
                {
                    if (dt.Rows.Count ==1)
                    {
                        this.Hide();
                        Vandaag f1 = new Vandaag();
                        f1.ShowDialog();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Verkeerd wachtwoord en/of gebruikersnaam");
                }

            }


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
