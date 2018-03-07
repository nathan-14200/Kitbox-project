using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientClassLibrary
{
    class Adder
    {
        //The key is the name of the adder and the value is a list of the pieces
        private static Dictionary<string, List<string>> possibleAdder = new Dictionary<string, List<string>>();
        //ajouter les adder + leurs pièces

        //Gives a list of possible adder
        public static List<string> GetAdder()
        {
            List<string> keyList = new List<string>(possibleAdder.Keys);
            return keyList;
        }

        //Get the list of pieces of a specific adder
        public static List<string> GetPieces(string adder)
        {
            List<string> pieces = new List<string>();

            foreach (KeyValuePair < string, List<string>> Adder in possibleAdder)
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
