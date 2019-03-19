using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewingClothes.Class
{
    public class Accessouries
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public string Position { get; set; }
        public long Amount { get; set; }
        public long CostPerUnit { get; set; }
        public string ImagePath { get; set; }

        public Accessouries()
        {
            Id = 0;
            Type = "";
            Position = "";
            Amount = 0;
            CostPerUnit = 0;
            ImagePath = "";
        }

        public Accessouries(long id, string type, string position, long amount, long costPerUnit, string imagePath)
        {
            Id = id;
            Type = type;
            Position = position;
            Amount = amount;
            CostPerUnit = costPerUnit;
            ImagePath = imagePath;
        }
    }
}
