using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using SewingClothes.Class;

namespace SewingClothes
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            SizeComboBoxLoad();
        }

        private void buttonReturnMenu_Click(object sender, EventArgs e)
        {
            Form2 Menu = new Form2();
            Menu.Show();
            Hide();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                SaveSelectedChangesToBuf();
                Form2 Menu = new Form2();
                Menu.Show();
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите все значения в списках.", "", MessageBoxButtons.OK);
            }
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenderComboBoxLoad();
        }

        private void buttonSizeCalculate_Click(object sender, EventArgs e)
        {
            SizeCalculate();
        }

        /// <summary>
        /// Сохранение изменений
        /// </summary>
        public void SaveSelectedChangesToBuf()
        {

                int index = comboBoxPurpose.SelectedIndex;
                DBBuf.ClothesTypeBuf = new ClothesType
                {
                    Id = DBLists.ClothesTypeList[index].Id,
                    Gender = DBLists.ClothesTypeList[index].Gender,
                    Purpose = DBLists.ClothesTypeList[index].Purpose
                };

                index = comboBoxSize.SelectedIndex;
                DBBuf.ClothesPropertiesBuf = new ClothesProperties
                {
                    Id = DBLists.ClothesPropertiesList[index].Id,
                    Size = DBLists.ClothesPropertiesList[index].Size
                };
            
        }

        /// <summary>
        /// Вывод списка одежды по полу
        /// </summary>
        public void GenderComboBoxLoad()
        {
            if (DBLists.ClothesTypeList != null)
            {
                DBLists.ClothesTypeList.Clear();
                comboBoxPurpose.Items.Clear();
            }

            string GenderBuf;
            GenderBuf = comboBoxGender.Text;

            SqlConnection connection = new SqlConnection(Connection.connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM ClothesType WHERE Gender=@Gender";
                command.Connection = connection;
                SqlParameter GenderParam = new SqlParameter("@Gender", GenderBuf);
                command.Parameters.Add(GenderParam);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DBLists.ClothesTypeList = new List<ClothesType>();
                    while (reader.Read())
                    {
                        long id = reader.GetInt64(0);
                        string Purpose = reader.GetString(1);
                        string Gender = reader.GetString(2);
                        ClothesType Element = new ClothesType(id, Purpose, Gender);

                        comboBoxPurpose.Items.Add(Purpose);
                        DBLists.ClothesTypeList.Add(Element);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SizeComboBoxLoad()
        {
            SqlConnection connection = new SqlConnection(Connection.connectionString);

            if (DBLists.ClothesTypeList != null)
            {
                DBLists.ClothesTypeList.Clear();
                comboBoxPurpose.Items.Clear();
            }
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM ClothesProperties";
                command.Connection = connection;
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DBLists.ClothesPropertiesList = new List<ClothesProperties>();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string Size = reader.GetString(1);

                        ClothesProperties Element = new ClothesProperties(id, Size);

                        comboBoxSize.Items.Add(Element.Size);
                        DBLists.ClothesPropertiesList.Add(Element);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SizeCalculate()
        {
            try
            {
                if (textBoxBreastSize.Text != null && textBoxWaistSize.Text != null && textBoxHipsSize.Text != null)
                {
                    int sizeBreast = Convert.ToInt32(textBoxBreastSize.Text);
                    int sizeWaist = Convert.ToInt32(textBoxWaistSize.Text);
                    int sizeHips = Convert.ToInt32(textBoxHipsSize.Text);

                    if (sizeBreast <= 88 & sizeBreast >= 82 || sizeWaist >= 58 && sizeWaist <= 64 ||
                        sizeHips <= 94 && sizeHips >= 88)
                    {
                        comboBoxSize.SelectedItem = comboBoxSize.Items[0]; //XS
                    }
                    else if (sizeBreast <= 94 & sizeBreast >= 88 || sizeWaist >= 64 && sizeWaist <= 70 ||
                             sizeHips <= 100 && sizeHips >= 94)
                    {
                        comboBoxSize.SelectedItem = comboBoxSize.Items[1]; //S
                    }
                    else if (sizeBreast <= 100 & sizeBreast >= 94 || sizeWaist >= 70 && sizeWaist <= 76 ||
                             sizeHips <= 106 && sizeHips >= 100)
                    {
                        comboBoxSize.SelectedItem = comboBoxSize.Items[2]; //M
                    }
                    else if (sizeBreast <= 106 & sizeBreast >= 100 || sizeWaist >= 76 && sizeWaist <= 82 ||
                             sizeHips <= 112 && sizeHips >= 106)
                    {
                        comboBoxSize.SelectedItem = comboBoxSize.Items[3]; //L
                    }
                    else if (sizeBreast <= 112 & sizeBreast >= 106 || sizeWaist >= 82 && sizeWaist <= 88 ||
                             sizeHips <= 118 && sizeHips >= 112)
                    {
                        comboBoxSize.SelectedItem = comboBoxSize.Items[4]; //XL
                    }
                    else if (sizeBreast <= 118 & sizeBreast >= 112 || sizeWaist >= 88 && sizeWaist <= 92 ||
                             sizeHips <= 122 && sizeHips >= 118)
                    {
                        comboBoxSize.SelectedItem = comboBoxSize.Items[5]; //XXL
                    }
                    else if (sizeBreast <= 124 & sizeBreast >= 118 || sizeWaist >= 92 && sizeWaist <= 96 ||
                             sizeHips <= 128 && sizeHips >= 122)
                    {
                        comboBoxSize.SelectedItem = comboBoxSize.Items[6]; //XXXL
                    }
                    else
                    {
                        MessageBox.Show("Введите корректные значения", "", MessageBoxButtons.OK);

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите целые числа","",MessageBoxButtons.OK);
            }
            
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }
    }

}
