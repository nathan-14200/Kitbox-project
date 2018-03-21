namespace Client_interface
{
    partial class NewCabinet
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
            this.WidthValidate = new System.Windows.Forms.Button();
            this.DepthValidate = new System.Windows.Forms.Button();
            this.Order = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.ComboBox();
            this.depthBox = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.newBox = new System.Windows.Forms.Button();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WidthValidate
            // 
            this.WidthValidate.AutoSize = true;
            this.WidthValidate.Location = new System.Drawing.Point(375, 200);
            this.WidthValidate.Name = "WidthValidate";
            this.WidthValidate.Size = new System.Drawing.Size(100, 35);
            this.WidthValidate.TabIndex = 0;
            this.WidthValidate.Text = "Validate";
            this.WidthValidate.UseVisualStyleBackColor = true;
            this.WidthValidate.Click += new System.EventHandler(this.WidthValidate_Click);
            // 
            // DepthValidate
            // 
            this.DepthValidate.AutoSize = true;
            this.DepthValidate.Location = new System.Drawing.Point(375, 275);
            this.DepthValidate.Name = "DepthValidate";
            this.DepthValidate.Size = new System.Drawing.Size(100, 35);
            this.DepthValidate.TabIndex = 1;
            this.DepthValidate.Text = "Validate";
            this.DepthValidate.UseVisualStyleBackColor = true;
            this.DepthValidate.Click += new System.EventHandler(this.DepthValidate_Click);
            // 
            // Order
            // 
            this.Order.AutoSize = true;
            this.Order.Location = new System.Drawing.Point(57, 86);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(489, 25);
            this.Order.TabIndex = 2;
            this.Order.Text = "Please choose the characteristics of your cabinet:";
            // 
            // widthBox
            // 
            this.widthBox.FormattingEnabled = true;
            this.widthBox.Location = new System.Drawing.Point(93, 200);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(276, 33);
            this.widthBox.TabIndex = 5;
            // 
            // depthBox
            // 
            this.depthBox.FormattingEnabled = true;
            this.depthBox.Location = new System.Drawing.Point(93, 275);
            this.depthBox.Name = "depthBox";
            this.depthBox.Size = new System.Drawing.Size(276, 33);
            this.depthBox.TabIndex = 6;
            // 
            // cancel
            // 
            this.cancel.AutoSize = true;
            this.cancel.Location = new System.Drawing.Point(35, 549);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(94, 35);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // newBox
            // 
            this.newBox.AutoSize = true;
            this.newBox.Location = new System.Drawing.Point(152, 550);
            this.newBox.Name = "newBox";
            this.newBox.Size = new System.Drawing.Size(108, 35);
            this.newBox.TabIndex = 10;
            this.newBox.Text = "Continue";
            this.newBox.UseVisualStyleBackColor = true;
            this.newBox.Click += new System.EventHandler(this.newBox_Click);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(12, 203);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(67, 25);
            this.widthLabel.TabIndex = 11;
            this.widthLabel.Text = "Width";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(12, 280);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(69, 25);
            this.depthLabel.TabIndex = 12;
            this.depthLabel.Text = "Depth";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 348);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(703, 152);
            this.textBox1.TabIndex = 13;
            // 
            // NewCabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 625);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.newBox);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.depthBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.DepthValidate);
            this.Controls.Add(this.WidthValidate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewCabinet";
            this.Text = "New Cabinet";
            this.Load += new System.EventHandler(this.NewCabinet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WidthValidate;
        private System.Windows.Forms.Button DepthValidate;
        private System.Windows.Forms.Label Order;
        private System.Windows.Forms.ComboBox widthBox;
        private System.Windows.Forms.ComboBox depthBox;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button newBox;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}