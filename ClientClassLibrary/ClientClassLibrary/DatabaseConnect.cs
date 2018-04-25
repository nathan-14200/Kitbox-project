using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClientClassLibrary
{
    public class DatabaseConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DatabaseConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "kitbox";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch
            {
                return false;

            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }


        //Select the whole "pieces" table
        public Dictionary<string, List<string>> SelectPieces()
        {
            string query = "SELECT * FROM piece";

            Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();

            if (this.OpenConnection() == true)
            {
                Console.WriteLine("Connected");
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                DataTable schema = null;

                //Gets the name of the columns
                using (var reader = cmd.ExecuteReader(System.Data.CommandBehavior.SchemaOnly))
                {
                    schema = reader.GetSchemaTable();
                }

                while (dataReader.Read())
                {
                   foreach(DataRow col in schema.Rows)
                   {
                        string colName = col.ToString();
                        data[colName].Add(dataReader[colName].ToString() + "");
                   }
                }

                dataReader.Close();
                this.CloseConnection();

                return data;
            }
            else
            {
                Console.WriteLine("Could not connect");
                return data;
            }

        }
    }
}
