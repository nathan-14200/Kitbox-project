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

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void button1_Click(object sender, EventArgs e)
        {
            CartMenu nextForm = new CartMenu();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            AllocConsole();
            ClientClassLibrary.InitComp.Retrievecomp();
        }
    }
}
