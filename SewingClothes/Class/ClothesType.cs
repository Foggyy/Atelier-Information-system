using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewingClothes.Class
{
    public class ClothesType
    {
        public long Id { get; set; }
        public string Purpose { get; set; }
        public string Gender { get; set; }

        public ClothesType()
        {
            Id = 0;
            Purpose = "";
            Gender = "";
        }

        public ClothesType(long id, string purpose, string gender)
        {
            Id = id;
            Purpose = purpose;
            Gender = gender;
        }
    }
}
