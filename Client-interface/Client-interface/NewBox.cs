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
    public partial class NewBox : Form
    {
        private string selectedHeight = "";
        private string selectedColour = "";
        private Boolean hasAdder = false;
        private string selectedAdder = "";

        public NewBox()
        {    
            InitializeComponent();
        }

        private void NewBox_Load(object sender, EventArgs e)
        {

        }

        private void SetComboBox(ComboBox myComboBox, string car)
        {
            List<string> values = new List<string>();
            List<Piece> allPieces = InitComp.GetAllPieces();

            if(hasAdder == false && car != "adder")
            {
                foreach(Piece piece in allPieces)
                {
                    string s = piece.GetAttribute<string>(car);
                    if(piece.GetName() == "Tasseau" && !values.Contains(s))
                    {
                        values.Add(s);
                    }
                }
            }
            else
            {

            }

            foreach (string str in values)
            {
                myComboBox.Items.Add(str);
            }



        }

        private void heightBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            selectedHeight = (string)comboBox.SelectedText;
        }


        private void colourBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            selectedColour = (string)comboBox.SelectedText;
        }

        private void adderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            selectedAdder = (string)comboBox.SelectedText;
        }

        private void Adder_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox adderCheck = (CheckBox)sender;
            this.hasAdder = adderCheck.Checked;
            adderBox.Enabled = hasAdder;
        }

        
    }
}
