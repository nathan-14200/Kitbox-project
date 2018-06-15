using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientClassLibrary
{
    //Not usable with Corniere decoupee because ends with DEC
    public static class Index
    {
        private static List<Tuple<string, string>> colours = new List<Tuple<string, string>>();
        private static List<Tuple<string, string>> piece = new List<Tuple<string, string>>();
        //private static List<Tuple<string, string>> 

        public static string GetColourIndex(string name)
        {
            SetList();

            foreach(var t in colours)
            {
                if(t.Item1 == name)
                {
                    return t.Item2;
                }
            }

            return "";
            
        }

        public static string GetPieceIndex(string name)
        {
            SetList();
            
            foreach(var t in piece)
            {
                if(t.Item1 == "name")
                {
                    return t.Item2;
                }
            }

            return "";
        }

        private static void SetList()x
        {
            if(colours.Count == 0)
            {
                var c = new List<string> { "Blanc", "Brun", "Galvanise", "Noir", "Verre" };
                var ind = new List<string> { "BL", "BR", "GL", "NR", "VE" };

                for(int i = 0; i < c.Count(); i++)
                {
                    var t = Tuple.Create(c[i], ind[i]);
                    colours.Add(t);
                }
            }

            if(piece.Count == 0)
            {
                var p = new List<string> { "Corniere", "Panneau Ar", "Panneau GD", "Panneau HB", "Porte", "Tasseau",
                "Traverse Ar", "Traverse Av", "Traverse GD"};
                var i = new List<string> { "COR", "PAR", "PAG", "PAH", "POR", "TAS", "TRR", "TRF", "TRG" };
            }
        }
    }
}
