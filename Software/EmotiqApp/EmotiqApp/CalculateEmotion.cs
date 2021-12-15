using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmotiqApp
{
    class CalculateEmotion
    {
        private string connectionString = "datasource=studmysql01.fhict.local;username=dbi484020;password=Adm1n!Adm1n!;database=dbi484020;";
        private string emotion;
        private int bpm;
        private double temp;
        private int o2;


        public string CalculationLastEmotion()
        {
            SelectLastBPM();
            SelectLastO2();
            SelectLastTemp();

            double emotionnumber = bpm * 1.5 + (o2 / 10) * (2 * (temp / 10));
            Console.WriteLine(emotionnumber);

            return emotion;
        }

        public int SelectLastBPM()
        {
            string query = "SELECT * FROM sensorvalues ORDER BY ID DESC LIMIT 1";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        bpm = reader.GetInt32(1);
                        Console.WriteLine(reader.GetInt32(1));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return bpm;
        }

        public double SelectLastTemp()
        {
            string query = "SELECT * FROM sensorvalues ORDER BY ID DESC LIMIT 1";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        temp = reader.GetDouble(2);
                        Console.WriteLine(reader.GetDouble(2));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return temp;
        }

        public int SelectLastO2()
        {
            string query = "SELECT * FROM sensorvalues ORDER BY ID DESC LIMIT 1";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        o2 = reader.GetInt32(3);
                        Console.WriteLine(reader.GetInt32(3));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return o2;
        }
    }
}
