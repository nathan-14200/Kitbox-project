namespace Client_interface
{
    partial class CabinetValidate
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
            this.CorniereBox = new System.Windows.Forms.ComboBox();
            this.CorniereLabel = new System.Windows.Forms.Label();
            this.SummarizeLabel = new System.Windows.Forms.Label();
            this.heightTag = new System.Windows.Forms.Label();
            this.boxTag = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.boxLabel = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Finalise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CorniereBox
            // 
            this.CorniereBox.FormattingEnabled = true;
            this.CorniereBox.Location = new System.Drawing.Point(46, 106);
            this.CorniereBox.Name = "CorniereBox";
            this.CorniereBox.Size = new System.Drawing.Size(176, 33);
            this.CorniereBox.TabIndex = 0;
            // 
            // CorniereLabel
            // 
            this.CorniereLabel.AutoSize = true;
            this.CorniereLabel.Location = new System.Drawing.Point(41, 61);
            this.CorniereLabel.Name = "CorniereLabel";
            this.CorniereLabel.Size = new System.Drawing.Size(395, 25);
            this.CorniereLabel.TabIndex = 1;
            this.CorniereLabel.Text = "Choose the colour of your metal corners";
            // 
            // SummarizeLabel
            // 
            this.SummarizeLabel.AutoSize = true;
            this.SummarizeLabel.Location = new System.Drawing.Point(41, 186);
            this.SummarizeLabel.Name = "SummarizeLabel";
            this.SummarizeLabel.Size = new System.Drawing.Size(205, 25);
            this.SummarizeLabel.TabIndex = 2;
            this.SummarizeLabel.Text = "Summarize Cabinet:";
            // 
            // heightTag
            // 
            this.heightTag.AutoSize = true;
            this.heightTag.Location = new System.Drawing.Point(41, 238);
            this.heightTag.Name = "heightTag";
            this.heightTag.Size = new System.Drawing.Size(131, 25);
            this.heightTag.TabIndex = 4;
            this.heightTag.Text = "Total height:";
            // 
            // boxTag
            // 
            this.boxTag.AutoSize = true;
            this.boxTag.Location = new System.Drawing.Point(41, 278);
            this.boxTag.Name = "boxTag";
            this.boxTag.Size = new System.Drawing.Size(181, 25);
            this.boxTag.TabIndex = 5;
            this.boxTag.Text = "Number of boxes:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(233, 238);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(24, 25);
            this.heightLabel.TabIndex = 6;
            this.heightLabel.Text = "0";
            // 
            // boxLabel
            // 
            this.boxLabel.AutoSize = true;
            this.boxLabel.Location = new System.Drawing.Point(233, 278);
            this.boxLabel.Name = "boxLabel";
            this.boxLabel.Size = new System.Drawing.Size(24, 25);
            this.boxLabel.TabIndex = 7;
            this.boxLabel.Text = "0";
            // 
            // Cancel
            // 
            this.Cancel.AutoSize = true;
            this.Cancel.Location = new System.Drawing.Point(46, 395);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(89, 35);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Finalise
            // 
            this.Finalise.AutoSize = true;
            this.Finalise.Location = new System.Drawing.Point(142, 395);
            this.Finalise.Name = "Finalise";
            this.Finalise.Size = new System.Drawing.Size(97, 35);
            this.Finalise.TabIndex = 10;
            this.Finalise.Text = "Finalise";
            this.Finalise.UseVisualStyleBackColor = true;
            this.Finalise.Click += new System.EventHandler(this.Finalise_Click);
            // 
            // CabinetValidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Finalise);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.boxLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.boxTag);
            this.Controls.Add(this.heightTag);
            this.Controls.Add(this.SummarizeLabel);
            this.Controls.Add(this.CorniereLabel);
            this.Controls.Add(this.CorniereBox);
            this.Name = "CabinetValidate";
            this.Text = "CabinetValidate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CorniereBox;
        private System.Windows.Forms.Label CorniereLabel;
        private System.Windows.Forms.Label SummarizeLabel;
        private System.Windows.Forms.Label heightTag;
        private System.Windows.Forms.Label boxTag;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label boxLabel;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Finalise;
    }
}