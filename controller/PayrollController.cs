using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.service;
using PayrollSystem.model;

namespace PayrollSystem.controller
{
    public class PayrollController : PayrollControllerInterface
    {
        private int AVERAGE_WORKING_DAY_PER_MONTH = 24;
        PayrollServiceInterface payrollService;
        AttendanceServiceInterface attendanceService;
        SalaryServiceInterface salaryService;
        RequestServiceInterface requestService;
        MiscellaneousServiceInterface miscellaneousService;

        public PayrollController()
        {
            payrollService = new PayrollService();
            attendanceService = new AttendanceService();
            salaryService = new SalaryService();
            requestService = new RequestService();
            miscellaneousService = new MiscellaneousService();
        }

        public PayrollController(PayrollServiceInterface payrollService)
        {
            this.payrollService = payrollService;
        }

        public List<Payslip> fetchUserPayrolls(User user)
        {
            return payrollService.fetchUserPayrolls(user);
        }

        public Payslip createPayslip(DateTime startDatePeriod, DateTime endDatePeriod, Employee employee)
        {
            // attendanceLogSheet
            Payslip payslip = new Payslip();
            payslip.employee = employee;
            payslip.startDatePeriod = startDatePeriod;
            payslip.endDatePeriod = endDatePeriod;
            List<Attendance> attendances = attendanceService.fetchEmployeeAttendance(startDatePeriod, endDatePeriod, employee);
            decimal monthlySalary = decimal.Multiply(employee.jobPosition.salary, AVERAGE_WORKING_DAY_PER_MONTH);
            
            decimal dailyBasedSalary = 0.00M;
            dailyBasedSalary = employee.jobPosition.salary;
            decimal periodSalary = decimal.Round(salaryService.calculatePeriodSalary(attendances, dailyBasedSalary), 2);

            AttendanceControllerInterface attendanceController = new AttendanceController();
            TimeSpan timeSpent = fetchTotalHoursSpent(payslip.startDatePeriod, payslip.endDatePeriod, payslip.employee, attendanceController);

            periodSalary = calculateTotalBasePay(timeSpent, payslip.employee.jobPosition.salary);
            payslip.basePay = periodSalary;

            decimal totalAllowanceAmount = 0.00M;
            MiscellaneousControllerInterface miscellaneousController = new MiscellaneousController();
            decimal foodAllowanceAmount = fetchFoodAllowance(payslip, miscellaneousController);
            decimal totalFoodAllowanceAmount = calculateTotalSpecificAllowance(foodAllowanceAmount, timeSpent);
            totalAllowanceAmount += totalFoodAllowanceAmount;

            decimal transpoAllowanceAmount = fetchTranspoAllowance(payslip, miscellaneousController);
            decimal totalTranspoAllowanceAmount = calculateTotalSpecificAllowance(transpoAllowanceAmount, timeSpent);
            totalAllowanceAmount += totalTranspoAllowanceAmount;

            List<Request> overtimeRequests = requestService.fetchOvertimeRequests(employee, startDatePeriod, endDatePeriod);
            payslip.requests = overtimeRequests;

            List<Request> leaveRequests = requestService.fetchLeaveRequest(employee, startDatePeriod, endDatePeriod);
            payslip.requests.AddRange(leaveRequests);

            decimal totalLeaveAmount = decimal.Round(salaryService.calculateDailBasedSalaryWithLeaveRequest(leaveRequests, dailyBasedSalary), 2);

            List<Miscellaneous> benefits = miscellaneousService.fetchMiscellaneousByBenefitType(employee);
            payslip.miscellaneous = benefits;

            RequestControllerInterface requestController = new RequestController();
            SalaryControllerInterface salaryController = new SalaryController();
            decimal totalOvertimeAmount = calculateDailyBasedSalaryWithOvertimeRequests(payslip.startDatePeriod, payslip.endDatePeriod, payslip.employee, requestController, salaryController);
            totalAllowanceAmount += totalOvertimeAmount;

            payslip.totalBenefits = totalAllowanceAmount + totalLeaveAmount;

            decimal cashAdvanceAmount = calculateTotalCashAdvanceAmount(payslip.startDatePeriod, payslip.endDatePeriod, payslip.employee, requestController, salaryController);

            payslip.sssDeduction = decimal.Divide(salaryService.fetchSssDeductionsWithPeriodSalary(monthlySalary), 2);
            payslip.sssDeduction = decimal.Round(payslip.sssDeduction, 2);

            payslip.pagIbigDeduction = decimal.Divide(salaryService.fetchPagIbigDeductionWithPeriodSalary(monthlySalary), 2);
            payslip.pagIbigDeduction = decimal.Round(payslip.pagIbigDeduction, 2);

            payslip.philHealthDeduction = decimal.Divide(salaryService.fetchPhilHealthDeductionWithPeriodSalary(monthlySalary), 2);
            payslip.philHealthDeduction = decimal.Round(payslip.philHealthDeduction, 2);

            Miscellaneous thirteenMonth = miscellaneousService.calculateThirteenMonth(employee, endDatePeriod);

            payslip.taxDeduction = decimal.Divide(salaryService.calculatePeriodSalaryTax(employee, monthlySalary), 2);            

            decimal totalDeductions = (decimal.Round(payslip.taxDeduction, 2) + decimal.Round(payslip.sssDeduction, 2) + decimal.Round(payslip.pagIbigDeduction, 2) + decimal.Round(payslip.philHealthDeduction, 2) + decimal.Round(cashAdvanceAmount, 2));
            payslip.totalDeduction = totalDeductions;

            decimal totalSalary = payslip.basePay + payslip.totalBenefits - totalDeductions;
            payslip.netPay = totalSalary;

            return payrollService.createPayslip(employee, payslip);
            /*
            List<Request> overtimeRequests = requestService.fetchOvertimeRequests(employee, startDatePeriod, endDatePeriod);
            payslip.requests = overtimeRequests;

            periodSalary += decimal.Round(salaryService.calculateDailyBasedSalaryWithOvertimeRequests(overtimeRequests, dailyBasedSalary), 2);
            Console.WriteLine("periodSalaryWithOvertime---->>" + periodSalary);

            List<Request> leaveRequests = requestService.fetchLeaveRequest(employee, startDatePeriod, endDatePeriod);
            payslip.requests.AddRange(leaveRequests);

            periodSalary += decimal.Round(salaryService.calculateDailBasedSalaryWithLeaveRequest(leaveRequests, dailyBasedSalary), 2);
            Console.WriteLine("periodSalaryWithLeave---->>" + periodSalary);

            List<Miscellaneous> benefits = miscellaneousService.fetchMiscellaneousByBenefitType(employee);
            payslip.miscellaneous = benefits;

            periodSalary += decimal.Round(salaryService.fetchTotalAmountOfBenefits(benefits, attendances, leaveRequests), 2);
            Console.WriteLine("periodSalaryWIthBenefits---->>" + periodSalary);

            //List<Miscellaneous> bonuses = miscellaneousService.fetchBonusMiscellaneousByDescriptionAsDate(employee, startDatePeriod, endDatePeriod);
            //payslip.miscellaneous.AddRange(bonuses);

            //periodSalary += salaryService.fetchTotalBonus(bonuses);
            //Console.WriteLine("periodSalaryWIthBonus---->>" + periodSalary);

            List<Request> cashAdvanceList = requestService.fetchAllApprovedCashAdvanceRequests(startDatePeriod, endDatePeriod, employee);
            periodSalary -= decimal.Round(salaryService.fetchTotalCashAdvanceAmount(cashAdvanceList), 2);
            Console.WriteLine("periodSalaryWIthCashAdvance---->>" + periodSalary);

            //List<Miscellaneous> deductions = miscellaneousService.fetchMiscellaneousByDeductionType(employee);

            //periodSalary -= decimal.Round(salaryService.fetchTotalDeductions(deductions), 2);

            payslip.sssDeduction = decimal.Divide(salaryService.fetchSssDeductionsWithPeriodSalary(monthlySalary), 2);
            payslip.sssDeduction = decimal.Round(payslip.sssDeduction, 2);

            payslip.pagIbigDeduction = decimal.Divide(salaryService.fetchPagIbigDeductionWithPeriodSalary(monthlySalary), 2);
            payslip.pagIbigDeduction = decimal.Round(payslip.pagIbigDeduction, 2);

            payslip.philHealthDeduction = decimal.Divide(salaryService.fetchPhilHealthDeductionWithPeriodSalary(monthlySalary), 2);
            payslip.philHealthDeduction = decimal.Round(payslip.philHealthDeduction, 2);

            periodSalary -= payslip.sssDeduction;
            periodSalary -= payslip.pagIbigDeduction;
            periodSalary -= payslip.philHealthDeduction;
            Console.WriteLine("periodSalaryWIthDeductions---->>" + periodSalary);

            payslip.taxDeduction = decimal.Divide(salaryService.calculatePeriodSalaryTax(employee, monthlySalary), 2);
            periodSalary -= payslip.taxDeduction;

            payslip.netPay = decimal.Round(periodSalary, 2);
            Console.WriteLine("periodSalaryWithholdingTax---->>" + periodSalary);
            */
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

        private decimal calculateTotalSpecificAllowance(decimal allowanceAmount, TimeSpan timeSpent)
        {
            double convertedTimeSpentTotalHoursToDay = Math.Round(timeSpent.TotalHours, 2) / 8.00;
            return decimal.Multiply(Convert.ToDecimal(convertedTimeSpentTotalHoursToDay), allowanceAmount);
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

        private decimal calculateHourlyRate(decimal salary)
        {
            return decimal.Divide(salary, 8.00M);
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

        public Payslip fetchPayslipById(int payslipId)
        {
            return payrollService.fetchPayslipById(payslipId);
        }

        public List<Payslip> fetchPayroll()
        {
            return payrollService.fetchPayroll();
        }

        public Payslip addThirteenMonthPayToPayslip(Employee employee, Payslip payslip)
        {
            Miscellaneous thirteenMonthPay = miscellaneousService.fetchEmployeeMiscellaneousBenefitByEmployeeId(employee, "ThirteenMonthAllowance");
            return payrollService.updatePayslipThirteenMonthPay(payslip, thirteenMonthPay);
        }
    }
}
