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
    public partial class Vandaag : Form
    {
        DataTbl GetDataBase = new DataTbl();
        Patient patient;
        MySqlDataReader reader;
        

        public Vandaag(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
            lblProfiel.Text = patient.ToString();
            lbxTijd.Items.Clear(); // maakt de listbox met datums en tijden leeg
            lbxMedicijn.Items.Clear(); // maakt de listbox met medicijnen leeg 
            reader = GetDataBase.loadSQL("SELECT cast(consumption_date.date as date) as dt_Date, cast(consumption_date.date as TIME) as dt_Time FROM consumption_date WHERE cast(consumption_date.date as date) = CURRENT_DATE AND consumption_date.patient_id =  '" + patient.Id + "';");// deze queryroept de datums op die gekopeld is met de patient id uit de database
            

            if (reader.HasRows) // checkt of de opgroepen tabel van de database rows heeft
            {
                while (reader.Read()) //leest hoeveel rijen er zijn en gaat door titdat het ze allemaal door is
                {
                    string Date = reader.GetString("dt_Time"); // zet de opgroepen datums in een vaste format die dan in de string 'date' word gezet

                    lbxTijd.Items.Add(Date); //voegt de 'date' strings toe aan de date listbox

                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HamburgerMenu f2 = new HamburgerMenu(patient);
            f2.ShowDialog();
        }

        private void navigatiebar_Paint(object sender, PaintEventArgs e)
        {
            navigatiebar.BackColor = Color.FromArgb(16, 92, 124);
        }

        private void lbxTijd_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxMedicijn.Items.Clear(); // maakt de listbox met medicijnen leeg 
            lbmedicineName.Text = "-";
            lbdose.Text = "-";
            lbwijzeInname.Text = "-";
            cbIngenomen.Text = "-";
            cbIngenomen.Checked = false; // de code hier boven maakt de labels in de presciptie group box leeg en zet de combo box als standaard false

            string gekozenDate = lbxTijd.GetItemText(lbxTijd.SelectedItem); // zet de geselecteerde item uit de date listbox in een string genaamd date


            reader = GetDataBase.loadSQL("SELECT cast(consumption_date.date as date) as dt_Date, cast(consumption_date.date as TIME) as dt_Time, medicine.name FROM `consumption_date`, medicine WHERE cast(consumption_date.date as date) = CURRENT_DATE AND consumption_date.medicine_id = medicine.id AND consumption_date.patient_id =  '" + 1 + "' AND cast(consumption_date.date as TIME) ='" + gekozenDate + "';"); // ropet de medcijn op die is gekoppeld aan de datum en id van de database
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

        private void lbxMedicijn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gekozenMedicijn = lbxMedicijn.GetItemText(lbxMedicijn.SelectedItem); // zet de geselecteerde item in de medicijn listbox in een string
            string gekozenDate = lbxTijd.GetItemText(lbxTijd.SelectedItem); // zet de geselecteerde item uit de date listbox in een string genaamd date


            reader = GetDataBase.loadSQL("SELECT cast(consumption_date.date as date) as dt_Date, cast(consumption_date.date as TIME) as dt_Time, medicine.name, medicine.consumption_method, consumption_date.amount, consumption_date.is_consumed FROM consumption_date, medicine WHERE cast(consumption_date.date as date) = CURRENT_DATE AND consumption_date.medicine_id = medicine.id AND medicine.name = '" + gekozenMedicijn + "' AND consumption_date.patient_id = '" + 1 + "' AND cast(consumption_date.date as TIME) ='" + gekozenDate + "';"); // roept de medcijn, dose, inname methode en of het al is ingenomen op die is gekoppeld aan de datum, id en de medicijn naam van de database
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lbmedicineName.Text = reader.GetString("name"); //verandert de naam van de medicijn  label
                    lbdose.Text = reader.GetString("amount");  //verandert de naam van de dose label
                    lbwijzeInname.Text = reader.GetString("consumption_method");//verandert de naam van de inname wijze label
                    if (reader.GetString("is_consumed") == "True") //verandert de naam van de checkbox
                    {
                        cbIngenomen.Text = "Ingenomen";
                    }
                    else
                    {
                        cbIngenomen.Text = "Niet ingenomen";
                    }
                    cbIngenomen.Checked = reader.GetBoolean("is_consumed"); //vverandert de waarde van de checkbox

                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
        }

        private void cbIngenomen_CheckedChanged(object sender, EventArgs e)
        {
            string gekozenDate = lbxTijd.GetItemText(lbxTijd.SelectedItem);// zet de geselecteerde item in de medicijn listbox in een string
            string gekozenMedicijn = lbxMedicijn.GetItemText(lbxMedicijn.SelectedItem);// zet de geselecteerde item uit de date listbox in een string genaamd date
            bool ingenomen = cbIngenomen.Checked; //zet de value van de checkbox in een bool genaamd ingenomen


            reader = GetDataBase.loadSQL("UPDATE consumption_date SET is_consumed = " + ingenomen + " WHERE cast(consumption_date.date as TIME) = '" + gekozenDate + "' AND consumption_date.patient_id = " + 1 + "; "); // deze query stuurt een update naar de database waar de patient id en de datum over een komen om aan de waarde van is_cosumed te veranderen naar de waarde van 'ingenomen'
            reader = GetDataBase.loadSQL("SELECT cast(consumption_date.date as date) as dt_Date, cast(consumption_date.date as TIME) as dt_Time, medicine.name, medicine.consumption_method, consumption_date.amount, consumption_date.is_consumed FROM consumption_date, medicine WHERE cast(consumption_date.date as date) = CURRENT_DATE AND consumption_date.medicine_id = medicine.id AND medicine.name = '" + gekozenMedicijn + "' AND consumption_date.patient_id = '" + 1 + "' AND cast(consumption_date.date as TIME) ='" + gekozenDate + "';"); // roept de medcijn, dose, inname methode en of het al is ingenomen op die is gekoppeld aan de datum, id en de medicijn naam van de database
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lbmedicineName.Text = reader.GetString("name"); //verandert de naam van de medicijn  label
                    lbdose.Text = reader.GetString("amount");  //verandert de naam van de dose label
                    lbwijzeInname.Text = reader.GetString("consumption_method");//verandert de naam van de inname wijze label
                    if (reader.GetString("is_consumed") == "True") //verandert de naam van de checkbox
                    {
                        cbIngenomen.Text = "Ingenomen";
                    }
                    else
                    {
                        cbIngenomen.Text = "Niet ingenomen";
                    }
                    cbIngenomen.Checked = reader.GetBoolean("is_consumed"); //vverandert de waarde van de checkbox

                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
        }

        private void lblProfiel_Click(object sender, EventArgs e)
        {
            lblProfiel.Text = patient.ToString();
        }
    }
}
