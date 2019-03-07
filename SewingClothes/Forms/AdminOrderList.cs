using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SewingClothes
{
    public partial class OrderList : Form
    {
        public OrderList()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(Connection.connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Успешное подключение");
                
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM Customer";
                command.Connection = connection;

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        object FIO = reader.GetValue(1);
                        object Address = reader.GetValue(2);
                        object PhoneNumber = reader.GetValue(3);
                        object Email = reader.GetValue(4);

                        string[] Customer =
                            {Convert.ToString(FIO), Convert.ToString(PhoneNumber),Convert.ToString(Email),Convert.ToString(Address)};

                        listViewOrders.Items.Add(new ListViewItem(Customer));
                    }
                    
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
