using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmotiqApp
{
    class DBemotion
    {
        private string connectionString = "datasource=studmysql01.fhict.local;username=dbi484020;password=Adm1n!Adm1n!;database=dbi484020;";
        private string CurrentEmotion;

        public string SelectLastEmotion()
        {
            string query = "SELECT * FROM emotion ORDER BY ID DESC LIMIT 1";
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
                        CurrentEmotion = reader.GetString(1);
                        Console.WriteLine(reader.GetString(1));
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

            return CurrentEmotion;
        }
    }
}
