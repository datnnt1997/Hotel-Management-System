using Business_Logic_Layer;
using DataTranferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class RoomStatus : Form
    {
        public RoomStatus()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Hide();
            hp.Show();
        }
        private String roomName = "";
        private void RoomStatus_Load(object sender, EventArgs e)
        {
            List<RoomDTO> listroom = RoomBUS.Instance.display();
            foreach(RoomDTO room in listroom)
            {

               
                if (room.Status == "Available")
                {
                    Panel newPanel = new System.Windows.Forms.Panel();
                    Label newLabelID = new System.Windows.Forms.Label();
                    PictureBox newPicturBox = new System.Windows.Forms.PictureBox();
                    Label newLabelStatus = new System.Windows.Forms.Label();
                    newPanel.Cursor = System.Windows.Forms.Cursors.Hand;
                    newPanel.Name = room.RID1;
                    newPanel.Size = new System.Drawing.Size(146, 143);
                    newPanel.BackColor = System.Drawing.Color.Green;
                  

                    newLabelStatus.AutoSize = true;
                    newLabelStatus.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    newLabelStatus.ForeColor = System.Drawing.Color.White;
                    newLabelStatus.Location = new System.Drawing.Point(25, 77);
                    newLabelStatus.Size = new System.Drawing.Size(132, 20);
                    newLabelStatus.TabIndex = 3;
                    newLabelStatus.Text = "Available";

                    newLabelID.AutoSize = true;
                    newLabelID.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    newLabelID.ForeColor = System.Drawing.Color.White;
                    newLabelID.Location = new System.Drawing.Point(40, 110);
                    newLabelID.Size = new System.Drawing.Size(84, 33);
                    newLabelID.TabIndex = 2;
                    newLabelID.Text = room.RID1;

                    newPicturBox.BackColor = System.Drawing.Color.Transparent;
                    newPicturBox.BackgroundImage = global::HotelManagement.Properties.Resources.Single_Bed_70px;
                    newPicturBox.Location = new System.Drawing.Point(34, 4);
                    newPicturBox.Size = new System.Drawing.Size(70, 70);
                    newPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    newPicturBox.TabIndex = 0;
                    newPicturBox.TabStop = false;

                    newPanel.Controls.Add(newLabelID);
                    newPanel.Controls.Add(newLabelStatus);
                    newPanel.Controls.Add(newPicturBox);
                   
                    roomFlowLayoutPanel.Controls.Add(newPanel);
                    // contextMenuStrip1
                    // 
                    ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();
                    ToolStripMenuItem availableToolStripMenuItem = new ToolStripMenuItem();
                    ToolStripMenuItem unavailableToolStripMenuItem = new ToolStripMenuItem();
                    ToolStripMenuItem cleaningToolStripMenuItem = new ToolStripMenuItem();
                    ToolStripMenuItem prepairingToolStripMenuItem = new ToolStripMenuItem();
                    contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
                    contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                    availableToolStripMenuItem,
                    unavailableToolStripMenuItem,
                    cleaningToolStripMenuItem,
                    prepairingToolStripMenuItem});
                    contextMenuStrip1.Name = "contextMenuStrip1";
                    contextMenuStrip1.Size = new System.Drawing.Size(157, 100);
                    // 
                    // availableToolStripMenuItem
                    // 
                    availableToolStripMenuItem.Name = "availableToolStripMenuItem";
                    availableToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
                    availableToolStripMenuItem.Text = "Available";
                    // 
                    // unavailableToolStripMenuItem
                    // 
                   unavailableToolStripMenuItem.Name = "unavailableToolStripMenuItem";
                   unavailableToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
                    unavailableToolStripMenuItem.Text = "Unavailable";
                    // 
                    // cleaninToolStripMenuItem
                    // 
                    cleaningToolStripMenuItem.Name = "cleaningToolStripMenuItem";
                    cleaningToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
                    cleaningToolStripMenuItem.Text = "Cleaning";
                    // 
                    // cleaningToolStripMenuItem
                    // 
                    prepairingToolStripMenuItem.Name = "prepairingToolStripMenuItem";
                    prepairingToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
                    prepairingToolStripMenuItem.Text = "Prepairing";
                    newPanel.ContextMenuStrip = contextMenuStrip1;
                    availableToolStripMenuItem.Click += new System.EventHandler(this.AvailableToolStripMenuItem_Click);
                    unavailableToolStripMenuItem.Click += new System.EventHandler(this.UnavailableToolStripMenuItem_Click);
                    cleaningToolStripMenuItem.Click += new System.EventHandler(this.CleaningToolStripMenuItem_Click);
                    prepairingToolStripMenuItem.Click += new System.EventHandler(this.PrepairingToolStripMenuItem_Click);
                    newPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
                    newLabelStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
                }
                if (room.Status == "Unavailable")
                {
                    Panel newPanel = new System.Windows.Forms.Panel();
                    Label newLabelID = new System.Windows.Forms.Label();
                    PictureBox newPicturBox = new System.Windows.Forms.PictureBox();
                    Label newLabelStatus = new System.Windows.Forms.Label();
                    newPanel.Cursor = System.Windows.Forms.Cursors.Hand;
                    newPanel.Size = new System.Drawing.Size(146, 143);
                    newPanel.Name = room.RID1;
                    newPanel.BackColor = System.Drawing.Color.Red;
               

                    newLabelStatus.AutoSize = true;
                    newLabelStatus.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    newLabelStatus.ForeColor = System.Drawing.Color.White;
                    newLabelStatus.Location = new System.Drawing.Point(20, 77);
                    newLabelStatus.Size = new System.Drawing.Size(132, 20);
                    newLabelStatus.TabIndex = 3;
                    newLabelStatus.Text = "Unavailable";

                    newLabelID.AutoSize = true;
                    newLabelID.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    newLabelID.ForeColor = System.Drawing.Color.White;
                    newLabelID.Location = new System.Drawing.Point(40, 110);
                    newLabelID.Size = new System.Drawing.Size(84, 33);
                    newLabelID.TabIndex = 2;
                    newLabelID.Text = room.RID1;

                    newPicturBox.BackColor = System.Drawing.Color.Transparent;
                    newPicturBox.BackgroundImage = global::HotelManagement.Properties.Resources.Single_Bed_70px;
                    newPicturBox.Location = new System.Drawing.Point(34, 4);
                    newPicturBox.Size = new System.Drawing.Size(70, 70);
                    newPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    newPicturBox.TabIndex = 0;
                    newPicturBox.TabStop = false;

                    newPanel.Controls.Add(newLabelID);
                    newPanel.Controls.Add(newLabelStatus);
                    newPanel.Controls.Add(newPicturBox);
                   
                    roomFlowLayoutPanel.Controls.Add(newPanel);
                    

                    // contextMenuStrip1
                    // 
                    ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();
                    ToolStripMenuItem availableToolStripMenuItem = new ToolStripMenuItem();
                    ToolStripMenuItem unavailableToolStripMenuItem = new ToolStripMenuItem();
                    ToolStripMenuItem cleaningToolStripMenuItem = new ToolStripMenuItem();
                    ToolStripMenuItem prepairingToolStripMenuItem = new ToolStripMenuItem();
                    contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
                    contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                    availableToolStripMenuItem,
                    unavailableToolStripMenuItem,
                    cleaningToolStripMenuItem,
                    prepairingToolStripMenuItem});
                    contextMenuStrip1.Name = "contextMenuStrip1";
                    contextMenuStrip1.Size = new System.Drawing.Size(157, 100);
                    // 
                    // availableToolStripMenuItem
                    // 
                    availableToolStripMenuItem.Name = "availableToolStripMenuItem";
                    availableToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
                    availableToolStripMenuItem.Text = "Available";
                    // 
                    // unavailableToolStripMenuItem
                    // 
                    unavailableToolStripMenuItem.Name = "unavailableToolStripMenuItem";
                    unavailableToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
                    unavailableToolStripMenuItem.Text = "Unavailable";
                    // 
                    // cleaninToolStripMenuItem
                    // 
                    cleaningToolStripMenuItem.Name = "cleaningToolStripMenuItem";
                    cleaningToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
                    cleaningToolStripMenuItem.Text = "Cleaning";
                    // 
                    // cleaningToolStripMenuItem
                    // 
                    prepairingToolStripMenuItem.Name = "prepairingToolStripMenuItem";
                    prepairingToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
                    prepairingToolStripMenuItem.Text = "Prepairing";
                    newPanel.ContextMenuStrip = contextMenuStrip1;
                    availableToolStripMenuItem.Click += new System.EventHandler(this.AvailableToolStripMenuItem_Click);
                    unavailableToolStripMenuItem.Click += new System.EventHandler(this.UnavailableToolStripMenuItem_Click);
                    cleaningToolStripMenuItem.Click += new System.EventHandler(this.CleaningToolStripMenuItem_Click);
                    prepairingToolStripMenuItem.Click += new System.EventHandler(this.PrepairingToolStripMenuItem_Click);
                    newPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
                }
                if (room.Status == "Prepairing")
                {
                    Panel newPanel = new System.Windows.Forms.Panel();
                    Label newLabelID = new System.Windows.Forms.Label();
                    PictureBox newPicturBox = new System.Windows.Forms.PictureBox();
                    Label newLabelStatus = new System.Windows.Forms.Label();
                    newPanel.Cursor = System.Windows.Forms.Cursors.Hand;
                    newPanel.Name = room.RID1;
                    newPanel.Size = new System.Drawing.Size(146, 143);
                    newPanel.BackColor = System.Drawing.Color.DarkOrange;

                    newLabelStatus.AutoSize = true;
                    newLabelStatus.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    newLabelStatus.ForeColor = System.Drawing.Color.White;
                    newLabelStatus.Location = new System.Drawing.Point(20, 77);
                    newLabelStatus.Size = new System.Drawing.Size(132, 20);
                    newLabelStatus.TabIndex = 3;
                    newLabelStatus.Text = "Prepairing";

                    newLabelID.AutoSize = true;
                    newLabelID.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    newLabelID.ForeColor = System.Drawing.Color.White;
                    newLabelID.Location = new System.Drawing.Point(40, 110);
                    newLabelID.Size = new System.Drawing.Size(84, 33);
                    newLabelID.TabIndex = 2;
                    newLabelID.Text = room.RID1;

                    newPicturBox.BackColor = System.Drawing.Color.Transparent;
                    newPicturBox.BackgroundImage = global::HotelManagement.Properties.Resources.Single_Bed_70px;
                    newPicturBox.Location = new System.Drawing.Point(34, 4);
                    newPicturBox.Size = new System.Drawing.Size(70, 70);
                    newPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    newPicturBox.TabIndex = 0;
                    newPicturBox.TabStop = false;

                    newPanel.Controls.Add(newLabelID);
                    newPanel.Controls.Add(newLabelStatus);
                    newPanel.Controls.Add(newPicturBox);
                    
                    roomFlowLayoutPanel.Controls.Add(newPanel);
                    
                    // contextMenuStrip1
                    // 
                    ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();
                    ToolStripMenuItem availableToolStripMenuItem = new ToolStripMenuItem();
                    ToolStripMenuItem unavailableToolStripMenuItem = new ToolStripMenuItem();
                    ToolStripMenuItem cleaningToolStripMenuItem = new ToolStripMenuItem();
                    ToolStripMenuItem prepairingToolStripMenuItem = new ToolStripMenuItem();
                    contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
                    contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                    availableToolStripMenuItem,
                    unavailableToolStripMenuItem,
                    cleaningToolStripMenuItem,
                    prepairingToolStripMenuItem});
                    contextMenuStrip1.Name = "contextMenuStrip1";
                    contextMenuStrip1.Size = new System.Drawing.Size(157, 100);
                    // 
                    // availableToolStripMenuItem
                    // 
                    availableToolStripMenuItem.Name = "availableToolStripMenuItem";
                    availableToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
                    availableToolStripMenuItem.Text = "Available";
                    // 
                    // unavailableToolStripMenuItem
                    // 
                    unavailableToolStripMenuItem.Name = "unavailableToolStripMenuItem";
                    unavailableToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
                    unavailableToolStripMenuItem.Text = "Unavailable";
                    // 
                    // cleaninToolStripMenuItem
                    // 
                    cleaningToolStripMenuItem.Name = "cleaningToolStripMenuItem";
                    cleaningToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
                    cleaningToolStripMenuItem.Text = "Cleaning";
                    // 
                    // cleaningToolStripMenuItem
                    // 
                    prepairingToolStripMenuItem.Name = "prepairingToolStripMenuItem";
                    prepairingToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
                    prepairingToolStripMenuItem.Text = "Prepairing";
                    newPanel.ContextMenuStrip = contextMenuStrip1;
                    availableToolStripMenuItem.Click += new System.EventHandler(this.AvailableToolStripMenuItem_Click);
                    unavailableToolStripMenuItem.Click += new System.EventHandler(this.UnavailableToolStripMenuItem_Click);
                    cleaningToolStripMenuItem.Click += new System.EventHandler(this.CleaningToolStripMenuItem_Click);
                    prepairingToolStripMenuItem.Click += new System.EventHandler(this.PrepairingToolStripMenuItem_Click);
                    newPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
                }
                if (room.Status == "Cleaning")
                {
                    Panel newPanel = new System.Windows.Forms.Panel();
                    Label newLabelID = new System.Windows.Forms.Label();
                    PictureBox newPicturBox = new System.Windows.Forms.PictureBox();
                    Label newLabelStatus = new System.Windows.Forms.Label();
                    newPanel.Cursor = System.Windows.Forms.Cursors.Hand;
                    newPanel.Size = new System.Drawing.Size(146, 143);
                    newPanel.BackColor = System.Drawing.Color.RoyalBlue;
                    newPanel.Name = room.RID1;


                    newLabelStatus.AutoSize = true;
                    newLabelStatus.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    newLabelStatus.ForeColor = System.Drawing.Color.White;
                    newLabelStatus.Location = new System.Drawing.Point(30, 77);
                    newLabelStatus.Size = new System.Drawing.Size(132, 20);
                    newLabelStatus.TabIndex = 3;
                    newLabelStatus.Text = "Cleaning";

                    newLabelID.AutoSize = true;
                    newLabelID.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    newLabelID.ForeColor = System.Drawing.Color.White;
                    newLabelID.Location = new System.Drawing.Point(40, 110);
                    newLabelID.Size = new System.Drawing.Size(84, 33);
                    newLabelID.TabIndex = 2;
                    newLabelID.Text = room.RID1;

                    newPicturBox.BackColor = System.Drawing.Color.Transparent;
                    newPicturBox.BackgroundImage = global::HotelManagement.Properties.Resources.Single_Bed_70px;
                    newPicturBox.Location = new System.Drawing.Point(34, 4);
                    newPicturBox.Size = new System.Drawing.Size(70, 70);
                    newPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    newPicturBox.TabIndex = 0;
                    newPicturBox.TabStop = false;

                    newPanel.Controls.Add(newLabelID);
                    newPanel.Controls.Add(newLabelStatus);
                    newPanel.Controls.Add(newPicturBox);
                  
                   roomFlowLayoutPanel.Controls.Add(newPanel);
                    

                    // contextMenuStrip1
                    // 
                    ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();
                    ToolStripMenuItem availableToolStripMenuItem = new ToolStripMenuItem();
                    ToolStripMenuItem unavailableToolStripMenuItem = new ToolStripMenuItem();
                    ToolStripMenuItem cleaningToolStripMenuItem = new ToolStripMenuItem();
                    ToolStripMenuItem prepairingToolStripMenuItem = new ToolStripMenuItem();
                    contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
                    contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                    availableToolStripMenuItem,
                    unavailableToolStripMenuItem,
                    cleaningToolStripMenuItem,
                    prepairingToolStripMenuItem});
                    contextMenuStrip1.Name = "contextMenuStrip1";
                    contextMenuStrip1.Size = new System.Drawing.Size(157, 100);
                    // 
                    // availableToolStripMenuItem
                    // 
                    availableToolStripMenuItem.Name = "availableToolStripMenuItem";
                    availableToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
                    availableToolStripMenuItem.Text = "Available";
                    // 
                    // unavailableToolStripMenuItem
                    // 
                    unavailableToolStripMenuItem.Name = "unavailableToolStripMenuItem";
                    unavailableToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
                    unavailableToolStripMenuItem.Text = "Unavailable";
                    // 
                    // cleaninToolStripMenuItem
                    // 
                    cleaningToolStripMenuItem.Name = "cleaningToolStripMenuItem";
                    cleaningToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
                    cleaningToolStripMenuItem.Text = "Cleaning";
                    // 
                    // cleaningToolStripMenuItem
                    // 
                    prepairingToolStripMenuItem.Name = "prepairingToolStripMenuItem";
                    prepairingToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
                    prepairingToolStripMenuItem.Text = "Prepairing";
                    newPanel.ContextMenuStrip = contextMenuStrip1;
                    availableToolStripMenuItem.Click += new System.EventHandler(this.AvailableToolStripMenuItem_Click);
                    unavailableToolStripMenuItem.Click += new System.EventHandler(this.UnavailableToolStripMenuItem_Click);
                    cleaningToolStripMenuItem.Click += new System.EventHandler(this.CleaningToolStripMenuItem_Click);
                    prepairingToolStripMenuItem.Click += new System.EventHandler(this.PrepairingToolStripMenuItem_Click);
                    newPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
                }
            }
        }

        private void AvailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomBUS.Instance.updateRoomStatus(roomName,"Available");
             while(roomFlowLayoutPanel.Controls.Count>0)
            roomFlowLayoutPanel.Controls.RemoveAt(0);
            RoomStatus_Load(sender, e);



        }
        private void UnavailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomBUS.Instance.updateRoomStatus(roomName,"Unavailable");
            while (roomFlowLayoutPanel.Controls.Count > 0)
                roomFlowLayoutPanel.Controls.RemoveAt(0);
            RoomStatus_Load(sender, e);


        }
        private void CleaningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomBUS.Instance.updateRoomStatus(roomName, "Cleaning");
            while (roomFlowLayoutPanel.Controls.Count > 0)
                roomFlowLayoutPanel.Controls.RemoveAt(0);
            RoomStatus_Load(sender, e);


        }
        private void PrepairingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomBUS.Instance.updateRoomStatus(roomName, "Prepairing");
            while (roomFlowLayoutPanel.Controls.Count > 0)
                roomFlowLayoutPanel.Controls.RemoveAt(0);
            RoomStatus_Load(sender, e);


        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Panel panel = sender as Panel;
                roomName = panel.Name;
            }
        }

       
    }
}
