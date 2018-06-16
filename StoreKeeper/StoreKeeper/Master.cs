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
        public List<Supplier> suppliers;

        public Master()
        {
            Init();
        }

        public void Init()
        {
            this.orders = InitOrders();
            this.stock = InitStock();
            this.suppliers = InitSuppliers();
        }

        public List<Supplier> InitSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();
            Dictionary<string, List<string>> dbsuppliers = this.Search("SELECT * FROM suppliers");

            int nb_sup = dbsuppliers["ID"].Count;

            for (int i = 0; i < nb_sup; i++)
            {
                string id = dbsuppliers["ID"][i];

                Dictionary<string, List<string>> dblink = this.Search("SELECT * FROM link_stock_supplier WHERE Fk_Supplier=" + id);

                int nb_p = dblink["Fk_Code"].Count;

                Dictionary<string, Tuple<double, int>> catalog = new Dictionary<string, Tuple<double, int>>();

                for (int j = 0; j < nb_p; j++)
                {
                    string code = dblink["Fk_Code"][j];

                    double price = double.Parse(dblink["price"][j]);
                    int delay = int.Parse(dblink["delay"][j]);

                    catalog[code] = new Tuple<double, int>(price, delay);
                }

                suppliers.Add(new Supplier(dbsuppliers["Nom"][i], catalog));
            }
            return suppliers;
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

                for (int j = 0; j < nb_comp; j++)
                {
                    int qt = Int32.Parse(lists["Qty"][j]);
                    int qt_miss = Int32.Parse(lists["Miss_Qty"][j]);
                    lcomponents[lists["Code_Piece"][j]] = new Tuple<int, int>(qt, qt_miss);
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

            for (int i = 0; i < nb_pc; i++)
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
            foreach (Order order in this.orders)
            {
                Console.WriteLine(order);
            }
        }

        public void ShowStock()
        {
            Console.WriteLine(String.Format("{0} ----- {1} ----- {2}", Environment.NewLine, "pieces in stock", Environment.NewLine));
            foreach (Piece piece in this.stock)
            {
                if (piece.Stock)
                    Console.WriteLine(piece);
            }
            Console.WriteLine(String.Format("{0} ----- {1} ----- {2}", Environment.NewLine, "pieces to buy", Environment.NewLine));
            foreach (Piece piece in this.stock)
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
            foreach (Order order in this.orders)
            {
                if (order.ID == id)
                    return order;
            }

            Console.WriteLine("[ERROR] Order not found");
            return null;
        }

        public Dictionary<string, Tuple<string, int, double>> CommandStock()
        {
            // create file with command made

            // find piece to command
            this.stock = InitStock();

            Dictionary<string, Tuple<string, int, double>> command = new Dictionary<string, Tuple<string, int, double>>();

            foreach (Piece piece in this.stock)
            {
                if (!piece.Stock)
                {
                    command[piece.Code] = BestRatio(piece.Code, piece.MQuantity);
                }                
            }
            return command;
        }

        public Tuple<string, int, double> BestRatio(string code, int qt)
        {
            int nb_sup = this.suppliers.Count;

            double ratio = 1000000000;
            string name = "";
            double price = -1;
            double total = -1;

            for (int i = 0; i < nb_sup; i++)
            {
                if (this.suppliers[i].Catalog.ContainsKey(code))
                {
                    if (this.suppliers[i].Ratio(code) < ratio)
                    {
                        name = suppliers[i].Name;
                        ratio = this.suppliers[i].Ratio(code);
                        price = this.suppliers[i].Catalog[code].Item1;

                        total = qt * price;
                    }
                }
            }

            if (total > 0)
            {
                Tuple<string, int, double> sup = new Tuple<string, int, double>(name, qt, total);

                return sup;
            }
            return null;
        }

        public void PrintCmd(Dictionary<string, Tuple<string, int, double>> cmd)
        {
            try
            {
                string txt = "";
                foreach (string code in cmd.Keys)
                {
                    txt = txt + String.Format("{0} - {1} / {2} / {3}{4}", code, cmd[code].Item1, cmd[code].Item2, cmd[code].Item3, Environment.NewLine);
                }

                string path = @"/output/cmd.txt";

                System.IO.File.WriteAllText(path, txt);
            }
            catch (Exception e)
            {
                Console.WriteLine("[PRINT] : No command made");
            }
        }

        public void ShowCmd(Dictionary<string, Tuple<string, int, double>> cmd)
        {
            try
            {
                string txt = "";
                foreach (string code in cmd.Keys)
                {
                    txt = txt + String.Format("{0} - {1} / {2} / {3}{4}", code, cmd[code].Item1, cmd[code].Item2, cmd[code].Item3, Environment.NewLine);
                }

                Console.WriteLine(txt);
            }
            catch (Exception e)
            {
                Console.WriteLine("[SHOW] : No command made");
            }
        }
    }
}

