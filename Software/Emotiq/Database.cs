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

        public enum Brandstof
        {
            benzine_auto = 100,
            diesel_auto = 150,
            LPG_auto = 90,
            elektrische_auto = 130
        };

        private void connect(string tabelnaam)
        {
            string query = "SELECT * FROM " + tabelnaam;

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
        }


        public List<ListViewItem> opvragen(Brandstof/* string tabelnaam, int colloms*/)
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

                // All succesfully executed, now do something

                // IMPORTANT : 
                // If your query returns result, use the following processor :

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetString(3));
                        // As our database, the array will contain : ID 0, BPM 1, Temp 2, O2 3
                        // Do something with every received database ROW
                        //string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                        //string[] row = { reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4) };
                        if (colloms == 3)
                        {
                            string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                            var listViewItem = new ListViewItem(row);
                            items.Add(listViewItem);
                        }

                        //var listViewItem = new ListViewItem(row);
                        //items.Add(listViewItem);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                // Finally close the connection
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }

            return items;
        } 

        public void verwijderen(int id)
        {

        }

        public void toevoegen(int id, string voornaam, string tussenvoegsel, string achternaam, int telefoonnummer)
        {

        }
    }
}
