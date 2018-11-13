using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace RestaurantsBooking
{
    public partial class Registration : MetroForm
    {
        public User User { get; set; } = new User();
        public List<User> Users { get; set; } = new List<User>();
        public Registration()
        {
            InitializeComponent();
            
        }
        private void metroTextBox1_Enter(object sender, EventArgs e)
        {

           metroButton1.Enabled = false;
           metroTextBox2.ReadOnly = true;
           metroTextBox3.ReadOnly = true;
           metroTextBox4.ReadOnly = true;
           metroTextBox5.ReadOnly = true;
        }
        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(metroTextBox1.Text))
            {
                metroTextBox2.ReadOnly = false;
                User.Login = metroTextBox1.Text;
            }
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(metroTextBox2.Text))
            {
                metroTextBox3.ReadOnly = false;
                User.Password = metroTextBox2.Text;
            }
        }

        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^\p{Lu}[a-z]{1,9}$";
            if (Regex.IsMatch(metroTextBox3.Text, pattern))
            {
                metroTextBox4.ReadOnly = false;
                User.Name = metroTextBox3.Text;

            }
            else
            {
                metroTextBox4.ReadOnly = true;
            }
        }

        private void metroTextBox4_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^\p{Lu}[a-z]{1,9}$";
            if (Regex.IsMatch(metroTextBox3.Text, pattern))
            {
                metroTextBox5.ReadOnly = false;
                User.Surname = metroTextBox4.Text;
            }
            else
            {
                metroTextBox5.ReadOnly = true;
            }
        }

        private void metroTextBox5_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[0-9]+$";
            if (!Regex.IsMatch(metroTextBox5.Text, pattern))
            {
                MessageBox.Show("Enter valid phone number,it`s requied for call back" +
                    "Ex: 3809812312323");
            }
            else
            {
                User.PhoneNumber = metroTextBox5.Text;
                if (!(string.IsNullOrEmpty(metroTextBox1.Text) && string.IsNullOrEmpty(metroTextBox2.Text) && string.IsNullOrEmpty(metroTextBox3.Text) && string.IsNullOrEmpty(metroTextBox4.Text) && string.IsNullOrEmpty(metroTextBox5.Text)))
                {
                    metroButton1.Enabled = true;
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Users\Dell\source\repos\RestaurantsBooking\RestaurantsBooking\bin\Debug\Users.xml"))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<User>));
                using (FileStream fs = new FileStream("Users.xml", FileMode.Open))
                {
                    Users = formatter.Deserialize(fs) as List<User>;
                }
                Users.Add(User);
                using (FileStream fs = new FileStream("Users.xml", FileMode.Create))
                {
                    formatter.Serialize(fs, Users);
                }
            }
            else
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<User>));
                Users.Add(User);
                using (FileStream fs = new FileStream("Users.xml", FileMode.Create))
                {
                    formatter.Serialize(fs, Users);
                }
            }
            ActiveForm.Close();
                

            
        }
    }
}
