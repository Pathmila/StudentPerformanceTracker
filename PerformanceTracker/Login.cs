using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PerformanceTracker
{
    public partial class Login : Form
    {
        private Dictionary<string, string> userStore = new Dictionary<string, string>();

        public Login()
        {
            InitializeComponent();
        }

        private void createAccount_click(object sender, EventArgs e)
        {
            Signup signup = new Signup(userStore);
            signup.FormClosed += (s, args) => this.Show(); // Show the login form when signup form is closed
            signup.Show();
            this.Hide(); // Hide the login form
        }

        private void btnlogin_click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("All fields are mandatory. Please fill in both username and password.");
                return;
            }

            if (SignIn(username, password))
            {
                MessageBox.Show("Login successful.");
                Home home = new Home(userStore, username);
                home.Show();
                this.Hide(); // Hide the login form
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private bool SignIn(string username, string password)
        {
            return userStore.ContainsKey(username) && userStore[username] == password;
        }

        private void lblTitleLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
