using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Toc_Toe_game
{
    public partial class login : Form
    {
        private List<User> users = new List<User>()
        {
            new User("user1", "password1"),
            new User("user2", "password2"),
            new User("user3", "password3")
        };
        public login()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text;
            string password = textBoxPassword.Text;

            // Check if the username and password are correct
            User user = users.Find(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                MessageBox.Show("Login successful!");
                Hide();
                FormXO f = new FormXO();
                f.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }
    }
}
