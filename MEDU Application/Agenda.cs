using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MEDU_Application
{
    public partial class Agenda : Form
    {
        Patient patient;
        DataTbl GetDataBase = new DataTbl();
        MySqlDataReader reader;

        public Agenda(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
            string gekozenDate = monthCalander.SelectionRange.Start.ToString("yyyy'-'MM'-'dd");

            reader = GetDataBase.loadSQL("SELECT cast(consumption_date.date as date) as dt_Date, cast(consumption_date.date as TIME) as dt_Time FROM `consumption_date` WHERE cast(consumption_date.date as date) = '" + gekozenDate + "' AND consumption_date.patient_id = '" + patient.Id + "';"); // deze queryroept de datums op die gekopeld is met de patient id uit de database

            if (reader.HasRows) // checkt of de opgroepen tabel van de database rows heeft
            {
                while (reader.Read()) //leest hoeveel rijen er zijn en gaat door titdat het ze allemaal door is
                {
                    string Tijd = (reader.GetString("dt_Time")); // zet de opgroepen datums in een vaste format die dan in de string 'date' word gezet

                    lbxTijd.Items.Add(Tijd); //voegt de 'date' strings toe aan de date listbox

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

        private void monthCalander_DateChanged(object sender, DateRangeEventArgs e)
        {
            lbxTijd.Items.Clear(); // maakt de listbox met datums en tijden leeg
            lbxMedicine.Items.Clear(); // maakt de listbox met medicijnen leeg 

            string gekozenDate = monthCalander.SelectionRange.Start.ToString("yyyy'-'MM'-'dd");

            reader = GetDataBase.loadSQL("SELECT cast(consumption_date.date as date) as dt_Date, cast(consumption_date.date as TIME) as dt_Time FROM `consumption_date` WHERE cast(consumption_date.date as date) = '" + gekozenDate + "' AND consumption_date.patient_id = '" + patient.Id + "';"); // deze queryroept de datums op die gekopeld is met de patient id uit de database

            if (reader.HasRows) // checkt of de opgroepen tabel van de database rows heeft
            {
                while (reader.Read()) //leest hoeveel rijen er zijn en gaat door titdat het ze allemaal door is
                {
                    string Tijd = (reader.GetString("dt_Time")); // zet de opgroepen datums in een vaste format die dan in de string 'date' word gezet

                    lbxTijd.Items.Add(Tijd); //voegt de 'date' strings toe aan de date listbox

                }

            }
            else
            {
                Console.WriteLine("No rows found.");
            }
        }

        private void lbxTijd_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxMedicine.Items.Clear(); // maakt de listbox met medicijnen leeg 
            lbmedicineName.Text = "-";
            lbdose.Text = "-";
            lbwijzeInname.Text = "-";
            lbIngenomen.Text = "-";

            string gekozenDate = monthCalander.SelectionRange.Start.ToString("yyyy'-'MM'-'dd");
            string gekozenTijd = lbxTijd.GetItemText(lbxTijd.SelectedItem); // zet de geselecteerde item uit de date listbox in een string genaamd date
            Console.WriteLine(gekozenTijd);

            reader = GetDataBase.loadSQL("SELECT cast(consumption_date.date as date) as dt_Date, cast(consumption_date.date as TIME) as dt_Time, medicine.name FROM `consumption_date`, medicine WHERE cast(consumption_date.date as date) = '" + gekozenDate + "' AND consumption_date.medicine_id = medicine.id AND consumption_date.patient_id = '" + patient.Id + "' AND cast(consumption_date.date as TIME) ='" + gekozenTijd + "';"); // ropet de medcijn op die is gekoppeld aan de datum en id van de database
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lbxMedicine.Items.Add(reader.GetString("name")); // voegt de medicijn naam aan de medicijn listbox
                }

            }
            else
            {
                Console.WriteLine("No rows found.");
            }
        }

        private void lbxMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gekozenMedicijn = lbxMedicine.GetItemText(lbxMedicine.SelectedItem); // zet de geselecteerde item in de medicijn listbox in een string
            string gekozenDate = monthCalander.SelectionRange.Start.ToString("yyyy'-'MM'-'dd"); // zet de geselecteerde item uit de date listbox in een string genaamd date
            string gekozenTijd = lbxTijd.GetItemText(lbxTijd.SelectedItem);
            Console.WriteLine(gekozenMedicijn);
            Console.WriteLine(gekozenDate);



            reader = GetDataBase.loadSQL("SELECT cast(consumption_date.date as date) as dt_Date, cast(consumption_date.date as TIME) as dt_Time, medicine.name, medicine.consumption_method, consumption_date.amount, consumption_date.is_consumed FROM `consumption_date`, medicine WHERE cast(consumption_date.date as date) = '" + gekozenDate + "' AND consumption_date.medicine_id = medicine.id AND medicine.name = '" + gekozenMedicijn + "' AND consumption_date.patient_id = '" + patient.Id + "' AND cast(consumption_date.date as TIME) ='" + gekozenTijd + "';"); // roept de medcijn, dose, inname methode en of het al is ingenomen op die is gekoppeld aan de datum, id en de medicijn naam van de database
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lbmedicineName.Text = reader.GetString("name"); //verandert de naam van de medicijn  label
                    lbdose.Text = reader.GetString("amount");  //verandert de naam van de dose label
                    lbwijzeInname.Text = reader.GetString("consumption_method");//verandert de naam van de inname wijze label
                    lbIngenomen.Text = reader.GetString("is_consumed"); //verandert de naam van de checkbox
                }

            }
            else
            {
                Console.WriteLine("No rows found.");
            }
        }
    }
}
