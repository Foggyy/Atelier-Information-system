using System;
using System.Windows.Forms;

namespace SewingClothes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Connection.connectionString = @"Data Source=DESKTOP-KGGC3BG;Initial Catalog=SewingBD;Integrated Security=True";
        }

        private void buttonAdminChoice_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();
            adm.Show();
            Hide();
        }

        private void buttonCustomerChoice_Click(object sender, EventArgs e)
        {
            Form2 clthsConstructor = new Form2();
            clthsConstructor.Show();
            Hide();
        }
    }

    public static class Connection
    {
        public static string connectionString { get; set; }
    }
}
