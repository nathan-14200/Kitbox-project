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
    public partial class CabinetMenu : Form
    {
        public CabinetMenu()
        {
            InitializeComponent();
            
        }

        /*
        private void SetDataGrid(object sender, EventArgs e)
        {
            DataGrid dataGrid = (DataGrid)sender;
            Cabinet currentCabinet = Session.GetCabinet();

            int index = 0;

            foreach(Box box in currentCabinet.GetBoxComposition())
            {
               DataGrid[i,0] = i.ToString();
               DataGrid[i,1] = box.GetHeight().ToString();
               DataGrid[i,2] = box.GetColour();
               DataGrid[i,3] = box.GetAdderName();
               DataGrid[i,4] = box.GetAdderColour();

               i +=1;
            }
        }
        */

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Are you sure to cancel your cabinet?", "Cancel cart", MessageBoxButtons.YesNo);
            if (delete == DialogResult.Yes)
            {
                //Delete the cart in program
                CartMenu nextForm = new CartMenu();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
            else if (delete == DialogResult.No)
            {
            }
        }

        private void NewBox_Click(object sender, EventArgs e)
        {
            NewBox nextForm = new NewBox();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
