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
    public partial class FabricsChoice : Form
    {
        public FabricsChoice()
        {
            InitializeComponent();
            LoadAllFabrics();            
        }

        private void buttonReturnMenu_Click(object sender, EventArgs e)
        {
            Form2 Menu = new Form2();
            Menu.Show();
            Close();
        }

        private void buttonAddFabric_Click(object sender, EventArgs e)
        {
            SaveFabric();
            Form2 Menu = new Form2();           
            Menu.Show();
            Close();
        }

        /// <summary>
        /// Сохранение выбранной ткани
        /// </summary>
        public void SaveFabric()
        {
            DBBuf.FabricBuf = new Fabric();
            int index ;
            if (listViewAllFabrics.SelectedItems.Count > 0)
            {
                index = listViewAllFabrics.Items.IndexOf(listViewAllFabrics.SelectedItems[0]);
                DBBuf.FabricBuf = DBLists.FabricList[index];
                AmountFabricCalculate();
            }
        }

        /// <summary>
        /// Загрузка всех тканей
        /// </summary>
        public void LoadAllFabrics()
        {
            SqlConnection connection = new SqlConnection(Connection.connectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM Fabric";
                command.Connection = connection;
                SqlDataReader reader = command.ExecuteReader();

                DBLists.FabricList = new List<Fabric>();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        long id = reader.GetInt64(0);
                        string Colour = reader.GetString(1);
                        string Name = reader.GetString(2);
                        string Material = reader.GetString(3);
                        string Facture = reader.GetString(4);
                        string Amount = reader.GetString(5);
                        string ImagePath = reader.GetString(6);
                        long Cost = reader.GetInt64(7);

                        Fabric Element = new Fabric(id, Colour, Name, Material, Facture, Convert.ToInt32(Amount), ImagePath, Cost);
                        string[] Fabric = { ImagePath, Colour, Name, Material, Facture, Amount, Convert.ToString(Cost) };
                        DBLists.FabricList.Add(Element);
                        listViewAllFabrics.Items.Add(new ListViewItem(Fabric));
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AmountFabricCalculate()
        {
            if (DBBuf.ClothesTypeBuf.Purpose == "Пиджак" || DBBuf.ClothesTypeBuf.Purpose == "Рубашка")
            {
                switch (DBBuf.ClothesPropertiesBuf.Size)
                {
                    case "XS":
                        DBBuf.FabricBuf.Amount = 2;
                        break;

                    case "S":
                        DBBuf.FabricBuf.Amount = 2;
                        break;

                    case "M":
                        DBBuf.FabricBuf.Amount = 2;
                        break;

                    case "L":
                        DBBuf.FabricBuf.Amount = 3;
                        break;

                    case "XL":
                        DBBuf.FabricBuf.Amount = 3;
                        break;

                    case "XXL":
                        DBBuf.FabricBuf.Amount = 4;
                        break;

                    case "XXXL":
                        DBBuf.FabricBuf.Amount = 4;
                        break;
                }
            }
            else if (DBBuf.ClothesTypeBuf.Purpose == "Жилет")
            {
                switch (DBBuf.ClothesPropertiesBuf.Size)
                {
                    case "XS":
                        DBBuf.FabricBuf.Amount = 2;
                        break;

                    case "S":
                        DBBuf.FabricBuf.Amount = 2;
                        break;

                    case "M":
                        DBBuf.FabricBuf.Amount = 2;
                        break;

                    case "L":
                        DBBuf.FabricBuf.Amount = 2;
                        break;

                    case "XL":
                        DBBuf.FabricBuf.Amount = 3;
                        break;

                    case "XXL":
                        DBBuf.FabricBuf.Amount = 3;
                        break;

                    case "XXXL":
                        DBBuf.FabricBuf.Amount = 3;
                        break;
                }
            }
            else if (DBBuf.ClothesTypeBuf.Purpose == "Брюки")
            {
                DBBuf.FabricBuf.Amount = 2;
            }
        }
    }
}
