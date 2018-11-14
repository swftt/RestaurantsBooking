using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantsBooking
{
    public partial class BookingMap : MetroForm
    {
        public List<Restaurant> TablesBooked { get; set; } = new List<Restaurant>();
        public UsersData CurrentUser { get; set; } = new UsersData();
        public BookingMap()
        {
            InitializeComponent();
        }
        public BookingMap(UsersData currUser, List<Restaurant> tablesBooked)
        {
            TablesBooked = tablesBooked;
            CurrentUser = currUser;
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var fortissimoRest = new FortissimoRestaurant(CurrentUser, TablesBooked);
            fortissimoRest.ShowDialog(this);
        }

        private void BookingMap_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F6)
            {
                Help webInfo = new Help();
                webInfo.ShowDialog();
            }
        }
    }
}
