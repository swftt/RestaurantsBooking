using System;

namespace RestaurantsBooking
{
    [Serializable]
    public class Restaurant
    {
        
        public string Title { get; set; }
        public bool[] AreTablesBooked { get; set; }
    }
}
