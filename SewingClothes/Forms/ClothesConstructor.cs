using System;
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
            Hide();
        }

        private void buttonFabricChoice_Click(object sender, EventArgs e)
        {
            try
            {
                FabricsChoice FChoice = new FabricsChoice();
                FChoice.Show();
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("В начале выберите характеристики одежды.","",MessageBoxButtons.OK);
            }
        }

        private void buttonAccessouriesChoice_Click(object sender, EventArgs e)
        {
            try
            {
                AccesouriesChoice AChoice = new AccesouriesChoice();
                AChoice.Show();
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("В начале выберите характеристики одежды.", "", MessageBoxButtons.OK);
            }

        }

        private void buttonBasket_Click(object sender, EventArgs e)
        {
            try
            {
                Bascket frm = new Bascket();
                frm.Show();
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите характеристики одежды, аксессуары и ткань.", "", MessageBoxButtons.OK);
            }
        }

        private void buttonInterfaceBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            Hide();
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

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }
    }
}
