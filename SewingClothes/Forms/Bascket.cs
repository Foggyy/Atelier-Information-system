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
using SewingClothes.Forms;

namespace SewingClothes
{
    public partial class Bascket : Form
    {
        private int Amount = DBBuf.FabricBuf.Amount;

        public Bascket()
        {
            InitializeComponent();
            LoadData();
        }

        private void buttonReturnMenu_Click(object sender, EventArgs e)
        {
            Form2 Menu = new Form2();
            Menu.Show();
            Hide();
        }

        public void LoadData()
        {
            labelGender.Text = DBBuf.ClothesTypeBuf.Gender;
            labelPurpose.Text = DBBuf.ClothesTypeBuf.Purpose;
            labelSize.Text = DBBuf.ClothesPropertiesBuf.Size;
            labelFabric.Text = DBBuf.FabricBuf.Name;
            labelFabricColour.Text = DBBuf.FabricBuf.Colour;

            long cost = DBBuf.FabricBuf.CostPerMeter * DBBuf.FabricBuf.Amount * Convert.ToInt64(textBoxClothesAmount.Text);
            labelFabricCost.Text = Convert.ToString(cost);


            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(60, 50);
            Bitmap emptyImage = new Bitmap(60, 50);
            using (Graphics gr = Graphics.FromImage(emptyImage))
            {
                gr.Clear(Color.White);
            }
            listViewAccessories.SmallImageList = imageList;

            long sum = 0;
            int i = 0;
            foreach (Accessouries Element in DBBuf.AccessouriesBufList)
            {
                sum += Element.CostPerUnit;

                if(Element.ImagePath != "" && Element.ImagePath != "-")
                imageList.Images.Add(new Bitmap(Element.ImagePath));
                else
                {
                    imageList.Images.Add(emptyImage);
                }

                string[] Accessories =
                    {"",Element.Type, Convert.ToString(Element.Position), Convert.ToString(Element.CostPerUnit)};

                ListViewItem lvi = new ListViewItem(Accessories);
                lvi.ImageIndex = i;
                i++;
                listViewAccessories.Items.Add(lvi);

            }
            labelAccessouriesCost.Text = Convert.ToString(sum);
            sum += cost;

            labelFinalCost.Text = Convert.ToString(sum);

            DBBuf.OrderBuf = new Order();

            DBBuf.ClothesBuf = new Clothes();
            DBBuf.ClothesBuf.Amount = Convert.ToInt32(textBoxClothesAmount.Text);
            DBBuf.ClothesBuf.Cost = Convert.ToInt32(sum);

        }

        private void buttonMakeOffer_Click(object sender, EventArgs e)
        {
            DBBuf.FabricBuf.Amount = Amount;
            OrderRegistration frm = new OrderRegistration();
            frm.Show();
            Hide();
        }

        private void textBoxClothesAmount_TextChanged(object sender, EventArgs e)
        {
            if (DBBuf.FabricBuf.Amount * Convert.ToInt64(textBoxClothesAmount.Text) <= DBBuf.AmountFabric)
            {
                long cost = DBBuf.FabricBuf.CostPerMeter * DBBuf.FabricBuf.Amount * Convert.ToInt64(textBoxClothesAmount.Text);
                labelFabricCost.Text = Convert.ToString(cost);

                long sum = 0;
                foreach (Accessouries Element in DBBuf.AccessouriesBufList)
                {
                    sum += Element.CostPerUnit;
                    Element.Amount = Element.Amount * Convert.ToInt32(textBoxClothesAmount.Text);
                }
                sum = sum * Convert.ToInt64(textBoxClothesAmount.Text);
                labelAccessouriesCost.Text = Convert.ToString(sum);
                sum += cost;
                labelFinalCost.Text = Convert.ToString(sum);

                DBBuf.ClothesBuf.Amount = Convert.ToInt32(textBoxClothesAmount.Text);
                DBBuf.ClothesBuf.Cost = Convert.ToInt32(sum);

                Amount = Convert.ToInt32(textBoxClothesAmount.Text) * DBBuf.FabricBuf.Amount;
            }
            else
            {
                MessageBox.Show("Количество одежды превышает количество имеющейся ткани, " +
                                "уменьшите количество одежды или выберите другую ткань.", "", MessageBoxButtons.OK);
                Amount = DBBuf.FabricBuf.Amount;
                textBoxClothesAmount.Text = "1";
            }
            
        }

        private void Bascket_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }
    }
}
