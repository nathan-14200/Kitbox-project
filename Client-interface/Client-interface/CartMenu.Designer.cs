namespace Client_interface
{
    partial class CartMenu
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
            this.newCabinet = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.validate = new System.Windows.Forms.Button();
            this.modify = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newCabinet
            // 
            this.newCabinet.Location = new System.Drawing.Point(17, 31);
            this.newCabinet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newCabinet.Name = "newCabinet";
            this.newCabinet.Size = new System.Drawing.Size(193, 39);
            this.newCabinet.TabIndex = 0;
            this.newCabinet.Text = "new cabinet";
            this.newCabinet.UseVisualStyleBackColor = true;
            this.newCabinet.Click += new System.EventHandler(this.newCabinet_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(17, 96);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(708, 363);
            this.textBox1.TabIndex = 1;
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(625, 506);
            this.validate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(132, 45);
            this.validate.TabIndex = 2;
            this.validate.Text = "validate";
            this.validate.UseVisualStyleBackColor = true;
            // 
            // modify
            // 
            this.modify.Location = new System.Drawing.Point(485, 506);
            this.modify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(132, 45);
            this.modify.TabIndex = 3;
            this.modify.Text = "modify";
            this.modify.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(347, 506);
            this.cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(131, 45);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // CartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 566);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.newCabinet);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CartMenu";
            this.Text = "CartMenu";
            this.Load += new System.EventHandler(this.CartMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newCabinet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Button cancel;
    }
}