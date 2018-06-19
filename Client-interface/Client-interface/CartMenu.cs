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
        private string selectedCabinet = "";

        public CartMenu()
        {
            InitializeComponent();
            SetDataGrid(dataGridCart);
            SetComboBox(CabinetBox);
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
                    grid.Rows[i].Cells[3].Value = Session.GetPrice(cabinet.GetComposition()).ToString();

                    i += 1;
                }
            }
            grid.Refresh();
            grid.ReadOnly = true;
        }


        private void SetComboBox(ComboBox comboBox)
        {
            int cabinetCount = Session.Cart().GetCabinets().Count();
            int i = 1;
            while(i <= cabinetCount)
            {
                comboBox.Items.Add(i);
                i += 1;
            }
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


        private void validate_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Have you finished you order?", "Order check", MessageBoxButtons.YesNo);
            if (ask == DialogResult.Yes)
            {
                //Code Valerian
				
				Postprocess pp = new Postprocess();
				Cart c = Session.Cart();
				//print ticket
				pp.Ticket(c);
				//update db
				pp.Stock(c);
				
				
                OrderRegistered nextForm = new OrderRegistered();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
            else if (ask == DialogResult.No)
            {
            }
            
        }


        private void Delete_Click(object sender, EventArgs e)
        {
            if(selectedCabinet != "")
            {
                List<Cabinet> cabinetList = Session.Cart().GetCabinets();
                Cabinet cabinet = cabinetList[int.Parse(selectedCabinet) - 1];
                Session.Cart().DeleteCabinet(cabinet);

                CartMenu nextForm = new CartMenu();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("You must select a cabinet to delete");
            }
        }


        private void CabinetBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            selectedCabinet = comboBox.Text;
        }
    }
}
