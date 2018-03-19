using Business_Logic_Layer;
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
    public partial class RentManagement : Form
    {
        public RentManagement()
        {
            InitializeComponent();
            
        }
        private void backpanelleft_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Hide();
            hp.Show();
        }

       

        private void RentManagement_Load(object sender, EventArgs e)
        {
            BillDetailBUS.Instance.displayAll(DataGridView);
        }
    }
}