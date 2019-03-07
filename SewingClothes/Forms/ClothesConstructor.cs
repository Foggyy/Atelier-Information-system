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

namespace SewingClothes
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            LoadChanges();
        }

        private void buttonClothesChoice_Click(object sender, EventArgs e)
        {
            Form3 CChoice = new Form3();           
            CChoice.Show();
            Close();
        }

        private void buttonFabricChoice_Click(object sender, EventArgs e)
        {
            FabricsChoice FChoice = new FabricsChoice();
            FChoice.Show();
            Close();
        }

        private void buttonAccessouriesChoice_Click(object sender, EventArgs e)
        {
            AccesouriesChoice AChoice = new AccesouriesChoice();
            AChoice.Show();
            Close();
        }

        private void buttonBasket_Click(object sender, EventArgs e)
        {
            try
            {
                Bascket frm = new Bascket();
                frm.Show();
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите характеристики одежды и ткань.", "", MessageBoxButtons.OK);
            }
        }

        private void buttonInterfaceBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            Close();
        }

        private void LoadChanges()
        {
            if (DBBuf.ClothesTypeBuf != null && DBBuf.ClothesPropertiesBuf != null)
            {
                labelGenderValue.Text = DBBuf.ClothesTypeBuf.Gender;
                labelGenderValue.Visible = true;

                labelPurposeValue.Text = DBBuf.ClothesTypeBuf.Purpose;
                labelPurposeValue.Visible = true;

                labelSizeValue.Text = DBBuf.ClothesPropertiesBuf.Size;
                labelSizeValue.Visible = true;
            }

            if (DBBuf.FabricBuf != null)
            {
                labelFabricNameValue.Text = DBBuf.FabricBuf.Name;
                labelFabricNameValue.Visible = true;
            }

            if (DBBuf.AccessouriesBufList != null)
            {
                for (int i = 0; i < DBBuf.AccessouriesBufList.Count; i++)
                {
                    richTextBoxAccessouries.Text += DBBuf.AccessouriesBufList[i].Type + "\n\n";
                }

                richTextBoxAccessouries.Visible = true;
            }
        }
    }
}
