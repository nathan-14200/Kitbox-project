using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientClassLibrary
{
    public class Box
    {
        private float height;
        private string colour;
        private bool HasAdder;
        private List<Piece> composition = new List<Piece>();
        private string adder;


        public Box(float height, string colour, bool hasAdder)
        {
            //The typical pieces of a box must be added here in composition
            this.height = height;
            this.colour = colour;
            this.HasAdder = hasAdder;
            //this.composition = ...; to be finished
        }

        public List<Piece> GetComposition()
        {
            // Has to add the minimal pieces with the ones of the Adder
            List<Piece> comp = this.composition;
            List<Piece> adderComp = Adder.GetPieces(adder);
            comp.AddRange(adderComp);
            return comp;
        }

        public void SetAdder(string adder)
        {
            //Check if adder in our list before accepting a change  
            List<string> possibleAdder = Adder.GetAdder();
            if (possibleAdder.Contains(adder))
            {
                this.adder = adder;
            }                
        }

        public float getHeight()
        {
            return height;
        }

    }
}
