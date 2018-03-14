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
        private string name;
        private int number;

        public Cart(string name, int number)
        {
            this.name = name;
            this.number = number;
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


        public List<string> GetClientInfo()
        {
            List<string> info = new List<string>();
            info.Add(name);
            info.Add(number.ToString());

            return info;
        }


        public List<Piece> GetComposition()
        {
            List<Piece> total = new List<Piece>();

            foreach(Cabinet cabinet in order)
            {
                total.AddRange(cabinet.GetComposition());
            }

            return total;
        }

        public float GetPrice()
        {
            float price = 0;

            foreach(Piece piece in GetComposition())
            {
                price += piece.GetPrice();
            }

            return price;
        }
    }
}
