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
using SewingClothes.Class;

namespace SewingClothes
{
    public partial class AccesouriesChoice : Form
    {
        public AccesouriesChoice()
        {
            InitializeComponent();
            LoadAccessouries();
        }


        public void SaveAccessouries()
        {
            DBBuf.AccessouriesBufList = new List<Accessouries>();
            int index;
            if (listViewAccessories.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listViewAccessories.SelectedItems.Count; i++)
                {
                    index = listViewAccessories.Items.IndexOf(listViewAccessories.SelectedItems[i]);
                    DBBuf.AccessouriesBufList.Add(DBLists.AccessouriesList[index]);
                    DBBuf.AccessouriesBufList[i].Amount = 1;
                }               
            }
        }

        public void LoadAccessouries()
        {
            SqlConnection connection = new SqlConnection(Connection.connectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM Accessories";
                command.Connection = connection;
                DBLists.AccessouriesList = new List<Accessouries>();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        long Id = reader.GetInt64(0);
                        string Type = reader.GetString(1);
                        string Position = reader.GetString(2);
                        long Amount = reader.GetInt64(3);
                        long CostPerUnit = reader.GetInt64(4);
                        string ImagePath = reader.GetString(5);

                        Accessouries Element = new Accessouries(Id, Type, Position, Amount, CostPerUnit, ImagePath);
                        string[] Accessories =
                            {"",Type, Convert.ToString(Position),Convert.ToString(Amount), Convert.ToString(CostPerUnit)};

                        listViewAccessories.Items.Add(new ListViewItem(Accessories));

                        DBLists.AccessouriesList.Add(Element);
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonReturnMenu_Click(object sender, EventArgs e)
        {
            Form2 Menu = new Form2();
            Menu.Show();
            Close();
        }

        private void buttonAddAccesories_Click(object sender, EventArgs e)
        {
            SaveAccessouries();
            Form2 Menu = new Form2();           
            Menu.Show();
            Close();
        }
    }
}
