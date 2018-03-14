using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientClassLibrary
{
    class Cabinet
    {
        private List<Box> Composition;
        private double Width;
        private double Depth;
        private double Height;
        private List<Piece> Composing;

        public Cabinet()
        {

        }

        public double width
        {
            get { return this.Width; }
            set { this.Width = value; }
        }

        public double depth
        {
            get { return this.Depth; }
            set { this.Depth = value; }
        }

        public double height
        {
            get { return this.Height; }
            set { this.Height = value; }
        }

        public void AddBox(Box box)
        {
            Composition.Add(box);
        }

        public void DeleteBox(Box box)
        {
            foreach (Box elem in this.Composition)
            {
                if (box == elem)
                {
                    Composition.Remove(box);
                }
                else
                {
                    Console.WriteLine("Box not found");
                }
            }
        }

        public void UpdateComposing()
        {
            this.Composing = new List<Piece>();

            foreach (Box box in this.Composition)
            {
                this.Composing.Concat(box.GetComposition());
            }
        }

        public List<Piece> SendComposing()
        {
            return Composing;
        }

        public double GetPrice()
        {
            double price = 0;

            foreach (Box box in this.Composition)
            {
                price += box.GetPrice();
            }

            return price;
        }
    }
}
