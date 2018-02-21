using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_interface
{
    public partial class CartMenu : Form
    {
        public CartMenu()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Are you sure to delete your cart?", "Deleting cart", MessageBoxButtons.YesNo);
            if(delete == DialogResult.Yes)
            {
                //Delete the cart in program
                Home nextForm = new Home();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
            else if(delete == DialogResult.No)
            {
            }
        }

        private void newCabinet_Click(object sender, EventArgs e)
        {
            NewCabinet nextForm = new NewCabinet();
            this.Hide();
            //nextForm.ShowDialog();
            this.Close();

        }
    }
}
