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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void help_Load(object sender, EventArgs e)
        {
            webBrowser1.Url =new Uri((Application.StartupPath + "\\Help.html")); 
        }
    }
}
