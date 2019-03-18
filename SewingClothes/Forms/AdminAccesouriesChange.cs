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
    public partial class AdminAccesouriesChange : Form
    {
        public AdminAccesouriesChange()
        {
            InitializeComponent();
        }

        private void AdminAccesouriesChange_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }

        private void buttonReturnAdmin_Click(object sender, EventArgs e)
        {
            Admin frm = new Admin();
            frm.Show();
            Hide();
        }
    }
}
