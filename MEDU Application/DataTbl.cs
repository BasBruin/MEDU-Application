using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace MEDU_Application
{
    class DataTbl
    {
        public static DataTable GetValues(string Username, string Password)
        {
            string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sql_database;";
            string query = string.Format("SELECT * FROM patient WHERE username='{0}' AND password='{1}'", Username, Password);
            MySqlConnection databaseConnection = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            databaseConnection.Open();

            DataTable dt = new DataTable(); //this is creating a virtual table  
            dt.Load(cmd.ExecuteReader());

            return dt;
        }
    }
}
