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
        public Bascket()
        {
            InitializeComponent();
            LoadData();
        }

        private void buttonReturnMenu_Click(object sender, EventArgs e)
        {
            Form2 Menu = new Form2();
            Menu.Show();
            Close();
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

            long sum = 0;
            foreach (Accessouries Element in DBBuf.AccessouriesBufList)
            {
                sum += Element.CostPerUnit;

                string[] Accessories =
                    {"",Element.Type, Convert.ToString(Element.Position), Convert.ToString(Element.CostPerUnit)};

                listViewAccessories.Items.Add(new ListViewItem(Accessories));
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
            OrderRegistration frm = new OrderRegistration();
            frm.Show();
            Close();
        }

        private void textBoxClothesAmount_TextChanged(object sender, EventArgs e)
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

            DBBuf.FabricBuf.Amount = Convert.ToInt32(textBoxClothesAmount.Text) * DBBuf.FabricBuf.Amount;;
        }
    }
}
