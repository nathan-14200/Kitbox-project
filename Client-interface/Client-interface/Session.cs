using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientClassLibrary;

namespace Client_interface
{
    public class Session
    {
        private float selected_width = 0; 
        private float selected_depth = 0;
        private Cart myCart;

        public Session()
        {

        }

        public Cart GetCart()
        {
            return this.myCart;
        }

        public void SetWidth(float value)
        {
            this.selected_width = value;
        }

        public float GetWidth()
        {
            return this.selected_width;
        }

        public void SetDepth(float value)
        {
            this.selected_depth = value;
        }

        public float GetDepth()
        {
            return this.selected_depth;
        }
    }

    
}
