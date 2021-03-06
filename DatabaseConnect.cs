﻿using System;
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

        public DatabaseConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "kitbox";
            uid = "root";
            string connectionString;
            connectionString = "server = " + server + "; " + "database = " +
            database + "; " + "uid =" + uid + "; SslMode=none;";

            connection = new MySqlConnection(connectionString);
            Console.WriteLine("hi there");
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
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
            string query = "SELECT * FROM pieces";

            Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                DataTable schema = null;

                //Get the name of the columns
                using (var reader = cmd.ExecuteReader(System.Data.CommandBehavior.SchemaOnly))
                {
                    schema = reader.GetSchemaTable();
                }

                Console.WriteLine("Connected");
                
                MySqlDataReader dataReader = cmd.ExecuteReader();

                int i = 0;

                while (dataReader.Read())
                {
                   foreach(DataRow col in schema.Rows)
                   {
                        string colName = col.Field<string>("ColumnName");
                        if (i == 0)
                        {
                            data[colName] = new List<string>();
                            data[colName].Add(dataReader[colName].ToString() + "");
                        }
                        else
                        {
                            
                            data[colName].Add(dataReader[colName].ToString() + "");
                        }
                                             
                   }
                    i += 1;
                    Console.WriteLine("num: " + i.ToString());
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

        //Modify the db
        public void Modify(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
