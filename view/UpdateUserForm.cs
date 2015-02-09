using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PayrollSystem.model;
using PayrollSystem.controller;

namespace PayrollSystem.view
{
    public partial class UpdateUserForm : Form
    {
        private IndexForm indexForm;
        private User user;
        private AdminDashBoard adminDashboard;

        public UpdateUserForm(IndexForm index, User user)
        {
            indexForm = index;
            this.user = user;
            InitializeComponent();
        }

        public UpdateUserForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }
        public UpdateUserForm(AdminDashBoard adminDashboard, User user)
        {
            this.adminDashboard = adminDashboard;
            this.user = user;
            InitializeComponent();
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdateUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //indexForm.Show();
        }

        private void clearButon_Click(object sender, EventArgs e)
        {
            password.Text = "";
            confirmPassword.Text = "";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
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
            user.password = password;
            if (userController.updateUser(user) != null)
            {
                MessageBox.Show("Password successfully updated.");
                FormControllerInterface formController = new FormController();
                formController.showAdminDashBoard(adminDashboard, this);
            }
            else
            {
                MessageBox.Show("Something went wrong, please contact your administrator.");
            }
        }
    }
}
