using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ClosedXML.Excel;
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
            DBBuf.FabricBuf = new Fabric();
            SqlConnection connection = new SqlConnection(Connection.connectionString);
            try
            {
                connection.Open();

                ImageList imageList = new ImageList();
                imageList.ImageSize = new Size(60, 50);
                Bitmap emptyImage = new Bitmap(60, 50);
                using (Graphics gr = Graphics.FromImage(emptyImage))
                {
                    gr.Clear(Color.White);
                }
                listViewAllFabrics.SmallImageList = imageList;

                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM Fabric";
                command.Connection = connection;
                SqlDataReader reader = command.ExecuteReader();

                int i = 0;
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

                        if (ImagePath != "" && ImagePath != "-")
                            imageList.Images.Add(new Bitmap(ImagePath));
                        else
                        {
                            imageList.Images.Add(emptyImage);
                        }

                        Fabric Element = new Fabric(id, Colour, Name, Material, Facture, Convert.ToInt32(Amount), ImagePath, Cost);
                        string[] Fabric = {"", Colour, Name, Material, Facture, Amount, Convert.ToString(Cost) };
                        DBLists.FabricList.Add(Element);

                        ListViewItem lvi = new ListViewItem(Fabric);
                        lvi.ImageIndex = i;
                        listViewAllFabrics.Items.Add(lvi);
                        i++;
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
                    long index = listViewAllFabrics.Items.IndexOf(listViewAllFabrics.SelectedItems[0]);
                    index = DBLists.FabricList[Convert.ToInt32(index)].Id;
                    DBBuf.FabricBuf.Id = index;
                    Fabric SupportFabric = new Fabric();
                    SqlParameter commandParameter;

                    command.CommandText =
                        "UPDATE Fabric SET Name=@name, Colour=@colour, Material=@material, Texture=@texture, " +
                        "Cost_per_meter=@cost, Amount=@amount, ImagePath=@image WHERE ID=@id";


                    foreach (Fabric Element in DBLists.FabricList)
                    {
                        if (Element.Id == index)
                        {
                            SupportFabric = new Fabric(Element.Id,Element.Colour,Element.Name,Element.Material,
                                Element.Facture,Element.Amount,Element.Image,Element.CostPerMeter);
                        }
                    }

                    if (textBoxFabricName.Text != "")
                    {
                        commandParameter = new SqlParameter("name", textBoxFabricName.Text);
                        command.Parameters.Add(commandParameter);
                    }
                    else
                    {

                        commandParameter = new SqlParameter("name", SupportFabric.Name);
                        command.Parameters.Add(commandParameter);
                    }

                    if (textBoxColour.Text != "")
                    {
                        commandParameter = new SqlParameter("colour", textBoxColour.Text);
                        command.Parameters.Add(commandParameter);
                    }
                    else
                    {
                        commandParameter =
                            new SqlParameter("colour", SupportFabric.Colour);
                        command.Parameters.Add(commandParameter);
                    }

                    if (textBoxFabricMaterial.Text != "")
                    {
                        commandParameter = new SqlParameter("material", textBoxFabricMaterial.Text);
                        command.Parameters.Add(commandParameter);
                    }
                    else
                    {
                        commandParameter = new SqlParameter("material", SupportFabric.Material);
                        command.Parameters.Add(commandParameter);
                    }

                    if (textBoxFabricTexture.Text != "")
                    {
                        commandParameter = new SqlParameter("texture", textBoxFabricTexture.Text);
                        command.Parameters.Add(commandParameter);
                    }
                    else
                    {
                        commandParameter = new SqlParameter("texture", SupportFabric.Facture);
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
                        commandParameter = new SqlParameter("cost", SupportFabric.CostPerMeter);
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
                        commandParameter = new SqlParameter("amount", SupportFabric.Amount);
                        command.Parameters.Add(commandParameter);
                    }

                    if (DBBuf.FabricBuf.Image != "")
                    {
                        commandParameter = new SqlParameter("image", DBBuf.FabricBuf.Image);
                        command.Parameters.Add(commandParameter);
                    }
                    else
                    {
                        commandParameter = new SqlParameter("image", SupportFabric.Image);
                        command.Parameters.Add(commandParameter);
                    }

                    command.Parameters.Add(new SqlParameter("id", DBBuf.FabricBuf.Id));
                }
                else
                {
                    int amount = Convert.ToInt32(textBoxFabricAmount.Text);
                    int cost = Convert.ToInt32(textBoxFabricCost.Text);
                    command.CommandText =
                        "INSERT INTO Fabric (Colour, Name, Material, Texture, Amount, ImagePath, Cost_per_meter) " +
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

                    SqlParameter FabricCost = new SqlParameter("@costPerMeter", Convert.ToString(cost));
                    command.Parameters.Add(FabricCost);
                }

                command.ExecuteReader();
                listViewAllFabrics.Items.Clear();
                LoadFabric();
                DBBuf.FabricBuf.Image = "";

            }
            catch (SqlException)
            {
                MessageBox.Show("Заполните все поля.", "",MessageBoxButtons.OK);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите целое число.", "", MessageBoxButtons.OK);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Заполните хотя бы одно поле.", "", MessageBoxButtons.OK);
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
            catch (SqlException)
            {
                MessageBox.Show("Данная ткань используется в заказе, удаление невозможно.","",MessageBoxButtons.OK);
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
            DBBuf.FabricBuf = new Fabric();
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "jpg (*.jpg)|*.jpg|png (*.png)|*.png";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                // получаем выбранный файл
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
                long index = listViewAllFabrics.Items.IndexOf(listViewAllFabrics.SelectedItems[0]);
                textBoxColour.Text = DBLists.FabricList[Convert.ToInt32(index)].Colour;
                textBoxFabricName.Text = DBLists.FabricList[Convert.ToInt32(index)].Name;
                textBoxFabricMaterial.Text = DBLists.FabricList[Convert.ToInt32(index)].Material;
                textBoxFabricTexture.Text = DBLists.FabricList[Convert.ToInt32(index)].Facture;
                textBoxFabricCost.Text = Convert.ToString(DBLists.FabricList[Convert.ToInt32(index)].CostPerMeter);
                textBoxFabricAmount.Text = Convert.ToString(DBLists.FabricList[Convert.ToInt32(index)].Amount);
                index = DBLists.FabricList[Convert.ToInt32(index)].Id;
                DBBuf.FabricBuf.Id = index;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            listViewAllFabrics.SelectedIndices.Clear();
            textBoxColour.Text = "";
            textBoxFabricName.Text = "";
            textBoxFabricMaterial.Text = "";
            textBoxFabricTexture.Text = "";
            textBoxFabricCost.Text = "";
            textBoxFabricAmount.Text = "";
        }

        private void buttonExcelOutput_Click(object sender, EventArgs e)
        {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.InitialDirectory = Application.StartupPath + @"\Reports\Fabric";
                sfd.Filter = "xlsx (*.xlsx)|*.xlsx|xls (*.xls)|*.xls";
                if (sfd.ShowDialog(this) == DialogResult.OK)
                {
                    // получаем выбранный файл
                    string filename = sfd.FileName;
                XLWorkbook book = new XLWorkbook();
                var sheet = book.Worksheets.Add("Ткани");

                sheet.Cell("B2").Value = "Список тканей";
                sheet.Cell("B3").Value = "ID";
                sheet.Cell("C3").Value = "Цвет";
                sheet.Cell("D3").Value = "Имя";
                sheet.Cell("E3").Value = "Материал";
                sheet.Cell("F3").Value = "Фактура";
                sheet.Cell("G3").Value = "Количество";
                sheet.Cell("H3").Value = "Стоимость за метр";
                sheet.Cell("I3").Value = "Путь изображения";

                int i = 4;
                foreach (Fabric Element in DBLists.FabricList)
                {
                    sheet.Cell(String.Format("B{0}", i)).Value = Element.Id;
                    sheet.Cell(String.Format("C{0}", i)).Value = Element.Colour;
                    sheet.Cell(String.Format("D{0}", i)).Value = Element.Name;
                    sheet.Cell(String.Format("E{0}", i)).Value = Element.Material;
                    sheet.Cell(String.Format("F{0}", i)).Value = Element.Facture;
                    sheet.Cell(String.Format("G{0}", i)).Value = Element.Amount;
                    sheet.Cell(String.Format("H{0}", i)).Value = Element.CostPerMeter;
                    sheet.Cell(String.Format("I{0}", i)).Value = Element.Image;
                    i++;
                }

                var TableRamka = sheet.Range(String.Format("B2:I{0}", i));
                var TableHeader = sheet.Range("A2:I2");
                TableHeader.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                TableHeader.Style.Font.Bold = true;
                TableRamka.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                TableRamka.Cell(1, 1).Style.Font.Bold = true;
                TableRamka.Cell(1, 1).Style.Fill.BackgroundColor = XLColor.CornflowerBlue;
                TableRamka.Cell(1, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                TableRamka.Row(1).Merge();
                TableRamka.Style.Border.OutsideBorder = XLBorderStyleValues.Thick;
                sheet.Columns(2, i).AdjustToContents();
                book.SaveAs(filename);

                    MessageBox.Show("Отчет создан");
                }                       
        }
    }
}
