﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using SewingClothes.Class;

namespace SewingClothes
{
    public partial class FabricsChoice : Form
    {
        public FabricsChoice()
        {
            InitializeComponent();

            DBBuf.FabricBuf = new Fabric();
            AmountFabricCalculate();
            LoadAllFabrics();
            LoadRecommendedAccessories();
        }

        private void buttonReturnMenu_Click(object sender, EventArgs e)
        {
            Form2 Menu = new Form2();
            Menu.Show();
            Hide();
        }

        private void buttonAddFabric_Click(object sender, EventArgs e)
        {
            bool ok;
            ok = SaveFabric();
            if (ok)
            {
                Form2 Menu = new Form2();
                Menu.Show();
                Hide();
            }
        }

        /// <summary>
        /// Сохранение выбранной ткани
        /// </summary>
        public bool SaveFabric()
        {
            int index;
            if (listViewRecommended.SelectedItems.Count == 1)
            {
                index = listViewRecommended.Items.IndexOf(listViewRecommended.SelectedItems[0]);
                DBBuf.FabricBuf = DBLists.FabricListSupport[index];
                DBBuf.AmountFabric = DBLists.FabricListSupport[index].Amount;
                AmountFabricCalculate();
                return true;
            }
            else if (listViewAllFabrics.SelectedItems.Count == 1)
            {
                index = listViewAllFabrics.Items.IndexOf(listViewAllFabrics.SelectedItems[0]);
                DBBuf.FabricBuf = DBLists.FabricList[index];
                DBBuf.AmountFabric = DBLists.FabricList[index].Amount;
                AmountFabricCalculate();
                return true;
            }
            else
            {
                MessageBox.Show("Выберите одну ткань.", "", MessageBoxButtons.OK);
                return false;
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

                ImageList imageList = new ImageList();
                imageList.ImageSize = new Size(60, 50);
                Bitmap emptyImage = new Bitmap(60, 50);
                using (Graphics gr = Graphics.FromImage(emptyImage))
                {
                    gr.Clear(Color.White);
                }
                listViewAllFabrics.SmallImageList = imageList;


                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM Fabric WHERE Amount >= @amount";
                command.Connection = connection;
                SqlParameter AmountParameter = new SqlParameter("amount", DBBuf.FabricBuf.Amount);
                command.Parameters.Add(AmountParameter);
                SqlDataReader reader = command.ExecuteReader();

                DBLists.FabricList = new List<Fabric>();
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

                        if(ImagePath != "" && ImagePath != "-")
                        imageList.Images.Add(new Bitmap(ImagePath));
                        else
                        {
                            imageList.Images.Add(emptyImage);
                        }

                        Fabric Element = new Fabric(id, Colour, Name, Material, Facture, Convert.ToInt32(Amount), ImagePath, Cost);
                        string[] Fabric = {"", Colour, Name, Material, Facture, Amount, Convert.ToString(Cost) };                       
                        ListViewItem lvi = new ListViewItem(Fabric);
                        lvi.ImageIndex = i;
                        DBLists.FabricList.Add(Element);
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

        public void LoadRecommendedAccessories()
        {
            SqlConnection connection = new SqlConnection(Connection.connectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                if (DBBuf.ClothesTypeBuf.Purpose == "Рубашка")
                    command.CommandText = "SELECT * FROM Fabric WHERE Amount >= @amount AND " +
                                      "Material = 'Лен' OR Material = 'Шелк' OR Material = 'Хлопок'";
                else if (DBBuf.ClothesTypeBuf.Purpose == "Пиджак")
                    command.CommandText = "SELECT * FROM Fabric WHERE Amount >= @amount AND " +
                                          "Material = 'Шерсть'";
                else if (DBBuf.ClothesTypeBuf.Purpose == "Жилет")
                    command.CommandText = "SELECT * FROM Fabric WHERE Amount >= @amount AND " +
                                          "Material = 'Шерсть' OR Material = 'Шелк'";
                else if (DBBuf.ClothesTypeBuf.Purpose == "Брюки")
                    command.CommandText = "SELECT * FROM Fabric WHERE Amount >= @amount AND " +
                                          "Material = 'Лен' OR Material = 'Шелк' OR Material = 'Хлопок'";
                else
                {
                    command.CommandText = "SELECT * FROM Fabric WHERE Amount >= @amount AND " +
                                              "Material = 'Шелк' OR Material = 'Хлопок'";
                }



                command.Connection = connection;
                SqlParameter AmountParameter = new SqlParameter("amount", DBBuf.FabricBuf.Amount);
                command.Parameters.Add(AmountParameter);

                ImageList imageList = new ImageList();
                imageList.ImageSize = new Size(60, 50);
                Bitmap emptyImage = new Bitmap(60, 50);
                using (Graphics gr = Graphics.FromImage(emptyImage))
                {
                    gr.Clear(Color.White);
                }
                listViewRecommended.SmallImageList = imageList;

                SqlDataReader reader = command.ExecuteReader();

                DBLists.FabricListSupport = new List<Fabric>();
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
                        ListViewItem lvi = new ListViewItem(Fabric);
                        lvi.ImageIndex = i;
                        i++;
                        DBLists.FabricListSupport.Add(Element);
                        listViewRecommended.Items.Add(lvi);
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
            else
            {
                DBBuf.FabricBuf.Amount = 2;
            }
        }

        private void FabricsChoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }
    }
}
