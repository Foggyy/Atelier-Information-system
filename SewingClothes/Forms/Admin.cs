using System;
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
            Hide();
        }

        private void buttonChangeAccessories_Click(object sender, EventArgs e)
        {
            AdminAccesouriesChange frm = new AdminAccesouriesChange();
            frm.Show();
            Hide();
        }

        private void buttonInterfaceBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            Hide();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RequestConstructor frm = new RequestConstructor();
            frm.Show();
            Hide();
        }
    }
}
