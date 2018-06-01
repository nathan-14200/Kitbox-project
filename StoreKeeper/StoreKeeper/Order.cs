using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreKeeper
{
    class Order
    {
        private Dictionary<String, Item> Items;
        private Dictionary<String, String> Client;

        public Order()
        {
            this.Items = new Dictionary<String, Item>(); // List of Items
            // Items = {"serial number": {"quantity": int, "need": int, "complete": int}}
            this.Client = new Dictionary<String, String>(); // Information about the client
            // Client = {"Complete": "yes/no", "telephone number": "02***", "address": "Promenade de l'Alma 5"}
        }

        public bool IsComplete()
        {
            foreach (Item item in this.Items.Values)
            {
                if (item.Complete == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public List<Item> IncompleteList()
        {
            List<Item> list = new List<Item>();
            foreach(Item item in this.Items.Values)
            {
                if (item.Complete == 0)
                {
                    list.Add(item);
                }
            }

            return list;
        }

        public override string ToString()
        {
            String str = "";
            // Add information about the Client
            foreach (String key in this.Items.Keys)
            {
                str += String.Format("{0} : {1}{2}", key, this.Items[key].ToString(), Environment.NewLine);
            }
            return str;
        }
    }
}
