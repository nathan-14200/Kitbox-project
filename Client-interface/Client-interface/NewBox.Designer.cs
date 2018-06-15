using System;

namespace Client_interface
{
    partial class NewBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AdderCheckBox = new System.Windows.Forms.CheckBox();
            this.heightBox = new System.Windows.Forms.ComboBox();
            this.height = new System.Windows.Forms.Label();
            this.colourBox = new System.Windows.Forms.ComboBox();
            this.colour = new System.Windows.Forms.Label();
            this.adderBox = new System.Windows.Forms.ComboBox();
            this.adderLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdderCheckBox
            // 
            this.AdderCheckBox.AutoSize = true;
            this.AdderCheckBox.Location = new System.Drawing.Point(38, 51);
            this.AdderCheckBox.Name = "AdderCheckBox";
            this.AdderCheckBox.Size = new System.Drawing.Size(101, 29);
            this.AdderCheckBox.TabIndex = 0;
            this.AdderCheckBox.Text = "Adder";
            this.AdderCheckBox.UseVisualStyleBackColor = true;
            this.AdderCheckBox.CheckedChanged += new System.EventHandler(this.Adder_CheckedChanged);
            // 
            // heightBox
            // 
            this.heightBox.FormattingEnabled = true;
            this.heightBox.Location = new System.Drawing.Point(38, 113);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(121, 33);
            this.heightBox.Sorted = true;
            this.heightBox.TabIndex = 1;
            this.heightBox.SelectedIndexChanged += new System.EventHandler(this.heightBox_SelectedIndexChanged);
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(166, 113);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(71, 25);
            this.height.TabIndex = 2;
            this.height.Text = "height";
            // 
            // colourBox
            // 
            this.colourBox.FormattingEnabled = true;
            this.colourBox.Location = new System.Drawing.Point(38, 165);
            this.colourBox.Name = "colourBox";
            this.colourBox.Size = new System.Drawing.Size(121, 33);
            this.colourBox.Sorted = true;
            this.colourBox.TabIndex = 3;
            this.colourBox.SelectedIndexChanged += new System.EventHandler(this.colourBox_SelectedIndexChanged);
            // 
            // colour
            // 
            this.colour.AutoSize = true;
            this.colour.Location = new System.Drawing.Point(166, 165);
            this.colour.Name = "colour";
            this.colour.Size = new System.Drawing.Size(71, 25);
            this.colour.TabIndex = 5;
            this.colour.Text = "colour";
            // 
            // adderBox
            // 
            this.adderBox.Enabled = false;
            this.adderBox.FormattingEnabled = true;
            this.adderBox.Location = new System.Drawing.Point(38, 216);
            this.adderBox.Name = "adderBox";
            this.adderBox.Size = new System.Drawing.Size(121, 33);
            this.adderBox.Sorted = true;
            this.adderBox.TabIndex = 6;
            this.adderBox.SelectedIndexChanged += new System.EventHandler(this.adderBox_SelectedIndexChanged);
            // 
            // adderLabel
            // 
            this.adderLabel.AutoSize = true;
            this.adderLabel.Location = new System.Drawing.Point(171, 216);
            this.adderLabel.Name = "adderLabel";
            this.adderLabel.Size = new System.Drawing.Size(69, 25);
            this.adderLabel.TabIndex = 7;
            this.adderLabel.Text = "Adder";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(360, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(345, 274);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(329, 227);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(184, 53);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // NewBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.adderLabel);
            this.Controls.Add(this.adderBox);
            this.Controls.Add(this.colour);
            this.Controls.Add(this.colourBox);
            this.Controls.Add(this.height);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.AdderCheckBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NewBox";
            this.Text = "NewBox";
            this.Load += new System.EventHandler(this.NewBox_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.CheckBox AdderCheckBox;
        private System.Windows.Forms.ComboBox heightBox;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.ComboBox colourBox;
        private System.Windows.Forms.Label colour;
        private System.Windows.Forms.ComboBox adderBox;
        private System.Windows.Forms.Label adderLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}