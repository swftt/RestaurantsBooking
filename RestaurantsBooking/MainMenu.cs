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
        public User CurrentUser { get; set; } = new User();
        public MainMenu()
        {
            InitializeComponent();
        }
        public MainMenu(User loggedUser)
        {
            CurrentUser = loggedUser;
            InitializeComponent();
        }
    }
}
