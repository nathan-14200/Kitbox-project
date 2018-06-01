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

        private bool CheckComplete()
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
    }
}
