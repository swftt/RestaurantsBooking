using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantsBooking
{
    [Serializable]
    public  class UsersData
    {
        public List<BookedTables> TablesBooked { get; set; } = new List<BookedTables>();
        public User User { get; set; } = new User();
    }
}
