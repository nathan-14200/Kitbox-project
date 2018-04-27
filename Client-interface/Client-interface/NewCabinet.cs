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
            //Have to us dic even though it is twice the same value because ComboBox needs a dictionary
            SetComboBoxValues(widthBox, "width");
            SetComboBoxValues(depthBox,"depth");
        }

        //car is the specification you will look for in all the pieces (width or depth)
        
        /*
         *  THE SEARCH WILL NEED TO BE ON THE PANNEAU SPECIFICALY NOT ALL PIECES
         */
        private void SetComboBoxValues(ComboBox myComboBox, string car)
        {
            string width = this.selectedWidth;
            string depth = this.selectedDepth;

            Dictionary<float, float> values = new Dictionary<float, float>();
            List<Piece> pieces = InitComp.GetAllPieces();

            //No restriction and we load all possible car
            if (width == "" && depth == "")
            {
                foreach(Piece p in pieces)
                {
                    float t = p.GetAttribute<float>(car) ;
                    if (!values.ContainsKey(t) && t != 0)
                    {
                        values[t] = t;
                    }
                }
                myComboBox.DataSource = new BindingSource(values, null);
                myComboBox.DisplayMember = "Value";
                myComboBox.ValueMember = "Key";
            }
            //The width is settled and we look for the new depths
            else if(width != "" && depth == "")
            {
                float w = float.Parse(width);
                foreach(Piece p in pieces)
                {
                    float t = p.GetAttribute<float>(car);
                    float getDepth = p.GetAttribute<float>("depth");

                    if(t == w && !values.ContainsKey(getDepth) && getDepth != 0)
                    {
                        values[getDepth] = getDepth;
                    }
                }

                myComboBox.DataSource = new BindingSource(values, null);
                myComboBox.DisplayMember = "Value";
                myComboBox.ValueMember = "Key";
            }
            //The depth is settled and we look for the new widths
            else if(width == "" && depth != "")
            {
                float d = float.Parse(depth);
                foreach (Piece p in pieces)
                {
                    float t = p.GetAttribute<float>(car);
                    float getWidth = p.GetAttribute<float>("width");
                    if (t == d && !values.ContainsKey(getWidth) && getWidth != 0)
                    {
                        
                        values[getWidth] = getWidth;
                    }
                }

                myComboBox.DataSource = new BindingSource(values, null);
                myComboBox.DisplayMember = "Value";
                myComboBox.ValueMember = "Key";
            } 
        }


        //Set width and load new values for the depth comboBox (that have the same width)
        private void WidthValidate_Click(object sender, EventArgs e)
        {
            string value = widthBox.Text;
            this.selectedWidth = value;
            SetComboBoxValues(depthBox, "depth");
        }

        //Set the depth and load new values for the width comboBox (that have the same depth)
        private void DepthValidate_Click(object sender, EventArgs e)
        {
            string value = depthBox.Text;
            this.selectedDepth = value;
            SetComboBoxValues(widthBox, "width");

        }


        private void newBox_Click(object sender, EventArgs e)
        {
            CabinetMenu nextForm = new CabinetMenu();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            CartMenu nextForm = new CartMenu();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
        //??
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
            SetComboBoxValues(widthBox, "width");
            SetComboBoxValues(depthBox, "depth");
        }
    }
}
