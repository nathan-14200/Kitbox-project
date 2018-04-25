using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientClassLibrary
{
    public static class InitComp
    {
        private static List<Piece> allPieces;

        public static void Retrievecomp()
        {
            //Retrieve and create Piece object and place them in allPieces list
            Console.WriteLine("In Retrieve");
            DatabaseConnect connection = new DatabaseConnect();
            Dictionary<string, List<string>> rawData = connection.SelectPieces();

            foreach(KeyValuePair<string,List<string>> k in rawData)
            {
                Console.WriteLine(k.Key);
            }

            Console.WriteLine("End of Retrieve");

        }

        public static List<Piece> GetAllPieces()
        {
            return allPieces;
        }

        public static void UpdateDB(String CmdString, Dictionary<String,int> Mod)
        {
            /* 
             * Template CmdString: @"UPDATE table_name SET param_column='@param_name' WHERE cdt_column='@cdt_name'"
             * Template Mod: {"@param_name": value}
             */

            String ConnectionString = String.Format("Server={0};Database={1};Trusted_Connection={2}", "server_name", "database_name", "bool");
            String CommandString = String.Format("UPDATE {0} SET {1}' WHERE {2}", "table_name", "param_column='@param_name'", "cdt_column='@cdt_name'");
            List <Object[]> Result = new List<Object[]>();

            using (SqlConnection conn = new SqlConnection())
            {
                // Init the commands for DB
                conn.ConnectionString = ConnectionString;
                SqlCommand command = new SqlCommand(CmdString, conn);
                conn.CreateCommand();

                // Modify the values of elements for all the element of the modification Dictionnary
                foreach (String Key in Mod.Keys)
                {
                    command.Parameters.Add(Key, SqlDbType.VarChar);
                    command.Parameters[Key].Value = Mod[Key];
                }

                conn.Open();

                command.ExecuteNonQuery();
            }
        }

        public static List<Object[]> ReadDB(String CmdString)
        {
            /* 
             * Template CmdString: @"SELECT * FROM table_name WHERE cdt_column=cdt_name"
             */

            String ConnectionString = String.Format("Server={0};Database={1};Trusted_Connection={2}", "server_name", "database_name", "bool");
            String CommandString = String.Format("SELECT {0} FROM {1} WHERE {2}", "*", "table_name", "cdt");
            List<Object[]> Result = new List<Object[]>();

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConnectionString;
                conn.Open();

                SqlCommand command = new SqlCommand(CmdString, conn);

                // Read the DB
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        List<String> Data = new List<string>();

                        // Save arrow of values in a returned list
                        Object[] values = new Object[reader.FieldCount];
                        int fieldCount = reader.GetValues(values);
                        Result.Add(values);
                    }
                }
            }

            return Result;
        }
    }
}
