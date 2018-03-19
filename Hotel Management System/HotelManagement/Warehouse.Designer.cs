namespace HotelManagement
{
    partial class Warehouse
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
            this.leftpanel = new System.Windows.Forms.Panel();
            this.backpanelleft = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.linepanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.typePanel = new System.Windows.Forms.Panel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.warehouseDataGridView = new System.Windows.Forms.DataGridView();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.backpanelleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.typePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.BackColor = System.Drawing.Color.DimGray;
            this.leftpanel.Controls.Add(this.backpanelleft);
            this.leftpanel.Controls.Add(this.linepanel);
            this.leftpanel.Controls.Add(this.label1);
            this.leftpanel.Location = new System.Drawing.Point(0, 0);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(275, 771);
            this.leftpanel.TabIndex = 1;
            // 
            // backpanelleft
            // 
            this.backpanelleft.BackColor = System.Drawing.Color.DarkGray;
            this.backpanelleft.Controls.Add(this.pictureBox6);
            this.backpanelleft.Controls.Add(this.label7);
            this.backpanelleft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backpanelleft.Location = new System.Drawing.Point(1, 662);
            this.backpanelleft.Name = "backpanelleft";
            this.backpanelleft.Size = new System.Drawing.Size(274, 83);
            this.backpanelleft.TabIndex = 5;
            this.backpanelleft.Click += new System.EventHandler(this.backpanelleft_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::HotelManagement.Properties.Resources.Undo_40px;
            this.pictureBox6.Location = new System.Drawing.Point(115, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.backpanelleft_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(92, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "BACK";
            this.label7.Click += new System.EventHandler(this.backpanelleft_Click);
            // 
            // linepanel
            // 
            this.linepanel.BackColor = System.Drawing.Color.White;
            this.linepanel.Location = new System.Drawing.Point(-2, 160);
            this.linepanel.Name = "linepanel";
            this.linepanel.Size = new System.Drawing.Size(277, 12);
            this.linepanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "WAREHOUSE";
            // 
            // typePanel
            // 
            this.typePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.typePanel.Controls.Add(this.nameTextBox);
            this.typePanel.Controls.Add(this.label2);
            this.typePanel.Controls.Add(this.quantityTextBox);
            this.typePanel.Controls.Add(this.label52);
            this.typePanel.Controls.Add(this.panel3);
            this.typePanel.Controls.Add(this.deleteButton);
            this.typePanel.Controls.Add(this.addButton);
            this.typePanel.Controls.Add(this.updateButton);
            this.typePanel.Controls.Add(this.label20);
            this.typePanel.Controls.Add(this.warehouseDataGridView);
            this.typePanel.Controls.Add(this.label21);
            this.typePanel.Controls.Add(this.pictureBox10);
            this.typePanel.Controls.Add(this.ClearButton);
            this.typePanel.Controls.Add(this.priceTextBox);
            this.typePanel.Controls.Add(this.label25);
            this.typePanel.Controls.Add(this.IDTextBox);
            this.typePanel.Controls.Add(this.label29);
            this.typePanel.Location = new System.Drawing.Point(273, 0);
            this.typePanel.Name = "typePanel";
            this.typePanel.Size = new System.Drawing.Size(1096, 771);
            this.typePanel.TabIndex = 36;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.nameTextBox.Location = new System.Drawing.Point(160, 314);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(277, 30);
            this.nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 93;
            this.label2.Text = "Name";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.quantityTextBox.Location = new System.Drawing.Point(159, 407);
            this.quantityTextBox.Multiline = true;
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(277, 30);
            this.quantityTextBox.TabIndex = 3;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.Transparent;
            this.label52.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label52.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.Black;
            this.label52.Location = new System.Drawing.Point(23, 407);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(104, 26);
            this.label52.TabIndex = 91;
            this.label52.Text = "Quantity";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(456, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 679);
            this.panel3.TabIndex = 90;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(233, 546);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(151, 45);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.White;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(62, 483);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(151, 45);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.White;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.updateButton.ForeColor = System.Drawing.Color.Black;
            this.updateButton.Location = new System.Drawing.Point(61, 542);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(151, 45);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label20.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(630, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(247, 40);
            this.label20.TabIndex = 83;
            this.label20.Text = "Product Table";
            // 
            // warehouseDataGridView
            // 
            this.warehouseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.warehouseDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.warehouseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.warehouseDataGridView.Location = new System.Drawing.Point(484, 87);
            this.warehouseDataGridView.Name = "warehouseDataGridView";
            this.warehouseDataGridView.ReadOnly = true;
            this.warehouseDataGridView.RowTemplate.Height = 24;
            this.warehouseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.warehouseDataGridView.Size = new System.Drawing.Size(599, 669);
            this.warehouseDataGridView.TabIndex = 82;
            this.warehouseDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.warehouseDataGridView_CellDoubleClick);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label21.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(1158, 274);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(141, 40);
            this.label21.TabIndex = 81;
            this.label21.Text = "Facilities";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::HotelManagement.Properties.Resources.Product_104px1;
            this.pictureBox10.Location = new System.Drawing.Point(176, 100);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(92, 89);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 69;
            this.pictureBox10.TabStop = false;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.White;
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.ClearButton.ForeColor = System.Drawing.Color.Black;
            this.ClearButton.Location = new System.Drawing.Point(233, 483);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(151, 45);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.priceTextBox.Location = new System.Drawing.Point(160, 358);
            this.priceTextBox.Multiline = true;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(277, 30);
            this.priceTextBox.TabIndex = 2;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(23, 360);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(67, 26);
            this.label25.TabIndex = 62;
            this.label25.Text = "Price";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.IDTextBox.Location = new System.Drawing.Point(159, 270);
            this.IDTextBox.Multiline = true;
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(277, 30);
            this.IDTextBox.TabIndex = 61;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label29.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(21, 272);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(127, 26);
            this.label29.TabIndex = 60;
            this.label29.Text = "Product ID";
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.typePanel);
            this.Controls.Add(this.leftpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Warehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.backpanelleft.ResumeLayout(false);
            this.backpanelleft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.typePanel.ResumeLayout(false);
            this.typePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftpanel;
        private System.Windows.Forms.Panel backpanelleft;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel linepanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel typePanel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView warehouseDataGridView;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
    }
}