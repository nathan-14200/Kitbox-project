using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientClassLibrary
{
    public class Cabinet
    {
        private List<Box> boxComposition;
        private float width;
        private float depth;
        private string id;
        //private double height;
        private List<Piece> composition;


        public Cabinet(float width, float depth)
        {
            this.width = width;
            this.depth = depth;
        }

        public float GetWidth()
        {
            return this.width;
        }

        public float GetDepth()
        {
            return this.depth;
        }


        public float height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int AddBox(Box box)
        {
            //Has to check if not more than 7 boxes and certain height limit.
            //Error message if not added?
            
            float h = box.getHeight() + height;
            if(boxComposition.Count < 7)  // + height limit
            {
                boxComposition.Add(box);
                height += box.getHeight();

                return 0;
            }

            return 1;            
        }

        public void DeleteBox(Box box)
        {
            //To be changed (no print)

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
