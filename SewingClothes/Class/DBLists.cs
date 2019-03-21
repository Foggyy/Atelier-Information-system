using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewingClothes.Class
{
    public static class DBLists
    {
        public static List<Accessouries> AccessouriesList { get; set; }
        public static List<Accessouries> AccessouriesListSupport { get; set; }
        public static List<ClothesProperties> ClothesPropertiesList { get; set; }
        public static List<ClothesType> ClothesTypeList { get; set; }
        public static List<Customer> CustomerList { get; set; }
        public static List<Fabric> FabricList { get; set; }
        public static List<Fabric> FabricListSupport { get; set; }
    }
}
