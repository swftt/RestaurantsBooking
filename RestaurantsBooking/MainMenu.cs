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

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string bookedInfoStr = String.Empty;
            if (CurrentUser.TablesBooked.Count != 0)
            {
                foreach (var booked in CurrentUser.TablesBooked)
                {
                    bookedInfoStr += "Restaurant: " + booked.Title;
                    foreach (var item in booked.AreTablesBooked)
                    {
                        if(item)
                        {
                            bookedInfoStr += "Table №" + booked.AreTablesBooked.ToList().IndexOf(item)+1;
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
    }
}
