namespace HotelManagement
{
    partial class RentManagement
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
            this.backpanelleft = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.linepanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.leftpanel = new System.Windows.Forms.Panel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label41 = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.backpanelleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.leftpanel.SuspendLayout();
            this.mainpanel.SuspendLayout();
            this.viewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backpanelleft
            // 
            this.backpanelleft.BackColor = System.Drawing.Color.Goldenrod;
            this.backpanelleft.Controls.Add(this.pictureBox6);
            this.backpanelleft.Controls.Add(this.label7);
            this.backpanelleft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backpanelleft.Location = new System.Drawing.Point(6, 595);
            this.backpanelleft.Name = "backpanelleft";
            this.backpanelleft.Size = new System.Drawing.Size(269, 83);
            this.backpanelleft.TabIndex = 5;
            this.backpanelleft.Click += new System.EventHandler(this.backpanelleft_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::HotelManagement.Properties.Resources.Undo_40px;
            this.pictureBox6.Location = new System.Drawing.Point(100, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(47, 41);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 15;
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
            this.label7.Location = new System.Drawing.Point(85, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "BACK";
            this.label7.Click += new System.EventHandler(this.backpanelleft_Click);
            // 
            // linepanel
            // 
            this.linepanel.BackColor = System.Drawing.Color.White;
            this.linepanel.Location = new System.Drawing.Point(0, 131);
            this.linepanel.Name = "linepanel";
            this.linepanel.Size = new System.Drawing.Size(268, 10);
            this.linepanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORT";
            // 
            // leftpanel
            // 
            this.leftpanel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.leftpanel.Controls.Add(this.backpanelleft);
            this.leftpanel.Controls.Add(this.linepanel);
            this.leftpanel.Controls.Add(this.label1);
            this.leftpanel.Location = new System.Drawing.Point(-6, 0);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(275, 767);
            this.leftpanel.TabIndex = 1;
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.Cornsilk;
            this.mainpanel.Controls.Add(this.DataGridView);
            this.mainpanel.Controls.Add(this.viewPanel);
            this.mainpanel.Location = new System.Drawing.Point(268, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1103, 767);
            this.mainpanel.TabIndex = 2;
            // 
            // viewPanel
            // 
            this.viewPanel.BackColor = System.Drawing.Color.Ivory;
            this.viewPanel.Controls.Add(this.dataGridView1);
            this.viewPanel.Controls.Add(this.label41);
            this.viewPanel.Location = new System.Drawing.Point(1, 1);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(1102, 766);
            this.viewPanel.TabIndex = 35;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1078, 618);
            this.dataGridView1.TabIndex = 34;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label41.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.Black;
            this.label41.Location = new System.Drawing.Point(400, 39);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(288, 52);
            this.label41.TabIndex = 31;
            this.label41.Text = "RENT TABLE";
            // 
            // DataGridView
            // 
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(7, 25);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(1079, 731);
            this.DataGridView.TabIndex = 36;
            // 
            // RentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.leftpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RentManagement_Load);
            this.backpanelleft.ResumeLayout(false);
            this.backpanelleft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.mainpanel.ResumeLayout(false);
            this.viewPanel.ResumeLayout(false);
            this.viewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel backpanelleft;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel linepanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel leftpanel;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.DataGridView DataGridView;
    }
}