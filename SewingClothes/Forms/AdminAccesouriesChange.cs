using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ClosedXML.Excel;
using SewingClothes.Class;

namespace SewingClothes
{
    public partial class AdminAccesouriesChange : Form
    {
        public AdminAccesouriesChange()
        {
            InitializeComponent();
            LoadAccessouries();
        }

        public void LoadAccessouries()
        {
            DBLists.AccessouriesList = new List<Accessouries>();
            DBBuf.AccessouriesBuf = new Accessouries();
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
                listViewAccessouries.SmallImageList = imageList;

                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM Accessories";
                command.Connection = connection;
                SqlDataReader reader = command.ExecuteReader();
                int i = 0;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        long id = reader.GetInt64(0);
                        string Type = reader.GetString(1);
                        string Position = reader.GetString(2);
                        long Amount = reader.GetInt64(3);
                        long Cost = reader.GetInt64(4);
                        string ImagePath = reader.GetString(5);

                        if (ImagePath != "" && ImagePath != "-")
                            imageList.Images.Add(new Bitmap(ImagePath));
                        else
                        {
                            imageList.Images.Add(emptyImage);
                        }

                        Accessouries Element = new Accessouries(id, Type, Position, Amount, Cost, ImagePath);
                        string[] Accessouries = { "", Type, Position, Convert.ToString(Cost), Convert.ToString(Amount)};

                        ListViewItem lvi = new ListViewItem(Accessouries);
                        lvi.ImageIndex = i;
                        i++;
                        DBLists.AccessouriesList.Add(Element);
                        listViewAccessouries.Items.Add(lvi);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddChangeAccessorie()
        {
            SqlConnection connection = new SqlConnection(Connection.connectionString);
            try
            {
                SqlCommand command = new SqlCommand();
                connection.Open();
                command.Connection = connection;

                if (listViewAccessouries.SelectedIndices.Count == 1)
                {

                    long index = listViewAccessouries.Items.IndexOf(listViewAccessouries.SelectedItems[0]);
                    index = DBLists.AccessouriesList[Convert.ToInt32(index)].Id;
                    DBBuf.AccessouriesBuf.Id = index;
                    Accessouries SupportAccessourie = new Accessouries();
                    SqlParameter commandParameter;

                    command.CommandText =
                        "UPDATE Accessories SET Type=@type, Position=@position, Amount=@amount, Cost_per_unit=@cost, " +
                        "ImagePath=@image WHERE ID=@id";


                    foreach (Accessouries Element in DBLists.AccessouriesList)
                    {
                        if (Element.Id == index)
                        {
                            SupportAccessourie = new Accessouries(Element.Id, Element.Type, Element.Position,
                                Element.Amount, Element.CostPerUnit, Element.ImagePath);
                        }
                    }

                    if (textBoxType.Text != "")
                    {
                        commandParameter = new SqlParameter("type", textBoxType.Text);
                        command.Parameters.Add(commandParameter);
                    }
                    else
                    {

                        commandParameter = new SqlParameter("type", SupportAccessourie.Type);
                        command.Parameters.Add(commandParameter);
                    }

                    if (textBoxPosition.Text != "")
                    {
                        commandParameter = new SqlParameter("position", textBoxPosition.Text);
                        command.Parameters.Add(commandParameter);
                    }
                    else
                    {
                        commandParameter = new SqlParameter("position", SupportAccessourie.Position);
                        command.Parameters.Add(commandParameter);
                    }

                    if (textBoxAmount.Text != "")
                    {
                        long amount = Convert.ToInt64(textBoxAmount.Text);
                        commandParameter = new SqlParameter("amount", Convert.ToInt64(textBoxAmount.Text));
                        command.Parameters.Add(commandParameter);
                    }
                    else
                    {
                        commandParameter = new SqlParameter("amount", SupportAccessourie.Amount);
                        command.Parameters.Add(commandParameter);
                    }

                    if (textBoxCost.Text != "")
                    {
                        long cost = Convert.ToInt64(textBoxCost.Text);
                        commandParameter = new SqlParameter("cost", Convert.ToInt64(textBoxCost.Text));
                        command.Parameters.Add(commandParameter);
                    }
                    else
                    {
                        commandParameter = new SqlParameter("cost", SupportAccessourie.CostPerUnit);
                        command.Parameters.Add(commandParameter);
                    }

                    if (DBBuf.AccessouriesBuf.ImagePath != "")
                    {
                        commandParameter = new SqlParameter("image", DBBuf.AccessouriesBuf.ImagePath);
                        command.Parameters.Add(commandParameter);
                    }
                    else
                    {
                        commandParameter = new SqlParameter("image", SupportAccessourie.ImagePath);
                        command.Parameters.Add(commandParameter);
                    }

                    command.Parameters.Add(new SqlParameter("id", DBBuf.AccessouriesBuf.Id));
                }
                else
                {
                    long amount = Convert.ToInt64(textBoxAmount.Text);
                    long cost = Convert.ToInt32(textBoxCost.Text);
                    command.CommandText =
                        "INSERT INTO Accessories (Type, Position, Amount, Cost_per_unit, ImagePath) " +
                        "VALUES (@type, @position, @amount, @cost, @imagePath)";
                    SqlParameter AccessoriesType = new SqlParameter("@type", textBoxType.Text);
                    command.Parameters.Add(AccessoriesType);
                    SqlParameter AccessoriesPosition = new SqlParameter("@position", textBoxPosition.Text);
                    command.Parameters.Add(AccessoriesPosition);
                    SqlParameter AccessoriesAmount = new SqlParameter("@amount", Convert.ToInt64(textBoxAmount.Text));
                    command.Parameters.Add(AccessoriesAmount);
                    SqlParameter AccessoriesCost = new SqlParameter("@cost", Convert.ToInt64(textBoxCost.Text));
                    command.Parameters.Add(AccessoriesCost);

                    if (DBBuf.AccessouriesBuf.ImagePath == "")
                    {
                        SqlParameter AccessoriesImage = new SqlParameter("@imagePath", "-");
                        command.Parameters.Add(AccessoriesImage);
                    }
                    else
                    {
                        SqlParameter AccessoriesImage = new SqlParameter("@imagePath", DBBuf.AccessouriesBuf.ImagePath);
                        command.Parameters.Add(AccessoriesImage);
                    }
                }

                command.ExecuteReader();
                listViewAccessouries.Items.Clear();
                LoadAccessouries();
            }
            catch (SqlException)
            {
                MessageBox.Show("Заполните все поля.", "", MessageBoxButtons.OK);
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

        public void DeleteAccessourie()
        {
            SqlConnection connection = new SqlConnection(Connection.connectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandText = "DELETE FROM Accessories WHERE ID=@idAccessorie";
                command.Connection = connection;

                SqlParameter commandParameter = new SqlParameter("idAccessorie", DBBuf.AccessouriesBuf.Id);
                command.Parameters.Add(commandParameter);
                command.ExecuteNonQuery();
                listViewAccessouries.Items.Clear();
                LoadAccessouries();
            }
            catch (SqlException)
            {
                MessageBox.Show("Данный аксессуар используется в заказе, удаление невозможно.", "", MessageBoxButtons.OK);
            }
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

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "jpg (*.jpg)|*.jpg|png (*.png)|*.png";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                // получаем выбранный файл
                string filename = openFileDialog.FileName;
                DBBuf.AccessouriesBuf.ImagePath = filename;
                labelImageLoaded.Text = "Изображение загружено";

            }
        }

        private void buttonAddAccessourie_Click(object sender, EventArgs e)
        {
            AddChangeAccessorie();
            textBoxType.Text = "";
            textBoxPosition.Text = "";
            textBoxAmount.Text = "";
            textBoxCost.Text = "";
            labelImageLoaded.Text = "Изображение не загружено";
            DBBuf.AccessouriesBuf = new Accessouries();
        }

        private void buttonDeleteAccessourie_Click(object sender, EventArgs e)
        {
            DeleteAccessourie();
        }

        private void listViewAccessouries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAccessouries.SelectedIndices.Count == 1)
            {
                long index = listViewAccessouries.Items.IndexOf(listViewAccessouries.SelectedItems[0]);
                textBoxType.Text = DBLists.AccessouriesList[Convert.ToInt32(index)].Type;
                textBoxPosition.Text = DBLists.AccessouriesList[Convert.ToInt32(index)].Position;
                textBoxAmount.Text = Convert.ToString(DBLists.AccessouriesList[Convert.ToInt32(index)].Amount);
                textBoxCost.Text = Convert.ToString(DBLists.AccessouriesList[Convert.ToInt32(index)].CostPerUnit);
                index = DBLists.AccessouriesList[Convert.ToInt32(index)].Id;
                DBBuf.AccessouriesBuf.Id = index;
               
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            listViewAccessouries.SelectedIndices.Clear();
            textBoxType.Text = "";
            textBoxPosition.Text = "";
            textBoxAmount.Text = "";
            textBoxCost.Text = "";
        }

        private void buttonExcelOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath + @"\Reports\Accessories";
            sfd.Filter = "xlsx (*.xlsx)|*.xlsx|xls (*.xls)|*.xls";
            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                // получаем выбранный файл
                string filename = sfd.FileName;
                XLWorkbook book = new XLWorkbook();
                var sheet = book.Worksheets.Add("Аксессуары");

                sheet.Cell("B2").Value = "Список аксессуаров";
                sheet.Cell("B3").Value = "ID";
                sheet.Cell("C3").Value = "Тип";
                sheet.Cell("D3").Value = "Положение";
                sheet.Cell("E3").Value = "Количество";
                sheet.Cell("F3").Value = "Цена за единицу";
                sheet.Cell("G3").Value = "Путь изображения";


                int i = 4;
                foreach (Accessouries Element in DBLists.AccessouriesList)
                {
                    sheet.Cell(String.Format("B{0}", i)).Value = Element.Id;
                    sheet.Cell(String.Format("C{0}", i)).Value = Element.Type;
                    sheet.Cell(String.Format("D{0}", i)).Value = Element.Position;
                    sheet.Cell(String.Format("E{0}", i)).Value = Element.Amount;
                    sheet.Cell(String.Format("F{0}", i)).Value = Element.CostPerUnit;
                    sheet.Cell(String.Format("G{0}", i)).Value = Element.ImagePath;
                    i++;
                }

                var TableRamka = sheet.Range(String.Format("B2:G{0}", i));
                var TableHeader = sheet.Range("A2:G2");
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
