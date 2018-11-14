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
        public User CurrentUser { get; set; } = new User();
        public MainMenu()
        {
            InitializeComponent();
        }
        public MainMenu(User loggedUser,List<Restaurant> bookedTables)
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
            foreach (var user in TablesBooked)
            {
               
            }
        }
    }
}
