using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewingClothes.Class
{
    public class Payment
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public Payment()
        {
            Id = 0;
            Type = "";
        }

        public Payment(int id, string type)
        {
            Id = id;
            Type = type;
        }
    }
}
