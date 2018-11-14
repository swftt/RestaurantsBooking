using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RestaurantsBooking
{
    public partial class FortissimoRestaurant : MetroForm
    {
        public List<Restaurant> TablesBooked { get; set; } = new List<Restaurant>();
        public UsersData CurrentUser { get; set; } = new UsersData();
        public FortissimoRestaurant()
        {
            InitializeComponent();
        }
        public FortissimoRestaurant(UsersData currUser, List<Restaurant> tablesBooked)
        {
            TablesBooked = tablesBooked;
            CurrentUser = currUser;
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TablesBooked.Count; i++)
            {
                if (TablesBooked[i].Title.CompareTo("Fortissimo") == 0)
                {
                    if (TablesBooked[i].AreTablesBooked[0] == false)
                    {
                        TablesBooked[i].AreTablesBooked[0] = true;
                        CurrentUser.TablesBooked.Add(new Restaurant { Title = "Fortissimo", AreTablesBooked = new bool[10] { true, false, false, false, false, false, false, false, false, false } });
                        MetroFramework.MetroMessageBox.Show(this, "Table is successfully booked");
                        break;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this,"Table is already booked");
                    }
                }
            }
        }

        private void FortissimoRestaurant_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<UsersData> tmpUsers = new List<UsersData>();
            List<UsersData> usersData = new List<UsersData>();
            XmlSerializer formatter = new XmlSerializer(typeof(List<UsersData>));
            using (FileStream fs = new FileStream("UsersData.xml", FileMode.Open))
            {
                usersData = formatter.Deserialize(fs) as List<UsersData>;
            }
            for (int i = 0; i < usersData.Count; i++)
            {
                if (usersData[i].User.Login.CompareTo(CurrentUser.User.Name) == 0 && usersData[i].User.Login.CompareTo(CurrentUser.User.Login) == 0)
                {
                    usersData.Remove(usersData[i]);
                    break;
                }

            }
            usersData.Add(CurrentUser);
            File.Delete(@"C:\Users\Dell\source\repos\RestaurantsBooking\RestaurantsBooking\bin\Debug\UsersData.xml");
            XmlSerializer xml = new XmlSerializer(typeof(List<UsersData>));
            using (FileStream fs = new FileStream("UsersData.xml", FileMode.Create))
            {
                formatter.Serialize(fs, usersData);
            }
            File.Delete(@"C:\Users\Dell\source\repos\RestaurantsBooking\RestaurantsBooking\bin\Debug\TablesBooked.xml");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Restaurant>));
            using (FileStream fs = new FileStream("TablesBooked.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, TablesBooked);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TablesBooked.Count; i++)
            {
                if (TablesBooked[i].Title.CompareTo("Fortissimo") == 0)
                {
                    if (TablesBooked[i].AreTablesBooked[1] == false)
                    {
                        TablesBooked[i].AreTablesBooked[1] = true;
                        CurrentUser.TablesBooked.Add(new Restaurant { Title = "Fortissimo", AreTablesBooked = new bool[10] { false, true, false, false, false, false, false, false, false, false } });
                        MetroFramework.MetroMessageBox.Show(this, "Table is successfully booked");
                        break;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Table is already booked");
                    }
                }
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TablesBooked.Count; i++)
            {
                if (TablesBooked[i].Title.CompareTo("Fortissimo") == 0)
                {
                    if (TablesBooked[i].AreTablesBooked[2] == false)
                    {
                        TablesBooked[i].AreTablesBooked[2] = true;
                        CurrentUser.TablesBooked.Add(new Restaurant { Title = "Fortissimo", AreTablesBooked = new bool[10] { false, false, true, false, false, false, false, false, false, false } });
                        MetroFramework.MetroMessageBox.Show(this, "Table is successfully booked");
                        break;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Table is already booked");
                    }
                }
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TablesBooked.Count; i++)
            {
                if (TablesBooked[i].Title.CompareTo("Fortissimo") == 0)
                {
                    if (TablesBooked[i].AreTablesBooked[3] == false)
                    {
                        TablesBooked[i].AreTablesBooked[3] = true;
                        CurrentUser.TablesBooked.Add(new Restaurant { Title = "Fortissimo", AreTablesBooked = new bool[10] { false, false, false, true, false, false, false, false, false, false } });
                        MetroFramework.MetroMessageBox.Show(this, "Table is successfully booked");
                        break;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Table is already booked");
                    }
                }
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TablesBooked.Count; i++)
            {
                if (TablesBooked[i].Title.CompareTo("Fortissimo") == 0)
                {
                    if (TablesBooked[i].AreTablesBooked[4] == false)
                    {
                        TablesBooked[i].AreTablesBooked[4] = true;
                        CurrentUser.TablesBooked.Add(new Restaurant { Title = "Fortissimo", AreTablesBooked = new bool[10] { false, false, false, false, true, false, false, false, false, false } });
                        MetroFramework.MetroMessageBox.Show(this, "Table is successfully booked");
                        break;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Table is already booked");
                    }
                }
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TablesBooked.Count; i++)
            {
                if (TablesBooked[i].Title.CompareTo("Fortissimo") == 0)
                {
                    if (TablesBooked[i].AreTablesBooked[5] == false)
                    {
                        TablesBooked[i].AreTablesBooked[5] = true;
                        CurrentUser.TablesBooked.Add(new Restaurant { Title = "Fortissimo", AreTablesBooked = new bool[10] { false, false, false, false, false, true, false, false, false, false } });
                        MetroFramework.MetroMessageBox.Show(this, "Table is successfully booked");
                        break;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Table is already booked");
                    }
                }
            }
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TablesBooked.Count; i++)
            {
                if (TablesBooked[i].Title.CompareTo("Fortissimo") == 0)
                {
                    if (TablesBooked[i].AreTablesBooked[6] == false)
                    {
                        TablesBooked[i].AreTablesBooked[6] = true;
                        CurrentUser.TablesBooked.Add(new Restaurant { Title = "Fortissimo", AreTablesBooked = new bool[10] { false, false, false, false, false, false, true, false, false, false } });
                        MetroFramework.MetroMessageBox.Show(this, "Table is successfully booked");
                        break;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Table is already booked");
                    }
                }
            }
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TablesBooked.Count; i++)
            {
                if (TablesBooked[i].Title.CompareTo("Fortissimo") == 0)
                {
                    if (TablesBooked[i].AreTablesBooked[7] == false)
                    {
                        TablesBooked[i].AreTablesBooked[7] = true;
                        CurrentUser.TablesBooked.Add(new Restaurant { Title = "Fortissimo", AreTablesBooked = new bool[10] { false, false, false, false, false, false, false, true, false, false } });
                        MetroFramework.MetroMessageBox.Show(this, "Table is successfully booked");
                        break;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Table is already booked");
                    }
                }
            }
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TablesBooked.Count; i++)
            {
                if (TablesBooked[i].Title.CompareTo("Fortissimo") == 0)
                {
                    if (TablesBooked[i].AreTablesBooked[8] == false)
                    {
                        TablesBooked[i].AreTablesBooked[8] = true;
                        CurrentUser.TablesBooked.Add(new Restaurant { Title = "Fortissimo", AreTablesBooked = new bool[10] {  false, false, false, false, false, false, false, false,true, false } });
                        MetroFramework.MetroMessageBox.Show(this, "Table is successfully booked");
                        break;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Table is already booked");
                    }
                }
            }
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TablesBooked.Count; i++)
            {
                if (TablesBooked[i].Title.CompareTo("Fortissimo") == 0)
                {
                    if (TablesBooked[i].AreTablesBooked[9] == false)
                    {
                        TablesBooked[i].AreTablesBooked[9] = true;
                        CurrentUser.TablesBooked.Add(new Restaurant { Title = "Fortissimo", AreTablesBooked = new bool[10] {false, false, false, false, false, false, false, false, false ,true  } });
                        MetroFramework.MetroMessageBox.Show(this, "Table is successfully booked");
                        break;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Table is already booked\n");
                    }
                }
            }
        }

        private void FortissimoRestaurant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                Help webInfo = new Help();
                webInfo.ShowDialog();
            }
        }
    }
}

