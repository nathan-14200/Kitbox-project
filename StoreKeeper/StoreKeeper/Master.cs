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

        public Master()
        {
            this.orders = InitOrders();
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

    }
}
