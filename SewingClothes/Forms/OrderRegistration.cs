using System;
using System.Windows.Forms;
using SewingClothes.Class;
using System.Data.SqlClient;

namespace SewingClothes.Forms
{
    public partial class OrderRegistration : Form
    {
        public OrderRegistration()
        {
            InitializeComponent();
            labelClothesCost.Text = DBBuf.ClothesBuf.Cost.ToString();
        }

        private void buttonMakeOrder_Click(object sender, EventArgs e)
        {
            PaymentRequest();
            DeliveryRequest();
            ConstructClothes();
            LoadAccessories();
            ReduceAmount();
            LoadOrder();            
            LoadData();
            
            Form2 frm = new Form2();
            frm.Show();
            Hide();

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

            DBBuf.OrderBuf = null;
            DBBuf.AccessouriesBufList = null;
            DBBuf.ClothesBuf = null;
            DBBuf.ClothesTypeBuf = null;
            DBBuf.ClothesPropertiesBuf = null;
            DBBuf.CustomerBuf = null;
            DBBuf.DeliveryBuf = null;
            DBBuf.FabricBuf = null;
            DBBuf.PaymentBuf = null;

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
           
            SqlConnection connection = new SqlConnection(Connection.connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = ("INSERT INTO Delivery (Type, Cost, DateOfDelivery) VALUES (@type, @cost, @dateOfDelivery)" +
                                       ";SELECT SCOPE_IDENTITY()");
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

        /// <summary>
        /// Добавление записи в таблицу Clothes
        /// </summary>
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

        /// <summary>
        /// Добавление записи в таблицу Order
        /// </summary>
        public void LoadOrder()
        {
            DBBuf.OrderBuf.Date = DateTime.Now.ToShortDateString();
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

        /// <summary>
        /// Добавление записей в таблицу Accessouries
        /// </summary>
        public void LoadAccessories()
        {
            SqlConnection connection = new SqlConnection(Connection.connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "INSERT INTO ClothesAccessories (IDClothes, IDAccessories) VALUES (@idClothes, @idAccessories)";
                command.Connection = connection;
                SqlParameter ClothesID = new SqlParameter("idClothes", DBBuf.ClothesBuf.Id);
                command.Parameters.Add(ClothesID);

                foreach (Accessouries Element in DBBuf.AccessouriesBufList)
                {
                    SqlParameter AccessoriesID = new SqlParameter("idAccessories", Element.Id);
                    command.Parameters.Add(AccessoriesID);
                    command.ExecuteNonQuery();
                    command.Parameters.Remove(AccessoriesID);
                }                            
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Уменьшение количества имеющихся аксессуаров и тканей
        /// </summary>
        public void ReduceAmount()
        {
            SqlConnection connection = new SqlConnection(Connection.connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "UPDATE Accessories SET Amount = Amount - @amount WHERE ID = @id";
                command.Connection = connection;

                foreach (Accessouries Element in DBBuf.AccessouriesBufList)
                {
                    SqlParameter AccessoriesAmount = new SqlParameter("amount", Element.Amount);
                    command.Parameters.Add(AccessoriesAmount);
                    SqlParameter AccessoriesID = new SqlParameter("id", Element.Id);
                    command.Parameters.Add(AccessoriesID);
                    command.ExecuteNonQuery();
                    command.Parameters.Remove(AccessoriesID);
                    command.Parameters.Remove(AccessoriesAmount);
                }

                command.CommandText = "UPDATE Fabric SET Amount = Amount - @amount WHERE ID = @id";
                SqlParameter FabricAmount = new SqlParameter("amount", DBBuf.FabricBuf.Amount);
                command.Parameters.Add(FabricAmount);
                SqlParameter FabricID = new SqlParameter("id", DBBuf.FabricBuf.Id);
                command.Parameters.Add(FabricID);
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PriceLoad()
        {            
            DBBuf.DeliveryBuf = new Delivery();
            DBBuf.DeliveryBuf.Type = comboBoxDelivery.SelectedItem.ToString();

            switch (DBBuf.DeliveryBuf.Type)
            {
                case "Почта":
                    DBBuf.DeliveryBuf.DeliveryTime = "1 - 2 недели";
                    DBBuf.DeliveryBuf.Cost = Convert.ToString(DBBuf.ClothesBuf.Cost / 50);
                    DBBuf.OrderBuf.TotalCost = Convert.ToInt64(DBBuf.DeliveryBuf.Cost) + Convert.ToInt32(DBBuf.ClothesBuf.Cost);
                    labelDeliveryCost.Text = DBBuf.DeliveryBuf.Cost;
                    labelTotalCost.Text = DBBuf.OrderBuf.TotalCost.ToString();
                    labelDeliveryDate.Text = DBBuf.DeliveryBuf.DeliveryTime;
                    break;

                case "Курьер":
                    DBBuf.DeliveryBuf.DeliveryTime = "до 5 дней";
                    DBBuf.DeliveryBuf.Cost = Convert.ToString(DBBuf.ClothesBuf.Cost / 25);
                    DBBuf.OrderBuf.TotalCost = Convert.ToInt64(DBBuf.DeliveryBuf.Cost) + Convert.ToInt32(DBBuf.ClothesBuf.Cost);
                    labelDeliveryCost.Text = DBBuf.DeliveryBuf.Cost;
                    labelTotalCost.Text = DBBuf.OrderBuf.TotalCost.ToString();
                    labelDeliveryDate.Text = DBBuf.DeliveryBuf.DeliveryTime;
                    break;

                case "Транспортная компания":
                    DBBuf.DeliveryBuf.DeliveryTime = "до 5 дней";
                    DBBuf.DeliveryBuf.Cost = Convert.ToString(DBBuf.ClothesBuf.Cost / 25);
                    DBBuf.OrderBuf.TotalCost = Convert.ToInt64(DBBuf.DeliveryBuf.Cost) + Convert.ToInt32(DBBuf.ClothesBuf.Cost);
                    labelDeliveryCost.Text = DBBuf.DeliveryBuf.Cost;
                    labelTotalCost.Text = DBBuf.OrderBuf.TotalCost.ToString();
                    labelDeliveryDate.Text = DBBuf.DeliveryBuf.DeliveryTime;
                    break;

                case "Самовывоз":
                    DBBuf.DeliveryBuf.DeliveryTime = "Можно забрать в любое время";
                    DBBuf.DeliveryBuf.Cost = Convert.ToString(0);
                    DBBuf.OrderBuf.TotalCost = DBBuf.ClothesBuf.Cost;
                    labelDeliveryCost.Text = DBBuf.DeliveryBuf.Cost;
                    labelTotalCost.Text = DBBuf.OrderBuf.TotalCost.ToString();
                    labelDeliveryDate.Text = DBBuf.DeliveryBuf.DeliveryTime;
                    break;
            }
        }

        private void comboBoxDelivery_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriceLoad();
        }

        private void buttonReturnMenu_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            Hide();
        }

        private void buttonReturnBascket_Click(object sender, EventArgs e)
        {
            Bascket frm = new Bascket();
            frm.Show();
            Hide();
        }

        private void OrderRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }
    }
}
