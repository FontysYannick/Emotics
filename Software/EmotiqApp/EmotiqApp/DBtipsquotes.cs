using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmotiqApp
{
    class DBtipsquotes
    {
        private string connectionString = "datasource=studmysql01.fhict.local;username=dbi484020;password=Adm1n!Adm1n!;database=dbi484020;";
        private string tip;
        private string quote;

        public string SelectTip(string emotion)
        {
            string query = "SELECT `ID`, `emotion`, `tip`, `quote` FROM `tipsquotes` WHERE `emotion` = '" + emotion + "'";
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
                        tip = reader.GetString(2);
                        Console.WriteLine(reader.GetString(2));
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

            return tip;
        }

        public string SelectQuote(string emotion)
        {
            string query = "SELECT `ID`, `emotion`, `tip`, `quote` FROM `tipsquotes` WHERE `emotion` = '" + emotion + "'";
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
                        quote = reader.GetString(3);
                        Console.WriteLine(reader.GetString(3));
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

            return quote;
        }
    }
}
