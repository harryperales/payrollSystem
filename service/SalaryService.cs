using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;
using System.IO;
using System.Diagnostics;

namespace PayrollSystem.service
{
    public class SalaryService : SalaryServiceInterface
    {
        private int SINGLE_MARRIED_LOWER_LIMIT = 2;
        private int SINGLE_MARRIED_UPPER_LIMIT = 3;
        private int SINGLE1_MARRIED1_LOWER_LIMIT = 4;
        private int SINGLE1_MARRIED1_UPPER_LIMIT = 5;
        private int SINGLE2_MARRIED2_LOWER_LIMIT = 6;
        private int SINGLE2_MARRIED2_UPPER_LIMIT = 7;
        private int SINGLE3_MARRIED3_LOWER_LIMIT = 8;
        private int SINGLE3_MARRIED3_UPPER_LIMIT = 9;
        private int SINGLE4_MARRIED4_LOWER_LIMIT = 10;
        private int SINGLE4_MARRIED4_UPPER_LIMIT = 11;

        private HolidayServiceInterface holidayService;
        public SalaryService()
        {
            holidayService = new HolidayService();
        }

        public decimal calculatePeriodSalary(List<Attendance> attendances, decimal dailyBasedSalary)
        {
            List<Holiday> holidays = holidayService.fetchHolidays();
            decimal periodSalary = 0.00M;
            decimal perHourBasedSalary = 0.00M;
            perHourBasedSalary = decimal.Divide(dailyBasedSalary, 8.00M);
            foreach (Attendance attendance in attendances)
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
                decimal calculatedSalaryWithTimeSpent = calculatePerHourSalaryFromHoursSpent(perHourBasedSalary, Convert.ToDecimal(timeSpent.Hours));

                decimal convertedMinutesToHour = decimal.Divide(timeSpent.Minutes, 59);
                calculatedSalaryWithTimeSpent += calculatePerHourSalaryFromHoursSpent(perHourBasedSalary, convertedMinutesToHour);

                periodSalary += calculatedSalaryWithTimeSpent;

                foreach (Holiday holiday in holidays)
                {

                    if (!holiday.date.ToString("MM/dd/yyyy").Equals(attendance.timeIn.ToString("MM/dd/yyyy")))
                    {
                        //nothing to do, just to skip the loop
                    } 
                    else if (holiday.holidayWages == HolidayWages.NonRegular)
                    {
                        periodSalary += decimal.Multiply(dailyBasedSalary, 0.30M); // add 30% of daily Salary
                    }
                    else if (holiday.holidayWages == HolidayWages.Regular)
                    {
                        periodSalary += dailyBasedSalary; // add 100% daily salary
                    }

                }
            }
            return periodSalary;
        }

        private static TimeSpan fetchValidDutyHoursTimeSpan()
        {
            return Convert.ToDateTime("08:00:00") - Convert.ToDateTime("00:00:00");
        }

        private static TimeSpan calculateTimeSpent(Attendance attendance)
        {
            return Convert.ToDateTime(attendance.timeOut.ToString("hh:mm:ss tt")) - Convert.ToDateTime(attendance.timeIn.ToString("hh:mm:ss tt"));
        }

        private static TimeSpan fetchOneHourBreakTimeSpan()
        {
            return Convert.ToDateTime("01:00:00") - Convert.ToDateTime("00:00:00");
        }

        private decimal calculatePerHourSalaryFromHoursSpent(decimal perHourBasedSalary, decimal hour)
        {
            return decimal.Multiply(perHourBasedSalary, hour);
        }

        public decimal calculatePeriodSalaryWithOvertimeRequests(List<Request> overtimeRequests, decimal dailyBasedSalary)
        {
            decimal perHourBasedSalary = 0.00M;
            perHourBasedSalary = decimal.Divide(dailyBasedSalary, 8.00M);
            int numberOfApprovedOvertimeRequests = overtimeRequests.Count;
            decimal semiOvertimeTotalPercentage = decimal.Multiply(numberOfApprovedOvertimeRequests, 0.30M);
            decimal finalOvertimeTotalPercentage = decimal.Add(semiOvertimeTotalPercentage, 1.00M);
            decimal periodSalaryWithOvertime = decimal.Multiply(perHourBasedSalary, finalOvertimeTotalPercentage);
            return periodSalaryWithOvertime;
        }

        public decimal calculatePeriodSalaryWithLeaveRequest(List<Request> leaveRequests, decimal dailyBasedSalary)
        {
            List<Holiday> holidays = holidayService.fetchHolidays();
            decimal periodSalary = 0.00M;
            decimal perHourBasedSalary = 0.00M;
            perHourBasedSalary = decimal.Divide(dailyBasedSalary, 8.00M);
            foreach (Request leaveRequest in leaveRequests)
            {
                decimal calculatedSalary = calculatePerHourSalaryFromHoursSpent(perHourBasedSalary, 8.00M);

                periodSalary += calculatedSalary;

                foreach (Holiday holiday in holidays)
                {

                    if (!holiday.date.ToString("MM/dd/yyyy").Equals(leaveRequest.dateFiled.ToString("MM/dd/yyyy")))
                    {
                        //nothing to do, just to skip the loop
                    }
                    else if (holiday.holidayWages == HolidayWages.NonRegular)
                    {
                        periodSalary += decimal.Multiply(dailyBasedSalary, 0.30M); // add 30% of daily Salary
                    }
                    else if (holiday.holidayWages == HolidayWages.Regular)
                    {
                        periodSalary += dailyBasedSalary; // add 100% daily salary
                    }

                }
            }
            return periodSalary;
        }

        public decimal calculatePeriodSalaryWithDeductions(List<Miscellaneous> deductions, decimal periodSalaryWithDeductions)
        {
            foreach (Miscellaneous deduction in deductions)
            {
                periodSalaryWithDeductions -= deduction.amount;
            }
            return periodSalaryWithDeductions;
        }

        public decimal calculatePeriodSalaryWithBenefits(List<Miscellaneous> benefits, decimal periodSalaryWithBenefits, List<Attendance> attendances, List<Request> leaveRequests)
        {
            foreach (Attendance attendance in attendances)
            {
                foreach (Miscellaneous benefit in benefits)
                {
                    periodSalaryWithBenefits += benefit.amount;
                }
            }


            foreach (Request leaveRequest in leaveRequests)
            {
                foreach (Miscellaneous benefit in benefits)
                {
                    periodSalaryWithBenefits += benefit.amount;
                }
            }
            return periodSalaryWithBenefits;
        }

        public decimal calculatePeriodSalaryWithBonus(List<Miscellaneous> bonuses, decimal periodSalaryWithBonus)
        {
            foreach (Miscellaneous bonus in bonuses)
            {
                Console.WriteLine(bonus.amount);
                periodSalaryWithBonus += bonus.amount;
            }

            return periodSalaryWithBonus;
        }

        public decimal calculatePeriodSalaryTax(Employee employee, decimal periodSalary)
        {
            decimal taxAmountToBeDeducted = 00.0M;
            if ((employee.civilStatus.Equals("Single") || employee.civilStatus.Equals("Married")) && employee.dependents == 0)
            {
                taxAmountToBeDeducted = fetchTaxCalculatedAmountForDeduction(periodSalary, SINGLE_MARRIED_LOWER_LIMIT, SINGLE_MARRIED_UPPER_LIMIT);
                Console.WriteLine(taxAmountToBeDeducted);
            }
            return taxAmountToBeDeducted;
        }

        private decimal fetchTaxCalculatedAmountForDeduction(decimal periodSalary, int lowerLimitIndex, int upperLimitIndex)
        {
            string fileName = "Tax_Table_Semi_Monthly.csv";
            
            return fetchDeductionAmount(periodSalary, lowerLimitIndex, upperLimitIndex, fileName);
        }

        private decimal fetchDeductionAmount(decimal periodSalary, int lowerLimitIndex, int upperLimitIndex, string fileName)
        {
            string directory = Path.Combine(Environment.CurrentDirectory, "Resources/" + fileName);
            directory = directory.Replace("\\", "/").Replace("/bin/Debug", "");
            directory = directory.Replace("\\", "/").Replace("/bin/Release", "");

            var reader = new StreamReader(File.OpenRead(@directory));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                decimal lowerLimitSalary = 0.00M;
                decimal upperLimitSalary = 0.00M;
                try
                {
                    lowerLimitSalary = Convert.ToDecimal(values[lowerLimitIndex].ToString());
                    upperLimitSalary = Convert.ToDecimal(values[upperLimitIndex].ToString());
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("error log:" + formatException.Message);
                    Console.WriteLine("-----------------------------------");
                }

                if (periodSalary >= lowerLimitSalary && periodSalary <= upperLimitSalary)
                {
                    decimal taxAmountToDeduct = Convert.ToDecimal(values[1].ToString());
                    decimal taxPercent = Convert.ToDecimal(values[0].ToString());
                    //Console.WriteLine(taxAmountToDeduct + "+" + "[(" + periodSalary + "-" + (upperLimitSalary - 1) + ")X" + taxPercent + "]");
                    taxAmountToDeduct += ((periodSalary - (upperLimitSalary - 1)) * taxPercent);

                    return taxAmountToDeduct;
                }
            }
            return 0.00M;
        }

        public decimal fetchSssDeductionsWithPeriodSalary(decimal periodSalary)
        {
            string fileName = "SSS_Table_Semi_Monthly.csv"; 
            string directory = Path.Combine(Environment.CurrentDirectory, "Resources/" + fileName);
            directory = directory.Replace("\\", "/").Replace("/bin/Debug", "");
            directory = directory.Replace("\\", "/").Replace("/bin/Release", "");

            var reader = new StreamReader(File.OpenRead(@directory));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                decimal lowerLimitSalary = 0.00M;
                decimal upperLimitSalary = 0.00M;
                try
                {
                    lowerLimitSalary = Convert.ToDecimal(values[0].ToString());
                    upperLimitSalary = Convert.ToDecimal(values[1].ToString());
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("error log:" + formatException.Message);
                    Console.WriteLine("-----------------------------------");
                }

                if (periodSalary >= lowerLimitSalary && periodSalary <= upperLimitSalary)
                {
                    return Convert.ToDecimal(values[2].ToString());
                }
            }
            return 0.00M;
        }

        public decimal fetchPagIbigDeductionWithPeriodSalary(decimal periodSalary)
        {
            return 100.00M;
        }

        public decimal fetchPhilHealthDeductionWithPeriodSalary(decimal periodSalary)
        {
            string fileName = "PhilHealt_Table_Semi_Monthly.csv";
            string directory = Path.Combine(Environment.CurrentDirectory, "Resources/" + fileName);
            directory = directory.Replace("\\", "/").Replace("/bin/Debug", "");
            directory = directory.Replace("\\", "/").Replace("/bin/Release", "");

            var reader = new StreamReader(File.OpenRead(@directory));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                decimal lowerLimitSalary = 0.00M;
                decimal upperLimitSalary = 0.00M;
                try
                {
                    lowerLimitSalary = Convert.ToDecimal(values[0].ToString());
                    upperLimitSalary = Convert.ToDecimal(values[1].ToString());
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("error log:" + formatException.Message);
                    Console.WriteLine("-----------------------------------");
                }

                if (periodSalary >= lowerLimitSalary && periodSalary <= upperLimitSalary)
                {
                    return Convert.ToDecimal(values[2].ToString());
                }
            }
            return 0.00M;
        }
    }
}
