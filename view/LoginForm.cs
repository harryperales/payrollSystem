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
        TimeInOutForm timeInOutForm;
        public LoginForm(TimeInOutForm timeInOutForm)
        {
            this.timeInOutForm = timeInOutForm;
            InitializeComponent();
            hideErrorMessage();
        }

        private void hideErrorMessage()
        {
            errorMessageLabel.Visible = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            UserControllerInterface userController = new UserController();
            User user = new User();
            user.username = username.Text;
            user.password = password.Text;
            user = userController.fetchUser(user);
            if (user == null || user.status == AccountStatus.Disable)
            {
                password.Text = "";
                showErrorMessage("The user you specified does not exists.");
                return;
            }
            else
            {
                password.Text = "";
                hideErrorMessage();
                FormControllerInterface formController = new FormController();
                formController.showDashboard(this, user);
            }
        }

        private void showErrorMessage(string errorMessage)
        {
            errorMessageLabel.Text = errorMessage;
            errorMessageLabel.Visible = true;
        }

        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {
            hideErrorMessage();
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            FormControllerInterface formController = new FormController();
            formController.closeLoginForm(this, timeInOutForm);
        }
    }
}
