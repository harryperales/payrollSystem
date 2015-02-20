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
            loadPendingRequests();
            loadApprovedRequests();
            hideErrorMessage();
            initializeDatePicker();
            hideSpinner();
        }

        private void hideErrorMessage()
        {
            errorMessageLabel.Visible = false;
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
                if (user.role.type != "admin")
                {
                    usersListBox.Items.Add(user.username);
                }
            }
        }

        public void loadPendingRequests()
        {
            RequestControllerInterface requestController = new RequestController();
            List<Request> requests = requestController.fetchAllPendingRequests();
            foreach (Request request in requests)
            {
                pendingRequestListBox.Items.Add(request.id+".) "+request.dateRequested.ToString("MM/dd/yyyy") + "|(" + request.employee.employeeId + ")|" + request.employee.fullName.Split(',')[0]);
            }
        }

        public void loadApprovedRequests()
        {
            RequestControllerInterface requestController = new RequestController();
            List<Request> requests = requestController.fetchAllApprovedRequests();
            foreach (Request request in requests)
            {
                Console.WriteLine("request:"+request.name);
                approvedRequestListBox.Items.Add(request.id + ".) " + request.dateRequested.ToString("MM/dd/yyyy") + "|(" + request.employee.employeeId + ")|" + request.employee.fullName.Split(',')[0]);
            }
        }

        private void usersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                usersListBox.SelectedIndex = l.SelectedIndex;
                usernameOrEmployeeId.Text = usersListBox.SelectedItem.ToString();
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
            if (usernameOrEmployeeId.Equals(""))
            {
                showErrorMessage("Please input a valid username");
                return;
            }
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
                showErrorMessage("The user you specified does not exists.");
                return;
            }
            else
            {
                FormControllerInterface formController = new FormController();
                formController.showUpdateUserForm(this, user);
            }
        }

        private void hideSpinner()
        {
            spinnerPictureBox.Visible = false;
        }

        private void showSpinner()
        {
            spinnerPictureBox.Visible = false;
        }

        private void createPayrollButton_Click(object sender, EventArgs e)
        {
            showSpinner();
            hideErrorMessage();
            if (!selectAllCheckBox.Checked)
            {
                EmployeeControllerInterface employeeController = new EmployeeController();
                Employee employee = employeeController.fetchEmployeeByUsername(usernameOrEmployeeId.Text);

                if (employee == null || employee.Equals(""))
                {
                    hideSpinner();
                    showErrorMessage("Please input a valid username.");
                    return;
                }

                PayrollControllerInterface payslipController = new PayrollController();
                payslipController.createPayslip(startDatePeriod.Value, endDatePeriod.Value, employee);
                hideSpinner();
                showErrorMessage("Successfully create payroll to user: "+ employee.userAccount.username);
            }
            else
            {
                
                UserControllerInterface userController = new UserController();
                List<User> users = userController.viewAllUsers();
                foreach (User user in users)
                {
                    if (user.role.type != "admin")
                    {

                        EmployeeControllerInterface employeeController = new EmployeeController();
                        Employee employee = employeeController.fetchEmployeeByUsername(user.username);

                        if (employee == null || employee.Equals(""))
                        {
                            hideSpinner();
                            showErrorMessage("Please input a valid username.");
                            return;
                        }

                        PayrollControllerInterface payslipController = new PayrollController();
                        payslipController.createPayslip(startDatePeriod.Value, endDatePeriod.Value, employee);
                    }
                }
                selectAllCheckBox.Checked = false;
                hideSpinner();
                showErrorMessage("Successfully create payroll to all users");
            }
        }

        private void addPositionButton_Click(object sender, EventArgs e)
        {
            FormControllerInterface formController = new FormController();
            formController.showPositionForm(this);
        }

        private void createMiscButton_Click(object sender, EventArgs e)
        {
            FormControllerInterface formController = new FormController();
            formController.showMiscForm(this);
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            FormControllerInterface formController = new FormController();
            formController.showLoginWindow(this, loginForm);
        }

        private void showErrorMessage(string errorMessage)
        {
            errorMessageLabel.Text = errorMessage;
            errorMessageLabel.Visible = true;
        }

        private void viewRequest_Click(object sender, EventArgs e)
        {
            string selectedId ="";
            try
            {
                Console.WriteLine(approvedRequestListBox.SelectedIndex);
                Console.WriteLine(pendingRequestListBox.SelectedIndex);
                if (pendingRequestListBox.SelectedIndex != -1)
                {
                    selectedId = pendingRequestListBox.SelectedItem.ToString().Split('.')[0];
                }
                else if(approvedRequestListBox.SelectedIndex != -1)
                {
                    selectedId = approvedRequestListBox.SelectedItem.ToString().Split('.')[0];
                }
                int requestId = Convert.ToInt32(selectedId);
                FormControllerInterface formController = new FormController();
                formController.showRequestFormById(this, requestId);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("No selected item: " + ex.Message);
            }
        }
    }
}
