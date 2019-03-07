using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewingClothes.Class
{
    public class ClothesAccessories
    {
        public long IDClothes { get; set; }
        public long IDAccessories { get; set; }

        public ClothesAccessories()
        {
            IDClothes = 0;
            IDAccessories = 0;
        }

        public ClothesAccessories(long idClothes, long idAccessories)
        {
            IDClothes = idClothes;
            IDAccessories = idAccessories;
        }
    }
}
