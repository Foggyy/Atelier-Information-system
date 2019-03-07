using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SewingClothes.Class;
using System.Data.SqlClient;
using System.Globalization;

namespace SewingClothes.Forms
{
    public partial class OrderRegistration : Form
    {
        public OrderRegistration()
        {
            InitializeComponent();
        }

        private void buttonMakeOrder_Click(object sender, EventArgs e)
        {
            PaymentRequest();
            DeliveryRequest();
            ConstructClothes();
            LoadOrder();
            LoadData();
            
            Form2 frm = new Form2();
            frm.Show();
            Close();

        }

        public void LoadData()
        {
           
            DBBuf.CustomerBuf = new Customer();
            DBBuf.CustomerBuf.FIO = textBoxFIO.Text;
            DBBuf.CustomerBuf.Address = textBoxAddress.Text;
            DBBuf.CustomerBuf.Email = textBoxEmail.Text;
            DBBuf.CustomerBuf.PhoneNumber = Convert.ToInt64(textBoxPhoneNumber.Text);
            DBBuf.CustomerBuf.IdOrder = DBBuf.OrderBuf.Id;

            SqlConnection connection = new SqlConnection(Connection.connectionString);

                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "INSERT INTO Customer (FIO, Address, Phone_number, Email, ID_Order) VALUES " +
                                      "(@fio, @address, @phoneNumber, @email, @idOrder)";
                SqlParameter FioParam = new SqlParameter("@fio", DBBuf.CustomerBuf.FIO);
                SqlParameter AddressParam = new SqlParameter("@address", DBBuf.CustomerBuf.Address);
                SqlParameter PhoneNumberParam = new SqlParameter("@phoneNumber", DBBuf.CustomerBuf.PhoneNumber);
                SqlParameter EmailParam = new SqlParameter("@email", DBBuf.CustomerBuf.Email);
                SqlParameter IdOrderParam = new SqlParameter("@idOrder", DBBuf.CustomerBuf.IdOrder);
                command.Parameters.Add(FioParam);
                command.Parameters.Add(AddressParam);
                command.Parameters.Add(EmailParam);
                command.Parameters.Add(PhoneNumberParam);
                command.Parameters.Add(IdOrderParam);

                command.Connection = connection;
                command.ExecuteNonQuery();

                MessageBox.Show("Заказ успешно добавлен.", "", MessageBoxButtons.OK);

            

        }

        /// <summary>
        /// Добавление способа оплаты в заказ
        /// </summary>
        public void PaymentRequest()
        {
            DBBuf.PaymentBuf = new Payment();
            DBBuf.PaymentBuf.Type = comboBoxPayment.SelectedItem.ToString();

            SqlConnection connection = new SqlConnection(Connection.connectionString);
            try
            {
                long value = 0;
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "INSERT INTO Payment (Payment_method) VALUES (@PaymentType);SELECT SCOPE_IDENTITY()";
                command.Connection = connection;
                SqlParameter PaymentType = new SqlParameter("@PaymentType",DBBuf.PaymentBuf.Type);
                command.Parameters.Add(PaymentType);

                DBBuf.PaymentBuf.Id = Convert.ToInt32(command.ExecuteScalar());

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Добавление доставки
        /// </summary>
        public void DeliveryRequest()
        {
            DBBuf.DeliveryBuf = new Delivery();
            DBBuf.DeliveryBuf.Type = comboBoxDelivery.SelectedItem.ToString();

            switch (DBBuf.DeliveryBuf.Type)
            {
                case "Почта":
                    DBBuf.DeliveryBuf.DeliveryTime = "1 - 2 недели";
                    DBBuf.DeliveryBuf.Cost = Convert.ToString(DBBuf.ClothesBuf.Cost/50);
                    DBBuf.OrderBuf.TotalCost = Convert.ToInt64(DBBuf.DeliveryBuf.Cost) + Convert.ToInt32(DBBuf.ClothesBuf.Cost);
                    break;

                case "Курьер":
                    DBBuf.DeliveryBuf.DeliveryTime = "до 5 дней";
                    DBBuf.DeliveryBuf.Cost = Convert.ToString(DBBuf.ClothesBuf.Cost/25);
                    DBBuf.OrderBuf.TotalCost = Convert.ToInt64(DBBuf.DeliveryBuf.Cost) + Convert.ToInt32(DBBuf.ClothesBuf.Cost);
                    break;

                case "Транспортная компания":
                    DBBuf.DeliveryBuf.DeliveryTime = "до 5 дней";
                    DBBuf.DeliveryBuf.Cost = Convert.ToString(DBBuf.ClothesBuf.Cost / 25);
                    DBBuf.OrderBuf.TotalCost = Convert.ToInt64(DBBuf.DeliveryBuf.Cost) + Convert.ToInt32(DBBuf.ClothesBuf.Cost);
                    break;

                case "Самовывоз":
                    DBBuf.DeliveryBuf.DeliveryTime = "Можно забрать в любое время";
                    DBBuf.DeliveryBuf.Cost = Convert.ToString(0);
                    DBBuf.OrderBuf.TotalCost = DBBuf.ClothesBuf.Cost;
                    break;
            }

            SqlConnection connection = new SqlConnection(Connection.connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = ("INSERT INTO Delivery (Type, Cost, DateOfDelivery) VALUES (@type, @cost, @dateOfDelivery);SELECT SCOPE_IDENTITY()");
                command.Connection = connection;
                SqlParameter DeliveryType = new SqlParameter("@type", DBBuf.DeliveryBuf.Type);
                command.Parameters.Add(DeliveryType);
                SqlParameter Cost = new SqlParameter("@cost", DBBuf.DeliveryBuf.Cost);
                command.Parameters.Add(Cost);
                SqlParameter DateOfDelivery = new SqlParameter("@dateOfDelivery", DBBuf.DeliveryBuf.DeliveryTime);
                command.Parameters.Add(DateOfDelivery);

                DBBuf.DeliveryBuf.Id = Convert.ToInt64(command.ExecuteScalar());

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ConstructClothes()
        {
            DBBuf.ClothesBuf.IdClothesProperties = DBBuf.ClothesPropertiesBuf.Id;
            DBBuf.ClothesBuf.IdClothesType = DBBuf.ClothesTypeBuf.Id;
            DBBuf.ClothesBuf.IdFabric = DBBuf.FabricBuf.Id;

            SqlConnection connection = new SqlConnection(Connection.connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = ("INSERT INTO Clothes (Amount, ID_ClothesType, ID_ClothesProperties, ID_Fabric, Cost) " +
                                       "VALUES (@amount, @idClothesType, @idClothesProperties, @idFabric, @cost);SELECT SCOPE_IDENTITY()");
                command.Connection = connection;
                SqlParameter ClothesAmount = new SqlParameter("@amount", DBBuf.ClothesBuf.Amount);
                command.Parameters.Add(ClothesAmount);
                SqlParameter ClothesIdType = new SqlParameter("@idClothesType", DBBuf.ClothesBuf.IdClothesType);
                command.Parameters.Add(ClothesIdType);
                SqlParameter ClothesIdProperties = new SqlParameter("@idClothesProperties", DBBuf.ClothesBuf.IdClothesProperties);
                command.Parameters.Add(ClothesIdProperties);
                SqlParameter ClothesIdFabric = new SqlParameter("@idFabric", DBBuf.ClothesBuf.IdFabric);
                command.Parameters.Add(ClothesIdFabric);
                SqlParameter ClothesCost = new SqlParameter("@cost", DBBuf.ClothesBuf.Cost);
                command.Parameters.Add(ClothesCost);

                DBBuf.ClothesBuf.Id = Convert.ToInt64(command.ExecuteScalar());

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadOrder()
        {
            DBBuf.OrderBuf.Date = DateTime.Today.Date.ToString();
            DBBuf.OrderBuf.IdClothes = DBBuf.ClothesBuf.Id;
            DBBuf.OrderBuf.IdDelivery = DBBuf.DeliveryBuf.Id;
            DBBuf.OrderBuf.IdPayment = DBBuf.PaymentBuf.Id;
            DBBuf.OrderBuf.TotalCost = DBBuf.ClothesBuf.Cost + Convert.ToInt32(DBBuf.DeliveryBuf.Cost);
            

            SqlConnection connection = new SqlConnection(Connection.connectionString);

                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = ("INSERT INTO Orders (Date, Total_cost, ID_Payment, ID_Delivery, ID_Clothes) " +
                                       "VALUES (@date, @totalCost, @idPayment, @idDelivery, @idClothes);SELECT SCOPE_IDENTITY()");
                command.Connection = connection;
                SqlParameter OrderDate = new SqlParameter("@date", DBBuf.OrderBuf.Date);
                command.Parameters.Add(OrderDate);
                SqlParameter OrderTotalCost = new SqlParameter("@totalCost", DBBuf.OrderBuf.TotalCost);
                command.Parameters.Add(OrderTotalCost);
                SqlParameter OrderIdPayment = new SqlParameter("@idPayment", DBBuf.OrderBuf.IdPayment);
                command.Parameters.Add(OrderIdPayment);
                SqlParameter OrderIdDelivery = new SqlParameter("@idDelivery", DBBuf.OrderBuf.IdDelivery);
                command.Parameters.Add(OrderIdDelivery);
                SqlParameter OrderIdClothes = new SqlParameter("@idClothes", DBBuf.OrderBuf.IdClothes);
                command.Parameters.Add(OrderIdClothes);

                DBBuf.OrderBuf.Id = Convert.ToInt64(command.ExecuteScalar());


        }
    }
}
