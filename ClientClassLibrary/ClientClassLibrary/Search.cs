using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientClassLibrary
{
    public static class Search
    {
        public static List<Piece> PossiblePiece(string attribute)
        {
            //Retrieve corresponding pieces depending on the search (width or depth)
            //DOES NOT CHECK IF EMPTY
            List<Piece> allPiece = InitComp.GetAllPieces();
            List<Piece> askedPiece = new List<Piece>();
            //width = largeur (PANNEAU Ar)
            if(attribute == "width")
            {
                foreach(Piece piece in allPiece)
                {
                    if(piece.GetName() == "PANNEAU Ar")
                    {
                        askedPiece.Add(piece);
                    }
                }
                return askedPiece;
            }
            //depth = profonder (PANNEAU GD)
            else if(attribute == "depth")
            {
                foreach(Piece piece in allPiece)
                {
                    if(piece.GetName() == "PANNEAU GD")
                    {
                        askedPiece.Add(piece);
                    }
                }
                return askedPiece;
            }
            else
            {
                return askedPiece;
            }
        }


        public static List<T> GetPossibleValue<T>(string attribute, List<Piece> myPiece)
        {
            //Retrieve the possible values of an attribute (width, depth, colour,) for a list of pieces
            List<T> newList = new List<T>();

            if()



        }
    }
}
