﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientClassLibrary
{
    public class Adder
    {
        private static Dictionary<string,Dictionary<string, int>> possibleAdder = new Dictionary<string, Dictionary<string, int>>();
        private string adderName;
        private float width;
        private float height;
        private string colour;
        private Dictionary<Piece, int> comp = new Dictionary<Piece, int>();

        public Adder(string adderName, float width, float height, string colour)
        {
            this.adderName = adderName;
            this.width = width;
            this.height = height;
            this.colour = colour;
            this.comp = SetComp(adderName, colour, width, height);
        }


        private static Dictionary<Piece, int> SetComp(string name, string colour, float width, float height)
        {
            Dictionary<Piece, int> d = new Dictionary<Piece, int>();

            foreach(var adder in possibleAdder)
            {
                if(adder.Key == name)
                {
                    Dictionary<string, int> rawComp = adder.Value;

                    foreach(var piece in rawComp)
                    {
                        //Making the id string to find the piece in the db
                        string indexP = Index.GetPieceIndex(piece.Key);
                        string h = height.ToString();
                        string w = width.ToString();
                        string indexC = Index.GetColourIndex(colour);

                        string id = indexP + h + w + indexC;

                        Piece p = InitComp.GetPieceByID(id);
                        //p name = "" if failed to find the id
                        if(p.GetName() != "")
                        {
                            d[p] = piece.Value;
                        }
                    }
                    break;
                }
            }
            return d;
        }


        //Gives a list of possible adder
        public static List<string> GetAdder()
        {
            SetAdder();
            List<string> keyList = new List<string>(possibleAdder.Keys);
            return keyList;
        }

        //Get the dictionary of pieces of the adder
        public Dictionary<Piece, int> GetComp()
        {
            return this.comp;
        }


        //Adding by hand all possible Adder and their piece (to be updated?)
        //Should have a list of list of all pieces for each Adder
        private static void SetAdder()
        {
            if(possibleAdder.Count() == 0)
            {
                List<Piece> allPiece = InitComp.GetAllPieces();
                foreach(Piece piece in allPiece)
                {

                    string name = piece.GetName();
                    string colour = piece.GetAttribute<string>("colour");

                    //Adding wooden doors
                    if(!possibleAdder.ContainsKey("Wooden Door") && name == "Porte" && colour != "Verre")
                    {
                        Dictionary<string, int> p = new Dictionary<string, int>();
                        p[piece] = 2;
                        p[coupel] = 2;
                        possibleAdder["Porte"] = p;
                    }
                    else if(!possibleAdder.ContainsKey(name+"V") && name == "Porte" && colour == "Verre")
                    {
                        Dictionary<Piece, int> p = new Dictionary<Piece, int>();
                    }
                }
            }
        }

    }
}
