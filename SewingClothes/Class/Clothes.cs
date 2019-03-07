using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewingClothes.Class
{
    public class Clothes
    {
        public long Id { get; set; }
        public int Amount { get; set; }
        public int Cost { get; set; }
        public long IdClothesType { get; set; }
        public int IdClothesProperties { get; set; }
        public long IdFabric { get; set; }

        public Clothes()
        {
            Id = 0;
            Amount = 0;
            Cost = 0;
            IdClothesProperties = 0;
            IdClothesType = 0;
            IdFabric = 0;
        }

        public Clothes(long id, int amount, int cost, long idClothesType, int idClothesProperties, long idFabric)
        {
            Id = id;
            Amount = amount;
            Cost = cost;
            IdClothesType = idClothesType;
            IdClothesProperties = idClothesProperties;
            IdFabric = idFabric;
        }
    }
}
