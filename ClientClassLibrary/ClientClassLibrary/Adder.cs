using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientClassLibrary
{
    public class Adder
    {
        //The key is the name of the adder and the value is a list of the pieces
        private static Dictionary<string, List<Piece>> possibleAdder = new Dictionary<string, List<Piece>>();
        //ajouter les adder + leurs pièces

        //Gives a list of possible adder
        public static List<string> GetAdder()
        {
            List<string> keyList = new List<string>(possibleAdder.Keys);
            return keyList;
        }

        //Get the list of pieces of a specific adder
        public static List<Piece> GetPieces(string adder)
        {
            List<Piece> pieces = new List<Piece>();

            foreach (KeyValuePair < string, List<Piece>> Adder in possibleAdder)
            {
                if (Adder.Key == adder)
                {
                    pieces = Adder.Value;
                    return pieces;
                }
            }
            //pieces will be empty
            return pieces;
        }

    }
}
