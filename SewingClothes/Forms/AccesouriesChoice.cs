﻿using System;
using System.Collections.Generic;
using System.Drawing;
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
            LoadRecommendedAccessories();
        }


        public void SaveAccessouries()
        {
            DBBuf.AccessouriesBufList = new List<Accessouries>();
            int index;
            if (listViewRecommended.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listViewRecommended.SelectedItems.Count; i++)
                {
                    index = listViewRecommended.Items.IndexOf(listViewRecommended.SelectedItems[i]);
                    DBBuf.AccessouriesBufList.Add(DBLists.AccessouriesListSupport[index]);
                    DBBuf.AccessouriesBufList[i].Amount = 1;
                }               
            }
            else if (listViewAccessories.SelectedItems.Count > 0)
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

                ImageList imageList = new ImageList();
                imageList.ImageSize = new Size(60, 50);
                Bitmap emptyImage = new Bitmap(60, 50);
                using (Graphics gr = Graphics.FromImage(emptyImage))
                {
                    gr.Clear(Color.White);
                }
                listViewAccessories.SmallImageList = imageList;



                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM Accessories WHERE Amount >= 1";
                command.Connection = connection;
                DBLists.AccessouriesList = new List<Accessouries>();

                SqlDataReader reader = command.ExecuteReader();
                int i = 0;
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

                        if (ImagePath != "" && ImagePath != "-")
                            imageList.Images.Add(new Bitmap(ImagePath));
                        else
                        {
                            imageList.Images.Add(emptyImage);
                        }

                        Accessouries Element = new Accessouries(Id, Type, Position, Amount, CostPerUnit, ImagePath);
                        string[] Accessories =
                            {"",Type, Convert.ToString(Position),Convert.ToString(Amount), Convert.ToString(CostPerUnit)};

                        ListViewItem lvi = new ListViewItem(Accessories);
                        lvi.ImageIndex = i;
                        i++;
                        listViewAccessories.Items.Add(lvi);

                        DBLists.AccessouriesList.Add(Element);
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

                ImageList imageList = new ImageList();
                imageList.ImageSize = new Size(60, 50);
                Bitmap emptyImage = new Bitmap(60, 50);
                using (Graphics gr = Graphics.FromImage(emptyImage))
                {
                    gr.Clear(Color.White);
                }
                listViewRecommended.SmallImageList = imageList;

                SqlCommand command = new SqlCommand();
                if (DBBuf.ClothesTypeBuf.Purpose == "Рубашка")
                    command.CommandText = "SELECT * FROM Accessories WHERE Type != 'Пиджачный воротник' AND Position = 'Воротник' OR " +
                                      "Position = 'Рукава' OR Position = 'Грудь' OR Type = 'Пуговицы'";
                else if (DBBuf.ClothesTypeBuf.Purpose == "Пиджак")
                    command.CommandText = "SELECT * FROM Accessories WHERE Type = 'Пиджачный воротник' OR " +
                                          "Position = 'Рукава' OR Type LIKE '%карман%' OR Type = 'Пуговицы'";
                else if (DBBuf.ClothesTypeBuf.Purpose == "Жилет")
                    command.CommandText = "SELECT * FROM Accessories WHERE Position = 'Воротник' OR " +
                                          "Type LIKE '%карман%' OR Type = 'Пуговицы' OR Type = 'Крючки'";
                else if (DBBuf.ClothesTypeBuf.Purpose == "Брюки")
                    command.CommandText = "SELECT * FROM Accessories WHERE Position = 'Левый бок' OR Position = 'Правый бок' OR " +
                                          "Type = 'Пуговицы' OR Type = 'Молния'";
                else
                {
                    command.CommandText = "SELECT * FROM Accessories WHERE Type = 'Пуговицы' OR Type = 'Молния'";

                }

                command.Connection = connection;
                DBLists.AccessouriesListSupport = new List<Accessouries>();

                SqlDataReader reader = command.ExecuteReader();
                int i = 0;
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

                        if (ImagePath != "" && ImagePath != "-")
                            imageList.Images.Add(new Bitmap(ImagePath));
                        else
                        {
                            imageList.Images.Add(emptyImage);
                        }

                        Accessouries Element = new Accessouries(Id, Type, Position, Amount, CostPerUnit, ImagePath);
                        string[] Accessories =
                            {"",Type, Convert.ToString(Position),Convert.ToString(Amount), Convert.ToString(CostPerUnit)};
                        ListViewItem lvi = new ListViewItem(Accessories);
                        lvi.ImageIndex = i;
                        i++;
                        listViewRecommended.Items.Add(lvi);

                        DBLists.AccessouriesListSupport.Add(Element);
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
            Hide();
        }

        private void buttonAddAccesories_Click(object sender, EventArgs e)
        {
            SaveAccessouries();
            Form2 Menu = new Form2();           
            Menu.Show();
            Hide();
        }

        private void AccesouriesChoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }
    }
}
