using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewingClothes.Class
{
    public class Order
    {
        public long Id { get; set; }
        public string Date { get; set; }
        public long TotalCost { get; set; }
        public int IdPayment { get; set; }
        public long IdDelivery { get; set; }
        public long IdClothes { get; set; }

        public Order()
        {
            Id = 0;
            Date = "";
            TotalCost = 0;
            IdPayment = 0;
            IdDelivery = 0;
            IdClothes = 0;
        }
        public Order(long id, string date, long totalCost, int idPayment, int idDelivery, long idClothes)
        {
            Id = id;
            Date = date;
            TotalCost = totalCost;
            IdPayment = idPayment;
            IdDelivery = idDelivery;
            IdClothes = idClothes;
        }

    }
}
