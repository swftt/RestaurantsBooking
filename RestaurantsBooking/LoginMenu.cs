using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RestaurantsBooking
{
    public partial class LoginMenu : MetroForm
    {
        public List<User> Users { get; set; } = new List<User>();
        public User LoggedUser { get; set; } = new User();
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
            if(!string.IsNullOrEmpty(metroTextBox1.Text)&& !string.IsNullOrEmpty(metroTextBox2.Text))
            {
                if (File.Exists(@"C:\Users\Dell\source\repos\RestaurantsBooking\RestaurantsBooking\bin\Debug\Users.xml"))
                {
                    XmlSerializer formatter = new XmlSerializer(typeof(List<User>));
                    using (FileStream fs = new FileStream("Users.xml", FileMode.Open))
                    {
                        Users = formatter.Deserialize(fs) as List<User>;
                    }

                    //using (FileStream fs = new FileStream("Users.xml", FileMode.Create))
                    //{
                    //    formatter.Serialize(fs, Users);
                    //}
                    foreach (var user in Users)
                    {
                        if(user.Login.CompareTo(metroTextBox1.Text)==0&&user.Password.CompareTo(metroTextBox2.Text)==0)
                        {
                            LoggedUser = user;
                            count++;
                        }
                        
                    }
                    if(count>0)
                    {
                        var mainMenu = new MainMenu(LoggedUser);
                        mainMenu.ShowDialog(this);
                        Users.Clear();
                    }
                    else
                    {
                        MessageBox.Show("There is no registered user");
                    }
                }

                //else
                //{
                //    XmlSerializer formatter = new XmlSerializer(typeof(List<User>));
                //    Users.Add(User);
                //    using (FileStream fs = new FileStream("Users.xml", FileMode.Create))
                //    {
                //        formatter.Serialize(fs, Users);
                //    }
                //}
            }
            else
            {
                MessageBox.Show("You have to write login or password");
            }
        }
    }
}
