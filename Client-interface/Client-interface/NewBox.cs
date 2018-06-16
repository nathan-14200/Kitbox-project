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
        private Boolean hasCoupel = false;
        private string selectedAdder = "";
        private string selectedAdderColour = "";

        public NewBox()
        {    
            InitializeComponent();
        }

        private void NewBox_Load(object sender, EventArgs e)
        {
            SetComboBox(heightBox, "height");
            SetComboBox(colourBox, "colour");
            SetComboBox(adderBox, "adder");

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
            else if(car == "adder")
            {
                //Get all possible adders
                List<string> adders = Adder.GetAdder();
                foreach(string adder in adders)
                {
                    values.Add(adder);
                }
            }            
            else if (car == "adderColour")
            {
                
                foreach (var element in Adder.GetPossibleAdder())
                {
                    if(element.Key == selectedAdder)
                    {
                        foreach(var p in element.Value)
                        {
                            //We assume that each piece have the same colour and available colour so doesn't matter with piece we choose
                            string name = p.Key;

                            foreach(Piece piece in allPieces)
                            {
                                string pieceColour = piece.GetColour();
                                if (piece.GetName() == "Porte " && !values.Contains(pieceColour))
                                {
                                    values.Add(pieceColour);
                                }
                            }
                            break;
                        }
                        
                    }
                }                              
            }
            
            foreach (string str in values)
            {
                myComboBox.Items.Add(str);
            }



        }

        private void heightBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            selectedHeight = (string)comboBox.Text;
        }


        private void colourBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            selectedColour = (string)comboBox.Text;
        }

        private void adderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            selectedAdder = (string)comboBox.Text;
            SetComboBox(adderColour, "adderColour");
        }


        private void adderColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            selectedAdderColour = (string)comboBox.Text;

            if (selectedAdderColour == "Verre")
            {
                CoupelBox.Enabled = false;
                CoupelBox.Checked = false;
                this.hasCoupel = false;
            }
            else
            {
                CoupelBox.Enabled = true;
            }
        }


        private void Adder_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox adderCheck = (CheckBox)sender;
            this.hasAdder = adderCheck.Checked;
            adderBox.Enabled = hasAdder;
            adderColour.Enabled = hasAdder;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Are you sure to cancel your box?", "Cancel box", MessageBoxButtons.YesNo);
            if (delete == DialogResult.Yes)
            {
                //Delete the cart in program
                CabinetMenu nextForm = new CabinetMenu();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
            else if (delete == DialogResult.No)
            {
            }
        }

        private void CoupelBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cupBox = (CheckBox)sender;
            this.hasCoupel = cupBox.Checked;
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            //create the box
            Cabinet currentCab = Session.GetCabinet();
            Box newBox = new Box(float.Parse(selectedHeight), currentCab.GetWidth(), currentCab.GetDepth(), selectedColour, hasAdder);
            if(hasAdder == true)
            {
                newBox.SetAdder(selectedAdder, selectedAdderColour);
            }

            if(Session.GetCabinet().AddBox(newBox) == 1)
            {
                MessageBox.Show("Sorry you have exceeded the maximum height allowed");
                NewBox nextform = new NewBox();
                this.Hide();
                nextform.ShowDialog();
                this.Close();
            }

            //load the CabinetMenu
            CabinetMenu nextForm = new CabinetMenu();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
