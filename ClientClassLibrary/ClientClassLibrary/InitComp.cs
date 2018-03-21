using System;
using System.Collections.Generic;
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

        }

        public static List<Piece> GetAllPieces()
        {
            return allPieces;
        }

        public static List<Object[]> ReadDB(String CmdString)
        {
            String ConnectionString = String.Format("Server={0};Database={1};Trusted_Connection={2}", "server_name", "database_name", "bool");
            String CommandString = String.Format("SELECT {0} FROM {1} WHERE {2}", "*", "table_name", "condition");
            List<Object[]> Result = new List<Object[]>();

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConnectionString;
                conn.Open();

                // use the connection here
                SqlCommand command = new SqlCommand(CmdString, conn);

                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        List<String> Data = new List<string>();

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
