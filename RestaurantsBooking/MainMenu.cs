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
    public partial class MainMenu : MetroForm
    {
        public List<Restaurant> TablesBooked { get; set; } = new List<Restaurant>();
        public UsersData CurrentUser { get; set; } =new UsersData();
        public MainMenu()
        {
            InitializeComponent();
        }
        public MainMenu(UsersData loggedUser,List<Restaurant> bookedTables)
        {
            CurrentUser = loggedUser;
            TablesBooked = bookedTables;
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var bookingMap = new BookingMap(CurrentUser, TablesBooked);
            bookingMap.ShowDialog(this);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string bookedInfoStr = String.Empty;
            if (CurrentUser.TablesBooked.Count != 0)
            {
                foreach (var booked in CurrentUser.TablesBooked)
                {
                    bookedInfoStr += "Restaurant: " + booked.Title;
                    foreach (var item in booked.AreTablesBooked)
                    {
                        counter++;
                        if(item)
                        {
                            bookedInfoStr += "  Table №" + counter+"\n";
                            counter = 0;
                            break;
                        }
                    }
                }
                MessageBox.Show(bookedInfoStr);
            }
            else
            {
                MessageBox.Show("You have no booked tables");
            }
        }

        private void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                Help webInfo = new Help();
                webInfo.ShowDialog();
            }
        }
    }
}
