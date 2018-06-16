using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreKeeper
{
    class Master
    {
        public List<Order> orders;
        public List<Piece> stock;

        public Master()
        {
            this.orders = InitOrders();
            this.stock = InitStock();
        }

        public List<Order> InitOrders()
        {
            List<Order> orders = new List<Order>();
            Dictionary<string, List<string>> clients = this.Search("SELECT * FROM client");

            int nb_cl = clients["ID"].Count;

            for (int i = 0; i < nb_cl; i++)
            {
                string name = clients["Nom"][i];
                string id = clients["ID"][i];
                Dictionary<string, Tuple<int, int>> lcomponents = new Dictionary<string, Tuple<int, int>>();

                Dictionary<string, List<string>> lists = this.Search("SELECT * FROM command WHERE ID_Com=" + id);

                int nb_comp = lists["ID_Com"].Count;

                for (int j=0; j<nb_comp; j++)
                {
                    int qt = Int32.Parse(lists["Qty"][j]);
                    int qt_miss = Int32.Parse(lists["Miss_Qty"][j]);
                    lcomponents[lists["Code_Piece"][j]] = new Tuple<int, int>(qt,qt_miss);
                }

                orders.Add(new Order(name, id, lcomponents));
            }

            return orders;
        }

        public List<Piece> InitStock()
        {
            List<Piece> orders = new List<Piece>();
            Dictionary<string, List<string>> pieces = this.Search("SELECT * FROM stock");

            int nb_pc = pieces["Fk_Code"].Count;

            for (int i=0; i<nb_pc; i++)
            {
                string code = pieces["Fk_Code"][i];
                int qt = int.Parse(pieces["Enstock"][i]);
                int qtm = int.Parse(pieces["Stock minimum"][i]);

                Piece piece = new Piece(code, qt, qtm);
                orders.Add(piece);
            }
            return orders;
        }

        public Dictionary<string, List<string>> Search(string query)
        {
            DbConnect db = new DbConnect();
            Dictionary<string, List<string>> data = db.Read(query);

            return data;
        }

        public void ShowOrders()
        {
            foreach(Order order in this.orders)
            {
                Console.WriteLine(order);
            }
        }

        public void ShowStock()
        {
            Console.WriteLine(String.Format("{0} ----- {1} ----- {2}", Environment.NewLine, "pieces in stock", Environment.NewLine));
            foreach(Piece piece in this.stock)
            {
                if (piece.Stock)
                    Console.WriteLine(piece);
            }
            Console.WriteLine(String.Format("{0} ----- {1} ----- {2}", Environment.NewLine, "pieces to buy", Environment.NewLine));
            foreach(Piece piece in this.stock)
            {
                if (!piece.Stock)
                    Console.WriteLine(piece);
            }
        }

        public void ShowStateOrder(int i)
        {
            string txt = "";
            
            Order order = FindOrder(i);

            if (order != null)
            {
                Dictionary<string, Tuple<int, int>> elems = order.Dictcomp;

                foreach (string elem in elems.Keys)
                {
                    int qt = order.Quantity(elem);
                    int qtt = order.TotalQuantity(elem);

                    txt = txt + String.Format("{0} - {1}/{2} {3}", elem, qt, qtt, Environment.NewLine);
                }
            }
            else { txt = "Retry"; }

            Console.WriteLine(txt);
        }

        public Order FindOrder(int id)
        {
            foreach(Order order in this.orders)
            {
                if (order.ID == id)
                    return order;
            }

            Console.WriteLine("[ERROR] Order not found");
            return null;
        }
    }
}
