using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientClassLibrary
{
    class Cabinet
    {
        private List<Box> boxComposition;
        //private double width;
        //private double depth;
        //private double height;
        private List<Piece> composition;

        public Cabinet()
        {

        }

        public double width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public double depth
        {
            get { return this.depth; }
            set { this.depth = value; }
        }

        public double height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public void AddBox(Box box)
        {
            boxComposition.Add(box);
        }

        public void DeleteBox(Box box)
        {
            foreach (Box elem in this.boxComposition)
            {
                if (box == elem)
                {
                    boxComposition.Remove(box);
                }
                else
                {
                    Console.WriteLine("Box not found");
                }
            }
        }
        /*
        public void UpdateComposing()
        {
            this.composition = new List<Piece>();

            foreach (Box box in this.boxComposition)
            {
                this.Composing.Add(box.SendComposing());
            }
        }
        */

        public List<Piece> GetComposition()
        {
            List<Piece> comp = composition;

            foreach(Box box in boxComposition)
            {
                comp.AddRange(box.GetComposition());
            }
            return comp;
        }

        public float GetPrice()
        {
            float price = 0;

            List<Piece> comp = GetComposition();
            foreach(Piece piece in comp)
            {
                price += piece.GetPrice();
            }

            return price;
        }
    }
}
