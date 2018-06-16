using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreKeeper
{
    class Piece
    {
        private string code;
        private int quantity;
        private int quantity_min;

        public Piece(string Code, int Quantity, int mQuantity)
        {
            this.code = Code;
            this.quantity = Quantity;
            this.quantity_min = mQuantity;
        }

        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = this.quantity + value; }
        }

        public int MQuantity
        {
            get { return this.quantity_min; }
        }

        public string Code
        {
            get { return this.code; }
        }
    }
}
