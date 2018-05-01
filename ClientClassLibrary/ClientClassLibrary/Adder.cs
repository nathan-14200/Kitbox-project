using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientClassLibrary
{
    public class Adder
    {
        //The key is the name of the adder and the value is a dictionary of pieces
        private static Dictionary<string, Dictionary<Piece, int>> possibleAdder = new Dictionary<string, Dictionary<Piece, int>>();
        //ajouter les adder + leurs pièces

        //Gives a list of possible adder
        public static List<string> GetAdder()
        {
            List<string> keyList = new List<string>(possibleAdder.Keys);
            return keyList;
        }

        //Get the dictionary of pieces of a specific adder
        public static Dictionary<Piece, int> GetPieces(string adder)
        {
            Dictionary<Piece, int> pieces = new Dictionary<Piece, int>();

            foreach(KeyValuePair <string, Dictionary<Piece, int>> Adder in possibleAdder)
            {
                if (Adder.Key == adder)
                {
                    return Adder.Value;
                }
            }
            //pieces will be empty
            return pieces;
        }

    }
}
