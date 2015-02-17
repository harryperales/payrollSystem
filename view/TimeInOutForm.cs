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
    public partial class TimeInOutForm : Form
    {
        public TimeInOutForm()
        {
            InitializeComponent();
            hideErrorMessage();
            tickDateTime();
        }

        private void hideErrorMessage()
        {
            errorMessageLabel.Visible = false;
        }

        private void timeInOutTimer_Tick(object sender, EventArgs e)
        {
            tickDateTime();
        }

        private void tickDateTime()
        {
            dateLabel.Text = DateTime.Now.Date.ToString("dd-MM-yyyy ddd");
            clockTickLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");

            if (DateTime.Now.Second % 10 == 0)
            {
                errorMessageLabel.Visible = false;
            }
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            FormControllerInterface formController = new FormController();
            formController.showLoginWindow(this);
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            FormControllerInterface formController = new FormController();
            formController.closeTimeInOutForm(this);
        }

        private void timeInButton_Click(object sender, EventArgs e)
        {
            long employeeNumber = 0;
            try
            {
                employeeNumber = Convert.ToInt64(employeeIdNumber.Text);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("error log:"+ex.Message);
                //username = employeeIdNumber.Text;
                showErrorMessage("Please Input a valid employee ID number.");
                return;
            }

            EmployeeControllerInterface employeeController = new EmployeeController();
            Employee employee = employeeController.fetchEmployeeByEmployeeIdNumber(employeeNumber);
            if (employee == null || employee.Equals(""))
            {
               showErrorMessage("Employee ID number does not exist.");                
            }
            else
            {
                errorMessageLabel.Visible = false;
                AttendanceControllerInterface attendanceController = new AttendanceController();
                DateTime currentDate = DateTime.Now;
                Attendance attendance = attendanceController.fetchEmployeeAttendanceByDate(employee, currentDate);
                if (attendance != null)
                {
                    showErrorMessage("User is already logged-in on " + attendance.timeIn);
                    return;
                }
                attendance = new Attendance();
                attendance.employee = employee;
                attendance.timeIn = currentDate;
                attendanceController.saveEmployeeAttendance(attendance);
            }
        }

        private void timeOutButton_Click(object sender, EventArgs e)
        {
            long employeeNumber = 0;
            try
            {
                employeeNumber = Convert.ToInt64(employeeIdNumber.Text);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("error log:" + ex.Message);
                //username = employeeIdNumber.Text;
                showErrorMessage("Please Input a valid employee ID number.");
                return;
            }

            EmployeeControllerInterface employeeController = new EmployeeController();
            Employee employee = employeeController.fetchEmployeeByEmployeeIdNumber(employeeNumber);
            if (employee == null || employee.Equals(""))
            {
                showErrorMessage("Employee ID number does not exist.");
                return;
            }
            else
            {
                errorMessageLabel.Visible = false;
                AttendanceControllerInterface attendanceController = new AttendanceController();
                DateTime currentDate = DateTime.Now;
                Attendance attendance = attendanceController.fetchEmployeeAttendanceByDate(employee, currentDate);
                if (attendance.timeOut != null && attendance.timeOut.ToString("MM/dd/yyyy").Equals(DateTime.Now.Date.ToString("MM/dd/yyyy")))
                {
                    showErrorMessage("User was already logged-out on " + attendance.timeOut);
                    return;
                }
                else if (attendance.timeIn == null || !attendance.timeIn.ToString("MM/dd/yyyy").Equals(DateTime.Now.Date.ToString("MM/dd/yyyy")))
                {
                    showErrorMessage("User is not yet logged in.");
                    return;
                }
                attendance.employee = employee;
                attendance.timeOut = currentDate;
                attendanceController.updateEmployeeAttendance(attendance);
            }
        }

        private void showErrorMessage(string errorMessage)
        {
            errorMessageLabel.Text = errorMessage;
            errorMessageLabel.Visible = true;
        }
    }
}
