using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RestaurantsBooking
{
    [Serializable]
    public class User
    {
        public string Name { get; set; }
        public string  Surname { get; set; }
        public  string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
    }
}
