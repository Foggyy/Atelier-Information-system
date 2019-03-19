using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SewingClothes
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void buttonOrdersList_Click(object sender, EventArgs e)
        {
            OrderList amdOrdList = new OrderList();
            amdOrdList.Show();
            Hide();
        }

        private void buttonChangeFabric_Click(object sender, EventArgs e)
        {
            AdminFabricChange frm = new AdminFabricChange();
            frm.Show();
            Close();
        }

        private void buttonChangeAccessories_Click(object sender, EventArgs e)
        {
            AdminAccesouriesChange frm = new AdminAccesouriesChange();
            frm.Show();
            Hide();
        }
    }
}
