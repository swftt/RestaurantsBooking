using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RestaurantsBooking
{
    public partial class LoginMenu : MetroForm
    {
        public List<UsersData> UsersData { get; set; } = new List<UsersData>();
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(metroTextBox1.Text) && string.IsNullOrEmpty(metroTextBox2.Text))
            {
                var regWindow = new Registration();
                regWindow.ShowDialog(this);

            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(metroTextBox1.Text) && !string.IsNullOrEmpty(metroTextBox2.Text))
            {
                if (File.Exists(@"C:\Users\Dell\source\repos\RestaurantsBooking\RestaurantsBooking\bin\Debug\UsersData.xml"))
                {
                    UsersData DataOfUser = new UsersData();
                    XmlSerializer formatter = new XmlSerializer(typeof(List<UsersData>));
                    using (FileStream fs = new FileStream("UsersData.xml", FileMode.Open))
                    {
                        UsersData = formatter.Deserialize(fs) as List<UsersData>;
                    }
                    foreach (var userInfo in UsersData)
                    {
                        if (userInfo.User.Login.CompareTo(metroTextBox1.Text) == 0 && userInfo.User.Password.CompareTo(metroTextBox2.Text) == 0)
                        {
                            DataOfUser = userInfo;
                            count++;
                        }
                    }
                    if (count > 0)
                    {
                        if (!File.Exists(@"C:\Users\Dell\source\repos\RestaurantsBooking\RestaurantsBooking\bin\Debug\TablesBooked.xml"))
                        {
                            List<Restaurant> bookedTables = new List<Restaurant>
                            {
                                {new Restaurant
                                    {
                                    Title ="Fortissimo",
                                    AreTablesBooked =new bool[10]
                                     {
                                        false,false,false,false,false,false,false,false,false,false}
                                    }

                                },
                                {
                                    new Restaurant
                                    {
                                        Title="Bazikalo",
                                        AreTablesBooked=new bool[12]
                                        {
                                             false,false,false,false,false,false,false,false,false,false,false,false
                                        }
                                    }
                                },
                                {  new Restaurant
                                    {
                                        Title="Le Chalot",
                                        AreTablesBooked=new bool[10]
                                        {
                                             false,false,false,false,false,false,false,false,false,false
                                        }
                                    }
                                },
                                 {  new Restaurant
                                    {
                                        Title="Catarsys",
                                        AreTablesBooked=new bool[15]
                                        {
                                        false,false,false,false,false,false,false,false,
                                            false,false,false,false,false,false,false
                                        }
                                    }
                                }
                            };
                            XmlSerializer xml = new XmlSerializer(typeof(List<Restaurant>));
                            using (FileStream fs = new FileStream("TablesBooked.xml", FileMode.Create))
                            {
                                xml.Serialize(fs, bookedTables);
                            }
                            var mainMenu = new MainMenu(DataOfUser, bookedTables);
                            mainMenu.ShowDialog(this);
                            UsersData.Clear();
                        }
                        else
                        {
                            List<Restaurant> bookedTables = new List<Restaurant>();
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Restaurant>));
                            using (FileStream fs = new FileStream("TablesBooked.xml", FileMode.Open))
                            {
                                bookedTables = xmlSerializer.Deserialize(fs) as List<Restaurant>;
                            }
                            var mainMenu = new MainMenu(DataOfUser, bookedTables);
                            mainMenu.ShowDialog(this);
                            UsersData.Clear();
                        }

                    }
                    else
                    {
                        MessageBox.Show("There is no such registered user");
                    }
                }
                else
                {
                    MessageBox.Show("There is no registered users");
                }
            }
            else
            {
                MessageBox.Show("You have to write login or password");
            }
        }
    }
}
