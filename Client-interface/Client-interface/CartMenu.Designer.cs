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
            this.validate = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.dataGridCart = new System.Windows.Forms.DataGridView();
            this.Cabinet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CabinetBox = new System.Windows.Forms.ComboBox();
            this.CabinetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCart)).BeginInit();
            this.SuspendLayout();
            // 
            // newCabinet
            // 
            this.newCabinet.Location = new System.Drawing.Point(17, 31);
            this.newCabinet.Margin = new System.Windows.Forms.Padding(4);
            this.newCabinet.Name = "newCabinet";
            this.newCabinet.Size = new System.Drawing.Size(193, 39);
            this.newCabinet.TabIndex = 0;
            this.newCabinet.Text = "new cabinet";
            this.newCabinet.UseVisualStyleBackColor = true;
            this.newCabinet.Click += new System.EventHandler(this.newCabinet_Click);
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(625, 506);
            this.validate.Margin = new System.Windows.Forms.Padding(4);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(132, 45);
            this.validate.TabIndex = 2;
            this.validate.Text = "validate";
            this.validate.UseVisualStyleBackColor = true;
            this.validate.Click += new System.EventHandler(this.validate_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(485, 506);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(132, 45);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(347, 506);
            this.cancel.Margin = new System.Windows.Forms.Padding(4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(131, 45);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // dataGridCart
            // 
            this.dataGridCart.AllowUserToAddRows = false;
            this.dataGridCart.AllowUserToDeleteRows = false;
            this.dataGridCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridCart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cabinet,
            this.Height,
            this.BoxNum,
            this.Price});
            this.dataGridCart.Location = new System.Drawing.Point(17, 100);
            this.dataGridCart.Name = "dataGridCart";
            this.dataGridCart.ReadOnly = true;
            this.dataGridCart.RowTemplate.Height = 33;
            this.dataGridCart.Size = new System.Drawing.Size(740, 327);
            this.dataGridCart.TabIndex = 5;
            // 
            // Cabinet
            // 
            this.Cabinet.HeaderText = "Cabinet";
            this.Cabinet.Name = "Cabinet";
            this.Cabinet.ReadOnly = true;
            this.Cabinet.Width = 131;
            // 
            // Height
            // 
            this.Height.HeaderText = "Height";
            this.Height.Name = "Height";
            this.Height.ReadOnly = true;
            this.Height.Width = 119;
            // 
            // BoxNum
            // 
            this.BoxNum.HeaderText = "Box number";
            this.BoxNum.Name = "BoxNum";
            this.BoxNum.ReadOnly = true;
            this.BoxNum.Width = 172;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 106;
            // 
            // CabinetBox
            // 
            this.CabinetBox.FormattingEnabled = true;
            this.CabinetBox.Location = new System.Drawing.Point(17, 506);
            this.CabinetBox.Name = "CabinetBox";
            this.CabinetBox.Size = new System.Drawing.Size(121, 33);
            this.CabinetBox.TabIndex = 6;
            this.CabinetBox.SelectedIndexChanged += new System.EventHandler(this.CabinetBox_SelectedIndexChanged);
            // 
            // CabinetLabel
            // 
            this.CabinetLabel.AutoSize = true;
            this.CabinetLabel.Location = new System.Drawing.Point(12, 461);
            this.CabinetLabel.Name = "CabinetLabel";
            this.CabinetLabel.Size = new System.Drawing.Size(179, 25);
            this.CabinetLabel.TabIndex = 7;
            this.CabinetLabel.Text = "Cabinet selected:";
            // 
            // CartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 566);
            this.Controls.Add(this.CabinetLabel);
            this.Controls.Add(this.CabinetBox);
            this.Controls.Add(this.dataGridCart);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.newCabinet);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CartMenu";
            this.Text = "Cart Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newCabinet;
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DataGridView dataGridCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cabinet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoxNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.ComboBox CabinetBox;
        private System.Windows.Forms.Label CabinetLabel;
    }
}