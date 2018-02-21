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
            this.validate = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.newCabinet = new System.Windows.Forms.Button();
            this.cabinetList = new System.Windows.Forms.TextBox();
            this.modify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(515, 389);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(113, 36);
            this.validate.TabIndex = 0;
            this.validate.Text = "validate";
            this.validate.UseVisualStyleBackColor = true;
            this.validate.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(277, 389);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(113, 36);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // newCabinet
            // 
            this.newCabinet.Location = new System.Drawing.Point(26, 39);
            this.newCabinet.Name = "newCabinet";
            this.newCabinet.Size = new System.Drawing.Size(113, 34);
            this.newCabinet.TabIndex = 2;
            this.newCabinet.Text = "new cabinet";
            this.newCabinet.UseVisualStyleBackColor = true;
            // 
            // cabinetList
            // 
            this.cabinetList.Location = new System.Drawing.Point(26, 79);
            this.cabinetList.Multiline = true;
            this.cabinetList.Name = "cabinetList";
            this.cabinetList.ReadOnly = true;
            this.cabinetList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cabinetList.Size = new System.Drawing.Size(602, 290);
            this.cabinetList.TabIndex = 3;
            // 
            // modify
            // 
            this.modify.Location = new System.Drawing.Point(396, 389);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(113, 36);
            this.modify.TabIndex = 4;
            this.modify.Text = "modify";
            this.modify.UseVisualStyleBackColor = true;
            // 
            // CartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 437);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.cabinetList);
            this.Controls.Add(this.newCabinet);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.validate);
            this.Name = "CartMenu";
            this.Text = "CartMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button newCabinet;
        private System.Windows.Forms.TextBox cabinetList;
        private System.Windows.Forms.Button modify;
    }
}