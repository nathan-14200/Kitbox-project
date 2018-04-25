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
        public NewCabinet()
        {
            InitializeComponent();
        }

        private void NewCabinet_Load(object sender, EventArgs e)
        {
            /*
            Graphics dc = this.CreateGraphics();
            this.Show();
            Pen BluePen = new Pen(Color.Blue, 3);
            dc.DrawRectangle(BluePen, 0, 0, 50, 50);
            Pen RedPen = new Pen(Color.Red, 2);
            dc.DrawEllipse(RedPen, 0, 50, 80, 60);
            */

            //Have to us dic even though it is twice the same value because ComboBox needs a dictionary
            widthBox.DataSource = new BindingSource(SetComboBoxValues("width"), null);
            widthBox.DisplayMember = "Value";
            widthBox.ValueMember = "Key";
            depthBox.DataSource = new BindingSource(SetComboBoxValues("depth"), null);
            depthBox.DisplayMember = "Value";
            depthBox.ValueMember = "Key";

        }

        //car could be width or depth
        private Dictionary<float, float> SetComboBoxValues(string car, float width = 0, float depth = 0)
        {
            Dictionary<float, float> values = new Dictionary<float, float>();

            //No restriction and we load all possible car
            if(width == 0 && depth == 0)
            {
                List<Piece> pieces = InitComp.GetAllPieces();

                foreach(Piece p in pieces)
                {
                    float t = p.GetAttribute<float>(car) ;
                    if (!values.ContainsKey(t) && t != 0)
                    {
                        values[t] = t;
                    }
                }
            }

            return values;
        }


        private void WidthValidate_Click(object sender, EventArgs e)
        {

        }


        private void DepthValidate_Click(object sender, EventArgs e)
        {

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

        private void widthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            selectedWidth = (string)comboBox.SelectedText;
        }
    }
}
