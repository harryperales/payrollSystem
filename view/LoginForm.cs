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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            UserControllerInterface userController = new UserController();
            User user = new User();
            user.username = username.Text;
            user.password = password.Text;
            user = userController.fetchUser(user);
            if (user == null)
            {
                password.Text = "";
                MessageBox.Show("The user you specified does not exists.");
                return;
            }
            else
            {
                password.Text = "";
                FormControllerInterface formController = new FormController();
                formController.showDashboard(this, user);
            }
        }
    }
}
