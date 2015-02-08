using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PayrollSystem.controller;
using PayrollSystem.model;

namespace PayrollSystem.view
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void viewUsers_Click(object sender, EventArgs e)
        {
            UserControllerInterface userController = new UserController();
            foreach (User user in userController.viewAllUsers())
            {
                Console.WriteLine(user.username);
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.password.Text;
            string confirmPassword = this.confirmPassword.Text;

            if (password != confirmPassword)
            {
                this.confirmPassword.Text = "";
                this.password.Text = "";
                MessageBox.Show("Passwords did not matched.");
                return;
            }
            User user = new User();
            user.username = username;
            user.password = password;
            UserControllerInterface userController = new UserController();
            if (userController.addUser(user).id > 0)
            {
                this.username.Text = "";
                this.password.Text = "";
                MessageBox.Show("New user added successfully.");
            }
            else
            {
                MessageBox.Show("Something went wrong, Please contact the admin.");
            }
        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.password.Text;
            string confirmPassword = this.confirmPassword.Text;

            if (password != confirmPassword)
            {
                this.confirmPassword.Text = "";
                this.password.Text = "";
                MessageBox.Show("Passwords did not matched.");
                return;
            }

            UserControllerInterface userController = new UserController();
            User user = new User();
            user.username = username;
            user.password = password;
            user = userController.fetchUser(user);
            if (user != null)
            {
                UpdateUserForm updateUser = new UpdateUserForm(this, user);
                this.confirmPassword.Text = "";
                this.password.Text = "";
                this.Hide();
                updateUser.ShowDialog();
            }
            else
            {
                MessageBox.Show("User does not exists.");
                this.confirmPassword.Text = "";
                this.password.Text = "";
            }
            

        }
    }
}
