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
            SetComboBox(heightBox, "height");
            SetComboBox(colourBox, "colour");

        }

        private void SetComboBox(ComboBox myComboBox, string car)
        {
            List<string> values = new List<string>();
            List<Piece> allPieces = InitComp.GetAllPieces();

            if (hasAdder == false && car == "height")
            {
                foreach (Piece piece in allPieces)
                {
                    //We use Tasseau to get the possible height
                    string s = piece.GetAttribute<string>(car);
                    if (piece.GetName() == "Tasseau" && !values.Contains(s))
                    {
                        values.Add(s);
                    }
                }
            }
            else if (car == "colour")
            {
                foreach (Piece piece in allPieces)
                {
                    string c = piece.GetAttribute<string>(car);
                    string[] name = piece.GetName().Split();
                    if (!values.Contains(c) && name[0] == "Panneau")
                    {
                        values.Add(c);
                    }
                }
            }
            //car = Adder
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


        private void tabControl_Edit(object sender, EventArgs e)
        {
            TabControl TabType = (TabControl)sender;
            string adder = selectedAdder;
            //Get the right dic from class adder
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
