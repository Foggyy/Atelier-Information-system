using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewingClothes.Class
{
    public class Customer
    {
        public long Id { get; set; }
        public string FIO { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public long IdOrder { get; set; }

        public Customer()
        {
            Id = 0;
            FIO = "";
            Address = "";
            PhoneNumber = 0;
            Email = "";
            IdOrder = 0;
        }

        public Customer(long id, string fio, string address, long phoneNumber, string email, long idOrder)
        {
            Id = id;
            FIO = fio;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            IdOrder = idOrder;
        }
    }
}
