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
    public partial class OrderRegistered : Form
    {
        public OrderRegistered()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home nextForm = new Home();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
