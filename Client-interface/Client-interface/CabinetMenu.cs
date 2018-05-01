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
    public partial class CabinetMenu : Form
    {
        public CabinetMenu()
        {
            InitializeComponent();
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
    }
}
