using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using ClosedXML.Excel;
using SewingClothes.Class;

namespace SewingClothes
{
    public partial class OrderList : Form
    {
        public OrderList()
        {
            InitializeComponent();
            CustomerLoad();
        }

        public void CustomerLoad()
        {
            SqlConnection connection = new SqlConnection(Connection.connectionString);
            try
            {
                connection.Open();
                DBLists.CustomerList = new List<Customer>();

                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM Customer";
                command.Connection = connection;

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        long ID = reader.GetInt64(0);
                        string FIO = reader.GetString(1);
                        string Address = reader.GetString(2);
                        long PhoneNumber = reader.GetInt64(3);
                        string Email = reader.GetString(4);
                        long IdOrder = reader.GetInt64(5);


                        DBLists.CustomerList.Add(new Customer(ID, FIO, Address, PhoneNumber, Email, IdOrder));

                        string[] Customer =
                        {Convert.ToString(ID), Convert.ToString(FIO), Convert.ToString(Address),Convert.ToString(Email),
                            Convert.ToString(IdOrder)};

                        listViewOrders.Items.Add(new ListViewItem(Customer));
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void OrderLoad(int index)
        {
            SqlConnection connection = new SqlConnection(Connection.connectionString);
            try
            {
                connection.Open();
                DBBuf.CustomerBuf = DBLists.CustomerList[index];
                DBBuf.OrderBuf = new Order();
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM Orders WHERE ID=@idOrder";
                command.Connection = connection;

                SqlParameter commandParameter = new SqlParameter("idOrder", DBBuf.CustomerBuf.IdOrder);
                command.Parameters.Add(commandParameter);

                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.HasRows)
                {
                        reader.Read();
                        labelDateDynamic.Text = reader.GetString(1);
                        labelCostDynamic.Text = Convert.ToString(reader.GetInt64(2));

                        DBBuf.OrderBuf.Id = reader.GetInt64(0);
                        DBBuf.OrderBuf.Date = reader.GetString(1);
                        DBBuf.OrderBuf.TotalCost = reader.GetInt64(2);
                        DBBuf.OrderBuf.IdPayment = reader.GetInt32(3);
                        DBBuf.OrderBuf.IdDelivery = reader.GetInt64(4);
                        DBBuf.OrderBuf.IdClothes = reader.GetInt64(5);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PaymentLoad()
        {
            SqlConnection connection = new SqlConnection(Connection.connectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM Payment WHERE ID=@idPayment";
                command.Connection = connection;

                SqlParameter commandParameter = new SqlParameter("idPayment", DBBuf.OrderBuf.IdPayment);
                command.Parameters.Add(commandParameter);

                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.HasRows)
                {
                    reader.Read();
                    labelPaymentDynamic.Text = reader.GetString(1);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeliveryLoad()
        {
            SqlConnection connection = new SqlConnection(Connection.connectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM Delivery WHERE ID=@idDelivery";
                command.Connection = connection;

                SqlParameter commandParameter = new SqlParameter("idDelivery", DBBuf.OrderBuf.IdDelivery);
                command.Parameters.Add(commandParameter);

                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.HasRows)
                {
                    reader.Read();
                    labelDeliveryDynamic.Text = reader.GetString(1);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ClothesLoad()
        {
            SqlConnection connection = new SqlConnection(Connection.connectionString);
            try
            {
                connection.Open();
                
                DBBuf.ClothesBuf = new Clothes();

                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM Clothes WHERE ID=@idClothes";
                command.Connection = connection;

                SqlParameter commandParameter = new SqlParameter("idClothes", DBBuf.OrderBuf.IdClothes);
                command.Parameters.Add(commandParameter);

                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.HasRows)
                {
                    reader.Read();
                    DBBuf.ClothesBuf.Id = reader.GetInt64(0);
                    DBBuf.ClothesBuf.IdFabric = reader.GetInt64(4);
                    DBBuf.ClothesBuf.IdClothesType = reader.GetInt64(2);
                }

                connection.Close();

                command = new SqlCommand();
                command.CommandText = "SELECT * FROM ClothesType WHERE ID=@idClothesType";
                commandParameter = new SqlParameter("idClothesType",DBBuf.ClothesBuf.IdClothesType);
                connection.Open();
                command.Connection = connection;
                command.Parameters.Add(commandParameter);

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    labelClothesTypeDynamic.Text = reader.GetString(1);
                    labelGenderDynamic.Text = reader.GetString(2);
                }

                connection.Close();

                command = new SqlCommand();
                command.CommandText = "SELECT * FROM Fabric WHERE ID=@idFabric";
                commandParameter = new SqlParameter("idFabric", DBBuf.ClothesBuf.IdFabric);
                connection.Open();
                command.Connection = connection;
                command.Parameters.Add(commandParameter);

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    labelFabricColour.Text = reader.GetString(1);
                    labelFabricName.Text = reader.GetString(2);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteOrder()
        {
            SqlConnection connection = new SqlConnection(Connection.connectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandText = "DELETE FROM ClothesAccessories WHERE IDClothes=@idClothes";
                command.Connection = connection;

                SqlParameter commandParameter = new SqlParameter("idClothes", DBBuf.ClothesBuf.Id);
                command.Parameters.Add(commandParameter);
                command.ExecuteNonQuery();

                command.CommandText = "DELETE FROM Customer WHERE ID=@idCustomer";
                commandParameter = new SqlParameter("idCustomer", DBBuf.CustomerBuf.Id);
                command.Parameters.Clear();
                command.Parameters.Add(commandParameter);
                command.ExecuteNonQuery();

                command.CommandText = "DELETE FROM Orders WHERE ID=@idOrders";
                commandParameter = new SqlParameter("idOrders", DBBuf.CustomerBuf.IdOrder);
                command.Parameters.Clear();
                command.Parameters.Add(commandParameter);
                command.ExecuteNonQuery();

                command.CommandText = "DELETE FROM Payment WHERE ID=@idPayment";
                commandParameter = new SqlParameter("idPayment", DBBuf.OrderBuf.IdPayment);
                command.Parameters.Clear();
                command.Parameters.Add(commandParameter);
                command.ExecuteNonQuery();

                command.CommandText = "DELETE FROM Delivery WHERE ID=@idDelivery";
                commandParameter = new SqlParameter("idDelivery", DBBuf.OrderBuf.IdDelivery);
                command.Parameters.Clear();
                command.Parameters.Add(commandParameter);
                command.ExecuteNonQuery();

                command.CommandText = "DELETE FROM Clothes WHERE ID=@idClothes";
                commandParameter = new SqlParameter("idClothes", DBBuf.ClothesBuf.Id);
                command.Parameters.Clear();
                command.Parameters.Add(commandParameter);
                command.ExecuteNonQuery();

                listViewOrders.Items.Clear();
                CustomerLoad();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listViewOrders_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listViewOrders.SelectedIndices.Count == 1)
            {
                int index = listViewOrders.SelectedIndices[0];
                OrderLoad(index);
                PaymentLoad();
                DeliveryLoad();
                ClothesLoad();
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Admin frm = new Admin();
            frm.Show();
            Hide();
        }

        private void buttonCancelOrder_Click(object sender, EventArgs e)
        {
            DeleteOrder();
        }

        private void OrderList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }

        private void buttonExcelOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath + @"\Reports\Orders";
            sfd.Filter = "xlsx (*.xlsx)|*.xlsx|xls (*.xls)|*.xls";
            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                // получаем выбранный файл
                string filename = sfd.FileName;
                XLWorkbook book = new XLWorkbook();
                var sheet = book.Worksheets.Add("Заказы");

                sheet.Cell("B2").Value = "Список тканей";
                sheet.Cell("B3").Value = "ID";
                sheet.Cell("C3").Value = "ФИО";
                sheet.Cell("D3").Value = "Адрес";
                sheet.Cell("E3").Value = "E-mail";
                sheet.Cell("F3").Value = "ID Заказа";

                int i = 4;
                foreach (Customer Element in DBLists.CustomerList)
                {
                    sheet.Cell(String.Format("B{0}", i)).Value = Element.Id;
                    sheet.Cell(String.Format("C{0}", i)).Value = Element.FIO;
                    sheet.Cell(String.Format("D{0}", i)).Value = Element.Address;
                    sheet.Cell(String.Format("E{0}", i)).Value = Element.Email;
                    sheet.Cell(String.Format("F{0}", i)).Value = Element.IdOrder;
                    i++;
                }

                var TableRamka = sheet.Range(String.Format("B2:F{0}", i));
                var TableHeader = sheet.Range("A2:F2");
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
