using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SewingClothes.Class;

namespace SewingClothes
{
    public partial class AdminFabricChange : Form
    {
        public AdminFabricChange()
        {
            InitializeComponent();
            LoadFabric();
        }

        public void LoadFabric()
        {
            DBLists.FabricList = new List<Fabric>();
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

        public void AddChangeFabric()
        {
            SqlConnection connection = new SqlConnection(Connection.connectionString);
            try
            {
                SqlCommand command = new SqlCommand();
                connection.Open();
                command.Connection = connection;
                
                if (listViewAllFabrics.SelectedIndices.Count == 1)
                {
                    DBBuf.FabricBuf = new Fabric();
                    long index = listViewAllFabrics.Items.IndexOf(listViewAllFabrics.SelectedItems[0]);
                    index = DBLists.FabricList[Convert.ToInt32(index)].Id;
                    DBBuf.FabricBuf.Id = index;
                    SqlParameter commandParameter;
                    
                    command.CommandText = "UPDATE Fabric SET Name=@name, Colour=@colour, Material=@material, Texture=@texture, " +
                                          "Cost_per_meter=@cost, Amount=@amount, ImagePath=@image WHERE ID=@id";

                    if (textBoxFabricName.Text != "")
                    {
                        commandParameter = new SqlParameter("name",textBoxFabricName.Text);
                        command.Parameters.Add(commandParameter);
                    }
                    else
                    {
                        commandParameter = new SqlParameter("name", DBLists.FabricList[Convert.ToInt32(index)].Name);
                        command.Parameters.Add(commandParameter);
                    }

                    if (textBoxColour.Text != "")
                    {
                        commandParameter = new SqlParameter("colour",textBoxColour.Text);
                        command.Parameters.Add(commandParameter);
                    }
                    else
                    {
                        commandParameter = new SqlParameter("colour", DBLists.FabricList[Convert.ToInt32(index)].Colour);
                        command.Parameters.Add(commandParameter);
                    }

                    if (textBoxFabricMaterial.Text != "")
                    {
                        commandParameter = new SqlParameter("material", textBoxFabricMaterial.Text);
                        command.Parameters.Add(commandParameter);
                    }
                    else
                    {
                        commandParameter = new SqlParameter("material", DBLists.FabricList[Convert.ToInt32(index)].Material);
                        command.Parameters.Add(commandParameter);
                    }

                    if (textBoxFabricTexture.Text != "")
                    {
                        commandParameter = new SqlParameter("texture", textBoxFabricTexture.Text);
                        command.Parameters.Add(commandParameter);
                    }
                    else
                    {
                        commandParameter = new SqlParameter("texture", DBLists.FabricList[Convert.ToInt32(index)].Facture);
                        command.Parameters.Add(commandParameter);
                    }

                    if (textBoxFabricCost.Text != "")
                    {
                        int cost = Convert.ToInt32(textBoxFabricCost.Text);
                        commandParameter = new SqlParameter("cost", textBoxFabricCost.Text);
                        command.Parameters.Add(commandParameter);
                    }
                    else
                    {
                        commandParameter = new SqlParameter("cost", DBLists.FabricList[Convert.ToInt32(index)].CostPerMeter);
                        command.Parameters.Add(commandParameter);
                    }

                    if (textBoxFabricAmount.Text != "")
                    {
                        int amount = Convert.ToInt32(textBoxFabricAmount.Text);
                        commandParameter = new SqlParameter("amount", textBoxFabricAmount.Text);
                        command.Parameters.Add(commandParameter);
                    }
                    else
                    {
                        commandParameter = new SqlParameter("amount", DBLists.FabricList[Convert.ToInt32(index)].Amount);
                        command.Parameters.Add(commandParameter);
                    }

                    if (DBBuf.FabricBuf.Image != "")
                    {
                        commandParameter = new SqlParameter("image", DBBuf.FabricBuf.Image);
                        command.Parameters.Add(commandParameter);
                    }
                    else
                    {
                        commandParameter = new SqlParameter("image", DBLists.FabricList[Convert.ToInt32(index)].Image);
                        command.Parameters.Add(commandParameter);
                    }

                    command.Parameters.Add(new SqlParameter("id",DBBuf.FabricBuf.Id));
                }
                else
                {
                    int amount = Convert.ToInt32(textBoxFabricAmount.Text);                    
                    command.CommandText = "INSERT INTO Fabric (Colour, Name, Material, Texture, Amount, ImagePath, Cost_per_meter) " +
                                          "VALUES (@colour, @name, @material, @texture, @amount, @imagePath, @costPerMeter)";
                    SqlParameter FabricColour = new SqlParameter("@colour", textBoxColour.Text);
                    command.Parameters.Add(FabricColour);
                    SqlParameter FabricName = new SqlParameter("@name", textBoxFabricName.Text);
                    command.Parameters.Add(FabricName);
                    SqlParameter FabricMaterial = new SqlParameter("@material", textBoxFabricMaterial.Text);
                    command.Parameters.Add(FabricMaterial);
                    SqlParameter FabricTexture = new SqlParameter("@texture", textBoxFabricTexture.Text);
                    command.Parameters.Add(FabricTexture);
                    SqlParameter FabricAmount = new SqlParameter("@amount", Convert.ToString(amount));
                    command.Parameters.Add(FabricAmount);

                    if (DBBuf.FabricBuf.Image == "")
                    {
                        SqlParameter FabricImage = new SqlParameter("@imagePath", "-");
                        command.Parameters.Add(FabricImage);
                    }
                    else
                    {
                        SqlParameter FabricImage = new SqlParameter("@imagePath", DBBuf.FabricBuf.Image);
                        command.Parameters.Add(FabricImage);
                    }

                    SqlParameter FabricCost = new SqlParameter("@costPerMeter", Convert.ToString(amount));
                    command.Parameters.Add(FabricCost);
                }

                command.ExecuteReader();
                listViewAllFabrics.Items.Clear();
                LoadFabric();
                DBBuf.FabricBuf.Image = "";

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteFabric()
        {
            SqlConnection connection = new SqlConnection(Connection.connectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandText = "DELETE FROM Fabric WHERE ID=@idFabric";
                command.Connection = connection;

                SqlParameter commandParameter = new SqlParameter("idFabric", DBBuf.FabricBuf.Id);
                command.Parameters.Add(commandParameter);
                command.ExecuteNonQuery();
                listViewAllFabrics.Items.Clear();
                LoadFabric();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdminBack_Click(object sender, EventArgs e)
        {
            Admin frm = new Admin();
            frm.Show();
            Hide();
        }

        private void buttonAddFabric_Click(object sender, EventArgs e)
        {
            AddChangeFabric();
            textBoxColour.Text = "";
            textBoxFabricAmount.Text = "";
            textBoxFabricCost.Text = "";
            textBoxFabricMaterial.Text = "";
            textBoxFabricName.Text = "";
            textBoxFabricTexture.Text = "";
            labelImageLoaded.Text = "Изображение не загружено";
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "jpg (*.jpg)|*.jpg|png (*.png)|*.png";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                // получаем выбранный файл
                DBBuf.FabricBuf = new Fabric();
                string filename = openFileDialog.FileName;
                DBBuf.FabricBuf.Image = filename;
                labelImageLoaded.Text = "Изображение загружено";

            }
        }

        private void AdminFabricChange_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                if (e.CloseReason == CloseReason.UserClosing)
                    Application.Exit();
            
        }

        private void buttonDeleteFabric_Click(object sender, EventArgs e)
        {
            DeleteFabric();
        }

        private void listViewAllFabrics_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listViewAllFabrics.SelectedIndices.Count == 1)
            {
                DBBuf.FabricBuf = new Fabric();
                long index = listViewAllFabrics.Items.IndexOf(listViewAllFabrics.SelectedItems[0]);
                index = DBLists.FabricList[Convert.ToInt32(index)].Id;
                DBBuf.FabricBuf.Id = index;
            }
        }
    }
}
