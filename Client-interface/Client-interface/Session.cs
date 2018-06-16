using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientClassLibrary;

namespace Client_interface
{
    public static class Session
    {
        private static Cart myCart;
        private static Cabinet actualCabinet;

        public static void InitCart()
        {
            myCart = new Cart();
        }

        public static Cart Cart()
        {
            return myCart;
        }


        public static Cabinet GetCabinet()
        {
            return actualCabinet;
        }

        public static void SetActualCabinet(Cabinet cabinet)
        {
            actualCabinet = cabinet;
        }
    }
}
