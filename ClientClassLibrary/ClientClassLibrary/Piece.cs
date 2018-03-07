using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientClassLibrary
{
    class Piece
    {
        private int ID;
        private string name;
        private float price;
        private string colour;
        private bool instock;

        public Piece(int ID, string name, float price, string colour, bool instock)
        {
            this.ID = ID;
            this.name = name;
            this.price = price;
            this.colour = colour;
            this.instock = instock;
        }


        public Boolean IsInStock()
        {
            return this.instock;
        }

        public string GetName()
        {
            return this.name;
        }

        public float GetPrice()
        {
            return this.price;
        }

        public string GetColour()
        {
            return this.colour;
        }

        public int GetID()
        {
            return this.ID;
        }
    }
}
