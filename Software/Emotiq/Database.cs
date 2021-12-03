using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Emotiq
{
    class Database
    {
        private string connectionString = "datasource=studmysql01.fhict.local;username=dbi484020;password=Adm1n!Adm1n!;database=dbi484020;";

        public List<ListViewItem> opvragen(string tabelnaam, int colloms)
        {
            string query = "SELECT * FROM " + tabelnaam;
            List<ListViewItem> items = new List<ListViewItem>();

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                // Open the database
                databaseConnection.Open();

                // Execute the query
                reader = commandDatabase.ExecuteReader();

                // If your query returns result, use the following processor :
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetString(3));
                        // ID 0, BPM 1, Temp 2, O2 3
                        // Do something with every received database ROW
                        if (colloms == 4)
                        {
                            string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                            var listViewItem = new ListViewItem(row);
                            items.Add(listViewItem);
                        }
                        else if (colloms == 5)
                        {
                            string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4) };
                            var listViewItem = new ListViewItem(row);
                            items.Add(listViewItem);
                        }
                    }
                }
                else
                {
                    // if there are no rows
                    Console.WriteLine("No rows found.");
                }

                // close database connection
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // error message database
                MessageBox.Show(ex.Message);
            }

            return items;
        } 

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
        public void verwijderen(string id)
        {
            // Delete the item with ID 1
            string query = "DELETE FROM `contactpersonen` WHERE id = " + id;

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                // Succesfully deleted
                MessageBox.Show("User succesfully deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }
        }
    }
}
