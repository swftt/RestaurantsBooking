﻿using MetroFramework.Forms;
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
    public partial class BookTables : MetroForm
    {
        public BookTables()
        {
            InitializeComponent();
        }

        private void BookTables_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                Help webInfo = new Help();
                webInfo.ShowDialog();
            }
        }
    }
}
