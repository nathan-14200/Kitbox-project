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
        private Dictionary<string, Tuple<double, int>> catalog;

        public Supplier(string Name, Dictionary<string, Tuple<double, int>> Catalog)
        {
            this.name = Name;
            this.catalog = Catalog;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Dictionary<string, Tuple<double,int>> Catalog
        {
            get { return this.catalog; }
        }

        public bool Contains(string code)
        {
            return this.catalog.ContainsKey(code);
        }

        public double Ratio(string code)
        {
            return this.catalog[code].Item1 * this.catalog[code].Item2; // ERROR HERE
        }
    }
}
