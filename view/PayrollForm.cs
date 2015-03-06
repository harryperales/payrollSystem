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
        AdminDashBoard adminDashboardForm;
        private Payslip payslip;
        public PayrollForm(DashboardForm dashboardForm, User user)
        {
            this.user = user;
            this.dashboardForm = dashboardForm;
            adminDashboardForm = null;
            InitializeComponent();
        }
        public PayrollForm(AdminDashBoard adminDashboardForm, Payslip payslip)
        {
            this.payslip = payslip;
            this.adminDashboardForm = adminDashboardForm;
            dashboardForm = null;
            InitializeComponent();
            initializeForm(payslip);
        }

        public PayrollForm(DashboardForm dashboardForm, Payslip payslip)
        {
            this.payslip = payslip;
            this.dashboardForm = dashboardForm;
            adminDashboardForm = null;
            InitializeComponent();
            initializeForm(payslip);
        }

        private void initializeForm(Payslip payslip)
        {
            RequestControllerInterface requestController = new RequestController();
            MiscellaneousControllerInterface miscellaneousController = new MiscellaneousController();
            SalaryControllerInterface salaryController = new SalaryController();
            AttendanceControllerInterface attendanceController = new AttendanceController();
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
            TimeSpan timeSpent = fetchTotalHoursSpent(payslip.startDatePeriod, payslip.endDatePeriod, payslip.employee, attendanceController);
            hoursSpent.Text = Math.Round(timeSpent.TotalHours, 2).ToString();
            decimal totalBasePayAmount = calculateTotalBasePay(timeSpent, payslip.employee.jobPosition.salary);
            totalBasePay.Text = totalBasePayAmount.ToString("0.##");
            decimal foodAllowanceAmount = fetchFoodAllowance(payslip, miscellaneousController);
            decimal totalFoodAllowanceAmount = calculateTotalSpecificAllowance(foodAllowanceAmount, timeSpent);
            foodAllowance.Text = totalFoodAllowanceAmount.ToString("0.##");
            decimal transpoAllowanceAmount = fetchTranspoAllowance(payslip, miscellaneousController);
            decimal totalTranspoAllowanceAmount = calculateTotalSpecificAllowance(transpoAllowanceAmount, timeSpent);            transportation.Text = totalTranspoAllowanceAmount.ToString("0.##");
            decimal thirteenMonth = 0.00M;
            overtimeHours.Text = Math.Round(fetchTotalHoursOvertimeSpent(payslip.startDatePeriod, payslip.endDatePeriod, payslip.employee, requestController).TotalHours, 2).ToString();
            decimal totalOvertimeAmount = calculateDailyBasedSalaryWithOvertimeRequests(payslip.startDatePeriod, payslip.endDatePeriod, payslip.employee, requestController, salaryController);
            overtimeAmount.Text = totalOvertimeAmount.ToString("0.##");

            List<Request> leaveRequests = requestController.fetchLeaveRequest(payslip.employee, payslip.startDatePeriod, payslip.endDatePeriod);
            decimal totalLeaveRequest = salaryController.calculateDailBasedSalaryWithLeaveRequest(leaveRequests, payslip.employee.jobPosition.salary);
            if (hasLeaveRequests(totalLeaveRequest))
            {
                showLeaveFields();
                daysOfLeave.Text = leaveRequests.Count.ToString();
                totalLeavePay.Text = totalLeaveRequest.ToString("0.##");
            }
            decimal cashAdvanceDeci = calculateTotalCashAdvanceAmount(payslip.startDatePeriod, payslip.endDatePeriod, payslip.employee, requestController, salaryController);
            cashAdvanceAmount.Text = cashAdvanceDeci.ToString("0.##");
            tax.Text = payslip.taxDeduction.ToString("0.##");
            sss.Text = payslip.sssDeduction.ToString("0.##");
            pagIbig.Text = payslip.pagIbigDeduction.ToString("0.##");
            philHealth.Text = payslip.philHealthDeduction.ToString("0.##");
            thirteenthMonthPay.Visible = false;
            if (payslip.thirteenMonthPay > 0.00M)
            {
                thirteenthMonthPay.Visible = true;
                thirteenthMonthPay.Text = payslip.thirteenMonthPay.ToString("0.##") + " day/s";
            }

            earnings.Text = totalBasePayAmount.ToString("0.##");
            benefits.Text = (totalFoodAllowanceAmount + totalTranspoAllowanceAmount ).ToString("0.##");
            extrasTotalAmount.Text = (totalOvertimeAmount + thirteenMonth + totalLeaveRequest).ToString("0.##");
            deductions.Text = ((decimal.Round(payslip.taxDeduction, 2) + decimal.Round(payslip.sssDeduction, 2) + decimal.Round(payslip.pagIbigDeduction, 2) + decimal.Round(payslip.philHealthDeduction, 2) + decimal.Round(cashAdvanceDeci, 2)) * -1).ToString("0.##");
            decimal totalSalary = Convert.ToDecimal(earnings.Text) + Convert.ToDecimal(benefits.Text) + Convert.ToDecimal(deductions.Text);
            netPay.Text = totalSalary.ToString("0.##");
        }

        private void showLeaveFields()
        {
            leaveRequestLabel.Visible = true;
            daysOfLeave.Visible = true;
            totalLeavePay.Visible = true;
        }

        private static bool hasLeaveRequests(decimal totalLeaveRequest)
        {
            return totalLeaveRequest > 0.00M;
        }

        private decimal calculateTotalSpecificAllowance(decimal allowanceAmount, TimeSpan timeSpent)
        {
            double convertedTimeSpentTotalHoursToDay = Math.Round(timeSpent.TotalHours, 2) / 8.00;
            return decimal.Multiply(Convert.ToDecimal(convertedTimeSpentTotalHoursToDay), allowanceAmount);
        }

        private decimal calculateTotalCashAdvanceAmount(DateTime startDatePeriod, DateTime endDatePeriod, Employee employee, RequestControllerInterface requestController, SalaryControllerInterface salaryController)
        {
            List<Request> cashAdvanceList = requestController.fetchAllApprovedCashAdvanceRequests(startDatePeriod, endDatePeriod, employee);
            return salaryController.fetchTotalCashAdvanceAmount(cashAdvanceList);
        }

        private decimal calculateDailyBasedSalaryWithOvertimeRequests(DateTime startDatePeriod, DateTime endDatePeriod, Employee employee, RequestControllerInterface requestController, SalaryControllerInterface salaryController)
        {
            List<Request> overtimeRequests = requestController.fetchOvertimeRequests(employee, startDatePeriod, endDatePeriod);
            return salaryController.calculateDailyBasedSalaryWithOvertimeRequests(overtimeRequests, employee.jobPosition.salary);
        }

        private TimeSpan fetchTotalHoursOvertimeSpent(DateTime startDatePeriod, DateTime endDatePeriod, Employee employee, RequestControllerInterface requestController)
        {
            return requestController.fetchTotalHoursOvertimeSpent(startDatePeriod, endDatePeriod, employee);
        }

        private decimal fetchFoodAllowance(Payslip payslip, MiscellaneousControllerInterface miscellaneousController)
        {
            return miscellaneousController.fetchMiscellaneousBenefitByNameAndEmployee(payslip.employee, "FoodAllowance").amount;
            //return miscellaneousController.fetchFoodAllowance().amount;
        }

        private decimal fetchTranspoAllowance(Payslip payslip, MiscellaneousControllerInterface miscellaneousController)
        {
            return miscellaneousController.fetchMiscellaneousBenefitByNameAndEmployee(payslip.employee, "TransportationAllowance").amount;
            //return miscellaneousController.fetchTranspoAllowance().amount;
        }

        private decimal calculateTotalBasePay(TimeSpan timeSpent, decimal dailyBasedSalary)
        {
            decimal hourlyRate = calculateHourlyRate(dailyBasedSalary);
            double timeSpentWithTwoDecimal = Math.Round(timeSpent.TotalHours, 2);
            return decimal.Multiply(Convert.ToDecimal(timeSpentWithTwoDecimal), hourlyRate);
        }

        private TimeSpan fetchTotalHoursSpent(DateTime startDatePeriod, DateTime endDatePeriod, Employee employee,
            AttendanceControllerInterface attendanceController)
        {
            var dates = Enumerable.Range(0, (endDatePeriod - startDatePeriod).Days + 1).Select(d => startDatePeriod.AddDays(d));
            List<Attendance> attendanceSheet = new List<Attendance>();
            foreach (var date in dates)
            {
                Attendance attendance = attendanceController.fetchEmployeeAttendanceByDate(employee, date);
                if (attendance != null)
                {
                    attendanceSheet.Add(attendance);
                }
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
            if (dashboardForm != null)
            {
                FormControllerInterface formController = new FormController();
                formController.showDashboardForm(this, dashboardForm);
            }
            else
            {
                FormControllerInterface formController = new FormController();
                formController.showAdminDashboardForm(this, adminDashboardForm);
            }
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            if (dashboardForm != null)
            {
                FormControllerInterface formController = new FormController();
                formController.showDashboardForm(this, dashboardForm);
            }
            else
            {
                FormControllerInterface formController = new FormController();
                formController.showAdminDashboardForm(this, adminDashboardForm);
            }
        }
    }
}
