using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewingClothes.Class
{
    public class ClothesProperties
    {
        public int Id { get; set; }
        public string Size { get; set; }

        public ClothesProperties()
        {
            Id = 0;
            Size = "";
        }
        public ClothesProperties(int id, string size)
        {
            Id = id;
            Size = size;
        }
    }
}
