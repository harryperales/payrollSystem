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
    public partial class PayrollForm : Form
    {
        User user;
        DashboardForm dashboardForm;
        private Payslip payslip;
        public PayrollForm(DashboardForm dashboardForm, User user)
        {
            this.user = user;
            this.dashboardForm = dashboardForm;
            InitializeComponent();
        }

        public PayrollForm(DashboardForm dashboardForm, Payslip payslip)
        {
            this.payslip = payslip;
            this.dashboardForm = dashboardForm;
            InitializeComponent();
            initializeForm(payslip);
        }

        private void initializeForm(Payslip payslip)
        {
            employeeFullName.Text = payslip.employee.fullName;
            dateEmployed.Text = payslip.employee.dateEmployed;
            employeeNumber.Text = payslip.employee.employeeId.ToString();
            position.Text = payslip.employee.jobPosition.name;
            startDatePeriod.Text = payslip.startDatePeriod.ToString();
            endDatePeriod.Text = payslip.endDatePeriod.ToString();
            datePayable.Text = payslip.dateCreated.ToString();
            positionName.Text = payslip.employee.jobPosition.name;
            dailyRate.Text = payslip.employee.jobPosition.salary.ToString("0.##");
            hourlyRate.Text = calculateHourlyRate(payslip.employee.jobPosition.salary).ToString("0.##");
            TimeSpan timeSpent = fetchTotalHoursSpent(payslip.startDatePeriod, payslip.endDatePeriod, payslip.employee);
            hoursSpent.Text = timeSpent.ToString();
            totalBasePay.Text = calculateTotalBasePay(timeSpent, payslip.employee.jobPosition.salary).ToString("0.##");
            decimal foodAllowanceAmount = fetchFoodAllowance(payslip);
            foodAllowance.Text = foodAllowanceAmount.ToString("0.##");
            decimal transpoAllowanceAmount = fetchTranspoAllowance(payslip);
            transportation.Text = transpoAllowanceAmount.ToString("0.##");


        }

        private decimal fetchFoodAllowance(Payslip payslip)
        {
            MiscControllerInterface miscellaneousController = new MiscellaneousController();
            return miscellaneousController.fetchFoodAllowance().amount;
        }

        private decimal fetchTranspoAllowance(Payslip payslip)
        {
            MiscControllerInterface miscellaneousController = new MiscellaneousController();
            return miscellaneousController.fetchTranspoAllowance().amount;
        }

        private decimal calculateTotalBasePay(TimeSpan timeSpent, decimal dailyBasedSalary)
        {
            decimal totalBasePay = 0.0000M;
            decimal hourlyRate = calculateHourlyRate(dailyBasedSalary);
            Console.WriteLine("Days:"+timeSpent.Days);
            Console.WriteLine("minutes:" + timeSpent.Minutes);
            Console.WriteLine("hours:" + timeSpent.Hours);
            if (timeSpent.Days > 0) totalBasePay = timeSpent.Days * dailyBasedSalary;
            if( timeSpent.Hours > 0 ) totalBasePay += (timeSpent.Hours * hourlyRate);
            if (timeSpent.Minutes > 0) totalBasePay += (timeSpent.Minutes * hourlyRate);

            return totalBasePay;
        }

        private TimeSpan fetchTotalHoursSpent(DateTime startDatePeriod, DateTime endDatePeriod, Employee employee)
        {
            var dates = Enumerable.Range(0, (endDatePeriod - startDatePeriod).Days + 1).Select(d => startDatePeriod.AddDays(d));
            AttendanceControllerInterface attendanceController = new AttendanceController();
            List<Attendance> attendanceSheet = new List<Attendance>();
            foreach (var date in dates)
            {
                Attendance attendance = attendanceController.fetchEmployeeAttendanceByDate(employee, date);
                attendanceSheet.Add(attendance);
            }

            TimeSpan totalTimeSpent = new TimeSpan(0);
            foreach (Attendance attendance in attendanceSheet)
            {
                TimeSpan breakTimeHour = fetchOneHourBreakTimeSpan();

                TimeSpan timeSpent = calculateTimeSpent(attendance);

                timeSpent -= breakTimeHour;

                TimeSpan validTimeSpent = fetchValidDutyHoursTimeSpan();

                // enforcing timeSpent to have an 8 hours only, if the user has an overtime, they should file an overtime request
                if (timeSpent > validTimeSpent)
                {
                    timeSpent = validTimeSpent;
                }
                if (timeSpent < new TimeSpan(0))
                {
                    timeSpent = new TimeSpan(0);
                }
                totalTimeSpent += timeSpent;
            }

            return totalTimeSpent;
        }

        private static TimeSpan fetchOneHourBreakTimeSpan()
        {
            return Convert.ToDateTime("01:00:00") - Convert.ToDateTime("00:00:00");
        }

        private static TimeSpan calculateTimeSpent(Attendance attendance)
        {
            if ((attendance == null || attendance.Equals("")))
            {
                return new TimeSpan(0);
            }
            if ((attendance.timeOut == null || attendance.timeOut.ToString().Equals(""))) attendance.timeOut = attendance.timeIn;
            return Convert.ToDateTime(attendance.timeOut.ToString("hh:mm:ss tt")) - Convert.ToDateTime(attendance.timeIn.ToString("hh:mm:ss tt"));
        }

        private static TimeSpan fetchValidDutyHoursTimeSpan()
        {
            return Convert.ToDateTime("08:00:00") - Convert.ToDateTime("00:00:00");
        }

        private decimal calculateHourlyRate(decimal salary)
        {
            return decimal.Divide(salary, 8.00M);
        }

        private void PayrollForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormControllerInterface formController = new FormController();
            formController.showDashboardForm(dashboardForm);
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            FormControllerInterface formController = new FormController();
            formController.showDashboardForm(this, dashboardForm);
        }
    }
}
