using System;

namespace RestaurantsBooking
{
    [Serializable]
    public class BookedTables
    {
        public Restaurant AnyRestaurant { get; set; } = new Restaurant();
        public string TimeBooked { get; set; }
    }
}
