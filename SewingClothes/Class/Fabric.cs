using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewingClothes.Class
{
    public class Fabric
    {
        public long Id { get; set; }
        public string Colour { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public string Facture { get; set; }
        public long CostPerMeter { get; set; }
        public int Amount { get; set; }
        public string Image { get; set; }

        public Fabric()
        {
            Id = 0;
            Colour = "";
            Name = "";
            Material = "";
            Facture = "";
            CostPerMeter = 0;
            Amount = 0;
            Image = "";
        }

        public Fabric(long id, string colour, string name, string material, string facture, int amount, string image, long cost)
        {
            Id = id;
            Colour = colour;
            Name = name;
            Material = material;
            Facture = facture;
            Amount = amount;
            Image = image;
            CostPerMeter = cost;
        }
    }
}
