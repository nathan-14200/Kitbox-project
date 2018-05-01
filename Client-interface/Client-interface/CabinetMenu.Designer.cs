namespace Client_interface
{
    partial class CabinetMenu
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
            this.Cancel = new System.Windows.Forms.Button();
            this.NewBox = new System.Windows.Forms.Button();
            this.Validate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.AutoSize = true;
            this.Cancel.Location = new System.Drawing.Point(45, 395);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(94, 35);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // NewBox
            // 
            this.NewBox.AutoSize = true;
            this.NewBox.Location = new System.Drawing.Point(145, 395);
            this.NewBox.Name = "NewBox";
            this.NewBox.Size = new System.Drawing.Size(101, 35);
            this.NewBox.TabIndex = 1;
            this.NewBox.Text = "NewBox";
            this.NewBox.UseVisualStyleBackColor = true;
            this.NewBox.Click += new System.EventHandler(this.NewBox_Click);
            // 
            // Validate
            // 
            this.Validate.AutoSize = true;
            this.Validate.Location = new System.Drawing.Point(252, 395);
            this.Validate.Name = "Validate";
            this.Validate.Size = new System.Drawing.Size(100, 35);
            this.Validate.TabIndex = 2;
            this.Validate.Text = "Validate";
            this.Validate.UseVisualStyleBackColor = true;
            // 
            // CabinetMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Validate);
            this.Controls.Add(this.NewBox);
            this.Controls.Add(this.Cancel);
            this.Name = "CabinetMenu";
            this.Text = "CabinetMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button NewBox;
        private System.Windows.Forms.Button Validate;
    }
}