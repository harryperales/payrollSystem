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
            loadPayrollList();
            loadPendingRequests();
            loadApprovedRequests();
            hideErrorMessage();
            initializeDatePicker();
            hideSpinner();
        }

        private void loadPayrollList()
        {
            PayrollControllerInterface payrollController = new PayrollController();
            List<Payslip> payroll = payrollController.fetchPayroll();
            payrollListBox.Items.Clear();
            foreach (Payslip payslip in payroll)
            {
                payrollListBox.Items.Add(payslip.id + ".)" + payslip.startDatePeriod.ToString("MM/dd/yyyy") + " - " + payslip.endDatePeriod.ToString("MM/dd/yyyy") + " | " + payslip.employee.userAccount.username);
            }
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
            pendingRequestListBox.Items.Clear();
            foreach (Request request in requests)
            {
                pendingRequestListBox.Items.Add(request.id+".) "+request.dateFiled.ToString("MM/dd/yyyy") + "|(" + request.employee.employeeId + ")|" + request.employee.fullName.Split(',')[0] + " | " + request.name);
            }
        }

        public void loadApprovedRequests()
        {
            RequestControllerInterface requestController = new RequestController();
            List<Request> requests = requestController.fetchAllApprovedRequests();
            approvedRequestListBox.Items.Clear();
            foreach (Request request in requests)
            {
                approvedRequestListBox.Items.Add(request.id + ".) " + request.dateFiled.ToString("MM/dd/yyyy") + "|(" + request.employee.employeeId + ")|" + request.employee.fullName.Split(',')[0] + " | " + request.name);
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
            if (employee != null && !employee.ToString().Equals(""))
            {
                FormControllerInterface formController = new FormController();
                formController.showEmployeeForm(this, employee);
            }
            else
            {
                showErrorMessage("The user you specified does not exists.");
            }

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
            spinnerPictureBox.Visible = true;
        }

        private void createPayrollButton_Click(object sender, EventArgs e)
        {

            TimeSpan validDate = endDatePeriod.Value - startDatePeriod.Value;
            if (validDate <= fetchValidDateDuration())
            {
                showErrorMessage("Invalid period.");
                return;
            }
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
                Payslip payslip = payslipController.createPayslip(startDatePeriod.Value, endDatePeriod.Value, employee);
                if (thirteenMonthPayCheckBox.Checked)
                {
                    payslipController.addThirteenMonthPayToPayslip(employee, payslip);
                }
                hideSpinner();
                loadPayrollList();
                adminTab.SelectedTab = payrollTab;
                showErrorMessage("Successfully created payroll to user: "+ employee.userAccount.username);
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
                loadPayrollList();
                adminTab.SelectedTab = payrollTab;
                showErrorMessage("Successfully create payroll to all users");
            }
        }

        private static TimeSpan fetchValidDateDuration()
        {
            return new TimeSpan(23, 59, 59);
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

        private void viewPayslipButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (payrollListBox.SelectedIndex != -1)
                {
                    int payslipId = Convert.ToInt32(payrollListBox.SelectedItem.ToString().Split('.')[0]);
                    PayrollControllerInterface payrollController = new PayrollController();
                    Payslip payslip = payrollController.fetchPayslipById(payslipId);

                    EmployeeControllerInterface employeeController = new EmployeeController();
                    payslip.employee = employeeController.fetchEmployeeById(payslip.employee.id);

                    FormControllerInterface formController = new FormController();
                    formController.showUserPayroll(this, payslip);
                }
                else
                {
                    showErrorMessage("Please select a record to view.");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("No item selected: " + ex.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            usersListBox.Items.Clear();
            long employeeId = 0;
            EmployeeControllerInterface employeeController = new EmployeeController();
            try
            {
                employeeId = Int64.Parse(usernameOrEmployeeId.Text);
                Employee employee = employeeController.fetchEmployeeByEmployeeIdNumber(employeeId);
                if (employee != null && !employee.Equals(""))
                {
                    List<User> users = new List<User>();
                    users.Add(employee.userAccount);
                    foreach (User user in users)
                    {
                        if (user.role.type != "admin")
                        {
                            usersListBox.Items.Add(user.username);
                        }
                    }
                }
                else
                {
                    showErrorMessage("User does not exist.");
                }
            }
            catch ( FormatException ex)
            {
                UserControllerInterface userController = new UserController();
                User searchedUser = new User();
                searchedUser.username = usernameOrEmployeeId.Text;
                List<User> users = new List<User>();
                searchedUser = userController.fetchUserByUsername(searchedUser);
                if (searchedUser != null && !searchedUser.Equals(""))
                {
                    users.Add(searchedUser);
                    foreach (User user in users)
                    {
                        if (user.role.type != "admin")
                        {
                            usersListBox.Items.Add(user.username);
                        }
                    }
                }
                else
                {
                    showErrorMessage("User does not exist.");
                }
            }
        }

        private void resetLeaveCreditsButton_Click(object sender, EventArgs e)
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
                LeaveCreditsControllerInteface leaveCreditsController = new LeaveCreditsController();
                EmployeeLeaveCredits employeeLeaveCredits = leaveCreditsController.resetEmployeeLeaveCredits(employee);
                hideSpinner();
                showErrorMessage("Successfully created payroll to user: " + employee.userAccount.username);
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

        private void viewPayrollSheetDataGridButton_Click(object sender, EventArgs e)
        {
            FormControllerInterface formController = new FormController();
            formController.showPayrollSheet();
        }
    }
}
