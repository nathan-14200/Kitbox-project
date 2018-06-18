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
            List<Piece> allPiece = InitComp.GetAllPieces();
            List<Piece> askedPiece = new List<Piece>();
            //width = largeur (Panneau Ar)
            if(attribute == "width")
            {
                foreach(Piece piece in allPiece)
                {
                    if(piece.GetName() == "Panneau Ar")
                    {
                        askedPiece.Add(piece);
                    }
                }
                return askedPiece;
            }
            //depth = profonder (Panneau GD)
            else if(attribute == "depth")
            {
                foreach(Piece piece in allPiece)
                {
                    if(piece.GetName() == "Panneau GD")
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
            //Retrieve the possible values of an attribute (width, depth, colour, height) for a list of pieces
            //The list is empty if not a correct attribute
            List<T> newList = new List<T>();

            foreach(Piece piece in myPiece)
            {
                T value = piece.GetAttribute<T>(attribute);
                if(value == null)
                {
                    return newList;
                }
                else
                {
                    newList.Add(value);
                }
            }
            return newList;
        }


        public static List<Piece> UpdateListPiece<T>(List<Piece> myPiece, string attribute, T value)
        {
            //Filter a list of pieces wich have the same attribute
            List<Piece> updatedList = new List<Piece>();

            foreach(Piece piece in myPiece)
            {
                if(piece.GetAttribute<T>(attribute).ToString() == value.ToString())
                {
                    updatedList.Add(piece);
                }
            }
            return updatedList;
        }
    }
}
