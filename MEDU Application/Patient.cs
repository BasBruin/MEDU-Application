using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MEDU_Application
{
    public class Patient
    {
        public DataTable dt { get; set; }
        public int Id { get; }
        public string Voornaam { get; }
        public string Achternaam { get; }
        public int Leeftijd { get; }
        public string Email { get; }
        public string Telefoonnummer { get; }
        public int Dokter_id { get; }
        public string Bsn { get; }
        //public List<Allergie> Allergiën = new List<Allergie>();
        public string Allergiën { get; }
        public string Username { get; }
        public string Password { get; }

        // Hier maak ik de constructor aan waar alle info in gaat van de user.
        public Patient(int Id, string Voornaam, string Achternaam, int Leeftijd, string Bsn, string Email, string Telefoonnummer, string Allergiën ,  int Dokter_id)
        {
            this.Id = Id;
            this.Voornaam = Voornaam;
            this.Achternaam = Achternaam;
            this.Leeftijd = Leeftijd;
            this.Email = Email;
            this.Telefoonnummer = Telefoonnummer;
            this.Dokter_id = Dokter_id;
            this.Bsn = Bsn;
            this.Allergiën = Allergiën;
        }

        // Deze constructor is voor de username en password door te geven 
        public Patient(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        // Deze Boolean kijkt of de username en password hetzelfde zijn als die in de database en op basis daarvan geeft hij een true of false terug
        public Boolean inloggen()
        {
            //Dit stukje zorgt voor de connectie met de database
            string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sql_database;";
            string query = string.Format("SELECT * FROM patient WHERE username='{0}' AND password='{1}'", this.Username, this.Password);
            MySqlConnection databaseConnection = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            databaseConnection.Open();

            dt = new DataTable(); //this is creating a virtual table  
            dt.Load(cmd.ExecuteReader());

            // Als de datatable terug komt met 1 row betekent dat er een profiel is met die specifieke username en password en mag je dus inloggen.
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }

        public void Uitloggen(Patient patient)
        {
            patient = null;
        }

        public override string ToString()
        {
            return this.Voornaam;
        }
    }

    
}
