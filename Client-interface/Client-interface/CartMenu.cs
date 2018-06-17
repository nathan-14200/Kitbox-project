using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientClassLibrary;

namespace Client_interface
{
    public partial class CartMenu : Form
    {
        public CartMenu()
        {
            InitializeComponent();
            SetDataGrid(dataGridCart);
        }


        private void SetDataGrid(object sender)
        {
            DataGridView grid = (DataGridView)sender;
            Cart myCart = Session.Cart();
            grid.ReadOnly = false;
            int i = 0;

            if (myCart.GetCabinets().Count() > 0)
            {
                foreach (Cabinet cabinet in myCart.GetCabinets())
                {
                    grid.Rows.Add();
                    grid.Rows[i].Cells[0].Value = (i + 1).ToString();
                    grid.Rows[i].Cells[1].Value = cabinet.GetHeight().ToString();
                    grid.Rows[i].Cells[2].Value = cabinet.GetBoxComposition().Count().ToString();
                    grid.Rows[i].Cells[3].Value = cabinet.GetPrice().ToString();

                    i += 1;
                }
            }

            grid.Refresh();
            grid.ReadOnly = true;
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
            nextForm.ShowDialog();
            this.Close();

        }

        private void CartMenu_Load(object sender, EventArgs e)
        {

        }

        private void validate_Click(object sender, EventArgs e)
        {

        }
    }
}
