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

            double emotionnumber = bpm * 1.5 + (o2 / 10) * (2 * (temp / 10)) + 4;

            if (emotionnumber > 0 && emotionnumber <= 104)
            {
                emotion = "Depressed";
            }
            else if (emotionnumber > 105 && emotionnumber <= 124) 
            {
                emotion = "Sad";
            }
            else if (emotionnumber > 125 && emotionnumber <= 154)
            {
                emotion = "Natural";
            }
            else if (emotionnumber > 155 && emotionnumber <= 184)
            {
                emotion = "Happy";
            }
            else if (emotionnumber > 185 && emotionnumber <= 199)
            {
                emotion = "Angry";
            }
            else if (emotionnumber > 200 && emotionnumber <= 250)
            {
                emotion = "Pannicked";
            }

            AddEmotionToDB(emotion);

            return emotion;
        }

        private int SelectLastBPM()
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

        private double SelectLastTemp()
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

        private int SelectLastO2()
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

        private void AddEmotionToDB(string emotion)
        {
            string query = "INSERT INTO emotion(`ID`, `emotion`) VALUES (NULL, '" + emotion + "')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
