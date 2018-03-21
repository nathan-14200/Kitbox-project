using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientClassLibrary
{
    public class Piece
    {
        private int ID;
        private string name;
        private float price;
        private float heigth;
        private float width;
        private float depth;
        private string colour;
        private bool instock;

        public Piece(int ID, string name, float price, float heigth, float width, float depth, string colour, bool instock)
        {
            this.ID = ID;
            this.name = name;
            this.price = price;
            this.heigth = heigth;
            this.width = width;
            this.depth = depth;
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

        public float GetHeight()
        {
            return this.heigth;
        }

        public float GetWidth()
        {
            return this.width;
        }

        public float GetDepth()
        {
            return this.depth;
        }
    }
}
