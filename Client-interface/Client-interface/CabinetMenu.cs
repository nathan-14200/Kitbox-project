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
            SetDataGrid(dataGridView1);
            test.Text = dataGridView1.ColumnCount.ToString();
            
        }

        
        private void SetDataGrid(object sender)
        {
            DataGridView grid = (DataGridView)sender;
            Cabinet currentCabinet = Session.GetCabinet();
            grid.ReadOnly = false;
            int i = 0;
            if(currentCabinet.GetBoxComposition().Count() > 0)
            {
                foreach (Box box in currentCabinet.GetBoxComposition())
                {
                    grid.Rows.Add();
                    grid.Rows[i].Cells[0].Value = (i+1).ToString();
                    grid.Rows[i].Cells[1].Value = box.GetHeight().ToString();
                    grid.Rows[i].Cells[2].Value = box.GetColour();
                    grid.Rows[i].Cells[3].Value = box.GetAdderName();
                    grid.Rows[i].Cells[4].Value = box.GetAdderColour();

                    i += 1;
                }
            }

            grid.Refresh();
            grid.ReadOnly = true;
        }

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
