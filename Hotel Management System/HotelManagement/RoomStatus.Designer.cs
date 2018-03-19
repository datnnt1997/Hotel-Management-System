namespace HotelManagement
{
    partial class RoomStatus
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nameForm = new System.Windows.Forms.Label();
            this.roomFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.topPanel.BackColor = System.Drawing.Color.Goldenrod;
            this.topPanel.Controls.Add(this.pictureBox2);
            this.topPanel.Controls.Add(this.nameForm);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1370, 64);
            this.topPanel.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::HotelManagement.Properties.Resources.Close_Window_40px;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1307, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 45);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // nameForm
            // 
            this.nameForm.AutoSize = true;
            this.nameForm.BackColor = System.Drawing.Color.Transparent;
            this.nameForm.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameForm.ForeColor = System.Drawing.Color.White;
            this.nameForm.Location = new System.Drawing.Point(527, 9);
            this.nameForm.Name = "nameForm";
            this.nameForm.Size = new System.Drawing.Size(316, 44);
            this.nameForm.TabIndex = 0;
            this.nameForm.Text = "HOTEL ROOMS";
            // 
            // roomFlowLayoutPanel
            // 
            this.roomFlowLayoutPanel.AutoScroll = true;
            this.roomFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.roomFlowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.roomFlowLayoutPanel.Location = new System.Drawing.Point(12, 70);
            this.roomFlowLayoutPanel.Name = "roomFlowLayoutPanel";
            this.roomFlowLayoutPanel.Size = new System.Drawing.Size(1342, 699);
            this.roomFlowLayoutPanel.TabIndex = 3;
            // 
            // RoomStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.roomFlowLayoutPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RoomStatus_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label nameForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel roomFlowLayoutPanel;
    }
}