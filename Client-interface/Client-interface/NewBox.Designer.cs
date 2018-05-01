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
            this.AdderCheckBox = new System.Windows.Forms.CheckBox();
            this.heightBox = new System.Windows.Forms.ComboBox();
            this.height = new System.Windows.Forms.Label();
            this.colourBox = new System.Windows.Forms.ComboBox();
            this.colour = new System.Windows.Forms.Label();
            this.adderBox = new System.Windows.Forms.ComboBox();
            this.adderLabel = new System.Windows.Forms.Label();
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
            // NewBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adderLabel);
            this.Controls.Add(this.adderBox);
            this.Controls.Add(this.colour);
            this.Controls.Add(this.colourBox);
            this.Controls.Add(this.height);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.AdderCheckBox);
            this.Name = "NewBox";
            this.Text = "NewBox";
            this.Load += new System.EventHandler(this.NewBox_Load);
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
    }
}