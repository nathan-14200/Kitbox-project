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
        private float width;
        private float depth;
        private string colour;
        private bool HasAdder;
        private Dictionary<Piece, int> composition = new Dictionary<Piece, int>();
        private string adder;


        public Box(float height, float width, float depth, string colour, bool hasAdder)
        {
            //The typical pieces of a box must be added here in composition
            this.height = height;
            this.width = width;
            this.depth = depth;
            this.colour = colour;
            this.HasAdder = hasAdder;
            this.composition = SetBox(colour, height, width, depth);
        }

        public Dictionary<Piece, int> GetComposition()
        {
            // Has to add the minimal pieces with the ones of the Adder
            Dictionary<Piece, int> comp = this.composition;

            Dictionary<Piece, int> adderComp = Adder.GetPieces(adder);
            foreach(var item in adderComp)
            {
                comp.Add(item.Key, item.Value);
            }
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
            //Adding 2 * 2cm of the 2 traverse
            return height + 4;

        }


        private Dictionary<Piece, int> SetBox(string colour, float height, float width, float depth)
        {
            Dictionary<Piece, int> myBox = new Dictionary<Piece, int>();
            List<Piece> allPieces = InitComp.GetAllPieces();
            
            
            foreach(Piece piece in allPieces)
            {
                if(piece.GetName() == "Panneau Ar" && piece.GetColour() == colour && piece.GetHeight() == height && !myBox.ContainsKey(piece))
                {
                    myBox[piece] = 1;
                }
                else if(piece.GetName() == "Panneau GD" && piece.GetColour() == colour && piece.GetHeight() == height && !myBox.ContainsKey(piece))
                {
                    myBox[piece] = 2;
                }
                else if (piece.GetName() == "Panneau HB" && piece.GetColour() == colour && piece.GetHeight() == height && !myBox.ContainsKey(piece))
                {
                    //2 HB panels
                    myBox[piece] = 2;
                }//Only one type of traverse differing by their height
                else if (piece.GetName() == "Traverse Ar" && piece.GetColour() == colour && piece.GetWidth() == height)
                {
                    //2  AR traverses
                    myBox[piece] = 2;
                }
                else if (piece.GetName() == "Traverse Av" && piece.GetColour() == colour && piece.GetHeight() == height)
                {
                    //2 Av traverse
                    myBox[piece] = 2;
                }
                else if (piece.GetName() == "Traverse GD" && piece.GetColour() == colour && piece.GetHeight() == height)
                {
                    //4 GD traverse
                    myBox[piece] = 4;
                }
                else if(piece.GetName() == "Tasseau" && piece.GetHeight() == height)
                {
                    //4 Tasseau
                    myBox[piece] = 4;
                }
            }

            return myBox;
        }


        public double GetPrice()
        {
            double price = 0;

            foreach (var item in this.composition)
            {
                price += item.Key.GetPrice() * item.Value;
            }

            return price;
        }

    }
}
