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
            this.adderColour = new System.Windows.Forms.ComboBox();
            this.adderColourlabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.validateButton = new System.Windows.Forms.Button();
            this.CoupelBox = new System.Windows.Forms.CheckBox();
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
            // adderColour
            // 
            this.adderColour.Enabled = false;
            this.adderColour.FormattingEnabled = true;
            this.adderColour.Location = new System.Drawing.Point(38, 268);
            this.adderColour.Name = "adderColour";
            this.adderColour.Size = new System.Drawing.Size(121, 33);
            this.adderColour.TabIndex = 8;
            this.adderColour.SelectedIndexChanged += new System.EventHandler(this.adderColour_SelectedIndexChanged);
            // 
            // adderColourlabel
            // 
            this.adderColourlabel.AutoSize = true;
            this.adderColourlabel.Location = new System.Drawing.Point(171, 268);
            this.adderColourlabel.Name = "adderColourlabel";
            this.adderColourlabel.Size = new System.Drawing.Size(134, 25);
            this.adderColourlabel.TabIndex = 9;
            this.adderColourlabel.Text = "Adder colour";
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.Location = new System.Drawing.Point(38, 395);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 35);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // validateButton
            // 
            this.validateButton.AutoSize = true;
            this.validateButton.Location = new System.Drawing.Point(140, 395);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(100, 35);
            this.validateButton.TabIndex = 11;
            this.validateButton.Text = "Validate";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // CoupelBox
            // 
            this.CoupelBox.AutoSize = true;
            this.CoupelBox.Enabled = false;
            this.CoupelBox.Location = new System.Drawing.Point(38, 320);
            this.CoupelBox.Name = "CoupelBox";
            this.CoupelBox.Size = new System.Drawing.Size(134, 29);
            this.CoupelBox.TabIndex = 12;
            this.CoupelBox.Text = "Cup pulls";
            this.CoupelBox.UseVisualStyleBackColor = true;
            this.CoupelBox.CheckedChanged += new System.EventHandler(this.CoupelBox_CheckedChanged);
            // 
            // NewBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CoupelBox);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.adderColourlabel);
            this.Controls.Add(this.adderColour);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox adderColour;
        private System.Windows.Forms.Label adderColourlabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.CheckBox CoupelBox;
    }
}