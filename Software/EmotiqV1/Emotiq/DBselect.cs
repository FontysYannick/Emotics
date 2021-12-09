using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emotiq
{
    class DBselect
    {
        private string connectionString = "datasource=studmysql01.fhict.local;username=dbi484020;password=Adm1n!Adm1n!;database=dbi484020;";

        public enum Tabel
        {
            contacts = 5,
            sensorvalues = 4,
            emotion = 2,
            tipsquotes = 4
        };

        public List<ListViewItem> Select(Tabel tabelname)
        {
            string Tabelname = tabelname.ToString();
            string query = "SELECT * FROM " + Tabelname;
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
                        if ((int)tabelname == 5)
                        {
                            string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4) };
                            Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetString(3) + " - " + reader.GetString(4));
                            var listViewItem = new ListViewItem(row);
                            items.Add(listViewItem);
                        }
                        else if ((int)tabelname == 4)
                        {
                            string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                            Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetString(3));
                            var listViewItem = new ListViewItem(row);
                            items.Add(listViewItem);
                        }
                        else if ((int)tabelname == 2)
                        {
                            string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2) };
                            Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2));
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
    }
}
