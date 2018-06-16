using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreKeeper
{
    class Order
    {
        private bool complete;
        private Dictionary<string, Tuple<int,int>> components;

        private string client;
        private string id;

        public Order(string Name, string ID, Dictionary<string,Tuple<int,int>> List)
        {
            this.client = Name;
            this.id = ID;
            this.components = List;

            Init();
        }

        public void Init()
        {
            this.complete = this.CompleteUpdate();
        }

        public bool Complete
        {
            get { return this.complete; }
            set { this.complete = this.CompleteUpdate(); }
        }

        public bool CompleteUpdate()
        {
            foreach (string elem in this.components.Keys)
            {
                if (this.components[elem].Item2 == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public Dictionary<string, List<string>> Search()
        {
            DbConnect db = new DbConnect();
            string query = "SELECT * FROM client";
            Dictionary<string, List<string>> client = db.Read(query);

            return client;
        }

        public override string ToString()
        {
            string txt = "";

            txt = txt + String.Format("{0} - {1} - {2}{3}", this.id, this.client, this.complete, Environment.NewLine);

            return txt;
        }
    }
}
