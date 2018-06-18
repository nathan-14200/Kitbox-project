using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientClassLibrary
{
    public class Cart
    {
        private List<Cabinet> order;
        private Dictionary<Piece, int> cartComp = new Dictionary<Piece, int>();

        public Cart()
        {
            this.order = new List<Cabinet>();
        }


        public void AddCabinet(Cabinet cabinet)
        {
            order.Add(cabinet);
        }


        public void DeleteCabinet(Cabinet cabinet)
        {
            if(order.Contains(cabinet))
            {
                order.Remove(cabinet);
            }
        }


        public List<Cabinet> GetCabinets()
        {
            return this.order;
        }


        public Dictionary<Piece, int> GetComposition()
        {
            if(cartComp.Count == 0)
            {
                foreach (Cabinet cabinet in order)
                {
                    Dictionary<Piece, int> cabinetComp = cabinet.GetComposition();
                    foreach (var p in cabinetComp)
                    {
                        if (!cartComp.ContainsKey(p.Key))
                        {
                            cartComp[p.Key] = p.Value;
                        }
                        else
                        {
                            cartComp[p.Key] += p.Value;
                        }
                    }
                }
            }

            return cartComp;
        }


        public float GetPrice()
        {
            float price = 0;

            foreach(var p in GetComposition())
            {
                price += p.Key.GetPrice() * p.Value;
            }

            return price;
        }
    }
}
