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
        private string selectedBox = "";

        public CabinetMenu()
        {
            InitializeComponent();
            SetDataGrid(dataGridView1);
            SetComboBox(BoxBox);
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


        private void SetComboBox(ComboBox comboBox)
        {
            int boxCount = Session.GetCabinet().GetBoxComposition().Count();
            int i = 1;

            while(i <= boxCount)
            {
                comboBox.Items.Add(i);
                i += 1;
            }
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

        private void Validate_Click(object sender, EventArgs e)
        {
            CabinetValidate nextForm = new CabinetValidate();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void BoxBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            selectedBox = comboBox.Text;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (selectedBox != "")
            {
                List<Box> boxList = Session.GetCabinet().GetBoxComposition();
                Box box = boxList[int.Parse(selectedBox) - 1];
                Session.GetCabinet().DeleteBox(box);

                CabinetMenu nextForm = new CabinetMenu();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("You must select a cabinet to delete");
            }
        }
    }
}
