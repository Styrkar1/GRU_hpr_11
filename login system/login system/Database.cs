using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace login_system
{
    class Database
    {

        private string server;

        private string database;

        private string uid;

        private string password;

        string connectionString = null;

        string querry = null;

        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
       // MySqlDataReader sqlReader = null;

        public void ConnectionToDatabase()
        {
            server = "tsuts.tskoli.is";
            database = "1612982129_gru";
            uid = "1612982129";
            password = "mypassword";

            connectionString = "server= " + server + ";userid= " + uid + ";password= " + password + ";database= " + database;

            sqlConnection = new MySqlConnection(connectionString);

        }

        public bool OpenConnection()
        {
            try
            {

                sqlConnection.Open();
                return true;

            }
            catch (MySqlException ex)
            {

                throw ex;
            }
        }

        public void InputIntoDatabase(string name, string home, string post, string age)
        {

            if (OpenConnection() == true)
            {
                querry = "INSERT INTO tableHlutaprof (name, home, post, age) VALUES ('" + name + "','" + home + "','" + post + "','" + age + "')";
                sqlCommand = new MySqlCommand(querry, sqlConnection);

                sqlCommand.ExecuteNonQuery();
                CloseConnection();
            }
        }

        /*  public string FindUserAndShow(string name)
          {

          }

          public void Delete(string name)
          {
              if (OpenConnection() == true)
              {
                  querry = "Delete FROM tableHlutaprof where name = '" + name + "'";
                  sqlCommand = new MySqlCommand(querry, sqlConnection);

                  sqlCommand.ExecuteNonQuery();
                  CloseConnection();
              }
          }
          */
        public void Update(string name, string home, int post, int age)
        {
            if (OpenConnection() == true)
            {
                querry = "Update tableHlutaprof set name ='" + name + "', home = '" + home + "', post = " + post + ", age = " + age;

                sqlCommand = new MySqlCommand(querry, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                CloseConnection();
            }
        }

       /* public List<string> ReadFromDatabase()
        {
            List<string> values = new List<string>();
            string line = null;
            if (OpenConnection() == true)
            {
                querry = "SELECT name, home, post, age FROM tableHlutaprof";
                sqlCommand = new MySqlCommand(querry, sqlConnection);

                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    for (int i = 0; i < sqlReader.FieldCount; i++)
                    {
                        line += (sqlReader.GetValue(i).ToString()) + ":";
                    }
                    values.Add(line);
                    line = null;
                }
                CloseConnection();
                return values;
            }
        }*/

        private bool CloseConnection()
        {
            try
            {

                sqlConnection.Close();
                return true;

            }
            catch (MySqlException ex)
            {

                throw ex;
            }
        }
    }
}
