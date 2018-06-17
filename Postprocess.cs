using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace ClientClassLibrary
{
    public class PostProcess
    {
        public void Ticket(Cart cart)
        {
            Dictionary<Piece, int> Ticket = cart.GetComposition(); 
            float Price = cart.GetPrice();
            using (StreamWriter file = new StreamWriter("ticket.txt"))
            {
                foreach (var entry in Ticket)
                    file.WriteLine("{0} - {1}", entry.Key, entry.Value);
                file.WriteLine("total = {0}", Price);
            }
        }

        public void Stock(Cart cart)
        {
            DatabaseConnect connection = new DatabaseConnect();
            Dictionary<string, List<string>> rawData = connection.SelectPieces();

            string id_com = DateTime.Now.ToString();

            Dictionary<string, int> data = new Dictionary<string, int>();
            int nb_elem = rawData["Fk_Code"].Count;
            for (int i=0; i< nb_elem; i++)
            {
                data[rawData["Fk_Code"][i]] = int.Parse(rawData["EnStock"][i]);
            }
            Dictionary<Piece, int> Ticket = cart.GetComposition();
            foreach (var entry in Ticket)
            {
                int Stock = data[entry.Key.GetName()];
                int Miss_Qty = entry.Value;
                if (Stock > entry.Value)
                {
                    int Qty = Stock - entry.Value;
                    Miss_Qty = 0;

                    // query to modify stock
                    string QueryStock = string.Format("UPDATE stock SET EnStock={0} WHERE stock.Fk_Code='{1}'", Qty, entry.Key.GetName());
                    connection.Modify(QueryStock);
                }
                // query to add to command table
                string QueryCommand = string.Format("INSERT INTO command (ID_Com, Code_Piece, Qty, Miss_Qty) VALUES ({0},{1},{2},{3})", id_com , entry.Key.GetName(), entry.Value, Miss_Qty);
                connection.Modify(QueryCommand);
            }

        }
    }       
}