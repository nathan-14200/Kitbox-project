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
    public partial class CabinetValidate : Form
    {
        private string selectedColour = "";

        public CabinetValidate()
        {
            InitializeComponent();
            SetComboBox(CorniereBox);
            SetText(heightLabel, "height");
            SetText(boxLabel, "box");
        }


        private void SetText(Label label, string str)
        {
            if(str == "height")
            {
                float h = Session.GetCabinet().GetHeight();
                label.Text = h.ToString();
            }
            else if(str == "box")
            {
                int num = Session.GetCabinet().GetBoxComposition().Count();
                label.Text = num.ToString();
            }
        }


        private void SetComboBox(ComboBox myComboBox)
        {
            List<Piece> allPieces = InitComp.GetAllPieces();
            List<string> colours = new List<string>();

            //Retrieve possible colours
            foreach(Piece piece in allPieces)
            {
                string pieceColour = piece.GetColour();
                if(piece.GetName() == "Cornières" && !colours.Contains(pieceColour))
                {
                    colours.Add(pieceColour);
                }
            }
            //Update ComboBox
            foreach (string str in colours)
            {
                myComboBox.Items.Add(str);
            }
        }


        private Piece GetCorniere(string colour, float height)
        {
            List<Piece> allPieces = InitComp.GetAllPieces();
            List<Piece> allCorniere = new List<Piece>();
            Piece myCorniere = new Piece("0000", "0", 0, 0, 0, 0, "0", false);

            //Retrieve all Corniere
            foreach (Piece p in allPieces)
            {
                if(p.GetName() == "Cornières")
                {
                    allCorniere.Add(p);
                }
            }


            //Check if standard size
            foreach(Piece c in allCorniere)
            {
                if(c.GetHeight() == height && c.GetColour() == colour)
                {
                    myCorniere = c;
                }
            }

            //Otherwise take the biggest cutted corniere
            if(myCorniere.GetID() == "0000")
            {
                while(height%25 != 0)
                {
                    height += 1;
                }

                foreach(Piece c in allCorniere)
                {
                    if(c.GetHeight() == height && c.GetColour() == colour)
                    {
                        myCorniere = c;
                    }
                }
            }
            return myCorniere;
        }


        private void Cancel_Click(object sender, EventArgs e)
        {            
           //Delete the cart in program
           CabinetMenu nextForm = new CabinetMenu();
           this.Hide();
           nextForm.ShowDialog();
           this.Close();
         }


        private void Finalise_Click(object sender, EventArgs e)
        {
            if(selectedColour != "")
            {
                Session.GetCabinet().SetCorniere(GetCorniere(selectedColour, Session.GetCabinet().GetHeight()));
                CartMenu nextForm = new CartMenu();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("You must select a colour before you can continue");
            }
        }

        private void CorniereBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            selectedColour = (string)comboBox.Text;
        }
    }
}
