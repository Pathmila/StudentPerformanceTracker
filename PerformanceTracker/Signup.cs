using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PerformanceTracker
{
    public partial class Signup : Form
    {
        // In-memory storage for user data
        private Dictionary<string, string> userStore;

        public Signup(Dictionary<string, string> userStore)
        {
            InitializeComponent();
            this.userStore = userStore;
        }

        private void btnSignup_click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string repassword = txtRePassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(repassword))
            {
                MessageBox.Show("All fields are mandatory. Please fill in all the fields.");
                return;
            }

            if (password != repassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                txtPassword.Clear();
                txtRePassword.Clear();
                return;
            }

            SignUp(username, password);
        }

        private void SignUp(string username, string password)
        {
            if (!userStore.ContainsKey(username))
            {
                userStore[username] = password;
                MessageBox.Show("User signed up successfully.");
                this.Close(); // Close the signup form
            }
            else
            {
                MessageBox.Show("Username already exists.");
                txtUsername.Clear();
                txtPassword.Clear();
                txtRePassword.Clear();
            }
        }
    }
}
