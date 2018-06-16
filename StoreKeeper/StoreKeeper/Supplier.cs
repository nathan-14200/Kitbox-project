using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreKeeper
{
    class Supplier
    {
        private string name;
        private Dictionary<string, Tuple<int, int>> catalog;

        Supplier(string Name, Dictionary<string, Tuple<int, int>> Catalog)
        {
            this.name = Name;
            this.catalog = Catalog;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Dictionary<string, Tuple<int,int>> Catalog
        {
            get { return this.catalog; }
        }

        public int RatioPiece(string piece)
        {
            int price = this.catalog[piece].Item1;
            int delay = this.catalog[piece].Item2;

            return price * delay;
        }
    }
}
