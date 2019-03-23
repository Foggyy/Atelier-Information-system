using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewingClothes.Class
{
    public class DataCondition
    {
        public string Field { get; set; }
        public string Condition { get; set; }
        public object Value { get; set; }
        public string Predicate { get; set; }

        public DataCondition()
        {
            Field = "";
            Condition = "";
            Value = "";
            Predicate = "";
        }

        public DataCondition(string field, string condition, object value, string predicate)
        {
            Field = field;
            Condition = condition;
            Value = value;
            Predicate = predicate;
        }
    }
}
