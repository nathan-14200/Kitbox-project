using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientClassLibrary;


namespace DebugApp
{
    class Program
    {
        static void Main(string[] args)
        {
            InitComp.Retrievecomp();
            Console.WriteLine(InitComp.GetAllPieces().Count());
            Console.ReadKey();
        }
    }
}
