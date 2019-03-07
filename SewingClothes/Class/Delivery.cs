using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewingClothes.Class
{
    public class Delivery
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public string Cost { get; set; }
        public string DeliveryTime { get; set; }

        public Delivery()
        {
            Type = "";
            Cost = "";
            DeliveryTime = "";
        }

        public Delivery(long id, string type, string cost, string deliveryTime)
        {
            Id = id;
            Type = type;
            Cost = cost;
            DeliveryTime = deliveryTime;

        }
    }
}
