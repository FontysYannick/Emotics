using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emotiq
{
    class Dbtoevoegencontact
    {
        private string connectionString = "datasource=studmysql01.fhict.local;username=dbi484020;password=Adm1n!Adm1n!;database=dbi484020;";

        public void toevoegen(string voornaam, string tussenvoegsel, string achternaam, string telefoonnummer)
        {
            string query = "INSERT INTO contactpersonen(`ID`, `voornaam`, `tv`, `achternaam`, `telefoonnummer`) VALUES (NULL, '" + voornaam + "', '" + tussenvoegsel + "', '" + achternaam + "', '" + telefoonnummer + "')";
            // Which could be translated manually to :t
            // INSERT INTO user(`ID`, `voornaam`, `tussenvoegsel`, `achternaam`, `telefoonnummer`) VALUES (NULL, 'voornaam', 'tussenvoegsel', 'Wayne Manor')

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("User succesfully registered", "Registerd", MessageBoxButtons.OK, MessageBoxIcon.Information);

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }
    }
}
