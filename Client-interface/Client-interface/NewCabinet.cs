using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientClassLibrary;

namespace Client_interface
{
    public partial class NewCabinet : Form
    {
        private string selectedWidth = "";
        private string selectedDepth = "";
        public NewCabinet()
        {
            InitializeComponent();
        }

        private void NewCabinet_Load(object sender, EventArgs e)
        {
            SetComboBoxValues(widthBox, "width");
            SetComboBoxValues(depthBox,"depth");
        }

        //car is the specification it will look for in all the pieces (width or depth)
        private void SetComboBoxValues(ComboBox myComboBox, string car)
        {
            string width = this.selectedWidth;
            string depth = this.selectedDepth;

            Dictionary<float, float> values = new Dictionary<float, float>();
            List<float> val = new List<float>();
            List<Piece> pieces = InitComp.GetAllPieces();

            //No restriction and we load all possible car
            foreach(Piece p in pieces)
            {
                float t = p.GetAttribute<float>(car) ;
                if (!val.Contains(t) && t != 0)
                {
                    val.Add(t);
                }
             }
            val.Sort();
            foreach(float num in val)
            {
                Console.WriteLine(num);
                myComboBox.Items.Add(num);
            }               
        }
       
        
        //Set width and load new values for the depth comboBox (that have the same width)
        private void WidthValidate_Click(object sender, EventArgs e)
        {
            string value = widthBox.Text;
            this.selectedWidth = value;
            widthBox.Enabled = false;
        }


        //Set the depth and load new values for the width comboBox (that have the same depth)
        private void DepthValidate_Click(object sender, EventArgs e)
        {
            string value = depthBox.Text;
            this.selectedDepth = value;
            depthBox.Enabled = false;
        }


        //Next window
        private void newBox_Click(object sender, EventArgs e)
        {
            if (selectedDepth != "" && selectedWidth != "")
            {
                Cart myCart = Session.Cart();

                //Adding the new cabinet to the cart
                myCart.AddCabinet(new Cabinet(float.Parse(selectedWidth), float.Parse(selectedDepth)));

                //Define the actual Cabinet we are working on for an easy access
                Session.SetActualCabinet(myCart.GetCabinets()[myCart.GetCabinets().Count - 1]);
                CabinetMenu nextForm = new CabinetMenu();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("You must validate width and depth before continuing");
            }
            
        }


        private void cancel_Click(object sender, EventArgs e)
        {
            CartMenu nextForm = new CartMenu();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }


        
        private void widthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            selectedWidth = (string)comboBox.SelectedText;
        }


        //Re initialize the selected width and depth value and combBox
        private void clear_Click(object sender, EventArgs e)
        {
            this.selectedWidth = "";
            this.selectedDepth = "";
            widthBox.Enabled = true;
            depthBox.Enabled = true;
        }
    }
}
