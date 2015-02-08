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
    public partial class AdminDashBoard : Form
    {
        private LoginForm loginForm;
        private User user;
        public AdminDashBoard(LoginForm loginForm, User user)
        {
            this.loginForm = loginForm;
            this.user = user;
            InitializeComponent();
            loadUsers();
            initializeDatePicker();
        }

        private void initializeDatePicker()
        {
            startDatePeriod.Format = DateTimePickerFormat.Custom;
            startDatePeriod.CustomFormat = "MMM dd, yyyy";
            startDatePeriod.Value = DateTime.Now.AddDays(-16);

            endDatePeriod.Format = DateTimePickerFormat.Custom;
            endDatePeriod.CustomFormat = "MMM dd, yyyy";
            endDatePeriod.Value = DateTime.Now.AddDays(-1);
        }

        public void loadUsers()
        {
            usersListBox.Items.Clear();
            UserControllerInterface userController = new UserController();
            List<User> users = userController.viewAllUsers();
            foreach (User user in users)
            {
                usersListBox.Items.Add(user.username);
            }
        }

        private void usersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                usersListBox.SelectedIndex = l.SelectedIndex;
                usernameOrEmployeeId.Text = usersListBox.SelectedItem.ToString();
                Console.WriteLine(usersListBox.SelectedItem.ToString());
            }
        }

        private void AdminDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormControllerInterface formController = new FormController();
            formController.showLoginWindow(loginForm);
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            FormControllerInterface formController = new FormController();
            formController.showEmployeeForm(this);
        }

        private void updateEmployeeInfoButton_Click(object sender, EventArgs e)
        {
            EmployeeControllerInterface employeeController = new EmployeeController();
            Employee employee = employeeController.fetchEmployeeByUsername(usernameOrEmployeeId.Text);

            FormControllerInterface formController = new FormController();
            formController.showEmployeeForm(this, employee);

        }

        private void updateUserPasswordButton_Click(object sender, EventArgs e)
        {
            UserControllerInterface userController = new UserController();
            User user = new User();
            user.username = usernameOrEmployeeId.Text;
            user = userController.fetchUserByUsername(user);
            if (user == null)
            {
                MessageBox.Show("The user you specified does not exists.");
                return;
            }
            else
            {
                FormControllerInterface formController = new FormController();
                formController.showUpdateUserForm(this, user);
            }
        }

        private void createPayrollButton_Click(object sender, EventArgs e)
        {
            EmployeeControllerInterface employeeController = new EmployeeController();
            Employee employee = employeeController.fetchEmployeeByUsername(usernameOrEmployeeId.Text);

            PayrollControllerInterface payslipController = new PayrollController();
            payslipController.createPayslip(startDatePeriod.Value, endDatePeriod.Value, employee);
        }
    }
}
