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
        private bool hasAdder;
        private Dictionary<Piece, int> composition = new Dictionary<Piece, int>();
        private Adder adder;


        public Box(float height, float width, float depth, string colour, bool hasAdder)
        {
            //The typical pieces of a box must be added here in composition
            this.height = height;
            this.width = width;
            this.depth = depth;
            this.colour = colour;
            this.hasAdder = hasAdder;
            this.composition = SetBox(colour, height, width, depth);
            
        }


        //Possibilty to add pieces to the composition
        public void AddPiece(Piece piece, int num)
        {
            if(!composition.ContainsKey(piece))
            {
                composition[piece] = num;
            }
            else
            {
                composition[piece] += num;
            }
        }


        public Dictionary<Piece, int> GetComposition()
        {
            // Has to add the minimal pieces with the ones of the Adder
            Dictionary<Piece, int> comp = this.composition;

            if(this.hasAdder == true)
            {
                Dictionary<Piece, int> adderComp = adder.GetComp();
                foreach (var item in adderComp)
                {
                    comp[item.Key] = item.Value;
                }
            }            
            return comp;
        }


        //Create the adder of the box
        public void SetAdder(string adderName, string colour)
        {
            Adder add = new Adder(adderName, this.height, this.width, colour);
            this.adder = add;            
        }



        public float GetHeight()
        {
            //Adding 2 * 2cm of the 2 traverses
            return this.height + float.Parse("4");
        }


        public string GetColour()
        {
            return colour;
        }


        public string GetAdderName()
        {
            if(this.hasAdder == true)
            {
                return adder.GetName();
            }

            return "";
        }


        public string GetAdderColour()
        {
            if (this.hasAdder == true)
            {
                return this.adder.GetColour();
            }

            return "";
        }


        public Boolean GetHasAdder()
        {
            return this.hasAdder;
        }


        private Dictionary<Piece, int> SetBox(string colour, float height, float width, float depth)
        {
            Dictionary<Piece, int> myBox = new Dictionary<Piece, int>();
            List<Piece> allPieces = InitComp.GetAllPieces();
            
            
            foreach(Piece piece in allPieces)
            {
                if(piece.GetName() == "Panneau Ar" && piece.GetColour() == colour && piece.GetHeight() == height && piece.GetWidth() == width)
                {
                    myBox[piece] = 1;
                }
                else if(piece.GetName() == "Panneau GD" && piece.GetColour() == colour && piece.GetHeight() == height && piece.GetDepth() == depth)
                {
                    myBox[piece] = 2;
                }
                else if (piece.GetName() == "Panneau HB" && piece.GetColour() == colour && piece.GetWidth() == width && piece.GetDepth() == depth)
                {
                    //2 HB panels
                    myBox[piece] = 2;
                }
                else if (piece.GetName() == "Traverse Ar" && piece.GetWidth() == width)
                {
                    //1  AR traverses
                    myBox[piece] = 1;
                }
                else if (piece.GetName() == "Traverse Av" && piece.GetWidth() == width)
                {
                    //1 Av traverse
                    myBox[piece] = 1;
                }
                else if (piece.GetName() == "Traverse GD" && piece.GetWidth() == width)
                {
                    //2 GD traverse
                    myBox[piece] = 2;
                }
                else if(piece.GetName() == "Tasseau" && piece.GetHeight() == height)
                {
                    //4 Tasseau
                    myBox[piece] = 4;
                }
            }
            return myBox;
        }
    }
}
