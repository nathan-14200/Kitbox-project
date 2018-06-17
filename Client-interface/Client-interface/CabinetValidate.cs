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
                //Add les bonnes cornieres
                CabinetMenu nextForm = new CabinetMenu();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }


        }
    }
}
