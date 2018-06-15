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
        //value of the heighest Corniere
        private float maxHeight = 375;
        //private double height;
        private Dictionary<Piece, int> composition;


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

        public int AddBox(float h, float width, float depth, string colour, bool hasAdder)
        {
            //Has to check if not more than 7 boxes and certain height limit.
            //Error message if not added?
            
            float height = h + 4 + this.height;
            if(boxComposition.Count < 7 && maxHeight > height)  // + height limit
            {
                boxComposition.Add(new Box(height, width, depth, colour, hasAdder));
                this.height += boxComposition[boxComposition.Count - 1].getHeight();

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


        public Dictionary<Piece, int> GetComposition()
        {
            composition = new Dictionary<Piece, int>();

            foreach(Box box in boxComposition)
            {
                Dictionary<Piece, int> boxComp = box.GetComposition();
                foreach(var p in boxComp)
                {
                    if(!composition.ContainsKey(p.Key))
                    {
                        composition[p.Key] = p.Value;
                    }
                    else
                    {
                        composition[p.Key] += p.Value; 
                    }
                }
            }
            return composition;
        }
    }
}
