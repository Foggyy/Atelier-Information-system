using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewingClothes.Class
{
    public static class DBBuf
    {
        public static Accessouries AccessouriesBuf { get; set; }
        public static List<Accessouries> AccessouriesBufList { get; set; }
        public static Clothes ClothesBuf { get; set; }
        public static ClothesProperties ClothesPropertiesBuf { get; set; }
        public static ClothesType ClothesTypeBuf { get; set; }
        public static Customer CustomerBuf { get; set; }
        public static Delivery DeliveryBuf { get; set; }
        public static Fabric FabricBuf { get; set; }
        public static Order OrderBuf { get; set; }
        public static Payment PaymentBuf { get; set; }

        public static long AmountFabric { get; set; }

    }
}
