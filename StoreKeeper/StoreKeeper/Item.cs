using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreKeeper
{
    class Item
    {
        private Dictionary<string, int> Data;

        Item(int quantity, int need)
        {
            Data = new Dictionary<string, int>();
            Data.Add("quantity", quantity);
            Data.Add("need", need);
            Data.Add("complete", Convert.ToInt32(need == quantity));
        }

        public int Quantity
        {
            get { return this.Data["quantity"];  }
            set { this.Data["quantity"] = value; }
        }

        public int Need
        {
            get { return this.Data["need"]; }
            set { this.Data["need"] = value; }
        }

        public int Complete
        {
            get { return this.Data["complete"]; }
            set { this.Data["complete"] = Convert.ToInt32(this.Data["need"] == this.Data["quantity"]); }
        }

        public void Update(int quantity, int need)
        {
            this.Quantity = quantity;
            this.Need = need;
            this.Complete = 0;
        }

        public override string ToString()
        {
            return String.Format("quantity: {0}/{1}", this.Quantity, this.Need);
        }
    }
}
