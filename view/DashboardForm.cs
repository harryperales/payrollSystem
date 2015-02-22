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
    public partial class DashboardForm : Form
    {
        LoginForm login;
        User user;
        public DashboardForm(LoginForm login, User user)
        {
            this.login = login;
            this.user = user;
            InitializeComponent();
            username.Text = user.username;
            loadPayrollList();
            loadAttendanceHistory();
            loadUserCurrentAttendance();
            hideErrorMessage();
            initializeRequestTab();
            loadPendingRequest();
            loadApprovedRequest();
            loadEmployeeLeaveCredits();
        }

        private void initializeRequestTab()
        {
            EmployeeControllerInterface employeeController = new EmployeeController();
            Employee employee = employeeController.fetchEmployeeByUsername(user.username);
            idNumber.Text = employee.employeeId.ToString();
            employeeName.Text = employee.fullName;
            employeeNumber.Text = employee.employeeId.ToString();
            dateFiled.Text = DateTime.Now.ToString("MM/dd/yyyy ddd");
        }

        private void hideErrorMessage()
        {
            errorMessageLabel.Visible = false;
        }

        private void initializeDatePicker()
        {
            dateOfLeave.Format = DateTimePickerFormat.Custom;
            dateOfLeave.CustomFormat = "MMM dd, yyyy";
            dateOfLeave.Value = DateTime.Now;
        }

        private void loadEmployeeLeaveCredits()
        {
            EmployeeControllerInterface employeeController = new EmployeeController();
            Employee employee = employeeController.fetchEmployeeByUsername(user.username);
            LeaveCreditsControllerInteface leaveCreditsController = new LeaveCreditsController();
            LeaveCredits leaveCredits = leaveCreditsController.fetchLeaveCreditsByEmployee(employee);
            vacationLeave.Text = leaveCredits.vacationLeaveCredits.ToString();
            sickLeave.Text = leaveCredits.sickLeaveCredits.ToString();
            emergencyLeave.Text = leaveCredits.emergencyLeaveCredits.ToString();
            paternityLeave.Text = leaveCredits.paternityLeaveCredits.ToString();
            bereavementLeave.Text = leaveCredits.bereavementLeaveCredits.ToString();
            birthdayLeave.Text = leaveCredits.birthdayLeaveCredits.ToString();
        }

        private void loadUserCurrentAttendance()
        {
            EmployeeControllerInterface employeeController = new EmployeeController();
            Employee employee = employeeController.fetchEmployeeByUsername(user.username);
            AttendanceControllerInterface attendanceController = new AttendanceController();
            Attendance attendance = attendanceController.fetchEmployeeAttendanceByDate(employee, DateTime.Now);
            if (attendance != null && !attendance.Equals(""))
            {
                clockedIn.Text = attendance.timeIn.ToString();
                clockedOut.Text = attendance.timeOut.ToString("MM/dd/yyyy").Equals("01/01/0001") ? "N/A" : attendance.timeOut.ToString() ;
                DateTime timeToClockOut = calculateTimeToClockOut(attendance.timeIn);
                validClockOut.Text = timeToClockOut.ToString();
            }
            else
            {
                clockedIn.Text = "Not yet clocked in.";
                clockedOut.Text = "N/A";
                validClockOut.Text = "N/A";
            }
        }

        private DateTime calculateTimeToClockOut(DateTime timeIn)
        {
            return timeIn.AddHours(8);
        }

        private void loadPayrollList()
        {
            PayrollControllerInterface payrollController = new PayrollController();
            List<Payslip> payroll = payrollController.fetchUserPayrolls(user);
            userPayrollListBox.Items.Clear();
            foreach(Payslip payslip in payroll)
            {
                userPayrollListBox.Items.Add(payslip.id+".)"+payslip.startDatePeriod.ToString("MM/dd/yyyy") + "-" + payslip.endDatePeriod.ToString("MM/dd/yyyy"));
            }
        }

        private void loadPendingRequest()
        {
            EmployeeControllerInterface employeeController = new EmployeeController();
            Employee employee = employeeController.fetchEmployeeByUsername(user.username);
            RequestControllerInterface requestController = new RequestController();
            List<Request> requests = requestController.fetchPendingRequestByEmployee(employee);
            pendingRequestListBox.Items.Clear();
            foreach (Request request in requests)
            {
                pendingRequestListBox.Items.Add(request.id + ".) " + request.name + " | " + request.requestedDate + " | " + request.description + " | " + request.name);
            }
        }

        private void loadApprovedRequest()
        {
            EmployeeControllerInterface employeeController = new EmployeeController();
            Employee employee = employeeController.fetchEmployeeByUsername(user.username);
            RequestControllerInterface requestController = new RequestController();
            List<Request> requests = requestController.fetchApprovedRequestByEmployee(employee);
            pendingRequestListBox.Items.Clear();
            foreach (Request request in requests)
            {
                pendingRequestListBox.Items.Add(request.id + ".) " + request.name + " | " + request.requestedDate + " | " + request.description + " | " + request.name);
            }
        }

        private void loadAttendanceHistory()
        {
            EmployeeControllerInterface employeeController = new EmployeeController();
            Employee employee = employeeController.fetchEmployeeByUsername(user.username);
            AttendanceControllerInterface attendanceController = new AttendanceController();
            List<Attendance> attendanceSheet = attendanceController.fetchEmployeeAttendance(employee);
            attendanceListBox.Items.Clear();
            foreach (Attendance attendance in attendanceSheet)
            {
                string timeOutString = attendance.timeOut.ToString("MM/dd/yyyy").Equals("01/01/0001") ? "Missed Clocked Out" : attendance.timeOut.ToString();
                attendanceListBox.Items.Add(attendance.id + ".)" + attendance.timeIn.ToString() + " | " + timeOutString);
            }
        }

        private void userPayrollListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                userPayrollListBox.SelectedIndex = l.SelectedIndex;
                Console.WriteLine(userPayrollListBox.SelectedItem.ToString());
            }
        }

        private void viewPayrollButton_Click(object sender, EventArgs e)
        {
            try
            {
                int payslipId = Convert.ToInt32(userPayrollListBox.SelectedItem.ToString().Split('.')[0]);
                PayrollControllerInterface payrollController = new PayrollController();
                Payslip payslip = payrollController.fetchPayslipById(payslipId);

                EmployeeControllerInterface employeeController = new EmployeeController();
                payslip.employee = employeeController.fetchEmployeeByUsername(user.username);

                FormControllerInterface formController = new FormController();
                formController.showUserPayroll(this, payslip);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("No item selected: " + ex.Message);
            }
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormControllerInterface formController = new FormController();
            formController.showLoginWindow(login);
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            FormControllerInterface formController = new FormController();
            formController.showLoginWindow(this, login);
        }

        private void leaveRequestButton_Click(object sender, EventArgs e)
        {
            EmployeeControllerInterface employeeController = new EmployeeController();
            Employee employee = employeeController.fetchEmployeeByUsername(user.username);

            Request request = new Request();
            request.employee = employee;
            request.name = typeOfLeaveComboBox.Text;
            request.requestedDate = Convert.ToDateTime(dateOfLeave.Text);
            request.status = RequestStatus.Pending;
            request.description = leaveDescription.Text;
            request.dateFiled = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy"));



            LeaveCreditsControllerInteface leaveCreditsService = new LeaveCreditsController();
            LeaveCredits leaveCredits = leaveCreditsService.fetchLeaveCreditsByEmployee(employee);
            if (request.name.Equals("Vacation Leave") && leaveCredits.vacationLeaveCredits < 1)
            {
                showErrorMessage("No available vacation leave credits.");
                request.description += " (Leave Without Pay)";
            }
            else if (request.name.Equals("Sick Leave") && leaveCredits.sickLeaveCredits < 1)
            {
                showErrorMessage("No available sick leave credits.");
                request.description += " (Leave Without Pay)";
            }
            else if (request.name.Equals("Bereavement Leave") && leaveCredits.bereavementLeaveCredits < 1)
            {
                showErrorMessage("No available beraavement leave credits.");
                request.description += " (Leave Without Pay)";
            }
            else if (request.name.Equals("Paternity Leave") && leaveCredits.paternityLeaveCredits < 1)
            {
                showErrorMessage("No available paternity leave credits.");
                request.description += " (Leave Without Pay)";
            }
            else if (request.name.Equals("Emergency Leave") && leaveCredits.emergencyLeaveCredits < 1)
            {
                showErrorMessage("No available emergency leave credits.");
                request.description += " (Leave Without Pay)";
            }
            else if (request.name.Equals("Birthday Leave") && leaveCredits.birthdayLeaveCredits < 1)
            {
                showErrorMessage("No available birthday leave credits.");
                return;
            }

            RequestControllerInterface requestController = new RequestController();
            request = requestController.createRequest(request);
            if (request != null)
            {
                loadPendingRequest();
                homeTabs.SelectedTab = pendingRequestTab;
            }
        }

        private void showErrorMessage(string errorMessage)
        {
            errorMessageLabel.Text = errorMessage;
            errorMessageLabel.Visible = true;
        }

        private void overtimeRequestButton_Click(object sender, EventArgs e)
        {
            var overtime = workingHour.Text.Split(':');
            
            TimeSpan time = new TimeSpan(0);
            try {
                if(overtime.Length == 1) {
                    time = new TimeSpan(Convert.ToInt32(overtime[0]),0,0);
                }
                else if(overtime.Length == 2){
                    time = new TimeSpan(Convert.ToInt32(overtime[0]),Convert.ToInt32(overtime[1]),0);
                }
            } 
            catch( FormatException ex) {
                showErrorMessage("Invalid working hour value");
                return;
            }
            if (time < new TimeSpan(0))
            {
                showErrorMessage("Invalid working hour value");
            }
            EmployeeControllerInterface employeeController = new EmployeeController();
            Employee employee = employeeController.fetchEmployeeByUsername(user.username);

            Request request = new Request();
            request.employee = employee;
            request.name = "OVERTIME";
            request.requestedDate = Convert.ToDateTime(dateOfLeave.Text);
            request.status = RequestStatus.Pending;
            request.description = leaveDescription.Text;
            DateTime date = DateTime.Now;
            request.dateFiled = new DateTime(date.Year, date.Month, date.Day, time.Hours, time.Minutes, 0);// Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy "));
            RequestControllerInterface requestController = new RequestController();
            request = requestController.createRequest(request);
            if (request != null)
            {
                loadPendingRequest();
                homeTabs.SelectedTab = pendingRequestTab;
            }
        }
    }
}
