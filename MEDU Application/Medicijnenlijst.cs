using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MEDU_Application
{
    public partial class Medicijnenlijst : Form
    {
        Patient patient;
        MySqlDataReader reader;
        DataTbl GetDataBase = new DataTbl();

        public Medicijnenlijst(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
            lblProfiel.Text = patient.ToString();
            lbxMedicijn.Items.Clear(); // maakt de listbox met medicijnen leeg 
            lbmedicineName.Text = "-";
            lbwijzeInname.Text = "-";

            reader = GetDataBase.loadSQL("SELECT medicine.name FROM medicine,consumption_date WHERE consumption_date.patient_id = '" + patient.Id + "' AND medicine.id = consumption_date.medicine_id GROUP BY medicine.name;");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lbxMedicijn.Items.Add(reader.GetString("name")); // voegt de medicijn naam aan de medicijn listbox
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
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

        private void lbxMedicijn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gekozenMedicijn = lbxMedicijn.GetItemText(lbxMedicijn.SelectedItem); // zet de geselecteerde item in de medicijn listbox in een string


            reader = GetDataBase.loadSQL("SELECT medicine.name, medicine.consumption_method, medicine.category FROM medicine,consumption_date WHERE consumption_date.patient_id = '" + patient.Id + "' AND medicine.id = consumption_date.medicine_id AND medicine.name='"+ gekozenMedicijn +"';");// roept de medcijn, dose, inname methode en of het al is ingenomen op die is gekoppeld aan de datum, id en de medicijn naam van de database
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lbmedicineName.Text = reader.GetString("name"); //verandert de naam van de medicijn  label
                    lbwijzeInname.Text = reader.GetString("consumption_method");//verandert de naam van de inname wijze label
                    lbCategory.Text = reader.GetString("category");
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
        }
    }
}
