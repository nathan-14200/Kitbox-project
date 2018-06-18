using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientClassLibrary;

namespace Client_interface
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Load piece from database
            if(InitComp.GetAllPieces().Count() == 0)
            {
                ClientClassLibrary.InitComp.Retrievecomp();
            }

            Session.InitCart();
            CartMenu nextForm = new CartMenu();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
