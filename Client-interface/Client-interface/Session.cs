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
        private Cart myCart = new Cart();

        public Session()
        {
        }

        public void SetWidth(float value)
        {
            this.selected_width = value;
        }

        public void SetDepth(float value)
        {
            this.selected_depth = value;
        }

        public float GetWidth()
        {
            return this.GetWidth();
        }

        public float GetDepth()
        {
            return this.selected_depth;
        }

    }

}
