﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_interface
{
    public partial class NewCabinet : Form
    {
        public NewCabinet()
        {
            InitializeComponent();

            Graphics dc = this.CreateGraphics();
            this.Show();
            Pen BluePen = new Pen(Color.Blue, 3);
            dc.DrawRectangle(BluePen, 0, 0, 50, 50);
            Pen RedPen = new Pen(Color.Red, 2);
            dc.DrawEllipse(RedPen, 0, 50, 80, 60);
        }

        private void NewCabinet_Load(object sender, EventArgs e)
        {
            
        }
    }
}
